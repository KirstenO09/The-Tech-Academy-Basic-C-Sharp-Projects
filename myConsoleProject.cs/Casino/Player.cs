using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        public Player(string name) : this(name, 100) { } 
        public Player(string name, int beginningBalance) // Player constructor that takes in a name and a beginning balance
        {
            Name = name; // Set the Name property based on the parameters passed in
            Balance = beginningBalance; // Set the Balance property based on the parameters passed in
            Hand = new List<Card>(); // Initialize the Hand property as a new list of Card objects 
            //Why is the Hand property initialized in the constructor instead of being set to a new list when it is declared?
            // The Hand property is initialized in the constructor because it allows us to create a new list of Card objects for each instance of the Player class.
            // If we were to set it to a new list when it is declared,ball instances of the Player class would share the same Hand list,
            // which would lead to unintended consequences when multiple players are playing the game.
            // By initializing it in the constructor, each player gets their own separate Hand list to hold their cards.
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; } // Unique identifier for the player
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }


        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
