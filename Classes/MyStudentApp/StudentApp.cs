using System;

namespace MyStudentApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declare a Student Object with defaul vales.
            Student firstStudentObject = new Student();

            //Prompt for data member values.
            firstStudentObject.StudentLastName = AskForStudentName("First");
            firstStudentObject.StudentFirstName = AskForStudentName("Last");
            firstStudentObject.StudenNumber = AskForStudentNumber();
            firstStudentObject.Major = AskForMajor(firstStudentObject.StudentFirstName);
            firstStudentObject.ExamScore1 = AskForExamScore(1);
            firstStudentObject.ExamScore2 = AskForExamScore(2);
            firstStudentObject.ExamScore3 = AskForExamScore(3);

            Console.Clear();

            Console.WriteLine("First Student");
            Console.WriteLine(firstStudentObject.ToString());


            //declare a student with a efined student number an the reaminang data members are default automatly.
            Student secondStudentObject = new Student("2345");
            //provide the ecam score data member values:
            secondStudentObject.ExamScore1 = 95;
            secondStudentObject.ExamScore2 = 62;
            secondStudentObject.ExamScore3 = 87;

            Console.WriteLine("\n\nSecond Student");
            Console.WriteLine("Student Number :" + secondStudentObject.StudenNumber
                + "\nAverage : {0:F1}", secondStudentObject.CalculateAvarage());


            //declare a student with a defined studen number, first name and last name:
            Student thirdStudentObject = new Student("5432", "Randolph", "Wonder");
            //provide the exam scores and major value.
            thirdStudentObject.Major = "Math";
            thirdStudentObject.ExamScore1 = 95;
            thirdStudentObject.ExamScore2 = 87;
            thirdStudentObject.ExamScore3 = 72;
            Console.WriteLine("\n\nThird Student:");
            Console.WriteLine(thirdStudentObject);

            //Declare a stundet object with all the data memebers values passed to the constructor
            //TODO LO COMENTADO ABAJO ES PORQUE ABAJO DE LO COMENTARO ESTA UN METODO MAS FACIL
            Student aStudentObject = new Student("9876", "Maria", "Smithsonian", 97, 86, 94, "CS");
            Console.WriteLine("\n\nA Student:");
            
                        Console.WriteLine(aStudentObject + "Exam Score 1: "+aStudentObject.ExamScore1);

                        Console.WriteLine("\n\n\tA Student Second View:");
                        Console.WriteLine("Student Name:" + aStudentObject.StudentFirstName+" "+ aStudentObject.StudentLastName +
                            "\nStudent Number: "+ aStudentObject.StudenNumber + "\nMajor:"+aStudentObject.Major +
                            "\nExam Score 1:" + aStudentObject.ExamScore1+
                            "\nExam Score 2:" + aStudentObject.ExamScore2 +
                            "\nExam Score 3:" + aStudentObject.ExamScore3 +
                            "\nExam Average: "+ aStudentObject.CalculateAvarage().ToString("F1"));
                        Console.ReadKey();
            


        }

        static int AskForExamScore(int whichOne)
        {
            string inValue;
            int aScore;
            Console.Write("Enter a value for score {0}:", whichOne);
            inValue = Console.ReadLine();
            aScore = int.Parse(inValue);

            return aScore;
        }

        static string AskForStudentName(string whichOne)
        {
            string inValue;

            Console.Write("Enter student {0} Name: ", whichOne);
            inValue = Console.ReadLine();
            return inValue;
        }

        static string AskForMajor(string name)
        {
            string major;
            Console.Write("Enter {0}'s: ", name);
            major = Console.ReadLine();
            return major;
        }
        static string AskForStudentNumber()
        {
            string student;
            Console.Write("Enter Student Number: ");
            student = Console.ReadLine();
            return student;
        }
    }
}

//OUTPUT:
/*
Enter student Last Name: b
Enter Student Number: 1 
Enter b's: l
Enter a value for score 1:10
Enter a value for score 2:10
Enter a value for score 3:8 
///////////    //////////     ///////

name:b a
Major: l
Score Avarage: 9.33


Second Student
Student Number :2345
Average : 81.3


Third Student:
name:Wonder Randolph
Major: Math
Score Avarage: 84.67


A Student:
name:Smithsonian Maria
Major: CS
Score Avarage: 92.33Exam Score 1: 97


        A Student Second View:
Student Name:Smithsonian Maria
Student Number: 9876
Major:CS
Exam Score 1:97
Exam Score 2:86
Exam Score 3:94
Exam Average: 92.3

*/