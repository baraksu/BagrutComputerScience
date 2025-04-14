using B2024.Q05;
using System;
using Unit4.CollectionsLib;

namespace TemplatesForAnswers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient(1, 200);
            Patient patient2 = new Patient(2, 200);
            Patient patient3 = new Patient(3, 200);
            Patient patient4 = new Patient(4, 200);

            Node<Patient> node1 = new Node<Patient>(patient1);
            Node<Patient> newNode = new Node<Patient>(patient2);
            Node<Patient> node3 = new Node<Patient>(patient3);
            Node<Patient> node4 = new Node<Patient>(patient4);

            Node<Patient> lst;
            lst = node1;

            lst.SetNext(node3);

            Node<Patient> current = lst;
            Node<Patient> pre = null;
            //1->3
            while (current != null && current.GetValue().GetId() < 2)
            {
                pre = current;
                current = current.GetNext();
            }
            if (pre == null)
            {// הכנסת איבר ראשון
                newNode.SetNext(lst);
                lst = newNode;
            }
            else
            {// הכנס בין pre l current
                pre.SetNext(newNode);
                newNode.SetNext(current);
            }
            // return lst;
            NodeTemplateT.Print(lst);


            Node<Patient> current;
            Node<Patient> pre;
            Node<Patient> lst;
            //1->2->3
            while (current != null && current.GetValue().GetId() <= 2)
            {
                pre = current;
                current = current.GetNext();
            }
            if (current !=null)
            {
                if (pre == null)
                {
                    lst = current.GetNext();
                }
                else
                {
                    pre.SetNext(current.GetNext());
                }
            }



            // חיבור בהתחלה
            // חיבור באמצע
            // חיבור בסוף
            // הורדה מהאמצע
            // הורדה מההתחלה
            // הורדה מהסוף



            Console.ReadKey();

        }
    }
}
