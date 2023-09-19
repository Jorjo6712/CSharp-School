using System.Diagnostics;

namespace TheFirmV2
{
    internal class Controller
    {
        /// <summary>
        /// This is the controller class where the main controller of the program is stored
        /// </summary>
        internal void MainController() 
        {

            // Instanciate multiple objects for both COO,CFO and CEO as well as view for GUI output
            View view = new View();
            CEO ceo = new CEO("John", "Marston", "12315124", true); 
            COO coo = new COO("Lenny", "Simens", "51667123", true);
            CFO cfo = new CFO("Gerald", "Wilhelm", "12781257", true);

            // Declare all salary values
            uint salary = 1500;
            uint leaderSalary = 2500;
            uint chiefSalary = 2750;
            uint cooSalary = 5000;
            uint cfoSalary = 5050;
            uint ceoSalary = 10000;

            // Give each type of employee their respective salary
            coo.RecieveSalary(cooSalary);
            cfo.RecieveSalary(cfoSalary);
            ceo.RecieveSalary(ceoSalary);

            // Test display
            view.Text(ceo.ToString());
            view.Text(coo.ToString());
            view.Text(cfo.ToString());


            // Instanciate HR objects inside Ceo HR list
            ceo.hRs.Add(new HR("Jose", "Gonzales", "89347842"));
            ceo.hRs.Add(new HR("Nelson", "Smith", "51228931"));
            ceo.hRs.Add(new HR("Jason", "Miller", "47285029"));

            // Instanciate 2 new chiefs each for their repsective Chief Officer
            Chief chiefCOO = new Chief("Mark", "Rober", "983481236");
            Chief chiefCFO = new Chief("Lee", "Harvard", "83298523");

            // Instanciate 2 new leaders each for their respective Chief
            Leader leaderChiefCoo = new Leader("Clark", "Johnson", "71278937");
            Leader leaderChiefCfo = new Leader("Melly", "Downes", "412816632");

            // Add said cheifs to Chief list under each Chief Officer class
            coo.chief.Add(chiefCOO);
            cfo.chief.Add(chiefCFO);

            // Add said leaders to Leaders list under Chief class
            chiefCOO.leaders.Add(leaderChiefCoo);
            chiefCOO.leaders.Add(leaderChiefCfo);


        }
    }
}
