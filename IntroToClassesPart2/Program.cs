using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClassesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWithMethods obj = new ClassWithMethods();
            obj.Func(1,2);
            obj.Func( x: 1, y: 2 );
        }
    }
}
