using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Deck
    {
        private Card[] cards;
        private int top;

        public Deck() 
        {
            cards = new Card[52];
            for(int i = 0;i < 4; i++)
            {
                int index = 0;
                for(int j = 0;j < 13; j++)
                {
                    cards[index] = new Card(i, j);
                    index++;
                }
            }
        }
        public Card Peek() 
        {
            top = 0;
            
        }
        public void Shuffle() 
        {
             
        }
        public Card Deal() { return cards[top]; }

        public void Reset() { top = 0; }
    }
}
