using System;



namespace inputOneDementionMassive
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод элементов массива в строку
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            string[] temp = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(temp[i]);
            }
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
