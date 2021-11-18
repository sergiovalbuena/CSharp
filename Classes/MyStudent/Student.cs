using System;
namespace MyStudentApp
{
    public class Student
    {
        //Data memebers, data fields, or characteristics
        private string studentNumber;
        private string studentFirstName;
        private string studentLastName;
        private int examScore1;
        private int examScore2;
        private int examScore3;
        private string major;

        //defaul constructor
        public Student()
        {
        }

        //constructor with one argument
        public Student(string sID)
        {
            studentNumber = sID;
        }
        //constructor with two arguments:
        public Student(string sID, string lastName, string firstName)
        {
            studentNumber = sID;
            studentLastName = lastName;
            studentFirstName = firstName;
        }
        //constructor with six arguments
        public Student(string sID, string lastName, string firstName, int s1, int s2, int s3, string maj)
        {
            studentNumber = sID;
            studentLastName = lastName;
            studentFirstName = firstName;
            examScore1 = s1;
            examScore2 = s2;
            examScore3 = s3;
            major = maj;
        }

        //PROPERTIES
        public string StudentLastName
        {
            get { return studentLastName; }
            set { studentLastName = value; }
        }
        public string StudentFirstName
        {
            get { return studentFirstName; }
            set { studentFirstName = value; }
        }
        public string StudenNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }
        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        public int ExamScore1
        {
            get { return examScore1; }
            set { examScore1 = value; }
        }
        public int ExamScore2
        {
            get { return examScore2; }
            set { examScore2 = value; }
        }
        public int ExamScore3
        {
            get { return examScore3; }
            set { examScore3 = value; }
        }

        public double CalculateAvarage()
        {
            return (examScore1 + examScore2 + examScore3) / 3.0;
        }
        public override string ToString()
        {
            return "name:" + studentFirstName + " " + studentLastName + 
                "\nMajor: " + major +
                "\nScore Avarage: " + CalculateAvarage().ToString("F2");
        }
    }
}

/*
//OUTPUT:
PROMPTS: 
Enter student First Name: Sergio
Enter student Last Name: Valbuena
Enter Student Number: 1010
Enter Valbuena's: CS
Enter a value for score 1:80
Enter a value for score 2:90
Enter a value for score 3:70

//PRINTED RESULTS

name:Valbuena Sergio
Major: CS
Score Avarage: 80.00


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