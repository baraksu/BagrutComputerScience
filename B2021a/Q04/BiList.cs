using System.ComponentModel;
using Infra;
using Unit4.CollectionsLib;

namespace B2021a.Q04
{
    public class BiList
    {

        private Node<int> lst1;

        public Node<int> GetLst1()
        {
            return this.lst1;
        }
        public void SetLst1(Node<int> lst1)
        {
            this.lst1 = lst1;
        }

        private Node<int> lst2;

        public Node<int> GetLst2()
        {
            return this.lst2;
        }
        public void SetLst2(Node<int> lst2)
        {
            this.lst2 = lst2;
        }

        public void AddNum(int num, int codeList)
        {
            if (codeList == 1)
            {
                lst1 = ListHelper.AddAtEnd(lst1, num);
                //lst1 = ListHelper.AddAtStart(lst1, num);
            }
            else if (codeList == 2)
            {
                lst2 = ListHelper.AddAtEnd(lst2, num);
            }

        }
    }
}