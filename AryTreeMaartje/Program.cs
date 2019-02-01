using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AryTreeMaartje
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> boom = new Tree<int>();
            TreeNode<int> root = boom.AddChildNode(2, null);
            TreeNode<int> Hanneke = boom.AddChildNode(4, root);
            TreeNode<int> Marieke = boom.AddChildNode(5, root);
            TreeNode<int> Tijn = boom.AddChildNode(6, Marieke);
            TreeNode<int> Neeltje = boom.AddChildNode(10, Hanneke);
            TreeNode<int> Tijs = boom.AddChildNode(11, Hanneke);


            int leafs = boom.LeafCount;
            int aantal = boom.Count;
            List<int> waardes = boom.TraverseNodes;
            List<int> somnaarleaf = boom.SumtoLeafs;

            foreach(int val in waardes)
            {Console.WriteLine(val);}

            foreach(int som in somnaarleaf)
            { Console.WriteLine(som); }
            Console.ReadLine();
        }
    }
}
