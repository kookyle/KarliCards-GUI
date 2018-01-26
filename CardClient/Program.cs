using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib;
using static System.Console;

namespace CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            Deck deck2 = new Deck();
            WriteLine($"The first card in the original deck is: {deck1.GetCard(0)}");
            WriteLine($"The first card in the cloned deck is: {deck2.GetCard(0)}");
            deck1.Shuffle();
            WriteLine("Original deck shuffled.");
            WriteLine($"The first card in the original deck is: {deck1.GetCard(0)}");
            WriteLine($"The first card in the cloned deck is: {deck2.GetCard(0)}");
            ReadKey();
        }
    }
}
