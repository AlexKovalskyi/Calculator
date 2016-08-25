using System;

namespace SharedCodeSnippets.FunWithInterfaces.FlyableTypes
{
    public class DragonFly : IFlyable
    {
        private long lifeTimeMilliseconds = 40 * 60 * 60 * 1000;

        public void Fly()
        {
            Console.WriteLine("Dragon Fly: zzzz");
        }
    }
}
