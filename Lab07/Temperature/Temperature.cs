using System;
namespace Temperature
{
    public class Temperature
    {
        int smallest = 9999;
        int biggest = 1;
        int[] weeklyTemps;

        public Temperature()
        {
        }

        public Temperature(int[] weeklyTemps)
        {
            this.weeklyTemps = weeklyTemps;
        }

        public int FindColdestTemp()
        {
            foreach (int i in weeklyTemps)
            {
                if (i < smallest)
                {
                    smallest = i;
                }
            }
            return smallest;
        }

        public int FindWarmestTemp()
        {
            foreach (int j in weeklyTemps)
            {
                if (j > biggest)
                {
                    biggest = j;
                }
            }
            return biggest;
        }

        public override string ToString()
        {
            return "Temperatures: \n"
                    + weeklyTemps[0] + " " + weeklyTemps[1] + " " + weeklyTemps[2] + "\n"
                    + weeklyTemps[3] + " " + weeklyTemps[4] + " " + weeklyTemps[5] + "\n"
                    + weeklyTemps[6] + "\n"
                    + "Temperatures ranged from " + smallest + " to " + biggest;
        }
    }
}
