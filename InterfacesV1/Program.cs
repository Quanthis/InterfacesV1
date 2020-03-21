using System;

namespace InterfacesV1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ob = new Class1(5);
            ob.ResetValue();

            Console.WriteLine(ob.GetValue());

            Console.ReadKey();
        }
    }
}
