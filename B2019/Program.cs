using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace B2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Insert(6);
            q.Insert(9);
            q.Insert(1);
            Console.WriteLine(ToNumber(q));
        }

        public static int ToNumber(Queue<int> q)
        {
            int result = 0;
            int mekadem = 1;

            while (!q.IsEmpty())
            {

                result += q.Remove() * mekadem;
                mekadem = mekadem * 10;
            }
            return result;
        }
    }
}
