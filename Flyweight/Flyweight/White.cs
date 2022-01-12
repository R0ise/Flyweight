using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class White : Board
    {
        public White()
        {
            color = "White";
        }
        public override void Create(double x, double y)
        {
            Console.WriteLine("Создать белую клетку в ({0}, {1})", x, y);
        }
    }
}
