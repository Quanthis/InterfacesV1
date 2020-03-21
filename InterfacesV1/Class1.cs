using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesV1
{
    public class Class1 : Interface1
    {
        private int value;

        public Class1(int value)
        {
            this.value = value;
        }

        public int GetValue()
        {
            return value;
        }

        public void ResetValue()
        {
            this.value = 0;
        }

    }
}
