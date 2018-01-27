﻿using System;
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
            try
            {
                Card myCard = deck1.GetCard(60);
            }
            catch(CardOutOfRange_Exception e)
            {
                WriteLine(e.Message);
                WriteLine(e.DeckContents[0]);
            }
            ReadKey();
        }
    }
}
