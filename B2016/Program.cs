using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.BinTreeCanvasLib;
using Unit4.CollectionsLib;

namespace B2016
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var t1 = new BinNode<int>(
                null,
                1,
                new BinNode<int>(
                    new BinNode<int>(
                        new BinNode<int>(
                            null,
                            19,
                            null),
                        17,
                        null),
                    2,
                    null));

            TreeCanvas.AddTree(t1);
            TreeCanvas.PrintOutAllElements(true);
            TreeCanvas.TreeDrawInOrder();
            Console.WriteLine("\n Q02");
            Console.WriteLine(UpPath(t1));
        }

        public static bool UpPath(BinNode<int> t)
        {
            if (t == null)
                return true;

            if (t.GetLeft() != null &&
                t.GetValue() < t.GetLeft().GetValue())
                return UpPath(t.GetLeft());
            if (t.GetRight() != null &&
                t.GetValue() < t.GetRight().GetValue())
                return UpPath(t.GetRight());
            if (t.GetLeft() == null && t.GetRight() == null)
                return true;
            return false;
        }
    }
}