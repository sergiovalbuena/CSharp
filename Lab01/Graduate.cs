using System;

namespace Graduate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Name: Sergio Valbuena");
            Console.WriteLine("Graduate Year: 2023");
            Console.WriteLine("School: Camosun College");

            string studentName = "Sergio Valbuena";
            string year = "2023";
            string SchoolName = "Camosun College";

            Console.WriteLine($"Name: {studentName} ");
            Console.WriteLine($"Graduate Year: {year} ");
            Console.WriteLine($"School: {SchoolName}");
        }
    }
}


/*
//OUTPUT=
Name: Sergio Valbuena
Graduate Year: 2023
School: Camosun College
Name: Sergio Valbuena 
Graduate Year: 2023 
School: Camosun College
*/