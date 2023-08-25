﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QHYApp
{
    class QHYLib
    {
        // These are DLL imports to the QHYCCD libraries. If you want to see documentation look here:
        // https://www.qhyccd.cn/file/repository/publish/SDK/code/QHYCCD_SDK_EN_V2.1.pdf

        // Initialzes SDK Resources and should only be called once, returns QHYCCD_SUCCESS
        // if the function succeeds.
        [DllImport("qhyccd.dll", EntryPoint = "InitQHYCCDResource",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 InitQHYCCDResource();

        // Scans the connected cameras, and returns the number of devices scanned.
        [DllImport("qhyccd.dll", EntryPoint = "ScanQHYCCD",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 ScanQHYCCD();

        // Parameters:
        // index: QHYCCD device index value in the device list.
        // id: The variable used to store the camera ID.
        [DllImport("qhyccd.dll", EntryPoint = "GetQHYCCDId",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 GetGHYCCDId(int index, StringBuilder id);

        // id: the id of the camera
        // returns a handle to a camera, and you can control camera function 
        // using this handle. If the handle is not empty, the function succeeds.
        [DllImport("qhyccd.dll", EntryPoint = "OpenQHYCCD",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 OpenQHYCCD(StringBuilder id);

        // Turn off the camera and disconnect, QHYCCD_SUCCESS is returned.
        [DllImport("qhyccd.dll", EntryPoint = "CloseQHYCCD",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 CloseQHYCCD(IntPtr handle);

        // Release camera resources.
        [DllImport("qhyccd.dll", EntryPoint = "ReleaseQHYCCDResource",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 ReleaseQHYCCDResource();
    }

    public enum CONTROL_ID
    {
        CONTROL_BRIGHTNESS = 0, // image brightness
        CONTROL_CONTRAST, // image contrast
        CONTROL_WBR, // red of white balance
        CONTROL_WBB, // blue of white balance
        CONTROL_WBG, // the green of white balance
        CONTROL_GAMMA, // screen gamma
        CONTROL_GAIN, // camera gain
        CONTROL_OFFSET, // camera offset
        CONTROL_EXPOSURE, // expose time (us)
        CONTROL_SPEED, // transfer speed
        CONTROL_TRANSFERBIT, // image depth bits
        CONTROL_CHANNELS, // image channels
        CONTROL_USBTRAFFIC, // hblank
        CONTROL_ROWNOISERE, // row denoise
        CONTROL_CURTEMP, // current cmos or ccd temprature
        CONTROL_CURPWM, // current cool pwm
        CONTROL_MANULPWM, // set the cool pwm
        CONTROL_CFWPORT, // control camera color filter wheel port
        CONTROL_COOLER, // check if camera has cooler
        CONTROL_ST4PORT, // check if camera has st4port
        CAM_COLOR,
        CAM_BIN1X1MODE, // check if camera has bin1x1 mode
        CAM_BIN2X2MODE, // check if camera has bin2x2 mode
        CAM_BIN3X3MODE, // check if camera has bin3x3 mode
        CAM_BIN4X4MODE, // check if camera has bin4x4 mode
        CAM_MECHANICALSHUTTER, // mechanical shutter
        CAM_TRIGER_INTERFACE, // triger
        CAM_TECOVERPROTECT_INTERFACE, // tec overprotect
        CAM_SINGNALCLAMP_INTERFACE, // singnal clamp
        CAM_FINETONE_INTERFACE, // fine tone
        CAM_SHUTTERMOTORHEATING_INTERFACE, // shutter motor heating
        CAM_CALIBRATEFPN_INTERFACE, // calibrated frame
        CAM_CHIPTEMPERATURESENSOR_INTERFACE, // chip temperaure sensor
        CAM_USBREADOUTSLOWEST_INTERFACE, // usb readout slowest
        CAM_8BITS, // 8bit depth
        CAM_16BITS, // 16bit depth
        CAM_GPS, // check if camera has gps
        CAM_IGNOREOVERSCAN_INTERFACE, // ignore overscan area
        QHYCCD_3A_AUTOBALANCE,
        QHYCCD_3A_AUTOEXPOSURE,
        QHYCCD_3A_AUTOFOCUS,
        CONTROL_AMPV, // ccd or cmos ampv
        CONTROL_VCAM, // Virtual Camera on off
        CAM_VIEW_MODE,
        CONTROL_CFWSLOTSNUM, // check CFW slots number
        IS_EXPOSING_DONE,
        ScreenStretchB,
        ScreenStretchW,
        CONTROL_DDR,
        CAM_LIGHT_PERFORMANCE_MODE,
        CAM_QHY5II_GUIDE_MODE,
        DDR_BUFFER_CAPACITY,
        DDR_BUFFER_READ_THRESHOLD,
        DefaultGain,
        DefaultOffset,
        OutputDataActualBits,
        OutputDataAlignment,
        CAM_SINGLEFRAMEMODE,
        CAM_LIVEVIDEOMODE,
        CAM_IS_COLOR,
        hasHardwareFrameCounter,
        CONTROL_MAX_ID_Error,
        CAM_HUMIDITY, // if camera has humidity sensor
        CAM_PRESSURE, // if camera has pressure sensor
        CONTROL_VACUUM_PUMP, // if camera has vaccum pump
        CONTROL_SensorChamberCycle_PUMP, // air cycle pump for sensor drying
        CAM_32BITS,
        CAM_Sensor_ULVO_Status, // Sensor working status [0:init  1:good  2:checkErr  3:monitorErr 8:good 9:powerChipErr]  410 461 411 600 268 [Eris board]
        CAM_SensorPhaseReTrain, // 2020,4040/PRO，6060,42PRO
        CAM_InitConfigFromFlash, // 2410 461 411 600 268 for now
        CAM_TRIGER_MODE, //check if camera has multiple triger mode
        CAM_TRIGER_OUT, //check if camera support triger out function
        CAM_BURST_MODE, //check if camera support burst mode
        CAM_SPEAKER_LED_ALARM, // for OEM-600
        CAM_WATCH_DOG_FPGA, // for _QHY5III178C Celestron, SDK have to feed this dog or it go reset
        CAM_BIN6X6MODE, //!< check if camera has bin4x4 mode
        CAM_BIN8X8MODE, //!< check if camera has bin4x4 mode
        CONTROL_MAX_ID  // This is the max index of the list
    };

    public enum BAYER_ID
    {
        BAYER_GB = 1,
        BAYER_GR,
        BAYER_BG,
        BAYER_RG
    };

    public enum RESULT
    {
        QHYCCD_SUCCESS = 0,
        QHYCCD_ERROR = -1,
        QHYCCD_ERROR_NO_DEVICE = -2
    };
}
