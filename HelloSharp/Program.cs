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

// Strings in C#
Console.WriteLine("##############");
String myFirstString = "My first string";
char myFirsyChar = 'm';

Console.WriteLine(myFirstString);
Console.WriteLine(myFirsyChar);

String mySecondString = "My first string";
if (myFirstString == mySecondString)
    Console.WriteLine("Both strings are the same.");

String numberAsString = "1111";
int numberFromString = Convert.ToInt32(numberAsString);
Console.WriteLine("numberFromString is " + numberFromString);

String invalidNumberAsString = "11DZ";
try
{
    int invalidNumberFromString = Convert.ToInt32(invalidNumberAsString);
    Console.WriteLine("invalidNumberFromString  is " + invalidNumberFromString);
}
catch (FormatException ex)
{
    Console.WriteLine("Error occured: " + ex.Message);
}


int result;
if (int.TryParse(invalidNumberAsString, out result))
{
    Console.WriteLine($"Parsed number {result}");
}
else
{
    Console.WriteLine("Invalid number format.");
}

// shower some char math
Console.Write("Enter some uppercase letters: ");
String someWords = Console.ReadLine();
for (int i = 0; i < someWords.Length; i++)
{
    Console.WriteLine(Convert.ToChar(someWords[i] + ('a' - 'A')));
}


Console.Write("No of the day of the week: ");
String weekDayAsString = Console.ReadLine();
Console.Write("The name of the day is: ");
switch (weekDayAsString)
{
    case "1":
        Console.WriteLine("Monday");
        break;

    case "2":
        Console.WriteLine("Tuesday");
        break;

    case "3":
        Console.WriteLine("Wednesday");
        break;

    case "4":
        Console.WriteLine("Thrusday");
        break;

    case "5":
        Console.WriteLine("Friday");
        break;

    case "6":
        Console.WriteLine("Saturday");
        break;

    case "7":
        Console.WriteLine("Saturday");
        break;

    default:
        throw new Exception("Invalid no of the day, must be between 0-7");
}

int getNumberFromUser;
while (true)
{
    Console.Write("Enter a number: ");
    String inputNumber = Console.ReadLine();
    if (int.TryParse(inputNumber, out getNumberFromUser))
    {
        break;
    }
    else
    {
        Console.WriteLine("Enter a valid number.");
    }
}

Console.WriteLine($"Your number is {getNumberFromUser}");
