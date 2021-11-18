//System.Array 
//BinarySearch 


using System;

namespace TheoryArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //CLEAR 
            double[] depth = { 6.8, 2.4, 3.3, 1.4, 7.8, 5.0 };
            double[] w = new double[6];

            w = depth;
            depth[0] = -99; //UPDATING DEPTH INSTEAD W. 
            depth.CopyTo(w, 0);


            foreach(double val in w)
            {
                Console.Write(val + " ");
            }

        }
    }
}
