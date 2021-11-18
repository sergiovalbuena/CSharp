//PARA CORRERLO EN VSC TOCA
//1. crear archivo: dotnet new console -o _repoName
//2. cd repoName
//3. converit el programa: csc fileName.cs / Program.cs
//4. ejecutar en consola : mono fileName.exe / Program.exe

/*
Value Types:
byte, sbyte, char, int, uint, long, ulong, short, ushort
*/
//Examples of Integral VAriables Declarations
int studentCount;
int ageOfStudent = 20;
int numberOfExams, coursesEnrrolled;  //use , to separate vars 
long numberOdSalesItems;
char myInital= 's';
//Floating-Point
double extraPerson = 3.50; //double is the default
double weight = 1.7E-3; 
double averageScore = 70.0;
//float 
float totalAmount = 23.57f; //must provide f after number
float initalCost = 0; 
//monetary data
decimal endowmentAmount = 33897698.26M;//must have M
decimal amountOwed = 3000.50m;
//Boolean
bool moreData = true;
//string
string courseName = "Algorithims & Programming";
string pi = "\u03c0"; 
string fileLocation = @ "C:\CSharpProjects\Chapter2"; //@ \ 

WriteLine("{0:c}", 26666.7888); //c for currency OUTPUT: $26.666.79
WriteLine("{0:c}", -2); //c for currency OUTPUT: ($2.00)
WriteLine("{0:F4}", 50); //OUTPUT: 50.0000
WriteLine("{0:F0} {1}" ,50,22); //output 5022
//N for number, P for percentage 
Console.WriteLine("Feet: \t\t{0,0:N0}",distanceFeet);
WriteLine("{0,10:F0}{1,8:C}")
//Making Data Constant
const double TAX_RATE = 0.06675;
const int SPEED = 70;
const char HIGHEST_GRADE = 'A';
