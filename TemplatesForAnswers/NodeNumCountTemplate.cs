using System.Xml.Linq;
using Unit4.CollectionsLib;

namespace TemplatesForAnswers
{
    public class NodeNumCountTemplate
    {
        // הוספת המספר למקום ברשימה
        public static Node<NumCount> InsertNum(Node<NumCount> lst, int x)
        {
            Node<NumCount> result = lst;
            Node<NumCount> newNode = new Node<NumCount>(new NumCount(x,1));
            Node<NumCount> current = lst;
            Node<NumCount> prev = null;
            while (current != null && current.GetValue().GetNum() < x)
            {
                prev = current;
                current = current.GetNext();
            }
            if (prev == null)
            {
                newNode.SetNext(lst);
                result = newNode;
            }
            else // הוספת איבר
            {
                prev.SetNext(newNode);
                newNode.SetNext(current);
            }
            return result;
        }
        // מחיקת המספר מהרשימה
        public static Node<NumCount> DeleteNum(Node<NumCount> lst, int x)
        {
            Node<NumCount> result = lst;
            Node<NumCount> current = lst;
            Node<NumCount> prev = null;
            while (current != null && current.GetValue().GetNum() != x)
            {
                prev = current;
                current = current.GetNext();
            }
            if (current != null)
            {
                if (prev == null)
                {
                    result = current.GetNext();
                }
                else
                {
                    prev.SetNext(current.GetNext());
                }
            }
            return result;
        }
    }
}