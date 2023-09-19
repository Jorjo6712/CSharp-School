using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    internal class Controller
    {
        internal void MainController()
        {
            View view = new View();

            Employee employee = new Employee("Gerald", "Mitch", "123123123");

            Sweeper sweeper = new Sweeper("Ismail", "Abdul", "55313211");

            Manager manager = new Manager("Isabella", "Smith", "1541251241", 42315511);

            ProjectManager projectManager = new ProjectManager("Jacob", "Lee", "15345234", 42315511, "kevin55@firm.com");

            view.Text(employee.ToString());
            view.Text(sweeper.ToString());
            view.Text(manager.ToString());
            view.Text(projectManager.ToString());

        }
    }
}
