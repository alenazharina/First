using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray;

            myarray = new int[5];

            myarray[1] = 3;

            myarray[4] = 10;

            long[] myarray1;

            myarray1 = new long[5];

            myarray1[2] = 7;

            myarray1[4] = 12;

            float[] myarray2;

            myarray2 = new float[5];

            myarray2[3] = 3;

            myarray2[4] = 9;

               

            Console.WriteLine ("Result = {0}", myarray[0]);
        }
    }
}
