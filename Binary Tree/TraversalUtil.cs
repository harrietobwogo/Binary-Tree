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
    }
}
