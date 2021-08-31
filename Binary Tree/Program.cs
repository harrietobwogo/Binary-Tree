using System;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            //TraversalUtil.PreOrderTraversal(root);
            //Console.WriteLine();
            //TraversalUtil.PreorderTraversalIterative(root);
            //Console.WriteLine();
            //TraversalUtil.InOrderTraversal(root);
            //Console.WriteLine();
            //TraversalUtil.InorderTraversalIterative(root);
            //Console.WriteLine();
            //TraversalUtil.PostOrderTraversal(root);
            //Console.WriteLine();
            //TraversalUtil.PostorderTraversalIterative(root);
            //Console.WriteLine();
            //TraversalUtil.LevelOrderTraversal(root);
            //Console.WriteLine();
            TraversalUtil.SpiralLevelOrderTraversal(root);
            Console.WriteLine();

            int height=CoreUtil.HeightOfBinaryTree(root);
            Console.WriteLine(height);
            int nodes = CoreUtil.NumberofNodesInBinaryTreeIterative(root);
            Console.WriteLine(nodes);
            int numNodes = CoreUtil.NumberOfNodesInBinaryTreeRecursive(root);
            Console.WriteLine(numNodes);
            int leafNodes = CoreUtil.NumberOfLeafNodes(root);
            Console.WriteLine(leafNodes);
            Console.WriteLine(CoreUtil.LeafNodes(root));
        }
    }
}
