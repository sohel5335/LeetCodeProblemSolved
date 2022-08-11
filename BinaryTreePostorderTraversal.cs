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
    public IList<int> PostorderTraversal(TreeNode root) 
    {
        List<int> res=new List<int>();
        if(root ==null)
            return res;
        
        
        postOrder( res, root);
      return  res;
    }
    void  postOrder( IList<int> res,TreeNode root)
    {
        if(root.left !=null)
        {
            postOrder(res,root.left);
        }
        if(root.right !=null)
        {
            postOrder(res,root.right);
        }
        res.Add(root.val);
       
    }
}