using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a program created with C# set up like the famous Madlibs
      Author: Kasandra Kleespie
      */


      // Let the user know that the program is starting:
Console.WriteLine("The madlibs begin now!");

      // Give the Mad Lib a title:
      string title = "MAD FEELINGS";

      Console.WriteLine(title);
      // Define user input and variables:
Console.Write("Enter a name: ");
string name = Console.ReadLine();
//adjectives
Console.Write("Enter 3 adjectives (ex: yummy, purple, chubby, yellow, silly)");
Console.Write("\n");
Console.Write ("Adjective 1: ");
string adjectiveOne = Console.ReadLine();
Console.Write ("Adjective 2: ");
string adjectiveTwo = Console.ReadLine();
Console.Write ("Adjective 3: ");
string adjectiveThree = Console.ReadLine();
//verb
Console.Write("Enter a verb (ex: play, swim, sleep)");
Console.Write("\n");
Console.Write ("Verb: ");
string verb = Console.ReadLine();
//nouns
Console.Write("Enter 2 nouns (ex: shark, truck, toast)");
Console.Write("\n");
Console.Write ("Noun 1: ");
Console.Write ("\n");
string nounOne = Console.ReadLine();
Console.Write ("Noun 2: ");
Console.Write ("\n");
string nounTwo = Console.ReadLine();
//animal
Console.Write("Enter an animal: ");
string animal = Console.ReadLine();
//food
Console.Write("Enter a food: ");
string food = Console.ReadLine();
//fruit
Console.Write("Enter a fruit: ");
string fruit = Console.ReadLine();
//superhero
Console.Write("Enter a superhero: ");
string superhero = Console.ReadLine();
//country
Console.Write("Enter a country: ");
string country = Console.ReadLine();
//dessert
Console.Write("Enter a dessert: ");
string dessert = Console.ReadLine();
//year
Console.Write("Enter a year: ");
string year = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


      // Print the story:
Console.WriteLine(story);
    }
  }
}
