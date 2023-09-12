namespace Blackjack
{
    internal struct Card
    {
        internal int Two { get; set; }
        internal int Three { get; set; }
        internal int Four { get; set; }
        internal int Five { get; set; }
        internal int Six { get; set; }
        internal int Seven { get; set; }
        internal int Eight { get; set; }
        internal int Nine { get; set; }
        internal int Ten { get; set; }
        internal int J { get; set; }
        internal int Q { get; set; }
        internal int K { get; set; }
        internal int[] Ace { get; set; }

        public Card() 
        { 
  
        }

        internal Card(int two, int three, int four, int five, int six, int seven, int eight, int nine, int ten, int j, int q, int k, int[] ace) : this()
        {
            two = Two;
            three = Three;
            four = Four;
            five = Five;
            six = Six;
            seven = Seven;
            eight = Eight;
            nine = Nine;
            ten = Ten;
            j = J;
            q = Q;
            k = K;
            ace = Ace;
        }

    }
}