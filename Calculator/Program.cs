// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Hello, user!");

Console.WriteLine("Please enter the first number:");
string userNum1 = Console.ReadLine();
int number1 = int.Parse(userNum1);

Console.WriteLine("Please enter the second number:");
string userNum2 = Console.ReadLine();
int number2 = int.Parse(userNum2);

Console.WriteLine("What would you like to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

string userChoice = Console.ReadLine();

// Set the number of retry attempts
int retryCount = 3;

for (retryCount = 3; retryCount > 0; retryCount--)
{
        ProgramLoop(userChoice);
}

void PrintFinalEquation(int number1, int number2, int result, string @operator)
{
    Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + result);
}

bool EqualsCaseInsensitive(string str1, string str2)
{
    return str1.ToUpper() == str2.ToUpper();
}

void ExitProgramOnSuccess()
{
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
}

void ProgramLoop(string? userChoice)
{
    if (EqualsCaseInsensitive(userChoice, "A"))
    {
        int result = number1 + number2;
        PrintFinalEquation(number1, number2, result, "+");
        ExitProgramOnSuccess();
        retryCount = 0; // Reset the retryCount if the operation is successful
    }
    else if (EqualsCaseInsensitive(userChoice, "S"))
    {
        int result = number1 - number2;
        PrintFinalEquation(number1, number2, result, "-");
        ExitProgramOnSuccess();
        retryCount = 0; // Reset the retryCount if the operation is successful

    }
    else if (EqualsCaseInsensitive(userChoice, "M"))
    {
        int result = number1 * number2;
        PrintFinalEquation(number1, number2, result, "*");
        ExitProgramOnSuccess();
        retryCount = 0; // Reset the retryCount if the operation is successful
    }
    else
    {
       Console.WriteLine("Invalid choice. Please try again.");
        retryCount = 3; // Reset the retryCount for invalid input
    }
}