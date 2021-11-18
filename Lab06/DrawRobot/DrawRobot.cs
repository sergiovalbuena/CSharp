using System;
namespace DrawRobot
{


    public class Robot
    {
        const int MAX_HEIGHT = 9;
        const int MAX_WIDTH = 9;

        public Robot()
        {
        }

        public void Draw()
        {
            DrawHead();
        }

        private void DrawHead()
        {
            for (int i = 0; i < MAX_HEIGHT; i++)
            {
                for (int j = 0; j < MAX_WIDTH; j++)
                {
                    if (i == 0 || j == 0 || i == MAX_HEIGHT - 1 || j == MAX_WIDTH - 1)
                    {
                        Console.Write("+");

                    }
                    else if ((i == 3 && j == 3) || (i == 3 && j == 5))
                    {
                        Console.Write("@");
                    }
                    else if ((i == 6 && j == 3) || (i == 6 && j == 4)
                        || (i == 6 && j == 5))
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

    }



}
