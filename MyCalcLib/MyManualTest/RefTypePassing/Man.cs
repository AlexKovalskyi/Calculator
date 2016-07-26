using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCodeSnippets.RefTypePassing
{
    public class Man
    {
        public string Name { get; private set; }

        public Man(string name)
        {
            Name = name;
        }
    }
}
