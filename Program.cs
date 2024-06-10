int sum;
int difference;
int product;
int quotient;

string? userChoice = "0";
string[] options = { "1", "2", "3", "4", "5", "6" };
string gameHistory = "";
int points = 0;

while (userChoice != "6")
{
    Random random = new Random();
    int num1 = random.Next(101);
    int num2 = random.Next(1, 11);

    do
    {
        Console.WriteLine("\n-------------------------------------");
        Console.WriteLine("1) Addition 2) Subtraction 3) Multiplication 4) Division 5) View Game History 6) End game");
        Console.WriteLine("Make a selection. Enter 1, 2, 3, 4, 5, or 6:");
        userChoice = Console.ReadLine();
        if (!options.Contains(userChoice))
        {
            Console.WriteLine("That is not a valid option. You must enter 1, 2, 3, 4, 5, or 6.");
        }
    } while (!options.Contains(userChoice));

    switch (userChoice)
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
            while (num1 % num2 != 0)
            {
                num1 = random.Next(101);
                num2 = random.Next(1, 11);
            }
            Console.WriteLine($"What is {num1} / {num2}?");
            break;

        case "5":
            Console.WriteLine("\nYour Game History:");
            Console.WriteLine(gameHistory);
            Console.WriteLine($"Total Points: {points}");
            break;

        case "6":
            Console.WriteLine("\nPost-Game Report:");
            Console.WriteLine(gameHistory);
            Console.WriteLine($"Total Points: {points}");
            Console.WriteLine("\nThanks for playing! Goodbye!");
            break;
    }

    string? userAnswerStr;
    int userAnswerInt = 0;
    bool validEntry = false;

    if (userChoice != "5" && userChoice != "6")
    {
        do
        {
            userAnswerStr = Console.ReadLine();
            if (userAnswerStr != null)
            {
                validEntry = int.TryParse(userAnswerStr, out userAnswerInt);
                if (!validEntry)
                {
                    Console.WriteLine("Invalid entry. Enter an integer.");
                }
            }
        } while (validEntry == false);
    }


    if (userChoice == "1")
    {
        sum = num1 + num2;
        if (sum == userAnswerInt)
        {
            Console.WriteLine("Congratulations. You answered correctly! +1 point");
            points++;
            gameHistory += $"{num1} + {num2} = {sum}...Answered correctly, +1 point\n";
        }
        else
        {
            Console.WriteLine($"Incorrect! The answer is {sum}.");
            gameHistory += $"{num1} + {num2} = {sum}...Answered incorrectly\n";
        }
    }
    else if (userChoice == "2")
    {
        difference = num1 - num2;
        if (difference == userAnswerInt)
        {
            Console.WriteLine("Congratulations. You answered correctly! +1 point");
            points++;
            gameHistory += $"{num1} - {num2} = {difference}...Answered correctly, +1 point\n";
        }
        else
        {
            Console.WriteLine($"Incorrect! The answer is {difference}.");
            gameHistory += $"{num1} - {num2} = {difference}...Answered incorrectly\n";
        }
    }
    else if (userChoice == "3")
    {
        product = num1 * num2;
        if (product == userAnswerInt)
        {
            Console.WriteLine("Congratulations. You answered correctly! +1 point");
            points++;
            gameHistory += $"{num1} * {num2} = {product}...Answered correctly, +1 point\n";
        }
        else
        {
            Console.WriteLine($"Incorrect! The answer is {product}.");
            gameHistory += $"{num1} * {num2} = {product}...Answered incorrectly\n";
        }
    }
    else if (userChoice == "4")
    {
        quotient = num1 / num2;
        if (quotient == userAnswerInt)
        {
            Console.WriteLine("Congratulations. You answered correctly! +1 point");
            points++;
            gameHistory += $"{num1} / {num2} = {quotient}...Answered correctly, +1 point\n";
        }
        else
        {
            Console.WriteLine($"Incorrect! The answer is {quotient}.");
            gameHistory += $"{num1} / {num2} = {quotient}...Answered incorrectly\n";
        }
    }
}

// You need to create a Math game containing the 4 basic operations

// The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.

// Users should be presented with a menu to choose an operation

// You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.

// You don't need to record results on a database. Once the program is closed the results will be deleted.