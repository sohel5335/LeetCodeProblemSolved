/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution
{
    public Node CopyRandomList(Node head)
    {
        if (head is null)
            return head;

        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        Node cur = head;

        while (cur is not null)
        {
            Node Copy = new Node(cur.val);
            map.Add(cur, Copy);
            cur = cur.next;
        }
        cur = head;
        while (cur is not null)
        {
            Node Copy = map[cur];
            Copy.next = (cur.next == null ? null : map[cur.next]);
            Copy.random = (cur.random == null ? null : map[cur.random]);
            cur = cur.next;
        }
        return map[head];

    }
}