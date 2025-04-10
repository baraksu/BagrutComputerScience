
using System.Reflection;
using System.Security.Cryptography;
using Unit4.CollectionsLib;

namespace B2024.Q05
{
    public class PriorQueue
    {
        Queue<Patient> q = new Queue<Patient>();

        public PriorQueue()
        {

        }

        public Queue<Patient> GetQ()
        {
            return q;
        }

        public void PriorityInsert(Patient p)
        {
            // בנה תור זמני
            // הכנס לתור כל עוד מתקיים תנאי
            // הכנס פי
            // העבר שאר לתור זמני
            // העבר מזמני לתור
            Queue<Patient> tmp = new Queue<Patient>();

            while (!this.q.IsEmpty() && q.Head().GetPriority() >= p.GetPriority())
            {
                tmp.Insert(q.Remove());
            }
            tmp.Insert(p);
            Copy(q, tmp);
            Copy(tmp, q);

        } 
        public void Update(int id, int pri)
        {
            // Find Patient
            // Remove from Queue
            // Update priority
            /// Insert
            /// 
            Patient p = GetPatient(id);
            p.SetPriority(pri);
            PriorityInsert(p);
        }
        // הסר מהתור והחזר את הפציינק
        public Patient GetPatient(int id)
        {
            // לולאה על התור
            // תור עזר
            // עד שאני מוצא את האובייקט

            Patient p = null;
            Queue<Patient> tmp = new Queue<Patient>();

            while (!this.q.IsEmpty())
            {
                if (q.Head().GetId() == id)
                {
                    p = q.Remove();
                }else
                {
                    tmp.Insert(q.Remove());
                }
                
            }
            Copy(tmp, q);

            return p;
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