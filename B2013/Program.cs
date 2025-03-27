using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.BinTreeCanvasLib;
using Unit4.CollectionsLib;

namespace B2013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BinNode<int> t = new BinNode<int>(
            //    new BinNode<int>(
            //        new BinNode<int>(null,4,null),
            //        7,
            //        new BinNode<int>(null,6,null)),
            //    5,
            //    new BinNode<int>(null,3,null));

            //amir(t, 0);

            //TreeCanvas.AddTree(t);
            //TreeCanvas.PrintOutAllElements(true);
            //TreeCanvas.TreeDrawPreOrder();

            var t = new BinNode<int>(
                    null,
                    4,
                    new BinNode<int>(null, 4, 
                    new BinNode<int> (null,4,null)));
                
            TreeCanvas.AddTree(t);
            TreeCanvas.PrintOutAllElements(true);
            TreeCanvas.TreeDrawInOrder();

            Console.ReadKey();
        }

        public static void amir(BinNode<int> t, int x)
        {
            if (t != null)
            {
                amir(t.GetLeft(), x+1);
                if (t.GetLeft() == null && t.GetRight() == null)
                {
                    t.SetValue(x);
                }
                amir(t.GetRight(), x + 1);
            }
        }
    }
}