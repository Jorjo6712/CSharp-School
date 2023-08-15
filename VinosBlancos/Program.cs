namespace VinosBlancos
{
    class Program
    {
        static void Main()
        {
            Controller();
        }

        static void View()
        {
            Console.WriteLine("*");
        }


        static int[,] Model()
        {
            int[,] vinos =
            {
              {175134, 2009},
              {175388, 2010},
              {172818, 2011},
              {142709, 2012},
              {151437, 2013},
              {152620, 2014},
              {150979, 2015},
              {152210, 2016},
              {149450, 2017},
              {154398, 2018},
              {150160, 2019}
            };

            return vinos;
        }


        static void Controller()
        {
            const int max = 175388;
            const byte maxStar = 100;

            int[,] vinos = Model();



            for (int i = 0; i < vinos.Length / 2; i++)
            {
                int star = maxStar * vinos[i, i] / max;

                Array.Sort(Model());

                for (int k = 0; k < star; i++)
                {
                    View();
                }
            }


        }
    }
}
