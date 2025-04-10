using Infra;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Unit4.CollectionsLib;

namespace B2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // להכניס איבר לתור
            // בטוח שהאיבר לא חלק מתור
            //  ידוע לי מספר האיברים


        }

        public static bool TwoSum(Queue<int> q, int x)
        {
            int a;
            int b;
            for (int i = 0; i < q.Size(); i++)
            {
                a = q.Remove();
                for (int j = i + 1; j < q.Size(); j++)
                {
                    b = q.Remove();
                    if (a + b == x)
                        return true;
                    q.Insert(b);
                }
            }
            return false;
        }
    }
}

