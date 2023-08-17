namespace PasswordValidatorFlowchartAttempt
{
    class Program
    {
        #region Entrypoint

        static void Main()
        {
            Controller();
        }

        #endregion Entrypoint

        #region Controllers

        static void Controller()
        {
            View();

            string? passwordInput = Console.ReadLine();

            if (Rule1(passwordInput) == true && Rule2(passwordInput) == true && Rule3(passwordInput) == true && Rule4(passwordInput) == true)
            {
                Green();
            }
            else if (Contains4(passwordInput) == false)
            {
                Yellow();
            }
            else
            {
                Red();
            }
        }

        #endregion Controllers

        #region View

        static void View()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Welcome to Password Validator \n");
            Console.WriteLine("\n Rules:\n");
            Console.WriteLine("1. Your password has to be between 12-64 characters long");
            Console.WriteLine("2. Your password has to include a mix of UPPER and lower case characters");
            Console.WriteLine("3. Your password has to include a mix of chracters and digits");
            Console.WriteLine("4. Your password has to include at least one special character");

            Console.WriteLine("\n There are 3 color codes that define the strenght of your password:");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 1. Green, meaning your password is strong and valid");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n 2. Yellow, meaning your password meets the requirements but can be fruther enforced");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n 3. Red, meaning your password is too weak");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n Please input your password: ");
        }

        static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Password is valid :)");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Yellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Password meets the requirements but can be fruther enforced");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Password is too weak");
            Console.ForegroundColor = ConsoleColor.White;
        }

        #endregion View

        #region ExtraMethods

        static bool Rule1(string passwordInput)
        {

            if (InputToCharArray(passwordInput).Length > 12)
            {
                return true;
            }
            else if (InputToCharArray(passwordInput).Length > 64)
            {
                return false;
            }
            else
            {
                return false;
            }

        }

        static bool Rule2(string passwordInput)
        {
            if (passwordInput.Any(char.IsUpper) && passwordInput.Any(char.IsLower))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool Rule3(string passwordInput)
        {
            if (passwordInput.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool Rule4(string passwordInput)
        {
            if (passwordInput.Any(char.IsSymbol))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool Contains4(string passwordInput)
        {
            int charCount = 1;

            char precedingChar = passwordInput[0];

            for (int i = 1; i < passwordInput.Length - 1; i++)
            {
                if (passwordInput[i] == passwordInput[i + 1])
                {
                    charCount++;
                }
                if (charCount == 4)
                {
                    return true;
                }
                else
                {
                    charCount = 1;
                }


            }
            return false;
        }


        static char[] InputToCharArray(string passwordInput)
        {

            char[] passwordArray = new char[passwordInput.Length];

            for (int i = 0; i < passwordInput.Length;)
            {
                passwordArray[i] = passwordInput[i];
                i++;
            }

            return passwordArray;
        }

        #endregion ExtraMethods
    }
}
