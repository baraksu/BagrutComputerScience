using Unit4.CollectionsLib;

namespace B2024_271_Sample.Q02
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
            Node<NumCount> p = new Node<NumCount>(new NumCount(-1,1), lst);
            Node<NumCount> lstTemp = p;

            while (p.GetNext() != null && p.GetNext().GetValue().GetNum() < x)
            {
                p = p.GetNext();
            }
            if (p.GetNext() != null && p.GetNext().GetValue().GetNum() == x)
            {
                NumCount v = p.GetNext().GetValue();
                v.SetCount(v.GetCount() + 1);
            }
            else
            {
                NumCount v = new NumCount(x, 1);
                Node<NumCount> nextNode = new Node<NumCount>(v, p.GetNext());
                p.SetNext(nextNode);
            }
            lst = lstTemp.GetNext();

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