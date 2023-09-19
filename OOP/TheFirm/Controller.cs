namespace TheFirm
{
    /// <summary>
    /// This is the Controller class where the program is controlled via the MainController method
    /// </summary>
    internal class Controller
    {
        internal void MainController()
        {
            View view = new View(); // instanciate view object

            Employee employee = new Employee("Gerald", "Mitch", "123123123"); // instanciate Employee object with details

            Sweeper sweeper = new Sweeper("Ismail", "Abdul", "55313211"); // instanciate Sweeper object with details

            Manager manager = new Manager("Isabella", "Smith", "1541251241", 42315511); // instanciate Manager object with details

            ProjectManager projectManager = new ProjectManager("Jacob", "Lee", "15345234", 42315511, "kevin55@firm.com"); // instanciate Project Manager object with details

            view.Text(employee.ToString()); // Display all employee info
            view.Text(sweeper.ToString()); // Display all sweeper info
            view.Text(manager.ToString()); // Display all manager info
            view.Text(projectManager.ToString()); // Display all project manager info

        }
    }
}
