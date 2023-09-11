using System.Reflection;

namespace Superhero
{
    internal class Program
    {
        Superhero[] superhero = new Superhero[3];

        static void Main()
        {
            Controller();
        }
        #region Controller
        static void Controller()
        {
            Program program = new Program();
            program.Superheros();
        }
        #endregion Controller

        #region Methods
        void Superheros()
        {
            for(int i = 0; i < 3; i++)
            {
                superhero[i] = new Superhero(); 
            }

            superhero[0].HeroName = "Batman";
            superhero[0].SecretName = "Clark Kent";
            superhero[0].Powers = "none";
            superhero[0].WearsMask = true;
            superhero[0].WearsCostume = true;
            superhero[0].FightsAlone = false;
            superhero[0].HasSecretIdentity = true;
            superhero[0].HasNemesis = true;
            superhero[0].HasStrongMoralComplex = true;
            superhero[0].HasPrivateAnxiety = false;

            superhero[1].HeroName = "Superman";
            superhero[1].SecretName = "Bruce wayne";
            superhero[1].Powers = "Laser eyes, Super strength, Flying";
            superhero[1].WearsMask = false;
            superhero[1].WearsCostume = true;
            superhero[1].FightsAlone = true;
            superhero[1].HasSecretIdentity = true;
            superhero[1].HasNemesis = true;
            superhero[1].HasStrongMoralComplex = true;
            superhero[1].HasPrivateAnxiety = false;

            superhero[2].HeroName = "The Flash";
            superhero[2].SecretName = "Bartholomew Henry Barry Allen";
            superhero[2].Powers = "Super speed, Time Manipulation";
            superhero[2].WearsMask = true;
            superhero[2].WearsCostume = true;
            superhero[2].FightsAlone = false;
            superhero[2].HasSecretIdentity = true;
            superhero[2].HasNemesis = true;
            superhero[2].HasStrongMoralComplex = true;
            superhero[2].HasPrivateAnxiety = false;

            View();
        }
        #endregion Methods
        
        #region View
        void View()
        {
            for (int i = 0; i < 3; i++)
            {
                foreach (PropertyInfo info in superhero[i].GetType().GetProperties())
                {   
                    Console.WriteLine($"{info.Name}: {info.GetValue(superhero[i])}");

                    Console.WriteLine();
                }
            }
        }
        #endregion View
    }    
}
