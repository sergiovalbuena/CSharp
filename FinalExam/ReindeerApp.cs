using System;

namespace PartC
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Reindeer ru = new Reindeer();
            ru.RName = "Rudolph";
            ru.FlySpeed = 2200.5f;
            Console.WriteLine(ru);


            Reindeer don = new Reindeer();
            don.RName = "Donner";
            don.FlySpeed = 2100.42f;
            Console.WriteLine(don);
        }

        public class Reindeer
        {
            string rName;
            float flySpeed;

            public Reindeer()
            {
            }

            public string RName
            {
                get { return rName; }
                set { rName = value; }
            }
            public float FlySpeed
            {
                get { return flySpeed; }
                set { flySpeed = value; }
            }


            public override string ToString()
            {
                return "Reindeer " + rName + " can fly at spped " + flySpeed;
            }

        }
    }
}
