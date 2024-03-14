namespace  Task3_1{

    public class Bool : ChoseTip<bool>
    {
        public override bool RandomTip()
        {
            if (random.Next(0, 1) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Stringer(string input)
        {
            return bool.Parse(input);
        }
    }
}