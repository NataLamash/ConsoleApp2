using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Team
    {
        public string TeamName { get; set; }

        public Team(string teamName)
        {
            TeamName = teamName;
            workers = new List<Worker>();
        }
        private List<Worker> workers;

        public void AddWorker(Worker worker)
        {
            workers.Add(worker);
        }
        public void GetTeamInfo()
        {
            Console.WriteLine($"Team: {TeamName}");

            foreach (var worker in workers)
            {

                Console.WriteLine(worker.Name);
            }
        }

        public void GetFullTeamInfo()
        {
            Console.WriteLine($"Team: {TeamName}");

            foreach (var worker in workers)
            {

                Console.WriteLine($"{worker.Name} - {worker.Position} - {worker.WorkDay}");
            }
        }
    }
}
