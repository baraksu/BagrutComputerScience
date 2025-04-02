using System;
using System.Collections;
using System.Collections.Generic;
using Unit4.CollectionsLib;

namespace Infra
{
    public static class Helper
    {
        public static void Print(IEnumerable arr)
        {
            string arrAsString = String.Join(", ", arr);
            Console.WriteLine("{" + arrAsString + "}");
        }
        public static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}