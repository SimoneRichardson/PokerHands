using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    
    class Hand
    {
    // define properties
        public List<Card> Cards{ get; set;}

        //define the constructor
        public Hand(string handstring) 
        {
            this.Cards = new List<Card>();
            var tempList = handstring.Split(' ').ToList();
            foreach(string eachcard in tempList)
            {
             this.Cards.Add(new Card (eachcard));           
            }            
        }
        



        //new functions go here
        public bool IsFlush()
        {
        //how to select just one property of an object
        // and get only unique (distinct) value
    
        //selects the only the suits of our cards, takes only distinct values
        //and counts them. If theere is only a suit it will be a flush.
       return this.Cards.Select(x => x.Suit).Distinct().Count() == 1;
        }
        public bool HasPair()
        {
            //selects only the values of the cards, takes only
            //distinct values, and counts them. If there are only
            //4 values; two of them must be the same.
            return this.Cards.Select(x => x.Rank).Distinct().Count() == 4;
        }

            //selects the suit and the rank
            //the Straight
            public bool IsStraight()
            {
             string testString = string.Join("", this.Cards.OrderBy(x =>x.Rank).Select(x => x.Rank));
                string tester = "234567891011121314";
                if (tester.Contains(testString))
                {
                    return true;
                }
                else return false;        
            }
        //
            }

        
    
       
        }

           
            