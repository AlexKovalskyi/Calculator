using SharedCodeSnippets.FunWithInterfaces;
using SharedCodeSnippets.FunWithInterfaces.FlyableTypes;
using System;

namespace SharedCodeSnippets
{
    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
		{
            Plane plane = new Plane();
            plane.TakeOff();
            IFlyable flyablePlane = plane;
            flyablePlane.Fly();

            foreach (IFlyable item in new IFlyable[]{ new Bird(), flyablePlane, new DragonFly()})
            {
                item.Fly();
            }
		}

































        private static void OldMain()
        {
            //foreach (string item in args)
            //{

            //}
            //OutputMethod();
            //Console.ReadLine();
            //ReferenceTypeUsage.Run();
        }
        private static void OutputMethod()
		{
			// Настроить консольный интерфейс (CUI).
			Console.Title = "My Rocking App";
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.WriteLine("*************************************");
			Console.WriteLine("***** Welcome to My Rocking App *****");
			Console.WriteLine("*************************************");
			Console.BackgroundColor = ConsoleColor.Black;
			// Ожидать нажатия клавиши <Enter>.
		}
	}
}
