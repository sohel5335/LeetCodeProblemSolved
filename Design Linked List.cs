public class MyLinkedList
{
    private Node head;
    int count = 0;



    public Node GetNode(int index)
    {

        Node tmp = head;
        int i = 0;
        while (tmp is not null)
        {
            if (i == index)
            {
                return tmp;
            }
            tmp = tmp.next;
            i++;
        }

        return null;
    }


    public void AddAtIndex(int index, int val)
    {
        if (index == 0)
            AddAtHead(val);
        else
        {
            var prev = GetNode(index - 1);
            if (prev is not null)
            {
                var next = prev.next;
                Node cur = new Node(val);
                prev.next = cur;
                cur.next = next;
            }
        }


    }

    public MyLinkedList()
    {

    }

    public int Get(int index)
    {
        var cur = GetNode(index);
        return cur is null ? -1 : cur.val;
    }


    public void Gets()
    {
        Node tmp = head;
        while (tmp is not null)
        {
            Console.WriteLine(tmp.val);
            tmp = tmp.next;
        }
    }
    public void AddAtTail(int val)
    {
        Node tmp = head;
        Node cur = new Node(val);
        if (head is null)
        {
            head = cur;
        }
        else
        {
            while (tmp.next is not null)
            {
                tmp = tmp.next;
            }
            tmp.next = cur;
        }

    }
    public void AddAtHead(int val)
    {
        Node cur = new Node(val);
        cur.next = head;
        head = cur;
    }

    public void DeleteAtIndex(int index)
    {
        if (index == 0)
        {
            head = head.next;
        }
        else
        {
            var prev = GetNode(index - 1);
            if (prev is not null)
            {
                if (prev.next is null)
                {
                    prev.next = null;

                }
                else
                {
                    prev.next = prev.next.next;
                }
            }


        }

    }
}


public class Node
{
    public int val = 0;
    public Node next;

    public Node(int val = 0)
    {
        this.val = val;
    }
}