using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            User tom = new User { name = "Tom", age = 23 };
            //tom.name = "Tom";
            //tom.age = 22;
            tom.Info();
            User bob = new User("Bob") { age = 26 };
            //bob.name = "Bob";
            //bob.age = 24;
            bob.Info();

            Console.ReadKey();
        }
    }

    
}
