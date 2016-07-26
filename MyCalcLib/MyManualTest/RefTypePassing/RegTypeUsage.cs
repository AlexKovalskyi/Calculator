using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCodeSnippets.RefTypePassing
{
    public static class ReferenceTypeUsage
    {
        public static void Run()
        {
            Man Sasha = new Man("Sasha Ko");
            Shark whiteShark = new Shark();
            whiteShark.Eat(Sasha);
            var SashaKo = whiteShark.SplitOut(Sasha);

            var something = whiteShark.SplitOut();
        }
    }
}
