using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, Lada!");
Console.WriteLine("[S]ee all todos");
Console.WriteLine("[A]dd todo");
Console.WriteLine("[R]emove todo");
Console.WriteLine("[E]xit");

string userInput = Console.ReadLine();
Console.WriteLine($"You entered: {userInput}");

bool isUserInputABC = userInput == "ABC";
Console.WriteLine(isUserInputABC ? "User input is ABC" : "User input is not ABC");

var number = 0;
string result;
if (number < 0)
{
    result = "negative";
            }
else if (number == 0)
{
    result = "zero";
            }
else
{
    result = "positive";
            }

Console.ReadKey();