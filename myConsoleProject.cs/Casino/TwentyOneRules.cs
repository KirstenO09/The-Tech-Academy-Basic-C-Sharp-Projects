using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        public static int[] GetAllPossibleHandValues(List<Card> Hand) // This method calculates all possible hand values considering Aces can be 1 or 11
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); // Count the number of Aces in the hand
            int[] result = new int[aceCount + 1]; // Create an array to hold all possible hand values, which is the number of Aces + 1 (for the case where all Aces are counted as 1)
            int value = Hand.Sum(x => _cardValues[x.Face]); // Calculate the base value of the hand with all Aces counted as 1
            result[0] = value; // The first possible value is the base value
            if (result.Length == 1)
            {
                return result; // If there are no Aces, return the single possible value
            }
            for (int i = 1; i < result.Length; i++) // For each Ace, calculate the new possible hand value by adding 10 (since we already counted 1 for each Ace)
            {
                value += (i * 10); // For each Ace, we can add 10 to the base value (since we already counted 1 for each Ace), so we multiply the number of Aces by 10 and add it to the base value
                result[i] = value; // Store the new possible hand value in the result array
            }
            return result; // Return the array of possible hand values
        }
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand); // Get all possible hand values for the given hand and store them in an array
            int value = possibleValues.Max(); // Get the maximum possible hand value
            if (value == 21) // If the maximum possible hand value is 21, then the hand is a Blackjack
            {
                return true; // Return true if it's a Blackjack
            }
            else
            {
                return false; // Return false if it's not a Blackjack
            }
        }
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min(); // Get the minimum possible hand value
            if (value > 21) return true; // If the minimum possible hand value is greater than 21, then the hand is busted
            else return false; // Otherwise, the hand is not busted
        } 
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand); // Get all possible hand values for the dealer's hand
            foreach (int value in possibleHandValues) // Iterate through each possible hand value
            {
                if (value > 16 && value < 22) // If any possible hand value is between 17 and 21 (inclusive), the dealer should stay
                {
                    return true; // Dealer should stay
                }
            } return false; // Dealer should not stay 
        }

        public static bool? CompareHands(List<Card> playerHand, List<Card> dealerHand) // This method compares the player's hand to the dealer's hand and determines the winner
        {
            int[] playerResults = GetAllPossibleHandValues(playerHand); // Get all possible hand values for the player's hand
            int playerScore = playerResults.Where(x => x < 22).Max(); // Get the highest valid hand value for the player (less than 22)
            int[] dealerResults = GetAllPossibleHandValues(dealerHand); // Get all possible hand values for the dealer's hand
            int dealerScore = dealerResults.Where(x => x < 22).Max(); // Get the highest valid hand value for the dealer (less than 22)
            if (playerScore > dealerScore) return true; // If the player's score is higher than the dealer's score, the player wins
            else if (playerScore < dealerScore) return false; // If the player's score is lower than the dealer's score, the dealer wins
            else return null; // If both scores are equal, it's a tie
        }
    }
}
