using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AryTreeMaartje
{
    public class Tree<T>
    {
        // receive property value Count (counting the number of nodes)
        public int Count
        {
            get
            {
                if (Root == null)
                    return 0;

                return 1 + Root.DescendantCount();
            }
        }

        // receive property value LeafCount

        public int LeafCount
        {
            get
            {
                if (Root == null)
                    return 0;

                return Root.LeafCount();
            }
        }

        public TreeNode<T> Root = null;

        // create method to add child node
        public TreeNode<T> AddChildNode(T value, TreeNode<T> parentNode)
        {
            TreeNode<T> Node = new TreeNode<T>(value, parentNode);

            if (parentNode != null)
                parentNode.children.Add(Node);
            else
                Root = Node;

            return Node;
        }

        // create method to remove nodes
        public void RemoveNode(TreeNode<T> node)
        {
            node.parent.children.Remove(node);
        }

        // Create list with the values of the nodes
        public List<T> TraverseNodes
        {
            get
            {
                if (Root == null)
                    return new List<T>();

                return Root.Values();
            }
        }

        // Create List with the sum to leafs
        public List<T> SumtoLeafs
        {
            get
            {
                if (Root == null)
                    return new List<T>();

                return Root.SumToLeafs();
            }
        }

    }
}
