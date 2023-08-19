namespace LetsPlayPoker
{ 
    //=================================================================================================================
    // Card Class
    //=================================================================================================================
    
    public class Card
    {
        // get; allows me to assign values to Rank and Suit when Card() is called
        public string Rank {get;}
        public string Suit {get;}

        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }

        // Prints Card in a specific format
        public override string ToString() 
        {
            return $"{Rank}{Suit}";
        }
    }

    //=================================================================================================================
    // Deck Class
    //=================================================================================================================
    public class Deck
    {
        // Standard set of Ranks and Suits in a 52-Deck Of Playing Cards
        protected readonly string[] Ranks = {"A", "2", "3", "4", "5", "6", "7", "8",
                                             "9", "10", "J", "Q", "K"};
        protected readonly string[] Suits = {"♠", "♦", "♣", "♥"};
        protected List<Card> DeckOfCards;
        
        public Deck()
        {
            DeckOfCards = new List<Card>();
            GenerateDeck();
        }

        protected void GenerateDeck()
        {
            foreach (string suit in Suits)
            {
                foreach(string rank in Ranks)
                {
                    DeckOfCards.Add(new Card(rank, suit));
                }
            }
        }

        public void DisplayDeck()
        {
            foreach(Card card in DeckOfCards)
            {
                Console.WriteLine(card);
            }
        }

        public void ShuffleDeck()
        {
            Random RandomInt = new Random();

            for (int i = 0; i < DeckOfCards.Count; i++)
            {
                int RandomIndex = RandomInt.Next(0, DeckOfCards.Count);
                Card TempCard = DeckOfCards[i];
                DeckOfCards[i] = DeckOfCards[RandomIndex];
                DeckOfCards[RandomIndex] = TempCard;
            } 
        }
    }

    //=================================================================================================================
    // Main Program Class
    //=================================================================================================================
    internal class Program
    {
        static void DisplayDeck(Deck DeckOfCards)
        {
            DeckOfCards.DisplayDeck();
        }

        static void ShuffleDeck(Deck DeckOfCards)
        {
            DeckOfCards.ShuffleDeck();
        }

        static void LetsPlayPoker()
        {
            Deck DeckOfCards = new Deck();
            DisplayDeck(DeckOfCards);
            ShuffleDeck(DeckOfCards);
        }

        static void Main(string[] args)
        {
            LetsPlayPoker();
            Console.ReadLine();
        }
    }
}
