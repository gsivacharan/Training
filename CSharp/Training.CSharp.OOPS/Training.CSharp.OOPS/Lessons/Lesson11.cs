using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp.OOPS.Lessons
{
    public class Lesson11
    {
        public int Grade;
        public int Department;
        // This is Default Constructor
        // When developer did not declare this Framwork will create this in run time.
        public Lesson11()
        {
            Console.WriteLine("Lesson11 Default Constructor Called");
        }

        //Parameter constructor
        public Lesson11(int grade)
        {
            Grade = grade;
            Console.WriteLine("Lesson11 Parameter Constructor Called and vlaue set {0}", Grade);
        }
        // This is constructor overloading
        public Lesson11(int grade, int department)
        {
            Grade = grade;
            Department = department;
            Console.WriteLine("Lesson11 Parameter Constructor Called and vlaue set {0} and {1}", Grade, Department);
        }

        //Copy Constructor
        public Lesson11(Lesson11 l11)
        {
            Console.WriteLine("Lesson11 Copy Constructor Called and vlaue set {0} and {1}", l11.Grade, l11.Department);
        }

    }


    // Private constructor
    // *** To Stop creating object use private constructor
    public class PrivateConstructorClass
    {
        /* When all the members in the class there is no need to create the object of this class
         * this members are available to with out creating the object
         * To prevent developer to create the object of this class private constructor used..
        */
        public static string name;
        public static string address;
        public static double phone;
        public static string gender;

        // #65 No
        //public PrivateConstructorClass()
        //{
        //    Console.WriteLine("Public PrivateConstructorClass called.");
        //}


        private PrivateConstructorClass()
        {
            Console.WriteLine("PrivateConstructorClass called.");
        }

        //# 68 . Yes
        private PrivateConstructorClass(string a)
        {
            Console.WriteLine("PrivateConstructorClass called.");
        }
    }

    // Internal constructor
    public class InternalConstructorClass
    {
        internal InternalConstructorClass()
        {
            Console.WriteLine("InternalConstructorClass called.");
        }
    }


    /* Stattic Constructor
     * 1. One static constructor per class
     * 2. Can not use access modifiers in static constructors
     * 3. Can not pass parametors in static constructors
     * 4. Can use public and  static constructors
     * 5. When create object static constructor called first then derault constructor called.
     * 6. When create multiple object of static constructor class only first time static costructor callled.
     */
    public class StaticConstructorClass
    {
        public static string name;
        public static string address;
        public static int age;

        static StaticConstructorClass()
        {
            Console.WriteLine("StaticConstructorClass static constuctor called.");
        }

        public StaticConstructorClass()
        {
            Console.WriteLine("StaticConstructorClass public constuctor called.");
        }

        //#70 No
        //public static StaticConstructorClass()
        //{
        //    Console.WriteLine("StaticConstructorClass constuctor called.");
        //}

        //#71 No
        //static StaticConstructorClass(string a)
        //{
        //    Console.WriteLine("StaticConstructorClass constuctor called.");
        //}

    }

    #region #77

    public class Base11
    {
        public Base11()
        {
            Console.WriteLine("Lesson11.Base11 Constructor called.");
        }
    }

    public class Child11 : Base11
    {
        public Child11()
        {
            Console.WriteLine("Lesson11.Child11 Constructor called.");
        }
    }
    #endregion

    #region #78 
    //using :this() we can call default constructor from an other constructor in same class
    public class MultipleConstructorCallDefaultFirst
    {
        public MultipleConstructorCallDefaultFirst()
        {
            Console.WriteLine("MultipleConstructorCallDefaultFirst Default Constructor Called");
        }

        public MultipleConstructorCallDefaultFirst(string a) : this()
        {
            Console.WriteLine("MultipleConstructorCallDefaultFirst Parametor Constructor Called");
        }
    }
    #endregion

    #region #79
    //using :this(param) we can call param constructor frist from an other constructor in same class
    public class MultipleConstructorCallParameterFirst
    {
        public MultipleConstructorCallParameterFirst() : this("A")
        {
            Console.WriteLine("MultipleConstructorCallParameterFirst Default Constructor Called");
        }

        public MultipleConstructorCallParameterFirst(string a)
        {
            Console.WriteLine("MultipleConstructorCallParameterFirst Parametor Constructor Called");
        }
    }

    #endregion

    #region #80
    //using :Base() we can call child class constractor first
    public class Base80
    {
        public Base80() : base()
        {
            Console.WriteLine("Lesson11.Base80 Default Constructor Called");
        }
    }

    public class Child80
    {
        public Child80()
        {
            Console.WriteLine("Lesson11.Child80 Default Constructor Called");
        }

    }

    #endregion

    // you can not Inherit Private constructor class
    //public class PrivateConstructorClassInheritClass : PrivateConstructorClass
    //{

    //}


    public class Lesson11Test
    {
        public void Test()
        {
            Lesson11 l0 = new Lesson11();
            Lesson11 l1 = new Lesson11(1);
            Lesson11 l2 = new Lesson11(1, 2);


            //Copy Constructor intialise
            Lesson11 l3 = new Lesson11(l2);

            //#66 No Calling Private constructor
            // PrivateConstructorClass pc = new PrivateConstructorClass();

            //Calling Internal constructor
            InternalConstructorClass ic = new InternalConstructorClass();

            //Calling static constructor
            Console.WriteLine("Creatign for first time");
            StaticConstructorClass sc = new StaticConstructorClass();

            Console.WriteLine("Creatign for second time");
            StaticConstructorClass sc1 = new StaticConstructorClass();

            //#77 First base class constructor called then child class construcor
            Console.WriteLine("#77");
            Child11 c11 = new Child11();

            //#78 Calling Multiple constructors 
            Console.WriteLine("#78");
            MultipleConstructorCallDefaultFirst mcd = new MultipleConstructorCallDefaultFirst("S");

            //#79 Calling Multiple constructors 
            Console.WriteLine("#79");
            MultipleConstructorCallParameterFirst mcp = new MultipleConstructorCallParameterFirst();

            //#80 Calling ChildClass constructors first
            Console.WriteLine("#80");
            Child80 ch80 = new Child80();
        }
    }
}
