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
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();
        if (root is null)
            return res;
        operation(root, res);
        return res;

    }
    void operation(TreeNode root, IList<int> res)
    {
        if (root.left is not null)
            operation(root.left, res);
        res.Add(root.val);
        if (root.right is not null)
            operation(root.right, res);
    }
}