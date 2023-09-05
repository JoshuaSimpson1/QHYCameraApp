using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QHYApp
{
    static class CameraCollection
    {
        public static Collection<Camera> cameras = new Collection<Camera>();

        static void CloseAllHandles()
        {
            foreach (var camera in cameras)
            {
                camera.CloseHandle();
            }
        }
    }
}
