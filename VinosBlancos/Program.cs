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
            Console.Write("*");
        }


        static int[] Model()
        {
            int[] vinos = new int[] { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };

            Array.Sort(vinos);

            return vinos;
        }


        static void Controller()
        {
            const int max = 175388;
            const byte maxStar = 100;

            int[] vinos = Model();



            for (int i = 0; i < vinos.Length; i++)
            {
                int star = maxStar * vinos[i] / max;

                for (int k = 0; k < star; k++)
                {
                    View();
                }

                Console.WriteLine();
            }
        }
    }
}
