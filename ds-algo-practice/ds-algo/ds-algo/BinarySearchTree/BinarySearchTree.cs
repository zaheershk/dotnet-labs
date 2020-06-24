using System;
using System.Collections.Generic;
using System.Text;

namespace ds_algo.BinarySearchTree
{
    public class BinarySearchTree
    {
        public BinaryTreeNode Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int i)
        {
            BinaryTreeNode newNode = new BinaryTreeNode
            {
                Data = i
            };

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                BinaryTreeNode current = Root;
                while (true)
                {
                    BinaryTreeNode parent = current;
                    if (i < Root.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }        
    }
}
