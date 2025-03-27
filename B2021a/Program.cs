﻿using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using B2021a.Q02;
using B2021a.Q04;
using B2021a.Q3;
using Infra;
using Unit4.CollectionsLib;

namespace B2021a
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* //Q4
             Node<int> lst = new Node<int>
                 (88, new Node<int>
                 (-9, new Node<int>
                 (0, new Node<int>
                 (10, new Node<int>
                 (6, new Node<int>
                 (13, null))))));

             Console.WriteLine("\n Print b2021 Q04 lst ");
             ListHelper.Print(lst);
             BiList biList = GenerateBiList(lst);
             Console.WriteLine("\n Print b2021 Q04 lst big");
             ListHelper.Print(biList.GetLst1());
             Console.WriteLine("\n Print b2021 Q04 lst smalls");
             ListHelper.Print(biList.GetLst2());
             Console.WriteLine("\n End Q04");
             Console.ReadKey();*/

            /*Node<int> lst = new Node<int>
            (5, new Node<int>
            (1, new Node<int>
            (2, new Node<int>
            (8, new Node<int>
            (4, null)))));
            Console.WriteLine("\n Print b2021 Q05 lst ");
            ListHelper.Print(lst);
            Node<int> newLst = Move(lst, 3);
            Console.WriteLine("\n Print b2021 Q05 new lst ");
            ListHelper.Print(newLst);
            Console.WriteLine("\n End Q05");
            Console.ReadKey();*/

            Queue<int> q1 = new Queue<int>();
            q1.Insert(1);
            q1.Insert(2);
            
            Queue<int> q2 = new Queue<int>();
            q2.Insert(1);
            q2.Insert(2);
            Console.WriteLine("\n Print b2021 Q07 q1 ");
            bool same = IsIdentical(q1, q2);
            Console.WriteLine($"q1:q2= {same}");
            q2.Insert(q2.Remove());
            bool rotate = IsSimilar(q1, q2);
            Console.WriteLine($"q1:q2= {rotate}");

            Console.ReadKey();


        }
        //Q1
        // דגשים
        // להשתמש בפעולת עזר
        // טענת כניסה וטענת יציאה
        // טענה כניסה מסבירה מהם הפרמטרים של הפונקציה, המערך אינו ריק וקיים לפחות אחד שווה ואחד שאינו שווה
        // : פעולת יציאה מסבירה את תוצאות הפעולה הפעולה מחזירה מערך חדש ללא המספר בפרמטר
        public static int[] Filter(int[] arr, int num)
        {
            var counter = GetFilterArraySize(arr, num);
            int[] newArr = new int[counter];
            int counter2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != num)
                {
                    newArr[counter2] = arr[i];
                    counter2++;
                }
            }
            return newArr;
        }
        //טענת כניסה, מערך לא ריק , מספר שלם
    // טענת יציאה מחזיר מספר אברים במערך שאינם שווים ל נאם

        private static int GetFilterArraySize(int[] arr, int num)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != num)
                {
                    counter++;
                }
            }

            return counter;
        }

        // בודק פעולה על חיצונית ועל אובייקט
        public static void PrintExcellent(ReportCard[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].IsExcellent())
                {
                    Console.WriteLine(arr[i].GetStuName());
                }
            }
        }

        public static MyString Special(MyString ms)
        {
            MyString newSpecial = new MyString();

            while (!ms.IsEmpty())
            {
                char ch = ms.FirstChar();
                int counter = ms.CounterChar(ch);
                ms.RemoveChar(ch);

                for (int i = 0; i < counter; i++)
                {
                    newSpecial.AppendChar(ch);
                }
            }
            return newSpecial;
        }
        public static BiList GenerateBiList (Node<int> lst)
        {
            BiList biList = new BiList();
            Node<int> pos = lst;
            int num = 0;
            while (pos!= null)
            {
                num = ListHelper.Max(pos);
                pos = ListHelper.Delete(pos, num);
                biList.AddNum(num,1);

                num = ListHelper.Min(pos);
                pos = ListHelper.Delete(pos, num);
                biList.AddNum(num, 2);

            }
            return biList;
        }

        public static Node<int> Move (Node<int> lst, int n)
        {
            int size = ListHelper.Size(lst);

            // 5 חוליות
            // העבר 2
            // השאר 3

            int k = size - n - 1 ;
            Node<int> pos = lst;
            while (k> 0)
            {
                pos = pos.GetNext();
                k--;
            }
            Node<int> newLst = pos.GetNext();
            pos.SetNext(null);

            pos = newLst;
            while(pos.GetNext() != null)
            {
                pos = pos.GetNext();
            }
            pos.SetNext(lst);

            return newLst;

        }

        public static bool IsIdentical (Queue<int> q1, Queue<int> q2)
        {
            if (Infra.Helper.Size(q1) != Infra.Helper.Size(q2))
            {
                return false;
            }
            bool identical = true;
            Queue<int> temp1 = new Queue<int>();
            Queue<int> temp2 = new Queue<int>();
            while (!q1.IsEmpty())
            {
                if (q1.Head() != q2.Head())
                {
                    identical = false;
                }
                temp1.Insert(q1.Remove());
                temp2.Insert(q2.Remove());
            }
            while (!temp1.IsEmpty())
            {
                q1.Insert(temp1.Remove());
                q2.Insert(temp2.Remove());
            }
            return identical;
        }

        public static bool IsSimilar (Queue<int> q1, Queue<int> q2)
        {
            int size1 = Infra.Helper.Size(q1);
            int size2 = Infra.Helper.Size(q2);
            if (size1 != size2)
            {
                return false;
            }
            for (int i = 0; i < size1; i++)
            {
                if (IsIdentical(q1, q2))
                {
                    return true;
                }
                q1.Insert(q1.Remove());
            }
            return false;

        }
    }

}
