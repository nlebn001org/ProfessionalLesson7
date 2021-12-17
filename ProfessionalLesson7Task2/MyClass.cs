using System;
using System.Collections.Generic;
using System.Text;

namespace ProfessionalLesson7Task2
{
    class MyClass
    {
        [Obsolete("ObsoleteMehtodWarning")]
        public void ObsoleteMehtodWarning()
        {
            Console.WriteLine("ObsoleteMehtodWarning");
        }

        [Obsolete("ObsoleteMehtodWarning", true)]
        public void ObsoleteMehtodError()
        {
            Console.WriteLine("ObsoleteMehtodWarning");
        }

    }
}
