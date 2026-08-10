W06 Interview Video Script – Binary Search Trees
Introduction (10–15 seconds)

Hello everyone. My name is Faith. In this video, I'll explain how I would use a recursive function to determine whether a valid Binary Tree is also a Binary Search Tree. I'll explain how the recursive function checks each node and maintains the correct range of values.

Question: Determining if a Binary Tree is a Binary Search Tree (About 2½ minutes)

A Binary Search Tree, or BST, is a Binary Tree where all the values in the left subtree are less than the current node, and all the values in the right subtree are greater than the current node.

To determine if a Binary Tree is a Binary Search Tree, I would use a recursive function that checks each node and keeps track of the minimum and maximum values that the node is allowed to have.

The function could take three parameters: the current node, a minimum value, and a maximum value.

The first step is to check the base case. If the current node is null, that means we have reached the end of that branch. There are no more values to check, so we return true.

Next, we check whether the current node's value is within the allowed range. If the value is less than or equal to the minimum, or greater than or equal to the maximum, then the tree does not follow the rules of a Binary Search Tree. In that case, we return false.

If the current node is valid, we then recursively check the left subtree and the right subtree.

When checking the left subtree, the maximum value becomes the current node's value because every value on the left must be smaller than the current node.

When checking the right subtree, the minimum value becomes the current node's value because every value on the right must be greater than the current node.

For example, suppose the root node has a value of 10. The values in the left subtree must be less than 10, while the values in the right subtree must be greater than 10.

If we have a left child with a value of 5, that is valid because 5 is less than 10. However, if somewhere inside that left subtree we find a value of 12, the function will identify a problem. Even though 12 might be greater than its immediate parent, it is still greater than the root value of 10, so it does not belong in the left subtree. The function would therefore return false.

This minimum and maximum range is important because we cannot simply compare a node with its immediate parent. We need to make sure that the node follows the rules of the entire subtree.

The recursive function continues this process until every node has been checked. If every node is within its correct range, the function returns true, which means the Binary Tree is a valid Binary Search Tree.

The time complexity is O(n) because we visit each node once. The space complexity is O(h) because recursion uses the call stack, where h represents the height of the tree.

Conclusion (10–15 seconds)

In summary, I would use recursion to check whether every node in a Binary Tree follows the rules of a Binary Search Tree. The function checks each node against a minimum and maximum allowed value and then recursively checks its left and right subtrees. If all nodes are valid, it returns true; otherwise, it returns false. This gives us an efficient O(n) solution. Thank you for watching.

Quick Memory Tips

Binary Search Tree Rules

Left subtree values are less than the current node.
Right subtree values are greater than the current node.
Every node must follow the rules of the entire subtree.

Recursive Function

Check if node is null → return true
Check if value is outside the allowed range → return false
Recursively check the left subtree
Recursively check the right subtree

Remember the Range

Left → update the maximum
Right → update the minimum
Example: Root 10 → left must be < 10, right must be > 10

Complexity

Time: O(n)
Space: O(h)

Key Idea

Check every node and make sure its value stays within the correct minimum and maximum range.