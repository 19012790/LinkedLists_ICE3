using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists_ICE3
{
    class Single
    {
        internal Node head;
    }
    internal int data;
    internal Node next;


    public Node(int d)
    {
        data = d;
        next = null;
    }
}
internal class HelperSLL
{
    internal SingleLinkedList CreateLinkList()
    {
        SingleLinkedList llist = new SingleLinkedList();

        llist.head = new Node(1);
        Node second = new Node(2);
        Node third = new Node(3);

        llist.head.next = second;
        second.next = third;

        return llist;
    }
    #region Insert_into_SinglyLinkedList
    internal void InsertFront(SingleLinkedList singlyList, int new_data)
    {
        Node new_node = new Node(new_data);
        new_node.next = singlyList.head;

        singlyList.head = new_node;
    }
    internal void InsertAfter(Node prev_node, int new_data)
    {
        if (prev_node == null)
        {
            Console.WriteLine("no null");
            return;
        }
        Node new_node = new Node(new_data);

        new_node.next = prev_node.next;
        prev_node.next = new_node;
    }
    internal void InsertLast(SingleLinkedList singlyList, int new_data)
    {
        Node new_node = new Node(new_data);

        if (singlyList.head == null)
        {
            singlyList.head = new_node;
            return;
        }
        Node lastNode = GetLastNode(singlyList);

        lastNode.next = new_node;
    }

    #endregion Insert_into_SinglyLinkedList

    internal Node GetLastNode(SingleLinkedList singlyList)
    {
        Node temp = singlyList.head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        return temp;

    }

    internal void DeleteNodebyKey(SingleLinkedList singlyList, int key)
    {
        Node temp = singlyList.head;
        Node prev = null;

        if (temp != null && temp.data == key)
        {
            singlyList.head = temp.next;
            return;
        }

        while (temp != null && temp.data != key)
        {
            prev = temp;
            temp = temp.next;
        }
        if (temp == null)
        {
            return;
        }
        prev.next = temp.next;
    }


    public void DeleteNodebyPosition(SingleLinkedList singlyList, int position)
    {
        if (singlyList.head == null)
        {
            return;
        }
        Node temp = singlyList.head;

        if (position == 0)
        {
            singlyList.head = temp.next;
            return;
        }
        for (int i = 0; temp != null && i < position - 1; i++)
        {
            temp = temp.next;
        }
        if (temp == null || temp.next == null)
        {
            return;
        }


        Node nextNode = temp.next.next;

        temp.next = nextNode;

    }

    public void SearchLinkedList(SingleLinkedList singlyList, int value)
    {
        Node temp = singlyList.head;

        while (temp != null)
        {
            if (temp.data == value)
            {
                Console.WriteLine("element is shown", value);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("element not shown", value);
    }

    public void ReverseLinkedList(SingleLinkedList singlyList)
    {
        Node prev = null;
        Node current = singlyList.head;
        Node temp = null;

        while (current != null)
        {
            temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;
        }
        singlyList.head = prev;

    }



    public void FindMiddle(SingleLinkedList singlyList)
    {
        Node slow_ptr = singlyList.head;
        Node fast_ptr = singlyList.head;

        if (singlyList.head != null)
        {
            while (fast_ptr != null && fast_ptr.next != null)
            {
                fast_ptr = fast_ptr.next.next;
                slow_ptr = slow_ptr.next;
            }
            Console.WriteLine("element 0 ", slow_ptr.data);
        }
    }


    public void PrintList(SingleLinkedList singlyList)
    {
        Node n = singlyList.head;
        while (n != null)
        {
            Console.Write(n.data + " ");
            n = n.next;
        }
    }
}



}
