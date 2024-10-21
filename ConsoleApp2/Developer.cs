using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Developer : Worker
    {
        public Developer(string personName) : base(personName)
        {
            Position = "Developer";  
        }

        public override void FillWorkDay()
        {
            WriteCode();
            Call();
            Relax();
            WriteCode();
        }
    }
}
