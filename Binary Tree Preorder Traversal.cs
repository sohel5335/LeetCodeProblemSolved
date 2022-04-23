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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();
        if (root is null)
            return res;
        Operation(root, res);
        return res;
    }
    void Operation(TreeNode root, IList<int> res)
    {
        res.Add(root.val);
        if (root.left is not null)
            Operation(root.left, res);
        if (root.right is not null)
            Operation(root.right, res);
    }
}