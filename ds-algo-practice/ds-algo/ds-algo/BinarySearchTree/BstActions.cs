using System;
using System.Collections.Generic;
using System.Text;

namespace ds_algo.BinarySearchTree
{
    public static class BstActions
    {
        public static BinarySearchTree Initialize()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(50);
            bst.Insert(17);
            bst.Insert(23);
            bst.Insert(12);
            bst.Insert(19);
            bst.Insert(54);
            bst.Insert(9);
            bst.Insert(14);
            bst.Insert(67);
            bst.Insert(76);

            return bst;
        }

        public static void PreorderTraversal(this BinaryTreeNode root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                PreorderTraversal(root.Left);
                PreorderTraversal(root.Right);
            }
        }

        public static void InorderTraversal(this BinaryTreeNode root)
        {
            if (root != null)
            {
                InorderTraversal(root.Left);
                Console.Write(root.Data + " ");
                InorderTraversal(root.Right);
            }
        }

        public static void PostorderTraversal(this BinaryTreeNode root)
        {
            if (root != null)
            {
                PostorderTraversal(root.Left);
                PostorderTraversal(root.Right);
                Console.Write(root.Data + " ");
            }
        }

        public static void BreadthFirstTraversal(this BinaryTreeNode node)
        {
            Queue<BinaryTreeNode> btNodeQueue = new Queue<BinaryTreeNode>();
            btNodeQueue.Enqueue(node);

            while (btNodeQueue.Count > 0)
            {
                node = btNodeQueue.Dequeue();
                Console.Write(node.Data + " ");

                if (node.Left != null)
                {
                    btNodeQueue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    btNodeQueue.Enqueue(node.Right);
                }
            }
        }

        public static void DepthFirstTraversal(this BinaryTreeNode node)
        {
            if (node == null)
                return;

            Console.Write(node.Data + " ");
            DepthFirstTraversal(node.Left);
            DepthFirstTraversal(node.Right);
        }
    }
}
