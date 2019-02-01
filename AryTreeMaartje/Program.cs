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
            // create 'boom' to add nodes
            Tree<int> boom = new Tree<int>();
            TreeNode<int> root = boom.AddChildNode(2, null);
            TreeNode<int> Hanneke = boom.AddChildNode(4, root);
            TreeNode<int> Marieke = boom.AddChildNode(5, root);
            TreeNode<int> Tijn = boom.AddChildNode(6, Marieke);
            TreeNode<int> Neeltje = boom.AddChildNode(10, Hanneke);
            TreeNode<int> Tijs = boom.AddChildNode(11, Hanneke);

            // remove 'Tijs' from boom
            boom.RemoveNode(Tijs);


            // count leafs, count nodes, show node values, show sum to leafs
            int leafs = boom.LeafCount;
            int aantal = boom.Count;
            List<int> waardes = boom.TraverseNodes;
            List<int> somnaarleaf = boom.SumtoLeafs;


            // display the values of the nodes
            foreach(int val in waardes)
            {Console.WriteLine(val);}

            // display the sum to leafs
            foreach(int som in somnaarleaf)
            { Console.WriteLine(som); }
            Console.ReadLine();
        }
    }
}
