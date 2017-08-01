using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        string name;
        public List<Card> hand;
        public Player(string pname){
            name = pname;
            hand = new List<Card>();
        }
        public Card Draw(Deck decky){
            Card newcard = decky.Deal();
            hand.Add(newcard);
            return newcard;
        }
        public Player Draw(Deck decky, int num){
            for(var i = 0; i< num;i++){
                this.Draw(decky);
            }
            return this;
        
        }
        public Card discard(int idx){
            if(idx < 0 || idx > hand.Count){
                System.Console.WriteLine("No such count");
                return null;
            }
            else {
                //remove
                Card res = hand[idx];
                hand.RemoveAt(idx);
                //bring it on back
                return res;

            }
        }


    }
}