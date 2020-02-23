using System;

namespace SortThreeNumbers
{
    public static class SortNumbers
    {
        private static int one = 0;
        private static int two = 0;
        private static int three = 0;
        public static void ShowTitle()
        {
            Console.WriteLine("\n\t\t\tSort Numbers\n");
        }
        public static void SetNumber()
        {
            Console.Write("\tFirst number:\t");
            one = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tFirst number:\t");
            two = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tFirst number:\t");
            three = Convert.ToInt32(Console.ReadLine());
        }

        public static void SortNumber()
        {
            if(one > two && one > three)
            {
                if (three > two)
                {
                    Console.Write($"\n\t\t{two}, {three}, {one}");
                }
                else
                {
                    Console.Write($"\n\t\t{three}, {two}, {one}");
                }
            }
            else if(two > one && two > three)
            {
                if(one > three)
                {
                    Console.Write($"\n\t\t{three}, {one}, {two}");
                }
                else
                {
                    Console.Write($"\n\t\t{one}, {three}, {two}");
                }
            }
            else if(one > two)
            {
                Console.Write($"\n\t\t{two}, {one}, {three}");
            }
        }
    }
}