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
            Console.WriteLine("-- Q02 --");
            OrderedList orderedList = new OrderedList();
            NodeHelper.Print(orderedList.GetLst());
            orderedList.InsertNum(5);
            NodeHelper.Print(orderedList.GetLst());
            orderedList.InsertNum(4);
            NodeHelper.Print(orderedList.GetLst());
            orderedList.InsertNum(6);
            NodeHelper.Print(orderedList.GetLst());
            orderedList.InsertNum(4);
            NodeHelper.Print(orderedList.GetLst());
            orderedList.InsertNum(2);
            NodeHelper.Print(orderedList.GetLst());
            orderedList.InsertNum(2);
            orderedList.InsertNum(6);
            NodeHelper.Print(orderedList.GetLst());
            

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

