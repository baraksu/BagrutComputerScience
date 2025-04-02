using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2024_271_Sample.Q02;
using Infra;
using Unit4.BinTreeCanvasLib;
using Unit4.CollectionsLib;


namespace B2024_271_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////--- q1 ---------

            /*Queue<int> q1 = new Queue<int>();
            q1.Insert(5);
            q1.Insert(4);
            q1.Insert(1);
            q1.Insert(4);
            q1.Insert(3);
            q1.Insert(15);
            q1.Insert(9);

            QueueHelper.Print(q1);
            int x = 10;
            bool result = TwoSum(q1, x);
            Console.WriteLine($"Is {x} in q1? {result}");*/
            /*
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
             Console.WriteLine($"order {4} is {orderedList.ValueN(4)}");
             Console.WriteLine($"order {2} is {orderedList.ValueN(2)}");
            */

            //--- q3 ---------
            //BinNode<int> tr = new BinNode<int>(24);
            //AddNodes(tr);
            //TreeCanvas.AddTree(tr);
            //TreeCanvas.TreeDrawPreOrder();
            BinNode<int> tr = new BinNode<int>(150);
            What(tr);
            TreeCanvas.AddTree(tr);
            TreeCanvas.TreeDrawPreOrder();


            Console.ReadKey();

        }
        // טענת כניסה: תור המכיל לפחות שני איברים ומספר שלם
        // טענת יציאה הפונקציה תחזיר אם קיימים שני מספרים שסכומם כפרמטר איקס
        public static bool TwoSum(Queue<int> q, int x)
        {
            int n = q.Size();
            for (int i = 0; i < n -1; i++)
            {
                int firstValue = q.Remove();
                for (int j = i + 1; j < n; j++)
                {
                    int secondValue = q.Remove();
                    if (firstValue + secondValue == x)
                    {
                        Console.WriteLine($"{firstValue} + {secondValue} = {x}");
                        return true;
                    }
                    q.Insert(secondValue);
                }
            }
            return false;
        }
        public static bool AddNodes(BinNode<int> tr)
        {
            if (tr == null)
                return false;
            if (Helper.IsPrime(tr.GetValue()))
            {
                return false;
            }
            for (int i = 2; i < tr.GetValue(); i += 1)
            {
                if (tr.GetValue() % i == 0)
                {
                    tr.SetLeft(new BinNode<int>(i));
                    tr.SetRight(new BinNode<int>(tr.GetValue() / i));
                    return true;
                }
            }
            return false;

        }
        public static void What(BinNode<int> tr)
        {
            if (AddNodes(tr))
            {
                What(tr.GetLeft());
                What(tr.GetRight());
            }

        }
    }
}
