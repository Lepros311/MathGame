int sum;
// int difference;
// int product;
// int quotient;
// int answer;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

Random random = new Random();
int num1 = random.Next(101);
int num2 = random.Next(101);

string? readResult;
string[] options = { "1", "2", "3", "4", };
// int userOption;
do
{
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("1) Addition 2) Subtraction 3) Multiplication 4) Division");
    Console.WriteLine("Select which operation you want to try. Enter 1, 2, 3, or 4:");
    readResult = Console.ReadLine();
    if (!options.Contains(readResult))
    {
        Console.WriteLine("That is not a valid option. You must enter 1, 2, 3, or 4.");
    }
} while (!options.Contains(readResult));

switch (readResult)
{
    case "1":
        Console.WriteLine($"What is {num1} + {num2}?");
        break;

    case "2":
        Console.WriteLine($"What is {num1} - {num2}?");
        break;

    case "3":
        Console.WriteLine($"What is {num1} x {num2}?");
        break;

    case "4":
        Console.WriteLine($"What is {num1} / {num2}?");
        break;
}

int userAnswer;
bool validEntry = false;

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        validEntry = int.TryParse(readResult, out userAnswer);
        if (!validEntry)
        {
            Console.WriteLine("Invalid entry. Enter an integer.");
        }
    }
} while (validEntry == false);





sum = num1 + num2;
if (sum == userAnswer)
{

}

// You need to create a Math game containing the 4 basic operations

// The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.

// Users should be presented with a menu to choose an operation

// You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.

// You don't need to record results on a database. Once the program is closed the results will be deleted.