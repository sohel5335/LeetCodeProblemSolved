/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{

    public bool IsSymmetric(TreeNode root)
    {

        return checkSymmetric(root, root);
    }

    public bool checkSymmetric(TreeNode leftNode, TreeNode rightNode)
    {
        if (leftNode is null && rightNode is null)
        {

            return true;
        }
        else if (leftNode is null || rightNode is null)
        {
            return false;
        }
        else if ((leftNode.val != rightNode.val))
        {

            return false;
        }
        return checkSymmetric(leftNode.left, rightNode.right) && checkSymmetric(leftNode.right, rightNode.left);
    }
}