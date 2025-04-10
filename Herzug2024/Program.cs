using Herzug2024.Q04;
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace Herzug2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<PriorityItem> q = new Queue<PriorityItem>();

            q.Insert(new PriorityItem(10, 7));
            q.Insert(new PriorityItem(10, 2));
            q.Insert(new PriorityItem(6, 8));

            //Add2PriorityQu(q, new PriorityItem(7, 4));
            Console.WriteLine(q);

             Add2PriorityQu(q, new PriorityItem(10, 5));
            Console.WriteLine(q);

        }
        public static void Add2PriorityQu(Queue<PriorityItem> q, PriorityItem item)
        {
            Queue<PriorityItem> tmp = new Queue<PriorityItem>();
            bool isFound = false;
            while (!q.IsEmpty() && !isFound)
            {
                if ((q.Head().GetPriority() > item.GetPriority()) ||
                        (q.Head().GetPriority() == item.GetPriority() &&
                        q.Head().GetTaskSize() > item.GetTaskSize()))
                {
                    tmp.Insert(q.Remove());
                }
                else
                {
                    isFound = true;
                }
                
            }
            tmp.Insert(item);
            Copy(q, tmp);
            Copy(tmp, q);
            

        }
        public static void Copy<T>(Queue<T> q1, Queue<T> q2)
        {
            while (!q1.IsEmpty())
            {
                q2.Insert(q1.Remove());
            }
        }

    }
}
