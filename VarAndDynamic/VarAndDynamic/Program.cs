using System;

namespace VarAndDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            long b = 20L;
            int a = (int)b;


            var p1 = new
            {
                FirstName = "John",
                LastName = "Doe"
            };

            var p2 = new
            {
                FirstName = "John2",
                LastName = "Doe2"
            };

            /*
            dynamic a = new CollectionOfIntegers(1, 2, 3);
            ProcessData(a);
            PrintInteger(a);
            */

            /*
            var a = new CollectionOfIntegers(1, 2, 3);
            int sum = a.Sum();
            Console.WriteLine(sum);
            */
        }

        private static void ProcessData(dynamic data)
        {
            // NOT WORKING!
            // a = a + 10;
            // int sum = data.Sum();
            // Console.WriteLine(sum);
            Console.WriteLine(data);

            //data = data.ToString() + " test";
            //Console.WriteLine(data);

            data = data + 20;
            Console.WriteLine(data);
        }

        private static void PrintInteger(int x)
        {
            Console.WriteLine(x);
        }
    }
}
