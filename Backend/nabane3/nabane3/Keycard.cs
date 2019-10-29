using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nabane.Keycard
{
    public class Keycard
    {
        private int keycardnumber;

        public Keycard(int keycardnumber)
        {
            this.keycardnumber = keycardnumber;
        }

        public override string ToString()
        {
            return "" + keycardnumber;
        }
    }
}