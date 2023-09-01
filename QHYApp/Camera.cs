using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QHYApp
{
    public class Camera
    {
        public int cameraIndex { get; set; }
        public Boolean hasLiveViewOpen { get; set; }
        public Boolean hasPropertiesViewOpen { get; set; }
        public StringBuilder cameraId { get; set; }
        public IntPtr cameraHandle { get; set; }

        public Camera(int cameraIndex, StringBuilder cameraId)
        {
            this.cameraIndex = cameraIndex;
            this.cameraId = cameraId;
            this.cameraHandle = IntPtr.Zero;
            this.hasLiveViewOpen = false;
            this.hasPropertiesViewOpen = false;
        }

        public Camera(int cameraIndex, StringBuilder cameraId, IntPtr cameraHandle)
        {
            this.cameraIndex = cameraIndex;
            this.cameraId = cameraId;
            this.cameraHandle = cameraHandle;
            this.hasLiveViewOpen = false;
            this.hasPropertiesViewOpen = false;
        }
    }
}
