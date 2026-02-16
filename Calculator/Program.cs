// See https://aka.ms/new-console-template for more information
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

if (userChoice == "A")
{
    int result = number1 + number2;
    Console.WriteLine($"The result of adding {number1} and {number2} is: {result}");
}
else if (userChoice == "S")
{
    int result = number1 - number2;
    Console.WriteLine($"The result of subtracting {number2} from {number1} is: {result}");
}
else if (userChoice == "M")
{
    int result = number1 * number2;
    Console.WriteLine($"The result of multiplying {number1} and {number2} is: {result}");
}
else
{
    Console.WriteLine("Invalid choice. Please try again.");
}

Console.WriteLine("Press any key to exit...");

Console.ReadKey();
