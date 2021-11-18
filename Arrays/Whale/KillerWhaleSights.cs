using System;
namespace WhalesApp
{
    public class KillerWhaleSighting
    {
        string location;
        string[] sightDate;
        int[] killerWhaleCount;

        public KillerWhaleSighting()
        {
        }

        public KillerWhaleSighting(string loc)
        {
            location = loc;
        }

        public KillerWhaleSighting(string loc, string[] date, int[] count)
        {
            sightDate = new string[date.Length];
            killerWhaleCount = new int[count.Length];
            Array.Copy(date, 0, sightDate, 0, date.Length);
            Array.Copy(count, 0, killerWhaleCount, 0, killerWhaleCount.LongLength);
            location = loc;
        }

        public KillerWhaleSighting(string loc, string[] date, int[] count, int numOfSailings)
        {
            sightDate = new string[numOfSailings];
            killerWhaleCount = new int[numOfSailings];
            Array.Copy(date, 0, sightDate, 0, numOfSailings);
            Array.Copy(count, 0, killerWhaleCount, 0, numOfSailings);
            location = loc;
        }

        //Properties
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string[] SightDate
        {
            get { return sightDate; }
            set { sightDate = value; }
        }
        public int[] KillerWhaleCount
        {
            get { return killerWhaleCount; }
            set { killerWhaleCount = value; }
        }

        //Determines what the average number of sightings is per location
        public double CalculateAvg()
        {
            double avg;

            int countOfValidEntries;
            int total = 0;
            foreach (int c in killerWhaleCount)
            {
                total += c;
            }
            countOfValidEntries = TestForZeros();
            avg = (double)total / countOfValidEntries;
            return avg;
        }

        //To avoid skewing average retirn number of cells with nonzero values
        public int TestForZeros()
        {
            int numberOfTrueSightings = 0;
            foreach (int count in killerWhaleCount)
            {
                if (count != 0)
                {
                    numberOfTrueSightings++;
                }
            }
            return numberOfTrueSightings;
        }
        //Returns an index where the largest number of sightings is stored
        public int GetIndexOfMostSightings()
        {
            int maxCntIndex = 0;

            for (int i = 1; i < killerWhaleCount.Length; i++)
            {
                if (killerWhaleCount[i] > killerWhaleCount[maxCntIndex])
                {
                    maxCntIndex = i;
                }
            }
            return maxCntIndex;
        }

        //Returns a count of the most sighted
        public int GetMostSightings()
        {
            return killerWhaleCount[GetIndexOfMostSightings()];
        }
        //Returns the date when the most sighting occurred
        public string GetDateWithMostSightings()
        {
            return sightDate[GetIndexOfMostSightings()];
        }
        //Returns the date when the most sightings occurred
        public string GetMonthWithMostSightings()
        {
            return ReturnMonth(sightDate[GetIndexOfMostSightings()]);
        }

        //computes the average for a given month
        public double ComputeAverageForMonth(string month)
        {
            int total = 0;
            int days = 0;
            double monthAverage;
            for (int i = 0; i < sightDate.Length; i++)
            {
                if (sightDate[i].StartsWith(month))
                {
                    total += killerWhaleCount[i];
                    days++;
                }
            }

            if (days > 0)
            {
                monthAverage = (double)total / days;
            }
            else
            {
                monthAverage = 0;
            }
            return monthAverage;
        }
        //Given a dat in the format of mm/dd/yyyy the name of the month is returned
        public string ReturnMonth(string someDate)
        {
            string[] monthName = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "Octuber", "November", "December" };
            string[] dateParts = someDate.Split('/');
            dateParts[0] = dateParts[0].TrimStart('0');

            return monthName[Convert.ToInt32(dateParts[0]) - 1];
        }

        public override string ToString()
        {
            return
                "\t📍Location: " + location +
                "\n\nAverage Numver of Sightings:\t" + CalculateAvg().ToString("F1") +
                "\n\nMonth name for the" +
                "\nDate of Most Sightings:\t\t" + GetMonthWithMostSightings() +
                "\n\nDate of Most Sightings:\t\t" + GetMonthWithMostSightings() +
                "\nCount for " + GetDateWithMostSightings() +
                ":\t\t" + GetMostSightings();
                ;
        }
    }
}
