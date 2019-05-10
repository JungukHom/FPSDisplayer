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
        // class instance
        private static Log _instance = null;

        // class instructor
        private Log() { }

        // class creator
        public static Log GetOrCreate()
        {
            return _instance ?? (_instance = new Log());
        }
    }
}