using System;

namespace Mod_5_2_Dom_z_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            try
            {
                for (int i = 0; i <= array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Выход индекса массива за пределы значений ");
            }
            finally
            {
                Console.WriteLine("Обработка массива завершена");
            }
        }
    }
}
