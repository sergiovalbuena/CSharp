
//ARITHMETIC OPERATIONS
//IF AND ELSE 
int a = 3;
int b = 3;
int c = 7;
if ((a + b + c > 10) || (a == b)) //or can use && = and. \\ = or. 
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

/*
num++; = num = nume +1;
++num; = first incremented and then use it
--value1:
*/
int num = 5; num += 2; //num = num + 2;

////////////////////////////////////////////////
////////////////////////////////////////////////
////////////////// LOOP: ///////////////////////
////////////////////////////////////////////////
////////////////////////////////////////////////
//while
int counter = 0;
while (counter <= 10)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++; //adds 1 to the var 
}
//do while 
//at least do one loop
int counter = 0;
do
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
} while (counter < 10);
//for
for(int counter = 0; counter < 100; counter++)
    //(initializar; condition; iterator)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
}
//foreach
//Nested Loops
for(int row = 1; row < 11; row++)
{
    for(char column = 'a'; column < 'r'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}
//Loop Challenge
int sum = 0;
for (int number = 1; number < 21; number++)
{
  if (number % 3 == 0)
  {
    sum = sum + number;
  }
}
Console.WriteLine($"The sum is {sum}");


//LIST, (method .ToUpper())