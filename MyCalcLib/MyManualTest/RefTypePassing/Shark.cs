using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCodeSnippets.RefTypePassing
{
    public class Shark
    {
        public void Eat(Man man)
        {
            //man.Name = "Vasya";
            man = null;
        }
        
        public Man SplitOut(Man man)
        {
            return man;
        }

        public Man SplitOut()
        {
            string nameOfTheMan = "NoName";
            return new Man(nameOfTheMan);
        }
    }
}
