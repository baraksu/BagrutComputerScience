using System;
using Unit4.CollectionsLib;

namespace Infra
{
    public static class QueueHelper
    {
        
        public static Queue<T> Clone<T>(Queue<T> queue)
        {
            Queue<T> tmp1 = new Queue<T>();
            Queue<T> tmp2 = new Queue<T>();

            while (!queue.IsEmpty())
            {
                T item = queue.Remove();
                tmp1.Insert(item);
                tmp2.Insert(item);
            }
            while (!tmp1.IsEmpty())
            {
                queue.Insert(tmp1.Remove());
            }
            return tmp2;
        }
        public static int Size<T>(this Queue<T> queue)
        {
            Queue<T> tmp1 = new Queue<T>();
            int num = 0;
            while (!queue.IsEmpty())
            {
                tmp1.Insert(queue.Remove());
                num++;
            }
            while (!tmp1.IsEmpty())
            {
                queue.Insert(tmp1.Remove());
            }
            return num;
        }

        public static void Print<T>(Queue<T> q)
        {
            Console.WriteLine("-- q --");
            Queue<T> tmp = new Queue<T>();
            while (!q.IsEmpty())
            {
                T item = q.Remove();
                Console.WriteLine(item);
                tmp.Insert(item);
            }
            while (!tmp.IsEmpty())
            {
                q.Insert(tmp.Remove());
            }
        }
    }
}