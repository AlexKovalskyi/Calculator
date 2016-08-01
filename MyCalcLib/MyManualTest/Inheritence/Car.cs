//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime;
//using System.Security.Permissions;
//using System.Text;
//using System.Threading.Tasks;

//namespace SharedCodeSnippets.Inheritence
//{
//    public class Car
//    {
//        public int Speed { get; set; }
//        public string Name { get; set; }
//        public decimal Cost { get; set; }

//        public void Ride()
//        {
//            Console.WriteLine($"Ride  with speed {Speed}");
//        }

//        public override bool Equals(object obj)
//        {
//            var tmpObj = obj as Car;
//            if (tmpObj != null)
//            {
//                if (this.Name.Equals(tmpObj.Name))
//                {
//                    return true;
//                }
//            }

//            return false;
//        }

//        public override string ToString()
//        {
//            return Name;
//        }
//    }

//}
