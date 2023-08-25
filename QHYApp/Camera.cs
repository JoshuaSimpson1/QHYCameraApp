using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QHYApp
{
    public class Camera
    {
        int cameraIndex { get; set; }
        StringBuilder cameraId { get; set; }
        IntPtr cameraHandle { get; set; }

        public Camera(int cameraIndex, StringBuilder cameraId)
        {
            this.cameraIndex = cameraIndex;
            this.cameraId = cameraId;
            this.cameraHandle = IntPtr.Zero;
        }

        public Camera(int cameraIndex, StringBuilder cameraId, IntPtr cameraHandle)
        {
            this.cameraIndex = cameraIndex;
            this.cameraId = cameraId;
            this.cameraHandle = cameraHandle;
        }
    }
}
