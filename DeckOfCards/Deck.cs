using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
    public List<Card> cards;
    public Card Deal(){
        if (cards.Count> 0){
            Card temp = cards[0];
            cards.RemoveAt(0);
            return temp;

        }
        return null; 
    }
    public Deck Reset(){
        List<Card> cards = new List<Card>();
        string[] suits =  {"Hearts","Spades","Clubs","Diamonds"}; //string[] suits = new string[4]{}
        string[] strVals = {"Ace", "two"};
        foreach (string suit in suits){
            for (int val = 0; val< strVals.Length; val++){
                Card value = new Card(strVals[val],suit,val+1);
                cards.Add(new Card(strVals[val],suit,val));
            }

        }
            return this;
    }
    public Deck Shuffle(){
        Random rand = new Random();
        for(int idx = cards.Count-1; idx>0; idx--){
            int randidx = rand.Next(idx);
            Card temp = cards[randidx];
            cards[randidx] = cards[idx];
            cards[idx] = temp;
        }
    return this;
    }


    }
    }
