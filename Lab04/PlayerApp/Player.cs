using System;
namespace PlayerApp
{
    public class Player
    {
        int playerID;
        string firstName;
        string lastName;
        int gamesWon;
        int gamesLost;
        int totalGames;

        public Player()
        {
        }
        // COMPLETE CONSTRUCTOR
        public Player(int pID, string fName, string lName)
        {
            playerID = pID;
            firstName = fName;
            lastName = lName;
        }

        public int GamesWon
        {
            get { return gamesWon; }
        }
        public int GamesLost
        {
            get { return gamesLost; }
        }
        public int TotalGames
        {
            get { return totalGames; }
        }

        public string FullName()
        {
            return (firstName + " " + lastName);
        }
        public int GamesPlayed()
        {
            return (gamesWon + gamesLost);
        }
        public void ScoreGameWin()
        {
            gamesWon++; 
        }
        public void ScoreGameLoss()
        {
            gamesLost++;
        }



        public override string ToString()
        {
            return "Student ID🧑🏼‍🎓 : " + playerID +
                "\n Full Name : " + FullName() +
                "\n Games Played: " + GamesPlayed();
        }

    }
}
