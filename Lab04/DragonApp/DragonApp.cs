using System;

namespace DragonApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dragon melvinTheDragon = new Dragon("Melvin", 32, 75.2f, true,"verde");
            melvinTheDragon.ToString();
            Console.WriteLine(melvinTheDragon);

            Console.WriteLine("");

            Dragon dewey = new Dragon("dewey");
            Console.WriteLine(dewey);

            Console.WriteLine("");

            Dragon jacoboDragon = new Dragon("Jacobo", 29, 81.3f,true,"turquis");
            jacoboDragon.ToString();
            Console.WriteLine(jacoboDragon);
        }
    }
}
/*
//OUTPUT

 age: 32
 spped💨: 75.2kph
 Breathe Fire🔥: True
 Color: verde

Dragon Name🐉: dewey
 age: 0
 spped💨: 0kph
 Breathe Fire🔥: False
 Color: 

Dragon Name🐉: Jacobo
 age: 29
 spped💨: 81.3kph
 Breathe Fire🔥: True

*/