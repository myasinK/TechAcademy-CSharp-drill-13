using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClassesPart2
{
    public class ClassWithMethods
    {
        public void Func(int x, int y)
        {
            Console.WriteLine(x+10);
            Console.WriteLine("The second number was "+ y);
        }
    }
}
