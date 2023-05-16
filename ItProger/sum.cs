using System;

namespace ItProger
{
    class sum
    {

        public static void Main()
        {
            int sum = 0;
            int ost = 0;
            int ost2 = 0;
            for (int i = 0; i < 1001; i++)
            {
                ost = (i % 3);
                ost2 = (i % 5);
                if (ost == 0 || ost2 == 0)
                {
                    sum = sum + i;
                }

            }
            Console.WriteLine(sum);
        }
    }
};
