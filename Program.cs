﻿using System;
using System.Diagnostics;

int sum;
int difference;
int product;
int quotient;

string? userGameChoice = "0";
string[] gameOptions = { "1", "2", "3", "4", "5", "6", "7" };
string gameHistory = "";
int points = 0;


// Try to implement levels of difficulty.

// Add a timer to track how long the user takes to finish the game.

// Add a function that let's the user pick the number of questions.

// Create a 'Random Game' option where the players will be presented with questions from random operations

string? userDifficultyChoice;
string[] difficultyOptions = { "1", "2", "3" };


Console.WriteLine("\nWelcome to the Math Game!");

do
{
    Console.WriteLine("\n1) Low 2) Medium 3) High");
    Console.WriteLine("Select difficulty level:");
    userDifficultyChoice = Console.ReadLine();
    if (!difficultyOptions.Contains(userDifficultyChoice))
    {
        Console.WriteLine("That is not a valid option. You must enter 1, 2, or 3.");
    }
} while (!difficultyOptions.Contains(userDifficultyChoice));

string? userMaxQuestionsStr;
int userMaxQuestionsInt;
bool validUserMaxQuestions = false;

do
{
    Console.WriteLine("Maximum number of questions:");
    userMaxQuestionsStr = Console.ReadLine();
    if (int.TryParse(userMaxQuestionsStr, out userMaxQuestionsInt))
    {
        if (userMaxQuestionsInt < 1 || userMaxQuestionsInt > 100)
        {
            Console.WriteLine("That is not a valid option. You must enter a number between 1 and 100.");
        }
        else
        {
            validUserMaxQuestions = true;
        }
    }
} while (validUserMaxQuestions == false);

int questionsAsked = 0;

while (userGameChoice != "7" && questionsAsked < userMaxQuestionsInt)
{
    Random random = new Random();
    int num1 = 0;
    int num2 = 0;

    if (userDifficultyChoice == "1")
    {
        num1 = random.Next(11);
        num2 = random.Next(1, 11);
    }
    else if (userDifficultyChoice == "2")
    {
        num1 = random.Next(101);
        num2 = random.Next(1, 101);
    }
    else if (userDifficultyChoice == "3")
    {
        num1 = random.Next(1001);
        num2 = random.Next(1, 1001);
    }

    do
    {
        Console.WriteLine("\n-------------------------------------");
        Console.WriteLine("1) Addition 2) Subtraction 3) Multiplication 4) Division 5) Random! (+, -, *, or /) 6) View Game History 7) End game");
        Console.WriteLine("Make a selection. Enter 1, 2, 3, 4, 5, 6, or 7:");
        userGameChoice = Console.ReadLine();
        if (!gameOptions.Contains(userGameChoice))
        {
            Console.WriteLine("That is not a valid option. You must enter 1, 2, 3, 4, 5, 6, or 7.");
        }
    } while (!gameOptions.Contains(userGameChoice));

    if (userGameChoice == "5")
    {
        userGameChoice = random.Next(1, 5).ToString();
    }

    Stopwatch timer = new Stopwatch();
    timer.Start();
    Console.WriteLine("Timer started...");

    Console.WriteLine($"Question #{questionsAsked + 1} out of {userMaxQuestionsInt}:");

    switch (userGameChoice)
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
                if (userDifficultyChoice == "1")
                {
                    num1 = random.Next(11);
                    num2 = random.Next(1, 11);
                }
                else if (userDifficultyChoice == "2")
                {
                    num1 = random.Next(101);
                    num2 = random.Next(1, 101);
                }
                else if (userDifficultyChoice == "3")
                {
                    num1 = random.Next(1001);
                    num2 = random.Next(1, 1001);
                }
            }
            Console.WriteLine($"What is {num1} / {num2}?");
            break;

        case "6":
            Console.WriteLine("\nYour Game History:");
            Console.WriteLine(gameHistory);
            Console.WriteLine($"Timer: {timer.Elapsed}");
            Console.WriteLine($"Total Points: {points}");
            break;

        case "7":
            timer.Stop();
            Console.WriteLine("\nPost-Game Report:");
            Console.WriteLine(gameHistory);
            Console.WriteLine($"Total Points: {points}");
            Console.WriteLine($"Timer: {timer.Elapsed}");
            Console.WriteLine("\nThanks for playing! Goodbye!");
            break;
    }

    string? userAnswerStr;
    int userAnswerInt = 0;
    bool validUserAnswer = false;

    if (userGameChoice != "6" && userGameChoice != "7")
    {
        do
        {
            userAnswerStr = Console.ReadLine();
            if (userAnswerStr != null)
            {
                validUserAnswer = int.TryParse(userAnswerStr, out userAnswerInt);
                if (!validUserAnswer)
                {
                    Console.WriteLine("Invalid entry. Enter an integer.");
                }
            }
        } while (validUserAnswer == false);
    }


    if (userGameChoice == "1")
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
    else if (userGameChoice == "2")
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
    else if (userGameChoice == "3")
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
    else if (userGameChoice == "4")
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
    questionsAsked++;

    if (questionsAsked == userMaxQuestionsInt)
    {
        timer.Stop();
        Console.WriteLine("\nPost-Game Report:");
        Console.WriteLine(gameHistory);
        Console.WriteLine($"Total Points: {points}");
        Console.WriteLine($"Timer: {timer.Elapsed}");
        Console.WriteLine("\nThanks for playing! Goodbye!");
    }
}

// You need to create a Math game containing the 4 basic operations

// The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.

// Users should be presented with a menu to choose an operation

// You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.

// You don't need to record results on a database. Once the program is closed the results will be deleted.