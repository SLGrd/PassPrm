using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassPrm
{
    public class CommonClass
    {
        public class ParmClass
        {
            private string _P1;
            private string _P2;

            public string P1 
            {
                get { return _P1;  }
                set { _P1 = value; }
            }

            public string P2
            {
                get { return _P2; }
                set { _P2 = value; }
            }

            public ParmClass()
            {
                _P1 = "Default P1";
                _P2 = "Default P2";
            }

            public ParmClass( string p1, string p2)
            {
                _P1 = p1;
                _P2 = p2;
            }
        }
    }
}
