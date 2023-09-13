namespace SortingHat
{
    internal class SortingHat
    {
        enum houses { Gryffindor, Hufflepuff, Ravenclaw, Slytherin };

        internal string Hat()
        {
            Random random = new Random();

            int value = random.Next(4);

            return Enum.GetName(typeof(houses),value);
        }
    }
}
