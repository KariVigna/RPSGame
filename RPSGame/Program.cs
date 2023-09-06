using System.Collections.Generic;
using System;
using RPSGame.Models;

namespace RPSGame
{
  class Program
  {
    static void Main()
    {
     Console.BackgroundColor = ConsoleColor.Green;
     Console.ForegroundColor = ConsoleColor.White;
     Console.WriteLine("WELCOME TO ROCK PAPER SCISSORS!");
     Console.WriteLine("Please enter your move to start a new game (rock, paper, or scissors):");
     string playerChoice = Console.ReadLine();
     Game newGame = new Game(playerChoice);
     if (playerChoice == "rock" || playerChoice == "paper" || playerChoice == "scissors")
     {
       Console.WriteLine("You chose " + playerChoice + ".");
       Console.WriteLine("Now we will choose a random move for the computer.");
       Console.WriteLine(newGame.CalculateWin());
     }
     else
     {
       Console.WriteLine("Invalid move. Please enter rock, paper, or scissors.");
     }  
    }
  }
}