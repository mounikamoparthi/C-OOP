using System;

namespace DeckOfCards
{
    public class Card
    {
        public string stringVal;
        // {  //to hold a,2,3,....J,Q,K
        //      get {
        //         if(val > 1 && val < 11) {
        //             return val.ToString();
        //         }
        //         else if (val == 11) {
        //             return "Jack";
        //         }
        //         else if (val == 12) {
        //             return "Queen";
        //         }
        //         else if (val == 13) {
        //             return "King";
        //         }
        //         else if (val == 1) {
        //             return "Ace";
        //         }
        //         else {
        //             return "Joker";
        //         }
        //     }
        // } 
        public string suit; //for holding clubs,hearts,...
        public int val; //for holding 1-13 integers
        public Card(string strVal, string cardSuit, int numVal) {
            stringVal = strVal;
            suit = cardSuit;
            val = numVal;
        }

    }
}