using System;
namespace Task3_1
{
	public class Two_dimension<Tip> : ArraysParent<Tip>
	{
        private Tip[,] array;
        public Two_dimension(bool randi, ChoseTip<Tip> Tp) : base(randi, Tp)
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
            Console.WriteLine("Количество столбцов");
            int columns = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество строк");
            int rows = int.Parse(Console.ReadLine());
            array = new Tip[rows, columns];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элемент массива:");

                    array[i, j] = Tip1.Stringer(Console.ReadLine());

                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        protected override void Fill_array_random()
        {
            Random random1 = new Random();
            int rows = random1.Next(3, 10);
            int columns = rows;
            array = new Tip[rows, columns];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Tip1.RandomTip();
                }
            }
            Console.WriteLine();
        }

        
        public override void Print()
        {
            Console.WriteLine("Двумерный массив");
            Console.WriteLine("Начальный массив:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
  

   
            Console.WriteLine();
        }

    }
}