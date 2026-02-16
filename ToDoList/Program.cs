using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, Lada!");
Console.WriteLine("[S]ee all todos");
Console.WriteLine("[A]dd todo");
Console.WriteLine("[R]emove todo");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();
bool isLong = IsLong(userChoice);

bool IsLong(string input)
{
    return input.Length > 10;
}

var result = Add(10, 5);
Console.WriteLine("The result of adding 10 and 5 is: {result}");

//if (userChoice == "S")
//{
//    PrintSelectedOption("Showing all todos...");
//}
//else if (userChoice == "A")
//{
//    PrintSelectedOption("Adding a new todo...");
//}
//else if (userChoice == "R")
//{
//    PrintSelectedOption("Removing a todo...");
//}
//else if (userChoice == "E")
//{
//    PrintSelectedOption("Exiting the application...");
//}
//else
//{
//    PrintSelectedOption("Invalid choice. Please try again.");
//}

//Console.ReadKey();
//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine($"You selected: {selectedOption}");
//}

int Add(int a, int b)
{
    return a + b;
}

