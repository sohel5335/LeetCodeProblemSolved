using System;

namespace DoublyLinkedLilst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            myDoubleLinkedList doubleLinkedList = new myDoubleLinkedList();
            doubleLinkedList.addHead(1);
            doubleLinkedList.addTail(2);
            doubleLinkedList.addTail(4);
            doubleLinkedList.AddInsertAt(2, 3);
            doubleLinkedList.Delete(2);
            doubleLinkedList.Gets();
        }
    }

    class myDoubleLinkedList
    {
        Node head;

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
        public void Gets()
        {
            Node cur = head;
            while(cur is not null)
            {
                Console.WriteLine(cur.val);
                cur = cur.next;
            }
        }
        public void addHead(int val)
        {
            Node cur = new Node(val);
            cur.next = head;
            if(head is not null)
            head.prev = cur;
            head = cur;
        }
        public void addTail(int val)
        {
            Node cur = head;
            while(cur != null && cur.next !=null)
            {
                cur = cur.next;
            }
            Node newNode = new Node(val);
            newNode.prev = cur;
            cur.next = newNode;
        }

        public void Delete(int index)
        {
            var prev = GetNode(index - 1);
            prev.next = prev.next.next;
            prev.next.prev = prev;

        }

        public void AddInsertAt(int index,int val)
        {
            var prev=GetNode(index - 1);
            var next = prev.next;
            Node newNode = new Node(val);
            prev.next = newNode;
            newNode.prev = prev;
            newNode.next = next;
            next.prev = newNode;
        }

    }

    class Node
    {
        public Node prev;
        public Node next;
        public int val;
        public Node(int val)
        {
            this.val = val;
        }

    }
}
