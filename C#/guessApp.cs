using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("Welcome to Csharp Programming");

    string secretWord = "Mercy";
    string guess = string.Empty;
    int guessCounter = 0;


    while( guess != secretWord )
    {
      
      Console.Write("Enter your guess: ");
      guess = Console.ReadLine();
      guessCounter++;

      for(x = 0; x < secretWord.length; x++){

        if(guess.Equal(secretWord[x]){
          Console.Write("Awesome, you win!, You made " + guessCounter + " Attempts");
        }

      }
      
    }

    Console.Write("Awesome, you win!, You made " + guessCounter + " Attempts");
  }
}
