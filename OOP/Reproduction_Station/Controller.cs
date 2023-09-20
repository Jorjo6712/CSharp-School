
namespace Reproduction_Station
{
    /// <summary>
    /// Used for instantiating all animal objects from the superclass animal and bookeeping newborn animal, as well as providing
    /// user with the ability to breed the animals
    /// </summary>
    internal class Controller
    {
        internal void MainController()
        {
            View view = new View(); // Instantiate view for GUI uses

            BookKeeping bookKeeping = new BookKeeping(); // Instantiate bookkeeping for keeping track of animal objects

            view.Text("\t--------------------------");
            view.Text("\t Animal Breeder:");

            view.Text("\t1. Breed dogs");               // Menu
            view.Text("\t2. Breed rabbits");
            view.Text("\t3. Breed chickens");

            view.Text("\t--------------------------");


            // Instantiate all 3 animal types with each being a pair of parents
            Dog dog1 = new Dog("Male","Candie",4,true,5,false,true);
            Dog dog2 = new Dog("Female", "Candie", 4, true, 7, false, true);

            Rabbit rabbit1 = new Rabbit("Male", "Leporidae", 4, true, 2, false, true);
            Rabbit rabbit2 = new Rabbit("Female", "Leporidae", 4, true, 4, false, true);

            Chicken chicken1 = new Chicken("Male", "Chordata", 4, false, 1, false, true);
            Chicken chicken2 = new Chicken("Female", "Chordata", 4, false, 2, false, true);


            // Add dogs to repsective bookkeeping list
            bookKeeping.dogs.Add(dog1);
            bookKeeping.dogs.Add(dog2);

            // Add rabbits to repsective bookkeeping list
            bookKeeping.rabbits.Add(rabbit1);
            bookKeeping.rabbits.Add(rabbit2);
            
            // Add chickens to repsective bookkeeping list
            bookKeeping.chickens.Add(chicken1);
            bookKeeping.chickens.Add(chicken2);

            //Add all animals to animal bookkeeping list
            bookKeeping.animals.Add(dog1);
            bookKeeping.animals.Add(dog2);
            bookKeeping.animals.Add(rabbit1);
            bookKeeping.animals.Add(rabbit2);
            bookKeeping.animals.Add(chicken1);
            bookKeeping.animals.Add(chicken2);


            // Gui functonality
            ConsoleKeyInfo cki = view.RK();

            switch (cki.Key)
            {
                case ConsoleKey.D1:
                    // Add newborn to bookkeeping list to show a new animal has appeared
                    bookKeeping.dogs.Add(new Dog("Male", "Candie", 4, true, 5, false, true));
                    view.Text("\n" + dog1.Breed()); // Display message saying that they are breeding
                    view.Text("\n" + dog2.Breed());

                    // Simple check for list count to output all list elements and their attributes
                    for (int i = 0; i < bookKeeping.dogs.Count; i++)
                    {
                        var dog = bookKeeping.dogs[i];
                        view.Text($"\nDog{i} attributes and abilities: " + "\n" + dog.ToString());
                    }
                    break;
                case ConsoleKey.D2:
                    // Add newborn to bookkeeping list to show a new animal has appeared
                    bookKeeping.rabbits.Add(new Rabbit("Male", "Leporidae", 4, true, 3, false, true));
                    view.Text("\n" + rabbit1.Breed()); // Display message saying that they are breeding
                    view.Text("\n" + rabbit2.Breed());

                    // Simple check for list count to output all list elements and their attributes
                    for (int i = 0; i < bookKeeping.rabbits.Count; i++)
                    {
                        var rabbit = bookKeeping.rabbits[i];
                        view.Text($"\nRabbit{i} attributes and abilities: " + "\n" + rabbit.ToString());
                    }
                    break;
                case ConsoleKey.D3:
                    // Add newborn to bookkeeping list to show a new animal has appeared
                    bookKeeping.chickens.Add(new Chicken("Female", "Chordata", 4, false, 2, false, true));
                    view.Text("\n" + chicken1.Breed()); // Display message saying that they are breeding
                    view.Text("\n" + chicken2.Breed());

                    // Simple check for list count to output all list elements and their attributes
                    for (int i = 0; i < bookKeeping.chickens.Count; i++)
                    {
                        var chicken = bookKeeping.chickens[i];
                        view.Text($"\nChicken{i} attributes and abilities: " + "\n" + chicken.ToString());
                    }
                    break;
            }

            view.RK(); // Used for program to wait before exiting

        }
    }
}
