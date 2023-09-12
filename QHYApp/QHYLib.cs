using System;
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
        // https://www.qhyccd.com/news2/


        // Initialzes SDK Resources and should only be called once, returns QHYCCD_SUCCESS
        // if the function succeeds.
        [DllImport("qhyccd.dll", EntryPoint = "InitQHYCCDResource",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 InitQHYCCDResource();

        // Release camera resources.
        [DllImport("qhyccd.dll", EntryPoint = "ReleaseQHYCCDResource",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 ReleaseQHYCCDResource();

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
        public unsafe static extern IntPtr OpenQHYCCD(StringBuilder id);

        // Initialize camera parameters and SDK resources. Different cameras require different
        // initialization times. QHYCCD_SUCCESS is returned when successful.
        [DllImport("qhyccd.dll", EntryPoint = "InitQHYCCD",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 InitQHYCCD(IntPtr handle);

        // Turn off the camera and disconnect, QHYCCD_SUCCESS is returned.
        [DllImport("qhyccd.dll", EntryPoint = "CloseQHYCCD",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 CloseQHYCCD(IntPtr handle);

        // Set the bin mode of the camera, "pixel binning" means taking a group of four adjacent pixels
        // and treating it as a bigger pixel on the cameras sensor. Removes grain.
        [DllImport("qhyccd.dll", EntryPoint = "SetQHYCCDBinMode",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 SetQHYCCDBinMode(IntPtr handle, UInt32 wbin, UInt32 hbin);

        // This function allows to set the camera parameters as to the entries in the CONTROL_ID enum.
        // When the function suceeds it returns QHYCCD_SUCCESS (it's 0 for some reason.)
        [DllImport("qhyccd.dll", EntryPoint = "SetQHYCCDParam",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 SetQHYCCDParam(IntPtr handle, CONTROL_ID controlId, double value);

        // This returns the maximum memory size required for the camera image. This function returns a fixed
        // memory size that is slightly larger than the actual size to avoid unexpected memory overflow.
        [DllImport("qhyccd.dll", EntryPoint = "GetQHYCCDMemLength",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 GetQHYCCDMemLength(IntPtr handle);

        // Starts single frame mode exposure, call the camera to start exposing a single frame
        // of the image. Supposed to return QHYCCD_SUCCESS but I guess other cameras can return different things.
        [DllImport("qhyccd.dll", EntryPoint = "ExpQHYCCDSingleFrame",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 ExpQHYCCDSingleFrame(IntPtr handle);

        // Stops the camera exposure. For WINUSB cameras the function stops exposure time, image data still needs
        // to be read.
        [DllImport("qhyccd.dll", EntryPoint = "CancelQHYCCDExposing",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 CancelQHYCCDExposing(IntPtr handle);

        // Stop camera exposure and stop data reading. Camera does not output data and software doesn't receive it.
        [DllImport("qhyccd.dll", EntryPoint = "CancelQHYCCDExposingAndReadout",
         CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 CancelQHYCCDExposingAndReadout(IntPtr handle);

        // w: image width information. h: image height information
        // bpp: image bits information. channels: obtained image channels information
        // rawArray: image data.
        [DllImport("qhyccd.dll", EntryPoint = "GetQHYCCDSingleFrame",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 GetQHYCCDSingleFrame(IntPtr handle, ref UInt32 w, ref UInt32 h, ref UInt32 bpp, ref UInt32 channels, byte* rawArray);

        public unsafe static UInt32 C_GetQHYCCDSingleFrame(IntPtr handle, ref UInt32 w, ref UInt32 h, ref UInt32 bpp, ref UInt32 channels, byte[] rawArray)
        {
            UInt32 ret;
            fixed (byte* prawArray = rawArray)
                ret = GetQHYCCDSingleFrame(handle, ref w, ref h, ref bpp, ref channels, prawArray);
            return ret;
        }

        // Gets the following chip information: width (mm), height (mm), image width, image height, pixel width (microns), pixel height (microns), image data depth
        [DllImport("qhyccd.dll", EntryPoint = "GetQHYCCDChipInfo",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 GetQHYCCDChipInfo(IntPtr handle, ref double chipw, ref double chiph, ref UInt32 imagew, ref UInt32 imageh, ref double pixelw, ref double pixelh, ref UInt32 bpp);

        // Check the link at the top for this one.
        [DllImport("qhyccd.dll", EntryPoint = "GetQHYCCDOverScanArea",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 GetQHYCCDOverScanArea(IntPtr handle, ref UInt32 startx, ref UInt32 starty, ref UInt32 sizex, ref UInt32 sizey);

        // This function outputs the valid size and starting position of the image.
        [DllImport("qhyccd.dll", EntryPoint = "GetQHYCCDEffectiveArea",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 GetQHYCCDEffectiveArea(IntPtr handle, ref UInt32 startx, ref UInt32 starty, ref UInt32 sizex, ref UInt32 sizey);

        // Returns the camera driver in the form of a date. (year - month - day)
        [DllImport("qhyccd.dll", EntryPoint = "GetQHYCCDFWVersion",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 GetQHYCCDFWVersion(IntPtr handle, byte* verBuf);
        public unsafe static UInt32 C_GetQHYCCDFWVersion(IntPtr handle, byte[] verBuf) {
            fixed (byte* pverBuf = verBuf)
                return GetQHYCCDFWVersion(handle, pverBuf);
        }

        // Obtains the settings of camera parameters, such as exposure time, gain, bias. Before using these,
        // you must use IsQHYCCDControlAvailable to check if the camera supports what you are attempting to do.
        [DllImport("qhyccd.dll", EntryPoint = "GetQHYCCDParam",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern double GetQHYCCDParam(IntPtr handle, CONTROL_ID controlid);

        // You can use this function to get the minimum, maximum, and min step of camera parameters
        [DllImport("qhyccd.dll", EntryPoint = "GetQHYCCDParamMinMaxStep",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 GetQHYCCDParamMinMaxStep(IntPtr handle, CONTROL_ID controlid, ref double min, ref double max, ref double step);

        // This has no documentation on the SDK
        // TODO: Find out if this is important
        [DllImport("qhyccd.dll", EntryPoint = "ControlQHYCCDGuide",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 ControlQHYCCDGuide(IntPtr handle, byte Direction, UInt16 PulseTime);

        // Sets the target tempature for camera cooling. You should check if the camera has cooling first.
        [DllImport("qhyccd.dll", EntryPoint = "ControlQHYCCDTemp",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 ControlQHYCCDTemp(IntPtr handle, double targettemp);

        // Control the rotation of the filter wheel to the specified position.
        [DllImport("qhyccd.dll", EntryPoint = "SendOrder2QHYCCDCFW",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 SendOrder2QHYCCDCFW(IntPtr handle, String order, int length);

        // This checks if a camera has a certain function based on the CONTROL_ID. Return QHYCCD_SUCCESS
        // if the camera has the function, and error otherwise. 
        [DllImport("qhyccd.dll", EntryPoint = "IsQHYCCDControlAvailable",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 IsQHYCCDControlAvailable(IntPtr handle, CONTROL_ID controlid);

        // This has no information on the SDK but I assume this is to assist in cooling the shutter.
        [DllImport("qhyccd.dll", EntryPoint = "ControlQHYCCDShutter",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 ControlQHYCCDShutter(IntPtr handle, byte targettemp);

        // Used to set the resolution and region of interest of the camera image, the base reference point is the upper left corner of the image
        [DllImport("qhyccd.dll", EntryPoint = "SetQHYCCDResolution",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 SetQHYCCDResolution(IntPtr handle, UInt32 startx, UInt32 starty, UInt32 sizex, UInt32 sizey);

        // mode: Working mode of the camera. When the value is 0, it is single frame mode, and when the value is 1, it's in continuous mode.
        [DllImport("qhyccd.dll", EntryPoint = "SetQHYCCDStreamMode",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 SetQHYCCDStreamMode(IntPtr handle, UInt32 mode);

        //EXPORTFUNC uint32_t STDCALL GetQHYCCDCFWStatus(qhyccd_handle *handle,char *status)
        // I would read the docs for this one.
        [DllImport("qhyccd.dll", EntryPoint = "GetQHYCCDCFWStatus",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 GetQHYCCDCFWStatus(IntPtr handle, StringBuilder cfwStatus);

        // Gets the version of the SDK version being used in qhyccd.dll
        [DllImport("qhyccd.dll", EntryPoint = "GetQHYCCDSDKVersion",
           CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 GetQHYCCDSDKVersion(ref UInt32 year, ref UInt32 month, ref UInt32 day, ref UInt32 subday);

        // Sets the trigger function of the camera. If the param is 0, the external trigger function is disabled.
        // NOTE: Since the developers aren't native english speakers the function in the DLL is called TRIGER NOT TRIGGER.
        [DllImport("qhyccd.dll", EntryPoint = "SetQHYCCDTrigerMode",
            CharSet = CharSet.Ansi, CallingConvention=CallingConvention.StdCall)]
        public unsafe static extern UInt32 SetQHYCCDTriggerMode(IntPtr handle, UInt32 triggerMode);

        // Same thing as above but just uses the true/false values
        [DllImport("qhyccd.dll", EntryPoint = "SetQHYCCDTrigerFunction",
            CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern UInt32 SetQHYCCDTriggerFunction(IntPtr handle, bool value);
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
        CAM_WATCH_DOG_FPGA, // for _QHY5III178C Celestron
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
