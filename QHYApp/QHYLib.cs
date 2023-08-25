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
    }
}
