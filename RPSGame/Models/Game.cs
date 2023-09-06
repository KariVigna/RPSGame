using System.Collections.Generic;
using System;

namespace RPSGame.Models
{
  public class Game
  {
    public string PlayerChoice { get; set; }
  
    public Game (string choice)
    {
      PlayerChoice = choice;
    }

    
    public string CalculateWin()
    {
      Random rnd = new Random();
      string [] computerOptions = new string[] {"rock", "paper", "scissors"};
      string computerChoice = computerOptions[rnd.Next(0, 3)];

      if (computerChoice == this.PlayerChoice)
      {
        return $"The computer chose {computerChoice}. You tied!";
      }
      else if (this.PlayerChoice == "scissors" && computerChoice == "paper" || 
      this.PlayerChoice == "paper" && computerChoice == "rock" || this.PlayerChoice == "rock" && computerChoice == "scissors")
      {
        return $"The computer chose {computerChoice}. You win!";
      }
      else
      {
        return $"The computer chose {computerChoice}. You lose!";
      }
    }
  }
}

// namespace RPSGame.Models
// {
//   public class Game
//   {
//     public string Player1Name { get; set;}
//     private static List<string> gameOutcomes = new List<string>{};
//     public Game (string name)
//     {
//       Player1Name = name;
//     }

    
//     public string CalculateWin(string playerChoice)
//     {
//       Random rnd = new Random();
//       string [] computerOptions = new string[] {"rock", "paper", "scissors"};
//       string computerChoice = computerOptions[rnd.Next(0, 3)];

//       if (computerChoice == this.PlayerChoice)
//       {
//         return $"The computer chose {computerChoice}. You tied!";
//       }
//       else if (this.PlayerChoice == "scissors" && computerChoice == "paper" || 
//       this.PlayerChoice == "paper" && computerChoice == "rock" || this.PlayerChoice == "rock" && computerChoice == "scissors")
//       {
//         return $"The computer chose {computerChoice}. You win!";
//       }
//       else
//       {
//         return $"The computer chose {computerChoice}. You lose!";
//       }
//     }
//   }
// }