using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();
            eagle.eagle();

            Chicken chicken = new Chicken();
            chicken.chicken();

            Duck duck= new Duck();
            duck.duck();
        }
    }
}
