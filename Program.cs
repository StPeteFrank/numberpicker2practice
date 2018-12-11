using System;

namespace numberpicker2practice
{
  class Program
  {
    static void Main(string[] args)
    {
      var minimum = 0;
      var maximum = 100;
      var guess = maximum / 2;
      var guessing = true;

      Console.WriteLine(guess);
      while (guessing)
      {
        Console.WriteLine("Is your number higher or lower?");
        var userResponse = Console.ReadLine();

        if (userResponse == "higher")
        {
          minimum = guess + 1;
          guess = (maximum + minimum) / 2;
          Console.WriteLine($"Is your number {guess} ?");
        }
        if (userResponse == "lower")
        {
          maximum = guess - 1;
          guess = (maximum + minimum) / 2;

          Console.WriteLine($"Is your number {guess} ?");
        }
        if (userResponse == "That's it!")
        {
          guessing = false;
          System.Console.WriteLine($"Your number is {guess} have a nice one!");
        }
      }
    }
  }
}

