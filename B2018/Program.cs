using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra;
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
            Console.WriteLine(TreeLessThanTree(t1, t2));

            Console.ReadKey();

        }

        public static bool TreeLessThanTree(BinNode<int> t1, BinNode<int> t2)
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
            return TreeLessThanTree(t1.GetLeft(), t2) &&
                TreeLessThanTree(t1.GetRight(), t2);
        }
    }
}
