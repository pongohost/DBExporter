using System;

namespace DataExporter
{
    public static class auth
    {
        static String _authId;
        static String _authName;
        static int _logId;
        public static String authID
        {
            get
            {
                return _authId;
            }
            set
            {
                _authId = value;
            }
        }

        public static string AuthName
        {
            get
            {
                return _authName;
            }

            set
            {
                _authName = value;
            }
        }

        public static int LogId
        {
            get
            {
                return _logId;
            }

            set
            {
                _logId = value;
            }
        }
    }
}
