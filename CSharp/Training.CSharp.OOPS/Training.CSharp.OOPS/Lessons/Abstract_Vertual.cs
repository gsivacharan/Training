using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp.OOPS.Lessons
{
    // Declaring the Abstract Class
    public abstract class Abstract_Vertual
    {
        public virtual void VertualMethod()
        {
            Console.WriteLine("VertualMethod Called");
        }
    }
    
    public class CallerOne : Abstract_Vertual
    {
        // We not overriding the vertual method in this class 
        // It means this class has base class method with same implementation
    }

    public class CallerTwo : Abstract_Vertual
    {
        // this base class method will be overrided
        public override void VertualMethod()
        {
            Console.WriteLine("CallerTwo Implementation.");
        }
    }
}
