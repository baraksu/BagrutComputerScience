using Unit4.CollectionsLib;

namespace TemplatesForAnswers
{
    public class NodeTemplatesInt
    {
        public static void PrintNode(Node<int> node)
        {
            while(node != null)
            {
                System.Console.Write(node.GetValue() + " ");
                node = node.GetNext();
            }
        }
        // הכנסת איבר למקום
        public static Node<int> InsertNum(Node<int> lst, int x)
        {
            Node<int> newNode = new Node<int>(x);
            Node<int> current = lst;
            Node<int> prev = null;
            Node<int> result = lst;
            while (current != null && current.GetValue() < x)
            {
                prev = current;
                current = current.GetNext();
            }
            if (prev == null)
            {
                newNode.SetNext(lst);
                result = newNode;
            }
            else
            {
                prev.SetNext(newNode);
                newNode.SetNext(current);
            }
            return result;
        }
        public static void DeleteNum(Node<int> lst, int x)
        {
            Node<int> current = lst;
            Node<int> prev = null;
            while (current != null && current.GetValue() != x)
            {
                prev = current;
                current = current.GetNext();
            }
            if (current != null)
            {
                if (prev == null)
                {
                    lst = current.GetNext();
                }
                else
                {
                    prev.SetNext(current.GetNext());
                }
            }
        }

    }
}