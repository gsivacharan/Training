using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp.OOPS.Lessons
{
    class Lesson3
    {
        /* 
            * A class can not created as Private/ Protected/ Protected Internal 
            * Default Internal
            * Can be change to Public only
            * Defualt variable in class are private not visible to derived class example 'MyVariable'
        */

        int MyVariable = 10;
    }

    class Lesson3Test
    {
        private void Test()
        {
            Lesson3 l3 = new Lesson3();

            //Private variable can not accessable
            //l3.MyVariable
        }
    }
}
