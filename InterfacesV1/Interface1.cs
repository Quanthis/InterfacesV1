using System;

namespace InterfacesV1
{
    interface Interface1
    {
        int GetValue();

        /*public int DuplicateValue(int a)               //this works starting at C# 8.0
        {
            return a * 2;
        }*/

        void ResetValue();
    }
}
