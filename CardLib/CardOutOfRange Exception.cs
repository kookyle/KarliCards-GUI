using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public class CardOutOfRange_Exception : Exception
    {
        private Cards deckContents;

        public Cards DeckContents
        {
            get { return deckContents; }
        }

        public CardOutOfRange_Exception(Cards sourceDeckContents)
            : base("There are only 52 cards in the deck.")
        {
            deckContents = sourceDeckContents;
        }
    }
}
