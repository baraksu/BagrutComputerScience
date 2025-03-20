using System.Xml;
using Unit4.CollectionsLib;

namespace B2022.Q04
{
    public class Q04
    {
        public static bool IsIncluded(Node<int> numList, Node<Range> rangeList)
        {
            int num;
            Range range;
            Node<int> numPointer = numList;
            Node<Range> rangePointer = rangeList;


            while (numPointer != null && rangePointer != null)
            {
                num = numPointer.GetValue();
                range = rangePointer.GetValue();

                if (num >= range.GetLow() && num <= range.GetHigh())
                {
                    numPointer = numPointer.GetNext();
                }
                else
                {
                    if (num > range.GetHigh())
                    {
                        rangePointer = rangePointer.GetNext();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return (numPointer == null);
            
        }
    }
}