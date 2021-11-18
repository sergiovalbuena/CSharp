using System;
namespace StudentsApp
{
    public class Student
    {
        string studentNumber,
            studentFirstname,
            studentLastname;
        int score1, score2, score3;
        string major;
        

        public Student()
        {
        }

        public Student(string sID)
        {
            studentNumber = sID;
        }
        public Student(string sID, string sName)
        {
            studentNumber = sID;
            studentFirstname = sName;
        }


        public Student(int sc1)
        {
            score1 = sc1;
        }

        public string GetName()
        {
            return studentFirstname + " " + studentLastname;

        }

        public override string ToString()
        {
            return "Student ID:" + studentNumber +
                "\nName: " + studentFirstname +
                " " + studentLastname +
                "\nScore: " + score1;
        }
    }
}
