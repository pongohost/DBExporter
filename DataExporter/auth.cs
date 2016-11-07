using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExporter
{
    public static class auth
    {
        static String _authId;
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
    }
}
