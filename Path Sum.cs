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
public class Solution {
    bool flag =false;
    public bool HasPathSum(TreeNode root, int targetSum) 
    {
      if(root is null) return false;
    
        if(root.left is null &&  root.right is null &&  root.val==targetSum)
        {
            return true;
        }
        
        return  HasPathSum( root.left, targetSum-root.val)  ||  HasPathSum( root.right, targetSum-root.val);
        
    }
    
    
  
    
}