using B2024.Q05;
using System;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TemplatesForAnswers;
using Unit4.CollectionsLib;

namespace B2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = {33,0,5,4,0,17,0,4,10,0,5,14 };

            //Console.WriteLine($"The biggest sum is: {BiggestSum(arr)}");

            /*
            Member c1 = new Member() ;
            c1.SetName("c1");
            c1.SetIsCoal(true);
            Member o1 = new Member();
            o1.SetName("O1");
            o1.SetIsCoal(false);

            Member c2 = new Member();
            c2.SetName("C2");
            c2.SetIsCoal(true);

            Committee v1 = new Committee();
            v1.SetName("v1");
            v1.SetMembers(new Member[] { c1, o1 ,c2});
            v1.SetCount(3);

            Committee v2 = new Committee();
            v2.SetName("v2");
            v2.SetMembers(new Member[] { c1,c2 });
            v2.SetCount(2);

            Member o2 = new Member();
            o2.SetName("O2");
            o2.SetIsCoal(false);

            Member c3 = new Member();
            c3.SetName("C3");
            c3.SetIsCoal(true);

            int num = Amount(new Committee[] { v1, v2 }, c3);
            Console.WriteLine($"The amount of committees is: {num}");
            */


            //int[] arr =  { 1,9,3 };
            //int total = Total(arr, 5);
            //Console.WriteLine($"Total is :{total}");

            //int sec = MinTime(arr, 7);
            //Console.WriteLine($"The minimuam time is: {sec}");

            //Queue<int> q = new Queue<int>();
            //q.Insert(5);
            //q.Insert(11);
            //q.Insert(6);
            //q.Insert(9);
            //q.Insert(3);
            //q.Insert(6);
            //q.Insert(3);
            //bool result = IsMagic(q, 2);
            //Console.WriteLine($" is magic:{result}");

            //Queue<int> q = new Queue<int>();
            //q.Insert(2);
            //q.Insert(3);
            //q.Insert(4);
            //q.Insert(2);

            //Queue<int> q2 = new Queue<int>();
            //q2.Insert(2);
            //q2.Insert(3);
            //q2.Insert(4);
            //// RemoveDuplicate(q);
            //QueueTemplate.Print(q);

            //bool b = IsEqual(q, q2);
            //Console.WriteLine(b);
            //Console.ReadKey();

            PriorQueue pq = new PriorQueue();
            Queue<Patient> q = pq.GetQ();
            Patient p1 = new Patient(13893, 7);
            q.Insert(p1);

            q.Insert(new Patient(2888, 7));
            q.Insert(new Patient(72890, 6));
            q.Insert(new Patient(72898, 4));
            q.Insert(new Patient(72899, 4));
            Console.WriteLine(q.ToString());
            Patient p6 = new Patient(11210, 6);
            pq.PriorityInsert(p6);
            
            Console.WriteLine(q.ToString());

            pq.Update(72898, 9);
            Console.WriteLine(q.ToString());

            Console.ReadKey();


        }

        public  static bool IsEqual(Queue<int> q1, Queue<int> q2)
        {
            while (!q1.IsEmpty() && !q2.IsEmpty())
            {
                if (q1.Remove() != q2.Remove())
                {
                    return false;
                }

            }
            
            if (q1.IsEmpty() == false || q2.IsEmpty() == false)
            {
                return false;
            }
            return true;
        }

        public static void RemoveDuplicate(Queue<int> q)
        {
            Queue<int> tmpout = new Queue<int>();
            Queue<int> tmpin = new Queue<int>();
            int x = 0;
            while (!q.IsEmpty())
            {
                x = q.Head();
                tmpout.Insert(q.Remove());
                while (!q.IsEmpty())
                {
                    if (q.Head() == x)
                    {
                        q.Remove();

                    }
                    else
                    {
                        tmpin.Insert(q.Remove());
                    }
                }
                Copy(tmpin, q);
            }
            Copy(tmpout, q);
             
        }
        public static void Copy<T>(Queue<T> q1, Queue<T> q2)
        {
            while (!q1.IsEmpty())
            {
                q2.Insert(q1.Remove());
            }

        }

        private static bool IsMagic(Queue<int> queue, int m)
        {
            Queue<int> tmp = new Queue<int>();
            if (m == 1)
            {
                return false;
            }
            int x = 0, y, z;
            bool isMagic = false;
            int index = 1;
            while (!queue.IsEmpty() && index <= m - 1)
            {
                x = queue.Head();
                tmp.Insert(queue.Remove());
                index++;
            }
            if (!queue.IsEmpty())
            {
                y = queue.Head();
                tmp.Insert(queue.Remove());
                if (!queue.IsEmpty())
                {
                    z = queue.Head();
                    tmp.Insert(queue.Remove());

                    if (x + z == y)
                    {
                        isMagic = true;
                    }
                }
            }
            while (!queue.IsEmpty())
            {
                tmp.Insert(queue.Remove());
            }
            while (!tmp.IsEmpty())
            {
                queue.Insert(tmp.Remove());
            }
            return isMagic;
        }

        private static int MinTime(int[] arr, int amount)
        {
          int sec = 1;
            int total = Total(arr, sec);

            while (total < amount)
            {
                sec++;
                total = Total(arr, sec);
            }
            return sec;
        }

        private static int Total(int[] arr, int numSeconds)
        {
            int num = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                num += numSeconds / arr[i];
            }
            return num;
        }

        public static int Amount(Committee[] arr, Member m)
        {
            // חברי הקואלציה מרובים מחברי האופוזיצה
            // כמות חברי הכנסת קטנה מ 16
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (CanJoinTheCommittee(arr[i], m))
                {
                    count++;
                }

            }
            return count;
        }

        public static bool NMagic(Queue<int> queue, int n)
        {
            int size = Infra.QueueHelper.Size(queue);

            int k = n;
            bool all = true;
            while (k <= size && all)
            {
                if (!IsMagic(queue, k))
                {
                    all = false;
                }
            }
            return all;

        }
        private static bool CanJoinTheCommittee(Committee committee, Member member)
        {
            // אם יש מקום;
            if (committee.GetCount() >= 3)
                return false;

            if (member.GetIsCoal())
            {
                return true;
            }
            if (member.GetIsCoal() == false)
            {
                int col = committee.Total(true);
                int opp = committee.GetCount() - col;
                
                if (col > opp + 1)
                {
                    return true;
                }
                return false;
            }
            return true;
        }

        public static int BiggestSum(int[] arr)
        {
            int maxSum = -1;
            int sum = 0;

            int index = 0;
            while (arr[index] != 0)
            {
                index++;
            }
            index++;

            for (int i = index; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                    sum = 0;
                }
                else
                {
                    sum += arr[i];
                }
            }
            return maxSum;
        }
    }
}
