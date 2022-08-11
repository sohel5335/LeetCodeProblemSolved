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
1..public class Solution {
    int ans;
    public int MaxDepth(TreeNode root) {
        ans=1;
        if (root is null)
            return 0;
        preOrder ( root,ans);
        return ans;
    }
    
    public void preOrder (TreeNode root,int depth)
    {
        if(root is null)
            return ;  
        if(root.left is null &&  root.right is null )
        ans= Math.Max(ans,depth);
        
        preOrder(root.left,depth+1);
        preOrder(root.right,depth+1);
    }
}
2..
public class Solution {
 
    public int MaxDepth(TreeNode root) {
       
        return postOrder(root);
    }
    
    public int  postOrder (TreeNode root)
    {
        if(root is null)
            return 0;
        int leftDepth=postOrder(root.left);
        int rightDepth=postOrder(root.right);
        
        return Math.Max(leftDepth,rightDepth)+1;
        
    }
}
