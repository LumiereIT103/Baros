using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baros
{
    internal class LoggedinUser
    {
        static string Uname;
        public static string uname
        {
            get { return Uname; }
            set { Uname = value; }

        }
    }
}
