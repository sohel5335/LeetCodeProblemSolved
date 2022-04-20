/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution
{
    public Node Flatten(Node head)
    {
        Node fast = head;
        Node slow = head;
        Stack<Node> stack = new Stack<Node>();
        while (fast != null)
        {

            if (fast.child is not null)
            {
                Node child = fast.child;
                if (fast.next is not null)
                {
                    stack.Push(fast.next);
                    fast.next.prev = null;
                }
                fast.next = child;
                child.prev = fast;
                fast.child = null;

            }
            slow = fast;
            fast = fast.next;

        }
        while (stack.Count > 0)
        {
            fast = stack.Pop();
            slow.next = fast;
            fast.prev = slow;
            while (fast != null)
            {
                slow = fast;
                fast = fast.next;
            }
        }

        return head;
    }
}