using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QHYApp
{
    static class AppSettings
    {
        readonly static String AppFolder = "/QHYApp/";

        // Gets the path for the Application data of a computer
        private static String GetAppDataPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }

        // Loads the default camera settings file and returns it per cameraId
        public static String LoadDefaultCamera(StringBuilder cameraId)
        {
            String AppdataPath = GetAppDataPath() + AppFolder;
            String CameraSettingsFile = "";

            // If there is no file that exists from previous cameras return an empty string
            if(!File.Exists(AppdataPath + cameraId.ToString()))
            {
                return CameraSettingsFile;
            }
            
            StreamReader streamReader = new StreamReader(AppdataPath + cameraId.ToString());
            CameraSettingsFile = streamReader.ReadLine();
            streamReader.Close();

            if (string.IsNullOrEmpty(CameraSettingsFile))
            {
                return "";
            }
            else
            {
                return CameraSettingsFile;
            }
        }

        public static void SaveDefaultCamera(StringBuilder cameraId, String settingsFilePath)
        {
            String AppdataPath = GetAppDataPath() + AppFolder;
            if(settingsFilePath == "")
            {
                return;
            }
            if(!Directory.Exists(AppdataPath))
            {
                Directory.CreateDirectory(AppdataPath);
            }

            StreamWriter streamWriter = new StreamWriter(AppdataPath + cameraId.ToString());
            streamWriter.WriteLine(settingsFilePath);
            streamWriter.Close();
        }
    }
}
