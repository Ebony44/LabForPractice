using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.LabForNumericOrder
{
    class Balanced_Binary_Tree_110
    {
        /*
         * 
         * 
         * Given a binary tree, determine if it is height-balanced.

            For this problem, a height-balanced binary tree is defined as:
            
                a binary tree in which the left and right subtrees of every node differ in height by no more than 1.
            3
        9       20
        x x     15  7
            
                    Input: root = [3,9,20,null,null,15,7]
            Output: true
            
                1
            2       2
        3       3   x   x
        44
            
                    Input: root = [1,2,2,3,3,null,null,4,4]
            Output: false
            
                    Example 3:
            
            Input: root = []
            Output: true
            
            
        
        [3,9,20,4,null,null,7,2,3,null,null,null,null,4]
                3
            9       20
        4   x       x 7
        23              4
        -> false

        [3,9,20,1,null,null,1]
                 3
            9       20
        1   x       x   1
        -> true
        [3,9,20,1,null,null,null]
        ->true
        
        [3,9,null,1]
        ->false
        [3,9,20,1,null,null,null]
        3
        9   20
        1x  xx
            

        [3,9,20,1,2,3,4,1,4,1,null,null,null,null,null]
                 3
            9       20
        1   2       3   4
        14  1x      xx  xx
        -> true
        [3,9,20,1,2,3,4,1,4,1,null,null,null,null,null,1]
        ->false

            Constraints:
            
                The number of nodes in the tree is in the range [0, 5000].
                -104 <= Node.val <= 104


         */

        /**
 * Definition for a binary tree node.
 public class TreeNode {
 public int val;
 public TreeNode left;
 public TreeNode right;
 public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 this.val = val;
 this.left = left;
 this.right = right;
 }
 }
 */
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public bool IsBalanced(TreeNode root)
        {
            TreeNode tempNode = new TreeNode();
            var bIsBalanced = true;

            // 0 -> 0, true
            // 1 -> 1
            // 22 -> 3, -> 2n, 3n
            // 3333 -> 7 -> 
            // 1
            // 2, 3
            // 4,5 , 6,7
            // 8,9,10,11 , 12,13,14,15
            // 4444 4444 -> 15

            // 1,3,6,12,24,48,...
            // 1,3,7,15,31,63,...

            // check leftside deepest and rightside deepest

            bool bIsLeft = false;
            bool bIsRight = false;

            // var left = SearchDepth(root.left);
            // var right = SearchDepth(root.right);


            return bIsBalanced;
        }
        public int SearchDepth(TreeNode root)
        {
            var depth = 0;
            if(root == null)
            {
                return 0;
            }
            var left = SearchDepth(root.left);
            var right = SearchDepth(root.right);
            int x = left - right;
            if(x > 1)
            {
                return -1;
            }
            if(left>right)
            {
                return 1 + left;
            }
            else
            {
                return 1 + right;
            }
            return depth;
        }

        public void TestNodeCreateSecond(TreeNode root, int value)
        {
            //TreeNode tempNode = new TreeNode(i);
            //if (root.left == null)
            //{
            //    AddNode(root, tempNode, null);
            //}
            //else if (root.right == null)
            //{
            //    AddNode(root, null, tempNode);
            //}
            TreeNode tempNode = new TreeNode();
            int tempInt = value - 1;
            
            if(value >= 0)
            {
                return;
            }
            TestNodeCreateSecond(tempNode, tempInt + 1);
            
        }

        public void TestNodeCreate(TreeNode root, int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                TreeNode tempNode = new TreeNode(i);
                if(root.left == null)
                {
                    AddNode(root, tempNode, null);
                }
                else if(root.right == null)
                {
                    AddNode(root, null, tempNode);
                }
            }
        }

        public void AddNode(TreeNode root, TreeNode left = null, TreeNode right = null)
        {
            if (left != null)
            {
                root.left = left;
            }
            if (right != null)
            {
                root.right = right;
            }
        }
    }
}
