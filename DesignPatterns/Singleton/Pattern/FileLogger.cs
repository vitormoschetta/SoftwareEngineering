using System.Collections.Generic;

namespace Pattern
{
    public class FileLogger
    {
        private FileLogger() { }
        private static FileLogger _instance;
        public string Text { get; set; }

        public static FileLogger GetInstance()
        {
            if (_instance == null)
                _instance = new FileLogger();

            return _instance;
        }

    }
}