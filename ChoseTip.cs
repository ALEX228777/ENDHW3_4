using System;

namespace Task3_1
{
    public abstract class ChoseTip<Tip>
    {
        public Random random = new Random();
        public abstract Tip RandomTip();
        public abstract Tip Stringer(string input);
        
    }
}