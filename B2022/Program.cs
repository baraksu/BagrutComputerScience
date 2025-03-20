using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, -4, 4, 9, 2 };
            int[] arr2 = { 9,2,0,-1,3,11,23 };


            int[] result = Multiple(arr1, arr2);
            Console.WriteLine("---Q01---");
            Infra.Helper.PrintArray(arr1);
            Infra.Helper.PrintArray(arr2);
            Infra.Helper.PrintArray(result);

            Console.ReadKey();
        }
        public static int[] Multiple(int[] arr1, int[] arr2)
        {
            int[] smallArr = arr1;
            int[] bigArr = arr2;
            

            if (arr1.Length > arr2.Length)
            {
                smallArr = arr2;
                bigArr = arr1;
            }
            int m = bigArr.Length;
            int k = smallArr.Length;

            int[] result = new int[bigArr.Length];

            for (int i = 0; i < smallArr.Length; i++)
            {
                result[i] = smallArr[i] * bigArr[i];
            }
            for (int i = smallArr.Length; i < bigArr.Length; i++)
            {
                result[i] = bigArr[i];
            }
            return result;
        }
    }
}
