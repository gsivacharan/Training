using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.CSharp.OOPS.Lessons;

namespace Training.CSharp.OOPS
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Abstract_Vertual

            //Abstract class can not be intanciate
            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            //Abstract_Vertual av = new Abstract_Vertual()
            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

            //

            //CallerOne c1 = new CallerOne();
            //CallerTwo c2 = new CallerTwo();
            //c1.VertualMethod();
            //Console.WriteLine("********");
            //c2.VertualMethod();
            //Console.Read();

            #endregion


            #region AbstractClassExample

            //** Absract class will be useful of code reusablilyt
            //** Code maintainability
            //** Same functioanality will be declare in Abstract class and reause in derived class with override key



            //BaseClass Inheritence
            //BaseFullTimeEmployee BFEmp = new BaseFullTimeEmployee
            //{
            //    FirstName = "siva",
            //    AnualSalary = 20000,
            //    Id=10,
            //    LastName = "Gavvala"
            //};
            //BaseContractEmployee BCEmp = new BaseContractEmployee
            //{
            //    FirstName = "Konda",
            //    HourlySalary = 20,
            //    Id = 10,
            //    LastName = "Rao"
            //};

            //// **** Reason for Abstract Class ****
            //// Here is the reason Developers Can create the Instance of
            //// Base class and set properties of employee
            //BaseClass BEmp = new BaseClass
            //{
            //    FirstName = "siva",
            //    Id = 10,
            //    LastName = "Gavvala"
            //};




            //Abstract Class Inheritence
            //AbstractFullTimeEmployee AFEmp = new AbstractFullTimeEmployee
            //{
            //    FirstName = "siva",
            //    AnualSalary = 20000,
            //    Id = 10,
            //    LastName = "Gavvala"
            //};
            //AbstractContractEmployee ACEmp = new AbstractContractEmployee
            //{
            //    FirstName = "Konda",
            //    HourlySalary = 20,
            //    Id = 10,
            //    LastName = "Rao"
            //};



            #endregion


            #region Lesson9

            Lesson9Test l9 = new Lesson9Test();
            Console.WriteLine("*** Lesson 9 *****");
            l9.Test();
            Console.WriteLine("*** Lesson 9 *****");
            Console.WriteLine();
            #endregion

            #region Lesson10

            Lesson10Test l10 = new Lesson10Test();
            Console.WriteLine("*** Lesson 10 *****");
            l10.Test();
            Console.WriteLine("*** Lesson 10 *****");
            Console.WriteLine();
            #endregion

            #region Lesson11

            Lesson11Test l11 = new Lesson11Test();
            Console.WriteLine("*** Lesson 11 *****");
            l11.Test();
            Console.WriteLine("*** Lesson 11 *****");
            Console.WriteLine();
            #endregion

            #region Lesson12

            Lesson12Test l12 = new Lesson12Test();
            Console.WriteLine("*** Lesson 12 *****");
            l12.Test();
            Console.WriteLine("*** Lesson 12 *****");
            Console.WriteLine();
            #endregion


            #region Lesson13

            Lesson13Test l13 = new Lesson13Test();
            Console.WriteLine("*** Lesson 13 *****");
            l13.Test();
            Console.WriteLine("*** Lesson 13 *****");
            Console.WriteLine();
            #endregion

            Console.Read();
        }
    }
}
