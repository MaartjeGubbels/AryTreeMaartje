using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AryTreeMaartje
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public TreeNode<T> parent { get; set; }
        public List<TreeNode<T>> children { get; set; }

        public TreeNode(T value, TreeNode<T> Parent)
        {
            Value = value;
            parent = Parent;
            children = new List<TreeNode<T>>();
        }

        public int DescendantCount()
        {
            int count = children.Count;
            foreach (TreeNode<T> child in children)
            {
                count += child.DescendantCount();
            }
            return count;
        }

        public int LeafCount()
        {
            if (children.Count == 0)
                return 1;                

            int leafCount = 0;
            foreach (TreeNode<T> child in children)
            {
                leafCount += child.LeafCount();
            }
            return leafCount;
        }


        public List<T> Values()
        {
            List<T> TraverseList = new List<T>();
            TraverseList.Add(Value);

            foreach (TreeNode<T> child in children)
            {
                foreach (T var in child.Values())
                {
                    TraverseList.Add(var);
                }
            }

            return TraverseList;
        }

        public List<TreeNode<T>> Descendants()
        {
            List<TreeNode<T>> DescList = new List<TreeNode<T>>();
            DescList.Add(this);

            foreach (TreeNode<T> child in children)
            {
                foreach (TreeNode<T> var in child.Descendants())
                {
                    DescList.Add(var);
                }
            }

            return DescList;
        }

        public T SumToRoot()
        {
            dynamic sum = Value;
            if(parent != null)
            {
                sum = sum + parent.SumToRoot();
            }
            return sum;
        }

        public dynamic SumToLeafs()
        {
            List<T> SumToLeafs = new List<T>();
            foreach(TreeNode<T> node in Descendants())
            {
                if(node.children.Count == 0)
                {
                    SumToLeafs.Add(node.SumToRoot());
                }
                //node.SumToLeafs();
            }
            return SumToLeafs;
        }

        //public IEnumerator<T> CreateEnumerator()
        //{
        //foreach (TreeNode<T> child in children)
        //{
        //    yield return child.Value;
        //  }
        //}

        //public IEnumerator<T> GetEnumerator()
        //{
        //  return CreateEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //  return (IEnumerator) GetEnumerator();
        //}
    }
}
