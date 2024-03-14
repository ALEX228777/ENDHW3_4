using System;
namespace Task3_1
{
	public abstract class ArraysParent<Tip> : IPrint, IArraysParent
	{
		protected ChoseTip<Tip> Tip1;
		public ArraysParent(bool randi, ChoseTip<Tip> Tp)
        {
            Tip1 = Tp;
            Createarray(randi);
        }
		public void Createarray(bool randi)
        {
            if (randi)
            {
                Fill_array();
            }
            else
            {
                Fill_array_random();
            }
        }
		public abstract  void Print();
	

		protected abstract void Fill_array();
		protected abstract void Fill_array_random();


    }
	
}

