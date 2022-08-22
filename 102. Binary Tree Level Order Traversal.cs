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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> resList = new List<IList<int>>();
        Queue<TreeNode> fifo = new Queue<TreeNode>();
        if (root != null)
            fifo.Enqueue(root);

        while (fifo.Count > 0)
        {
            IList<int> tmpList = new List<int>();

            int len = fifo.Count;
            for (int i = 0; i < len; i++)
            {
                TreeNode curNode = fifo.Peek();
                tmpList.Add(curNode.val);
                if (curNode.left != null)
                    fifo.Enqueue(curNode.left);
                if (curNode.right != null)
                    fifo.Enqueue(curNode.right);

                fifo.Dequeue();
            }
            resList.Add(tmpList);
        }
        return resList;
    }
}