using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp.OOPS.Lessons
{
    public abstract class AbstractClassExample
    {
        /*
        The main perpouse of the Abstract Class

            Abstract classes are create for moving the common code functionality of two or more related classes into a base class and when we dont want 
            that base class to be inherited.

        Advantages
            1. Code reusability
            2. Code maintainability
        
        
        Notes
            1. Abstract methods no implementation. Derived class will have the implementation
            2. Vertual method in Abstract class can/can not implementatin but derived class can override this implementation if they want to.
                   
    */

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Abstract methods no implementation. Derived class will have the implementation
        public abstract int GetSalary();
       
        //Vertual method in Abstract class has implementatin but derived class can override this implementation
        public virtual string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }

    public class BaseClass
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual int GetSalary()
        {
            // Declare a vertual method here for GetSalary
            // the inherited class will do the implementation
            throw new NotImplementedException();
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

    }

    public class BaseFullTimeEmployee : BaseClass
    {
        //public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int AnualSalary { get; set; }

        //public string GetFullName()
        //{
        //    return FirstName + " " + LastName;
        //}

        //public int Salary()
        //{
        //    return AnualSalary / 12;
        //}
    }

    public class BaseContractEmployee :BaseClass
    {
        //public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int HourlySalary { get; set; }

        //public string GetFullName()
        //{
        //    return FirstName + " " + LastName;
        //}

        //public int Salary()
        //{
        //    return (HourlySalary * 8) * 21;
        //}
    }

    public class AbstractFullTimeEmployee : AbstractClassExample
    {
        //public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int AnualSalary { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public override int GetSalary()
        {
            return AnualSalary / 12;
        }
    }

    public class AbstractContractEmployee : AbstractClassExample
    {
        //public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int HourlySalary { get; set; }

        // This method is base class abstract method
        //This method need to override in this derived class
        public override int GetSalary()
        {
            return (HourlySalary * 8) * 21;
        }
    }
}
