using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Manager : Worker
    {
        private Random random;
        public Manager(string personName) : base(personName)
        {
            Position = "Manager";
            var random = new Random();
        }

        public override void FillWorkDay()
        {
            int firstRandomCalls = random.Next(1, 11);

            for (int i = 0; i < firstRandomCalls; i++)
            {
                Call();
            }

            Relax();

            int secondRandomCalls = random.Next(1, 6);
            for (int i = 0; i < secondRandomCalls; i++)
            {
                Call();
            }
        }
    }
}
