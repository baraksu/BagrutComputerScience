using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra;
using Unit4.BinTreeCanvasLib;
using Unit4.CollectionsLib;

namespace B2018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinNode<int> t1 = new BinNode<int>(new BinNode<int>(0), 1, new BinNode<int>(2));
            BinNode<int> t2 = new BinNode<int>(new BinNode<int>(3), 4, new BinNode<int>(5));
            Console.WriteLine("Q06");

            //TreeCanvas.AddTree(t1);
            TreeCanvas.AddTree(t2);
            TreeCanvas.PrintOutAllElements(true);
            TreeCanvas.TreeDrawInOrder();

            Console.WriteLine(TreeLessThanTree(t2, t1));

            Console.ReadKey();

        }

        public static bool TreeLessThanTree(BinNode<int> t2, BinNode<int> t1)
        {
            // כל ערך ב t1  
            // קטן מכל ערך ב t2  

            if (t1 == null)
            {
                return true;
            }
            if (!BinNodeHelper.LessThanTree(t2, t1.GetValue()))
            {
                return false;
            }
            return TreeLessThanTree(t2, t1.GetLeft()) &&
                TreeLessThanTree(t2, t1.GetRight());
        }
    }
}
