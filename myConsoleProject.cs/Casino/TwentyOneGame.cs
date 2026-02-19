using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer(); // Create a new dealer
            foreach (Player player in Players) // Loop through each player
            {
                player.Hand = new List<Card>(); // Initialize player's hand
                player.Stay = false; // Set player's stay status to false
            }
            Dealer.Hand = new List<Card>(); // Initialize dealer's hand
            Dealer.Stay = false; // Set dealer's stay status to false
            Dealer.Deck = new Deck(); // Create a new deck of cards
            Dealer.Deck.Shuffle();
            

            foreach (Player player in Players)
            {
                bool validAnswer = false; // Flag to check if the player's input is valid
                int bet = 0; // Variable to store the player's bet
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!"); // Prompt players to place their bets
                    validAnswer = int.TryParse(Console.ReadLine(), out bet); // Try to parse the player's input as an integer
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals."); // If the input is not a valid integer, prompt the player to enter a valid bet
                }
                if (bet < 0) // If the bet is negative
                {
                    throw new FraudException("Security! Kick this person out."); // Throw a Fraud exception
                }
                bool successfullyBet = player.Bet(bet); // Attempt to place the bet
                if (!successfullyBet) // If the bet was not successful
                {
                    return; // Exit the method
                }
                Bets[player] = bet; // Store the player's bet in the Bets dictionary]
            }
            for (int i = 0; i < 2; i++) // Deal two cards to each player and the dealer
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players) // Loop through each player
                {
                    Console.Write("{0}: ", player.Name); // Display player's name
                    Dealer.Deal(player.Hand); // Deal a card to the player
                    if (i == 1) // If it's the second card
                    {
                        bool blackjack = TwentyOneRules.CheckForBlackJack(player.Hand); // Check for blackjack
                        if (blackjack) // If the player has blackjack
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]); // Announce the win
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); // Update player's balance
                            return;
                        }
                    }
                }
                Console.Write("Dealer: "); // Display dealer's name
                Dealer.Deal(Dealer.Hand); // Deal a card to the dealer
                if(i == 1) // If it's the second card
                {
                    bool blackjack = TwentyOneRules.CheckForBlackJack(Dealer.Hand); // Check for blackjack
                    if (blackjack) // If the dealer has blackjack
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses."); // Announce the loss
                        foreach (KeyValuePair<Player, int> entry in Bets) // Loop through each player's bet
                        {
                            Dealer.Balance += entry.Value; // Update dealer's balance with the player's bet
                        }
                        return;
                    }
                }
            }
            
            foreach(Player player in Players) // Loops through players
            {
                while (!player.Stay) // if player does not want to stay
                {
                    Console.WriteLine("Your cards are: "); // print their cards
                    foreach (Card card in player.Hand) // loop through players Hand
                    {
                        Console.Write("{0} ", card.ToString()); //print players card to screen
                    }
                    Console.WriteLine("\n\nHit or stay?"); // ask the player if they want to hit or stay
                    string answer = Console.ReadLine().ToLower(); // Convert user input to lowercase
                    if (answer == "stay") // player wants to stay
                    {
                        player.Stay = true; // set stay to true
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);

                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if(busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower(); 
                        if(answer == "yes" || answer == "yeah")
                        {
                            player.IsActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.IsActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); 
            while(!Dealer.Stay && !Dealer.isBusted) //As long as the dealer is not busted and as long as he is staying do the following
            {
                Console.WriteLine("Dealer is hitting..."); 
                Dealer.Deal(Dealer.Hand); // Deal the Dealer a card
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); // Check if Dealer busted
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); //Check if dealer is staying
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if(Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach(Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins,");
                    player.Balance += Bets[player];                                       
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    player.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.IsActivelyPlaying = true;

                }
                else
                {
                    player.IsActivelyPlaying = false;
                }
            }
           
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
