using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHand = new Hand("2H 3Q 4D 5S 6H");
            Console.WriteLine(myHand.IsStraight());
            Console.ReadKey();
        }
    }
}
