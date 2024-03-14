namespace Task3_1
{
    public class IntValueProvider : ChoseTip<int>
    {
        public override int RandomTip()
        {
            return random.Next(-200, 200);
        }

        public override int Stringer(string input)
        {
            return int.Parse(input);
        }
    }
}