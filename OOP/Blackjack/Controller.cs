namespace Blackjack
{
    internal class Controller 
    {
        bool playerStand;
        bool dealerStand;
        bool bust;
        bool start = false;
        internal void Start()
        {
            
            View view = new View();

            view.Show("Hello and welcome to Blackjack!");

            view.Show("\nWhat you like to begin?");

            view.Show("\n If yes, press enter to begin.");

            ConsoleKeyInfo playerStart = Console.ReadKey();

            if (playerStart.Key == ConsoleKey.Enter)
            {
                while (true)
                {
                    if (start == true)
                    {
                        List<string> dealerHand = new List<string>();
                        List<string> playerHand = new List<string>();

                        for (int i = 0; i < 2; i++)
                        {

                        }
                    }
                }
            }

        }

        private void DealHands()
        {
          
        }

    }
}