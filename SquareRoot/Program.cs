using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbersList = new List<Square>
            {
                new Square{Number = 1},
                new Square{Number = 2},
                new Square{Number = 3},
                new Square{Number = 4},
                new Square{Number = 15},
                new Square{Number = 6},
                new Square{Number = 7},
                new Square{Number = 18},
                new Square{Number = 9},
            };


            var findNumbers = from Numbers in numbersList where Numbers.Number <= 9 && Numbers.Number > 0 select Numbers.Number;


           
            var square = from Square in numbersList
                where Square.Number;
        }
    }
}
