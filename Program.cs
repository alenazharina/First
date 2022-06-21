using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[3];

            myarray[0] = 1;

            myarray[1] = myarray[0] * myarray[0];

            myarray[2] = myarray[0] + myarray[1];

            Console.WriteLine("Result = {0}", myarray[0]);
            Console.WriteLine("Result = {0}", myarray[1]);
            Console.WriteLine("Result = {0}", myarray[2]);

            long[] myarray1 = new long[3];

            myarray1[0] = 7;

            myarray1[1] = myarray1[0] * myarray1[0];

            myarray1[2] = myarray1[0] + myarray1[1];

            Console.WriteLine("Result = {0}", myarray1[0]);
            Console.WriteLine("Result = {0}", myarray1[1]);
            Console.WriteLine("Result = {0}", myarray1[2]);

            float[] myarray2 = new float[3];

            myarray2[0] = 3;

            myarray2[1] = myarray2[0] * myarray2[0];

            myarray2[2] = myarray2[0] + myarray2[1];

               

            Console.WriteLine ("Result = {0}", myarray2[0]);
            Console.WriteLine("Result = {0}", myarray2[1]);
            Console.WriteLine("Result = {0}", myarray2[2]);
        }
    }
}
