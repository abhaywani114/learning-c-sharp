// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int numberOne = 1000;
int numberTwo = 1000;
long numberThree = 1000;
long numberFour = 1000L;

if (numberOne == numberTwo)
    Console.WriteLine("Number one is equal to number two.");

if (numberOne == numberThree)
    Console.WriteLine("Number one is equal to number three (long).");

if (numberThree == numberFour)
    Console.WriteLine("Number three (long) is equal to number four (long).");


int maxValue = int.MaxValue;
Console.WriteLine("Max value is " + maxValue);
try
{
    checked
    {
        int overflowedValue = maxValue + 10;
        Console.WriteLine("overflowedValue is " + overflowedValue);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

long maxValueLong = long.MaxValue;
Console.WriteLine("Max value of a long type: " + maxValueLong);

float float1 = 1.0F;
double double1 = 1.0D;

if (float1 == double1)
    Console.WriteLine("float1 is equal to double1.");

Decimal decimal1 = 1.0M;

// if (decimal1 == double1) ... Can't be compared

if (((double)decimal1) == double1)
    Console.WriteLine("Casted decimal1 to double is equal to double1.");

Console.WriteLine(0.1 + 0.2 == 0.3);        // double surprise

