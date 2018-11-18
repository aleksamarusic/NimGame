using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.nim.ma150129d
{
    public abstract class Player
    {
        public abstract State PlayMove(State state);
    }
}
