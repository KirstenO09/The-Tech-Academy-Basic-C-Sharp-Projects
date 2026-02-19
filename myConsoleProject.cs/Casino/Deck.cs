using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    // Deck class representing a deck of playing cards
    public class Deck
    {
        // Deck constructor
        public Deck() 
        {
            Cards = new List<Card>(); // Initialize the Cards list

            for (int i = 0; i < 13; i++) // Loop through each face value
            {
                for (int j = 0; j < 4; j++) // Loop through each suit
                {
                    Card card = new Card(); // Create a new Card object
                    card.Face = (Face)i; // Set the face of the card
                    card.Suit = (Suit)j; // Set the suit of the card
                    Cards.Add(card); // Add the card to the Cards list
                }
            }

            //List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; // List of card suits
            //List<string> Faces = new List<string>() 
            //{ "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" }; // List of card faces

            //// Nested loop to create all combinations of faces and suits
            //foreach (string face in Faces) // Iterate through each face
            //{
            //    foreach (string suit in Suits)// Iterate through each suit
            //    {
            //        Card card = new Card(); // Create a new Card object
            //        card.Face = face; // Set the face of the card
            //        card.Suit = suit; // Set the suit of the card
            //        Cards.Add(card); // Add the card to the Cards list
            //    }
            //}
        }
        public List<Card> Cards { get; set; } // List to hold the cards in the deck 
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++) // Shuffle the deck the specified number of times
            {
                List<Card> TempList = new List<Card>(); // Temporary list to hold shuffled cards
                Random random = new Random(); // Random number generator

                while (Cards.Count > 0)// While there are still cards in the original deck
                {
                    int randomIndex = random.Next(0, Cards.Count); // Get a random index
                    TempList.Add(Cards[randomIndex]); // Add the card at the random index to the temporary list
                    Cards.RemoveAt(randomIndex); // Remove the card from the original deck
                }
                Cards = TempList; // Set the deck's cards equal to the shuffled temporary list
            }
        }
    }
}
