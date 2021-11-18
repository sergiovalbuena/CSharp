using System;

namespace Switch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("enter the province initials: ");
            string inVal;
            string province;
            inVal = Console.ReadLine();

            switch (inVal.ToUpper())
            {
                //case "bc":
                case "BC": province = "British Columbia";
                    break;
                case "AB": province = "Alberta";
                    break;
                case "SK": province = "Saskatchewan";
                    break;
                default: province = "an Unknown province";
                    break;
            }
            Console.WriteLine($"You selected {province}");
        }
    }
}

/*
//OUTPUT
//Prompt: enter the rpovince initials:
You selected ________
*/