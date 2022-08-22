/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        
        IList<int> res = new List<int>();
        
        Stack<Node> lifo = new Stack<Node>();
        if(root !=null)
            lifo.Push(root);
        
        while(lifo.Count>0)
        {
            Node curr =lifo.Pop();
            res.Add(curr.val);
             for(int i=curr.children.Count-1;i>=0;i--)
             {
                lifo.Push(curr.children[i]);
             }
            
        }
        
        return res;
    }
}