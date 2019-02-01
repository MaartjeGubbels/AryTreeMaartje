using System;
using System.Collections.Generic;
using AryTreeMaartje;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestingTreeM
{

    [TestFixture]
    public class TestAryTree
    {
        [TestCase]
        public void Testing_AddChildNode()
        {
            // arrange
            Tree<int> boom = new Tree<int>();

            //act
            TreeNode<int> root = boom.AddChildNode(2, null);
            TreeNode<int> Hanneke = boom.AddChildNode(4, root);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(Hanneke.parent.Value == 2);
                Assert.Contains(Hanneke, boom.Root.children);
            });
        }

        [TestCase]
        public void Testing_LeafCount()
        {
            // arrange
            Tree<int> boom = new Tree<int>();

            //act
            TreeNode<int> root = boom.AddChildNode(2, null);
            TreeNode<int> Hanneke = boom.AddChildNode(4, root);
            TreeNode<int> Marieke = boom.AddChildNode(5, root);
            int leafs = boom.LeafCount;

            // Assert
            Assert.That(leafs == 2);

            
        }

        [TestCase]
        public void Testing_Count()
        {
            // arrange
            Tree<int> boom = new Tree<int>();

            //act
            TreeNode<int> root = boom.AddChildNode(2, null);
            TreeNode<int> Hanneke = boom.AddChildNode(4, root);
            TreeNode<int> Marieke = boom.AddChildNode(5, root);
            int aantal = boom.Count;

            // Assert
            Assert.That(aantal == 3);
        }


        [TestCase]
        public void Testing_TraverseNodes()
        {
            // arrange
            Tree<string> boom = new Tree<string>();

            // act
            TreeNode<string> root = boom.AddChildNode("Oma", null);
            TreeNode<string> Hanneke = boom.AddChildNode("Hanneke", root);
            TreeNode<string> Marieke = boom.AddChildNode("Marieke", root);
            List<string> waardes = boom.TraverseNodes;

            var checklist = new List<string> { "Oma", "Hanneke", "Marieke" };

            // Assert
            Assert.That(waardes.SequenceEqual(checklist));


        }

        [TestCase]
        public void Testing_SumToLeaf()
        {
            // arrange
            Tree<double> boom = new Tree<double>();

            // act
            TreeNode<double> root = boom.AddChildNode(2.0, null);
            TreeNode<double> Hanneke = boom.AddChildNode(3.3, root);
            List<double> somnaarleaf = boom.SumtoLeafs;

            // Assert
            Assert.That(somnaarleaf[0] == 5.3);


        }

    }


}
