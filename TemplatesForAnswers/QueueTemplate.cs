using System;
using Unit4.CollectionsLib;

namespace TemplatesForAnswers
{
    public class QueueTemplate
    {
        
        public static void Insert(Queue<NumCount> q, int x)
        {
            Queue<NumCount> temp = new Queue<NumCount>();
            while (!q.IsEmpty() && q.Head().GetNum() < x)
            {
                temp.Insert(q.Remove());
            }// אם נמצא האיבר
            if (!q.IsEmpty() && q.Head().GetNum() == x)
            {
                NumCount nc = q.Remove();
                nc.SetCount(nc.GetCount() + 1);
                temp.Insert(nc);
            }
            else// אם לא נמצא האיבר
            {
                temp.Insert(new NumCount(x, 1));
            }// ריקון התור
            while (!q.IsEmpty())
            {
                temp.Insert(q.Remove());
            }// החזרת האיברים לתור
            while (!temp.IsEmpty())
            {
                q.Insert(temp.Remove());
            }
        }
        public static void Print<T>(Queue<T> q)
        {
            Queue<T> tmp = new Queue<T>();
            while (!q.IsEmpty())
            {
                tmp.Insert(q.Head());
                Console.WriteLine(q.Remove());
            }
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