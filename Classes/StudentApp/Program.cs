using System;

namespace StudentsApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student Bill = new Student(56);
            Console.WriteLine(Bill);

            Student mary = new Student("703", "West");
            Console.WriteLine(mary);

            //method call or method invoke
            DisplayStudent(mary.GetName()); //mary is the argument provided to the method call 
            DisplayStudent(mary);
        }

        //method heading = static void DisplayStudent(Student person)
        //method signature = static DisplayStudent DisplayStudent(Student person) //No VOID!
        //parameter = (Student person) - because is in the method definition
        static void DisplayStudent(string person) 
        { //body of method - everything between {}
            Console.WriteLine(person);
        }
        static void DisplayStudent(Student person)
        {
            Console.WriteLine(person);
        }
    }
}
