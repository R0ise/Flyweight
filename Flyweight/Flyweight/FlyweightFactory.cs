using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class FlyweightFactory
    {
        Dictionary<string, Board> color = new Dictionary<string, Board>();
        public FlyweightFactory()
        {
            color.Add("White", new White());
            color.Add("Black", new Black());
        }
        public Board GetParticle(string key)
        {
            if (color.ContainsKey(key))
                return color[key];
            else
                return null;
        }
    }
}
