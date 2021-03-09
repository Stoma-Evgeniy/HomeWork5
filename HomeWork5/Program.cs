using System;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,-2,-3,-4,5,6,7,-8 };
            int last = 0;
            int id =-1;
            int i;
            
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    last = nums[i];
                    id = i;
                }

            }
            Console.WriteLine(last);
            Console.WriteLine(id);

            // 

            int[,] nums2 =
            {
                { 1, -2, -3, -4, 5, 6, 7, -8 },
                { 9, 10, 11, 12, -13, -14, -15, -16 },
            };

            int max = 0;
            int x, y;
            for (x = 0; x <= nums2.GetUpperBound(0); x++)
            {
                for (y = 0; y <= nums2.GetUpperBound(1); y++)
                {
                    if (nums2[x, y] > max)
                    {
                        max = nums2[x, y];
                    }
                }
                bool isMaxFound = false;
                for(y = 0; y <= nums2.GetUpperBound(1); y++)
                {
                    if (isMaxFound == true)
                        Console.Write(0 + " ");
                    else Console.Write(nums2[x, y] + " ");
                    if (nums2[x,y] == max)
                    {
                        isMaxFound = true;
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
