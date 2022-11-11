using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.GfGReferences
{
    class TreeTraversal
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node(int item)
            {
                this.data = item;
                left = null;
                right = null;
            }





        }

        public class BreadthFirstTraversal_1 // time complexity is O(n^2), aux space is O(N)
        {

            // Root of the Binary Tree
            public Node root;

            public void BinaryTree() { root = null; }

            /* function to print level order
               traversal of tree*/
            public virtual void printLevelOrder()
            {
                int h = height(root);
                int i;
                for (i = 1; i <= h; i++)
                {
                    printCurrentLevel(root, i);
                }
            }

            /* Compute the "height" of a tree --
            the number of nodes along the longest
            path from the root node down to the
            farthest leaf node.*/
            public virtual int height(Node root)
            {
                if (root == null)
                {
                    return 0;
                }
                else
                {
                    /* compute height of each subtree */
                    int lheight = height(root.left);
                    int rheight = height(root.right);

                    /* use the larger one */
                    if (lheight > rheight)
                    {
                        return (lheight + 1);
                    }
                    else
                    {
                        return (rheight + 1);
                    }
                }
            }

            /* Print nodes at the current level */
            public virtual void printCurrentLevel(Node root,
                                                  int level)
            {
                if (root == null)
                {
                    return;
                }
                if (level == 1)
                {
                    Console.Write(root.data + " ");
                }
                else if (level > 1)
                {
                    printCurrentLevel(root.left, level - 1);
                    printCurrentLevel(root.right, level - 1);
                }
            }

        }

        public class BreadthFirstTraversal_2
        {
            Node root;

            /* Given a binary tree. Print
            its nodes in level order using
             array for implementing queue */
            void printLevelOrder()
            {
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(root);
                while (queue.Count != 0)
                {

                    Node tempNode = queue.Dequeue();
                    Console.Write(tempNode.data + " ");

                    /*Enqueue left child */
                    if (tempNode.left != null)
                    {
                        queue.Enqueue(tempNode.left);
                    }

                    /*Enqueue right child */
                    if (tempNode.right != null)
                    {
                        queue.Enqueue(tempNode.right);
                    }
                }
            }




        }

    }
}
