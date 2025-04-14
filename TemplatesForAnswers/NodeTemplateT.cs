using Unit4.CollectionsLib;

namespace TemplatesForAnswers
{
    public class NodeTemplateT
    {
        public static void Print<T>(Node<T> node)
        {
            while (node != null)
            {
                System.Console.Write($"[{node}]");
                node = node.GetNext();
            }
        }
    }
}