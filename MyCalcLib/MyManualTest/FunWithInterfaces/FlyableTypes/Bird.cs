using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCodeSnippets.FunWithInterfaces.FlyableTypes
{
    public class Bird : IFlyable
    {
        private string kind;

        public void Fly()
        {
            Console.WriteLine("Bird flies below the clouds");
        }
    }
}
