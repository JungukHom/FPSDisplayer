namespace developer0223.Logger
{
    /// <summary>
    /// Logger class for Unity Engine.
    /// 
    /// Developer Information
    /// GitHub : https://github.com/jungukhom
    /// Blog : https://developer0223.tistory.com/
    /// </summary>

    // C#
    using System;
    using System.IO;

    // Unity
    using UnityEngine;

    public partial class Log
    {
#if UNITY_ANDROID
        // class instance
        private static Log _instance = null;

        // class instructor
        private Log() { }

        // class creator
        public static Log GetOrCreate()
        {
            return _instance ?? (_instance = new Log());
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        // private static readonly variables
        private static readonly string DefaultLogFileName = $"{Application.productName}_Log";
        private static readonly string Extender = ".txt";

        // private static variables
        private static string Path = @"E:\Test\";

        // private static properties
        private static string FullPath { get { return $"{Path}{DefaultLogFileName}{Extender}"; } }
        private static string LogPrefix { get { return $"{DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss")} :: "; } }

        public static void Write(string message)
        {
            if (!Exists())
            {
                CreateFile();
            }

            UpdateFile(message);
        }

        public static void Write(string[] messages)
        {
            if (!Exists())
            {
                CreateFile();
            }

            foreach (string message in messages)
            {
                UpdateFile(message);
            }
        }

        public static void Write(object message)
        {
            if (!Exists())
            {
                CreateFile();
            }

            UpdateFile(message.ToString());
        }

        public static void Write(object[] messages)
        {
            if (!Exists())
            {
                CreateFile();
            }

            foreach (object message in messages)
            {
                UpdateFile(message.ToString());
            }
        }

        public static void SetPath(string path)
        {
            Path = path;
        }

        private static bool CreateFile()
        {
            if (!Exists())
            {
                if (!Directory.Exists(Path))
                {
                    Directory.CreateDirectory(Path);
                }

                StreamWriter writer = File.CreateText(FullPath);
                writer.Close();
                UpdateFile("Log file created.");
                return true;
            }
            return false;
        }

        private static void UpdateFile(string message)
        {
            StreamWriter writer = File.AppendText(FullPath);
            writer.WriteLine(LogPrefix + message);
            writer.Close();
        }

        private static void ClearFile()
        {
            if (Exists())
            {
                File.WriteAllText(FullPath, "");
            }
        }

        private static void DeleteFile()
        {
            if (Exists())
            {
                File.Delete(FullPath);
            }
        }

        private static bool Exists()
        {
            return File.Exists(FullPath);
        }
#endif
    }
}