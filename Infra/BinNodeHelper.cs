using Unit4.CollectionsLib;

namespace Infra
{
    public class BinNodeHelper
    {
        public static bool LessThanTree(BinNode<int> root, int val)
        {
            if (root == null)
            {
                return true;
            }
            if (root.GetValue() <= val)
            {
                return false;
            }
            return LessThanTree(root.GetLeft(), val) &&
                LessThanTree(root.GetRight(), val);
        }

    }
}