namespace BirthdayConsoleApp
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Clear();

                Console.WriteLine("Write your birthday (ddMMyyyy): ");
                
                string readin = Console.ReadLine(); // Reads user input in

                DateTime birthday = DateTime.ParseExact(readin,"ddMMyyyy", null); // Parses input into ddMMyyyy format and stores in birthday

                DateTime now = DateTime.Now; // Declares current time

                TimeSpan difference = now - birthday; // Declares difference between now and birthday in days

                int years = (int) Math.Floor(difference.TotalDays / 365.2425); // Rounds difference

                birthday = birthday.AddYears(years); // Rounded birthday days convert to years
                
                difference = now - birthday; // Difference between now and birthday years

                int days = (int)Math.Floor(difference.TotalDays); // Declares days

                Console.WriteLine("\nYou are " +years+" years and "+days+" days old. \n"); // Prints results
                
                Console.WriteLine("Press any key to exit... \n");

                Console.ReadKey();

                Console.Clear();
            } 
            catch (FormatException) // Format exception handling
            {
                Console.WriteLine("Write your birthday in this format: {ddMMyyyy} \n");
            }
        }
    }
}