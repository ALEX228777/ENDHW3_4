using System;
using System.Diagnostics;
namespace Task3_1
{
	public class One_dimension<Tip> : ArraysParent<Tip>
	{
        private Tip[] array;
        public One_dimension(bool randi, ChoseTip<Tip> Tp) : base(randi, Tp)
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
        

        protected override void Fill_array()
        {
            Console.WriteLine();
            Console.WriteLine("Длина массива");

            int length = int.Parse(Console.ReadLine());

            array = new Tip[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива:");

                 array[i] = Tip1.Stringer(Console.ReadLine());

                Console.WriteLine();
            }
            Console.WriteLine();

        }

        protected override void Fill_array_random()
        {
            Random random = new Random();
            array = new Tip[4];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Tip1.RandomTip();
                            
            }
            Console.WriteLine();
        }




        public override void Print()
        {
            Console.WriteLine("Одномер");
            Console.WriteLine("Начальный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
        }
    }
}


