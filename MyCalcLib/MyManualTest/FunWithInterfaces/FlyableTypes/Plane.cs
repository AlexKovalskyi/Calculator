using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCodeSnippets.FunWithInterfaces.FlyableTypes
{
    public class Plane : IFlyable
    {

        private string material = "metal";

        public void Fly()
        {
            Console.WriteLine("Plane flies 3,5 km hieght.");
        }

        public void TakeOff()
        {

        }


    }
}
