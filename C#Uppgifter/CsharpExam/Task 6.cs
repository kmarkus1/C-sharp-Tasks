using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class Game
    {
        public string Name { get; set; }
        public string Publisher {  get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }

        //Constructor that sets values
        public Game(string name, string publisher, string year, string genre)
        {
            Name = name;
            Publisher = publisher;
            Year = year;
            Genre = genre;
        }
       
        //Method for Displaying game information
        public void DisplayGame()
        {
            Console.WriteLine($"Name: {Name}\nPublisher: {Publisher}\nYear: {Year}\nGenre: {Genre}\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //List that stores Game objects
            List<Game> list = new List<Game>();
            //Call Game constructor and set values
            Game game1 = new Game("Bloons 6", "Ninja Kiwi", "2018", "Tower Defense");
            //Add game1 values to list
            list.Add(game1);

            Game game2 = new Game("Bloons 5", "ninja Kiwi", "2012", "Tower Defense");
            //Add game2 values to list
            list.Add(game2);

            //Using DisplayGame method to display game information
            game1.DisplayGame();
            game2.DisplayGame();

            //Loop trough list and print all values
            foreach (Game game in list)
            {
                Console.WriteLine($"{game.Name}, {game.Publisher}, {game.Year}, {game.Genre}");
            }

        }
    }
}
