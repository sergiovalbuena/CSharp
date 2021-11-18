string day = "Monaday";
Console.WriteLine($"Length of day is {day.Length}");
day.Substring;
char c;
char.TryParse(day.Substring(0,1), out c); //0,1 means 0 posicion array, 1 for lenght. 
Console.WriteLine(c;)
//OUTPUT: M


int[] numArr; //decalre an Array but no demension it.

numArr = new int[5]; //dimensioned it 
//OTHER WEY TO CREATED 
numArr[0] = 10;
numArr[1] = 15;

numArray = new int[] {9,8,7,6,5,4,3,2,1};//complite time of intitializationn

//SHORTCUT
int [] numArra = {1,2,3,4,5,6,77 };// SHORTCUT compile-tine initializaction

//
//Add togehter two arays: 
//a,b,c are integer arrays if length 5
//c[0] = a[0] + b[0]

int[] a = new int[]{5,3,2,-1,4};
int[] b = new int[]{7,2,6,5,-3};
int[] c = new int[a.lenght];

for (int i=0; i<a.Length; i++)
{
    c[i]= a[i]+b[i];
}


string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars.Length);
// Outputs 4

string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
for (int i = 0; i < cars.Length; i++) 
{
  Console.WriteLine(cars[i]);
}

//FOREACH!
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}

int total = 0;
double avg;
foreach(int val in score)
{
    total += val;
}
WritleLine("Total: "+ total);
avg = (double)total/scoreCnt;
WritleLine("Average: " + avg.ToString(0));


//SORT
// Sort an int
int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
  Console.WriteLine(i);
}


//foreach read only access to arrays
foreach(int i in a)
{
    Console.WriteLine(i);
}