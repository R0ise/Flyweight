using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Black : Board
    {
        public Black()
        {
            color = "Black";
        }
        public override void Create(double x, double y)
        {
            Console.WriteLine("Создать черную клетку в ({0}, {1})", x, y);
        }
    }
}
