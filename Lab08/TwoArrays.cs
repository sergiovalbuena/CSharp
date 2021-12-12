using System;

namespace TwoDArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDArray = new int[100, 2];

            for (int i = 0; i < twoDArray.GetLongLength(0); i++)
            {
                Random r = new Random();
                twoDArray[i, 0] = r.Next(1, 101);
                twoDArray[i, 1] = (int)Math.Pow(twoDArray[i, 0], 2);
            }

            Console.WriteLine("Random Values Squares\n");
            Console.WriteLine("{0,6} {1,13}", "Random", "Number");
            Console.WriteLine("{0,6} {1,13}", "Number", "Squared");
            Console.WriteLine("----------------------");
            for (int i = 0; i < twoDArray.GetLongLength(0); i++)
            {
                Console.WriteLine("{0,5} {1,14}", twoDArray[i, 0], twoDArray[i, 1]);
            }
        }
    }
}

/*
OUTPUT:
Random Values Squares

Random        Number
Number       Squared
----------------------
   63           3969
   26            676
   18            324
   65           4225
   20            400
   75           5625
   86           7396
   34           1156
  100          10000
   37           1369
   60           3600
   66           4356
   78           6084
   63           3969
   21            441
   33           1089
   61           3721
   79           6241
    7             49
   86           7396
   75           5625
   77           5929
   75           5625
   14            196
   72           5184
   67           4489
   41           1681
   14            196
   84           7056
   36           1296
   59           3481
   74           5476
   34           1156
   75           5625
   15            225
   90           8100
   38           1444
    3              9
   12            144
   55           3025
   52           2704
   89           7921
   99           9801
   76           5776
   29            841
   15            225
   25            625
   65           4225
   56           3136
   54           2916
   96           9216
   44           1936
   63           3969
   95           9025
   82           6724
   60           3600
   24            576
   78           6084
   66           4356
   26            676
    7             49
   45           2025
   23            529
   37           1369
   52           2704
   59           3481
    4             16
   76           5776
   22            484
    3              9
   68           4624
   32           1024
   41           1681
   25            625
    7             49
   59           3481
   51           2601
   72           5184
   57           3249
   30            900
   15            225
   49           2401
   32           1024
    4             16
   13            169
   88           7744
   84           7056
   12            144
   67           4489
   28            784
   39           1521
   34           1156
   10            100
   59           3481
   21            441
   81           6561
   39           1521
   35           1225
   97           9409
   44           1936
*/