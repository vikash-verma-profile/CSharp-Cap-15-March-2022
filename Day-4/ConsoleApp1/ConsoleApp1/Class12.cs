using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //enums
    /*enumerations are value data type
     * 
     */

    enum Gender
    {
        Female=1,
        Male=2,
        Others=3
    }
    internal class Class12
    {
        public static void Main13()
        {
            Console.WriteLine(Gender.Male);
            Console.WriteLine((int)Gender.Male);
        }
    }
}
