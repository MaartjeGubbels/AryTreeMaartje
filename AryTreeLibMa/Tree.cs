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
        public int Count
        {
            get
            {
                if (Root == null)
                    return 0;

                return 1 + Root.DescendantCount();
            }
        }

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

        public TreeNode<T> AddChildNode(T value, TreeNode<T> parentNode)
        {
            TreeNode<T> Node = new TreeNode<T>(value, parentNode);

            if (parentNode != null)
                parentNode.children.Add(Node);
            else
                Root = Node;

            return Node;
        }

        public void RemoveNode(TreeNode<T> node)
        {
            node.parent.children.Remove(node);
        }

        public List<T> TraverseNodes
        {
            get
            {
                if (Root == null)
                    return new List<T>();

                return Root.Values();
            }
        }

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
