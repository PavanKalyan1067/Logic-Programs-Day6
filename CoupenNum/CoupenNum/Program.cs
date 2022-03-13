using System;
using System.Collections;
using System.Collections.Generic;

namespace coupencode
{
    public class CoupenGenerate
    {
    public static void Main(String[] args)
        {
            int distinct = 0, count = 0;
            Console.WriteLine("Enter a number of given distinct coupons:");
            int couponNo = Convert.ToInt32(Console.ReadLine());
            bool[] isCollected = new bool[couponNo];
            while (distinct < couponNo)
            {
                Random random = new Random();
                int newCoupon = (int)(random.NextDouble() * couponNo);
                count++;
                if (!isCollected[newCoupon])
                {
                    distinct++;
                    isCollected[newCoupon] = true;
                }
            }

            Console.WriteLine("Total random number needed to have all distinct coupons:" + count);
        }
    }
}