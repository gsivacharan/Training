using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp.OOPS.Lessons
{
    
    public class L9BaseClass
    {
        public void GetName()
        {
            Console.WriteLine("L9BaseClass.GetName called.");
        }
    }

    public class L9ChildClass : L9BaseClass
    {
        public void GetName()
        {
            Console.WriteLine("L9ChildClass.GetName called.");
        }
    }

    public class Lesson9Test
    {
        public void Test()
        {
            //#39. UpCasting and DownCasting

            L9BaseClass b = new L9BaseClass(); // This will work 

            L9BaseClass bb = new L9ChildClass(); // This will work (UpCasting)

            L9ChildClass c = new L9ChildClass(); // This will work 

            //L9ChildClass cc = new L9BaseClass();  // This will not work (Downcasting)

            //c = (L9ChildClass) b; // This will not work (Downcasting) throw runtime error

            b.GetName(); // Base Method Called
            bb.GetName(); // BaseMethod Called
            c.GetName(); // ChildMethod Called

        }
    }
}
