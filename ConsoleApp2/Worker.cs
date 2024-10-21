using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Worker
    {
        public string Name {  get; set; }
        public string Position { get; set; }
        public string WorkDay { get; set; }
        public Worker(string personName) 
        { 
            Name = personName;
            Position = "Unknown";
            WorkDay = "Unknown";
        }

        public void Call() 
        {
            Console.WriteLine($"{Name} is making a call");
        }
        public void WriteCode()
        {
            Console.WriteLine($"{Name} is writing a code");
        }
        public void Relax()
        {
            Console.WriteLine($"{Name} is relaxing");
        }

        public abstract void FillWorkDay();
    }

}
