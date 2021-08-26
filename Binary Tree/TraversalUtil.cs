using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
   public static class TraversalUtil
    {
        //Root-->Left-->Right
       public static void PreOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write($"{root.data} ");
            PreOrderTraversal(root.left);
            PreOrderTraversal(root.right);

        }

        //Left-->Root-->Right
        public static void InOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            InOrderTraversal(root.left);
            Console.Write($"{root.data} ");
            InOrderTraversal(root.right);
        }

        //Left-->Right-->Root
        public static void PostOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            PostOrderTraversal(root.left);
            PostOrderTraversal(root.right);
            Console.Write($"{root.data} ");
        }

        public static void LevelOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Queue<TreeNode> levels = new Queue<TreeNode>();
            levels.Enqueue(root);
            while (levels.Count != 0)
            {
                TreeNode current = levels.Dequeue();
                Console.Write(current.data+" ");
                if (current.left != null)
                {
                    levels.Enqueue(current.left);
                }
                if (current.right != null)
                {
                    levels.Enqueue(current.right);
                }
            }
        }

        public static void InorderTraversalIterative(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode node = root;
            while (node!=null || stack.Count > 0)
            {
                if (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }
                else
                {
                    node = stack.Pop();
                    Console.Write(node.data+ " ");
                    node = node.right;
                }

            }
        }

        public static void PreorderTraversalIterative(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode node = root;
            while(node!=null|| stack.Count > 0)
            {
                if (node != null)
                {
                    Console.Write(node.data+ " ");
                    stack.Push(node);
                    node = node.left;
                }
                else
                {
                    node = stack.Pop();
                    node = node.right; 
                }
            }
        }
        public static void PostorderTraversalIterative(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            Stack<TreeNode> output = new Stack<TreeNode>();
            TreeNode node = root;
            while(node!=null|| stack.Count > 0)
            {
                if (node != null)
                {
                    output.Push(node);
                    stack.Push(node);
                    node = node.right;
                }
                else
                {
                    node = stack.Pop();
                    node = node.left;
                }
            }
            while (output.Count > 0)
            {
                TreeNode element = output.Pop();
                Console.Write(element.data+ " ");
            }
        }
    }
}
