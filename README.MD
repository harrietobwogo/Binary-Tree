##Binnary Tree Traversal
> A C# implementation

>A binary tree is an ordered tree in each every vertex has no more than two children, and each child is either designated as a left child or a right child of its parent vertex.

>Tree traversal (also known as tree search and walking the tree) is a form of graph traversal and refers to the process of visiting (checking and/or updating) each node in a tree data structure, exactly once. 

> Therefore, when we traverse through a tree, what we’re really trying to do is **walk through the tree without ever repeating ourselves.**

### Program.cs

>Main entry point for the code. Runner for TravesalUtils utility methods.

## TraversalUtil.cs
>Trees may be traversed in multiple ways.

- Depth-first
- Breadth-first

![Image of Traversal types](https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Sorted_binary_tree_ALL_RGB.svg/1024px-Sorted_binary_tree_ALL_RGB.svg.png)

**Image illustrates**

> *Traversal of an ordered binary tree with keys **A,B,C,D,E,F,G,H,I**. (**3** nodes with **2** children, *1 node* with *1 left*, *1 node* with *1 right*, and *4 nodes* without child.) Access to node in preorder position only (red, ) yields the sequence F-B-A-D-C-E-G-I-H; in inorder position only (green, ) yields the sequence A-B-C-D-E-F-G-H-I; in postorder position only (blue, ) yields the sequence A-C-E-D-B-H-I-G-F.*

###[Depth-first search of binary tree](https://github.com/samuelowino/Binary-Tree/blob/master/Binary%20Tree/TraversalUtil.cs)
> These searches are referred to as **depth-first search (DFS)**, since the search tree is deepened as much as possible on each child before going to the next sibling

The general recursive pattern for traversing a binary tree is this:

1. Go down one level to the recursive argument N. If N exists (is non-empty) execute the following three operations in a certain order:

> **L**: Recursively traverse N's left subtree.
> **R**: Recursively traverse N's right subtree.
> **N**: Access (visit) the current node N itself. 

2. Return by going up one level and arriving at the parent node of N.

###[Pre-order, NLR](https://github.com/samuelowino/Binary-Tree/blob/cdc6fbb5113029ffdfa3663523b46cf8c131e8fd/Binary%20Tree/TraversalUtil.cs#L10)
1. Access the data part of the current node (in the figure: position red).

2. Traverse the left subtree by recursively calling the pre-order function.

3. Traverse the right subtree by recursively calling the pre-order function.

```

if (root == null){
    return;
}

Console.Write($"{root.data} ");
PreOrderTraversal(root.left);
PreOrderTraversal(root.right);

```

The pre-order traversal is a **topologically sorted one**, because a parent node is processed before any of its child nodes is done.

###[Post-order, LRN](https://github.com/samuelowino/Binary-Tree/blob/cdc6fbb5113029ffdfa3663523b46cf8c131e8fd/Binary%20Tree/TraversalUtil.cs#L35)
1.Traverse the left subtree by recursively calling the post-order function.

2.Traverse the right subtree by recursively calling the post-order function.

3.Access the data part of the current node (in the figure: position blue).

```
if (root == null){
    return;
}

Stack<TreeNode> stack = new Stack<TreeNode>();
Stack<TreeNode> output = new Stack<TreeNode>();
TreeNode node = root;

while(node!=null|| stack.Count > 0){
    if (node != null){
        output.Push(node);
        stack.Push(node);
        node = node.right;
    }
    else{
        node = stack.Pop();
        node = node.left;
    }
}

while (output.Count > 0){
    TreeNode element = output.Pop();
    Console.Write(element.data+ " ");
}

```

###[In-order, LNR](https://github.com/samuelowino/Binary-Tree/blob/cdc6fbb5113029ffdfa3663523b46cf8c131e8fd/Binary%20Tree/TraversalUtil.cs#L23)
1.Traverse the left subtree by recursively calling the in-order function.

2.Access the data part of the current node (in the figure: position green).

3.Traverse the right subtree by recursively calling the in-order function.

```

if (root == null){
    return;
}

InOrderTraversal(root.left);
Console.Write($"{root.data} ");
InOrderTraversal(root.right);

```


