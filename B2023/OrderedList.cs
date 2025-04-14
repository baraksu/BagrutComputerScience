using Unit4.CollectionsLib;

namespace B2023
{
    public class OrderedList
    {
        private Node<NumCount> lst;

        public Node<NumCount> GetLst()
        {
            return this.lst;
        }
        public void InsertNum(int x)
        {
            Node<NumCount> current = this.lst;
            Node<NumCount> prev = null;

            while (current != null && current.GetValue().GetNum() < x)
            {
                prev = current;
                current = current.GetNext();
            }

            if (current != null && current.GetValue().GetNum() == x)
            {
                current.GetValue().SetCount(current.GetValue().GetCount() + 1);
                return;
            }

            if (prev == null)
            {
                this.lst = new Node<NumCount>(new NumCount(x, 1), lst);
            }
            else
            {
                    Node<NumCount> newNode = new Node<NumCount>(new NumCount(x, 1));
                    prev.SetNext(newNode);
                    newNode.SetNext(current);
            }
        }

        public int ValueN(int n)
        {
            int count = 0;
            Node<NumCount> p = lst;
            while (count < n && p != null)
            {
                count += p.GetValue().GetCount();
                if (count >= n)
                {
                    return p.GetValue().GetNum();
                }
                p = p.GetNext();
            }
            return -1;
        }
    }
}