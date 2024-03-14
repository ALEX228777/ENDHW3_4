using System;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool randi = false;
            Console.WriteLine("Ввод мвссивов с клавиатуры?");
            if(Console.ReadLine() == "Да")
            {
                randi = true;
            }

            IntValueProvider inti = new IntValueProvider();
            Bool booli = new Bool();
            DoubleValueProvider doublei = new DoubleValueProvider();
            StringValueProvider stringi = new StringValueProvider();

            IPrint[] arrayprint = new IPrint[8];
            arrayprint[0] = new One_dimension<int>(randi, inti);
            arrayprint[1] = new One_dimension<string>(randi, stringi);
            arrayprint[2] = new One_dimension<double>(randi, doublei);
            arrayprint[3] = new One_dimension<bool>(randi, booli);
            arrayprint[4] = new Two_dimension<int>(randi, inti);
            arrayprint[5] = new Two_dimension<string>(randi, stringi);
            arrayprint[6] = new Two_dimension<double>(randi, doublei);
            arrayprint[7] = new Two_dimension<bool>(randi, booli);

            foreach (IPrint i in arrayprint)
            {
                i.Print();
                Console.WriteLine();
            }

        }
    }
}
