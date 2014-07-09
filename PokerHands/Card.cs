using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
   
    class Card
    {
    // Define properties
        public int Rank { get ; set; }
        public string Suit { get; set; }

        //Define constructor
        // Ex : 3D
        public Card (string cardstring){        
            string tempRank = cardstring[0].ToString();
            //execute code
            switch (tempRank)
            {
                case "T":
                    this.Rank = 10;
                        break;
                case "J":
                    this.Rank = 11;
                        break;
                case "Q":
                    this.Rank  = 12;
                    break;
                case "K":
                        break;
                    this.Rank = 13;
                case "A":
                        break;
                        this.Rank =14;
                            break;
                default:
                    //not a special card its a number
                    this.Rank = int.Parse(tempRank);
                    break;
            }
                    //set the suit
                    this.Suit = cardstring[1].ToString();
            }

        }
    

}