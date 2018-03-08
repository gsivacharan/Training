using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Training.CSharp.OOPS.Lessons
{
    public class Lesson13
    {
        public virtual void VirtualMember()
        {
            Console.WriteLine("Base Class VirtualMember called.");
        }

        //#107
        public virtual void VirtualMemberWithNewKeyWord()
        {
            Console.WriteLine("Base Class VirtualMemberWithNewKeyWord called.");
        }

        public void NonVertualMember()
        {
            Console.WriteLine("Base Class NonVertualMember called.");
        }

        public void Calculate(params int[] sum)
        {
            var v = 0;
            foreach (var val in sum)
            {
                v += val;
            }
            Console.WriteLine("The total is : {0}",v);
        }

        protected internal abstract class AbstractClass
        {
            static void test()
            {
                
            }

        }
        
    }

    public class Derived13 : Lesson13
    {
        public override void VirtualMember()
        {
            Console.WriteLine("Derived class VirtualMember override called.");
        }

        //#107
        public new void VirtualMemberWithNewKeyWord()
        {
            Console.WriteLine("Derived Class VirtualMemberWithNewKeyWord called.");
        }
        public new void NonVertualMember()
        {
            Console.WriteLine("Derived class NonVertualMember override called.");
        }

        //#109
        //public sealed override void VirtualMember()
        //{
        //    Console.WriteLine("Derived class VirtualMember override called.");
        //}

    }

    //#109
    //public class Derived131 : Derived13
    //{
    //    //public override void VirtualMember()
    //    //{
    //    //    Console.WriteLine("Derived class VirtualMember override called.");
    //    //}

    //}


    public class Lesson13Test
    {
        public void Test()
        {
            Console.WriteLine("#98..");
            Derived13 d13 = new Derived13();
            d13.VirtualMember();
            Console.WriteLine("#101..");
            d13.NonVertualMember();
            Console.WriteLine("#107..");
            d13.VirtualMemberWithNewKeyWord();

            Console.WriteLine("#111..");
            //using params parameter we can overload the method by passing different paramerters
            d13.Calculate(1, 2, 3);
            d13.Calculate(1, 2, 3, 4, 5, 6);
        }
    }
}
