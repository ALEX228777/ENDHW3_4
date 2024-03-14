using System;

namespace Task3_1
{
    public class DoubleValueProvider :ChoseTip<double>
    {
        public override double RandomTip()
        {
            return random.NextDouble();
        }

        public override double Stringer(string input)
        {
            return double.Parse(input);
        }
    }
}