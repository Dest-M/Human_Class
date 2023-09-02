using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 5;
            Human[] h = new Human[count];

            h[0] = new Human("Sasha", "Male", 45);
            h[1] = new Human("Alexis", "Female", 39);
            h[2] = new Human("Roy", "Male", 23, h[0], h[1]);
            h[3] = new Human("Amy", "Female", 24);
            h[4] = new Human("Lily", "Female", 2, h[2], h[3]);

            Console.WriteLine(h[0].GetName() + " Partner " + h[0].partner.GetName());
            Console.WriteLine(h[1].GetName() + " Child " + h[0].child.GetName());
            Console.WriteLine(h[3].ToString());
            Console.WriteLine(h[4].ToString());

        }
    }
}
