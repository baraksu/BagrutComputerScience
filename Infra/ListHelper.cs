using System;
using Unit4.CollectionsLib;

namespace Infra
{
    public class ListHelper
    {
        //ומסירה ממנו את כל האיברים שערכם הוא המספר הנוסף שהתקבל כפרמטר // (Node) פעולה המקבלת רשימה
        //    הפעולה מחזירה רשימה )חוליה ראשונה(. מכיון שיש סיכוי שהאיבר שהוצא הוא האיבר הראשון ברשימה. //
        public static Node<int> RemoveAll(Node<int> lst, int num)
        {
            Node<int> pos = new Node<int>(0, lst); // משתנה עזר המכיל את המיקום התורן ברשימה
                                                   //לנוחיותנו נוסיף לרשימה חוליית "דמה" לפני החוליה הראשונה //
            lst = pos;
            while (pos.GetNext() != null)
            {
                if (pos.GetNext().GetValue() == num) // אם מצאנו חוליה שיש להסיר
                    pos.SetNext(pos.GetNext().GetNext()); // pos נסיר את האיבר, אחרי החוליה
                else
                    pos = pos.GetNext(); // נתקדם לבדוק את החוליה הבאה
            }
            return lst.GetNext(); // . נחזיר את האיבר השני ברשימה
            //שזו הרשימה ללא איבר ה"דמה" שהוספנו בהתחלה //
        }
        public static Node<int> Delete(Node<int> lst, int num)
        {
            if (lst == null)
                return null;
            if (lst.GetValue() == num)
                return lst.GetNext();
            Node<int> prev = lst;
            Node<int> pos = lst.GetNext();

            while (pos != null)
            {
                if (pos.GetValue() == num)
                {
                    prev.SetNext(pos.GetNext());
                    return lst;
                }
                prev = pos;
                pos = pos.GetNext();
            }
            return lst;
        }


        public static Node<T> AddAtEnd<T>(Node<T> lst, T value)
        {
            if (lst == null)
            {
                return new Node<T>(value, null);
            }
            Node<T> pos = lst;
            while (pos.GetNext() != null)
            {
                pos = pos.GetNext();
            }
            pos.SetNext(new Node<T>(value, null));
            return lst;
        }
        public static Node<T> AddAtStart<T>(Node<T> lst, T value)
        {
            return new Node<T>(value, lst);
        }

        public static int Max(Node<int> lst)
        {
            if (lst == null)
                return int.MinValue;
            int max = lst.GetValue();
            Node<int> pos = lst.GetNext();
            while (pos != null)
            {
                if (pos.GetValue() > max)
                    max = pos.GetValue();
                pos = pos.GetNext();
            }
            return max;
        }

        public static int Min(Node<int> lst)
        {
            if (lst == null)
                return int.MaxValue;
            int min = lst.GetValue();
            Node<int> pos = lst.GetNext();
            while (pos != null)
            {
                if (pos.GetValue() < min)
                    min = pos.GetValue();
                pos = pos.GetNext();
            }
            return min;
        }
        public static void Print<T>(Node<T> lst)
        {
            Node<T> p = lst;
            while (p != null)
            {
                Console.Write(p.GetValue() + " ");
                p = p.GetNext();
            }

        }

        public static int Size(Node<int> lst)
        {
            int count = 0;
            Node<int> pos = lst;
            while (pos != null)
            {
                count++;
                pos = pos.GetNext();
            }
            return count;
        }
    }

}