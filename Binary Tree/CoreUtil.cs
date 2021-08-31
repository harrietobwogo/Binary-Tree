using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    public class CoreUtil
    {
        public static int HeightOfBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftH = HeightOfBinaryTree(root.left);
            int rightH = HeightOfBinaryTree(root.right);
            return Math.Max(leftH, rightH) + 1;

        }

        public static int NumberofNodesInBinaryTreeIterative(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            Queue<TreeNode> levels = new Queue<TreeNode>();
            levels.Enqueue(root);
            int count = 0;
            while (levels.Count > 0)
            {
                TreeNode temp = levels.Dequeue();
                count++;
                if (temp.left != null)
                {
                    levels.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    levels.Enqueue(temp.right);
                }
            }
            return count;
        }

        public static int NumberOfNodesInBinaryTreeRecursive(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftH = NumberOfNodesInBinaryTreeRecursive(root.left);
            int rightH = NumberOfNodesInBinaryTreeRecursive(root.right);
            return (leftH + rightH) + 1;
        }

        public static int NumberOfLeafNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            Queue<TreeNode> levels = new Queue<TreeNode>();
            levels.Enqueue(root);
            int count = 0;
            while (levels.Count != 0)
            {
                TreeNode node = levels.Dequeue();
                if (node.left == null && node.right == null)
                {
                    count++;
                }
                if (node.left != null)
                {
                    levels.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    levels.Enqueue(node.right);
                }
            }
            return count;
        }
        public static int LeafNodes(TreeNode root)
        {

            if (root == null)
            {
                return 0;
            }
            if (root.left == null && root.right == null)
            {
                return 1;
            }
            int leftH = LeafNodes(root.left);
            int rightH = LeafNodes(root.right);
            return (leftH + rightH);
        }


    }
}
