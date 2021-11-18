namespace PlayerApp
{
    class Player
    {
        private string lname;
        private string fname;
        private string id;
        private int[] pointsScored;
        private int numberOfGames;

        // Default Constructor
        public Player()
        {
        }

        // Constructor accepts any size
        // pointsScored array. 
        public Player(string ln, string fn,
                   string iden, int[] s, int numGames)
        {
            numberOfGames = numGames;
            FillPointsScoredArray(s);
            lname = ln;
            fname = fn;
            id = iden;
        }


        public string FName
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }

        public string LName
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int NumberOfGames
        {
            get
            {
                return numberOfGames;
            }
            set
            {
                numberOfGames = value;
            }
        }

        public int[] PointsScored
        {
            get
            {
                return pointsScored;
            }
            set
            {
                pointsScored = value;
            }
        }

        public void FillPointsScoredArray(int[] s)
        {
            pointsScored = new int[numberOfGames];
            for (int i = 0; i < pointsScored.Length; i++)
            {
                pointsScored[i] = s[i];
            }
        }

        public double ComputeAverage()
        {
            double total = 0;
            double avg;

            foreach (int s in pointsScored)
            {
                total += s;
            }
            if (pointsScored.Length > 0)
            {
                avg = total / pointsScored.Length;
            }
            else
            {
                avg = 0;
            }
            return avg;
        }

        public override string ToString()
        {
            return "Player Name: " + fname + " " + lname +
                   "\nPlayer ID: " + id +
                   "\nNumber of Games: " + numberOfGames +
                   "\nAverage Points Scored per Game: " + ComputeAverage().ToString("F2");
        }
    }
}