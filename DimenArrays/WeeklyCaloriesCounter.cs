using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace WeeklyCalorieCounter
{
    class WeeklyCalorieCounter
    {
        static void Main(string[] args)
        {
            int[,] calories = {{900, 750, 1020},
                                {300, 1000, 2700},
                                {500, 700, 2100},
                                {400, 900, 1780},
                                {600, 1200, 1100},
                                {575, 1150, 1900},
                                {600, 1020, 1700}};

            double[] dailyAverage = new double[7];
            double[] mealAverage = new double[3];

            dailyAverage = CalculateAverageByDay(calories);
            mealAverage = CalculateAverageByMeal(calories);

            DisplayDailyAverage(dailyAverage);
            DisplayMealAverage(mealAverage);
            DisplayAverageCaloriesPerMeal(calories);
            Console.ReadKey();
        }

        public static double[] CalculateAverageByDay(int[,] calories)
        {
            int sum = 0;
            double[] dailyAverage = new double[7];
            for (int r = 0; r < calories.GetLength(0); r++)
            {
                for (int c = 0; c < calories.GetLength(1); c++)
                    sum += calories[r, c];
                dailyAverage[r] = (double)sum / calories.GetLength(1);
                sum = 0;
            }
            return dailyAverage;
        }

        public static double[] CalculateAverageByMeal(int[,] calories)
        {
            int sum = 0;
            double[] mealAverage = new double[3];

            for (int c = 0; c < calories.GetLength(1); c++)
            {
                for (int r = 0; r < calories.GetLength(0); r++)
                    sum += calories[r, c];
                mealAverage[c] = (double)sum / calories.GetLength(0);
                sum = 0;
            }
            return mealAverage;
        }

        public static void DisplayDailyAverage(double[] dailyAverage)
        {
            int dayNumber = 1;
            Console.WriteLine("Calorie Counter");
            Console.WriteLine("Daily Averages");
            foreach (double avgCalorie in dailyAverage)
            {
                Console.WriteLine("Day {0}: {1,6:N0}", dayNumber, avgCalorie);
                dayNumber++;
            }
        }

        public static void DisplayMealAverage(double[] mealAverage)
        {
            string[] mealTime = { "Breakfast", "Lunch", "Dinner" };
            Console.WriteLine("\n\nCalorie Counter");
            Console.WriteLine("Meal Averages");
            for (int c = 0; c < mealAverage.Length; c++)
            {
                Console.WriteLine("{0,-10}: {1,6}", mealTime[c], mealAverage[c].ToString("N0"));
            }
        }

        public static void DisplayAverageCaloriesPerMeal(int[,] calories)
        {
            double sum = 0;
            for (int da = 0; da < calories.GetLength(0); da++)
                for (int ml = 0; ml < calories.GetLength(1); ml++)
                    sum += calories[da, ml];
            Console.WriteLine("\nCaloric Average Per Meal: {0:N0}", sum / calories.Length);

        }
    }
}

/*
//OUTPUT: 
Calorie Counter
Daily Averages
Day 1:    890
Day 2:  1,333
Day 3:  1,100
Day 4:  1,027
Day 5:    967
Day 6:  1,208
Day 7:  1,107


Calorie Counter
Meal Averages
Breakfast :    554
Lunch     :    960
Dinner    :  1,757

Caloric Average Per Meal: 1,090

*/