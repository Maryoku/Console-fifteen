using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_fifteen
{
    class Program
    {
        static void Main(string[] args)
        {
            var fifteen = new Game3(0, 1, 2, 3, 4, 5, 6, 7, 8);

            var Interface = new ConsoleGameUI(fifteen);

            Interface.Print();
            Interface.Move();
            Interface.Move();
            Interface.Move();
            Interface.Move();
            Interface.Move();
        }
    }
}
