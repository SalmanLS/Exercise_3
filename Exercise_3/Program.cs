﻿using System;
using System.Security;

namespace Exercise_Linked_List_A
{
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }
    class CircularList
    {
        Node LAST;
        public CircularList()
        {
            LAST = null;
        }

        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            for (previous = current = LAST.next; current!= LAST; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                    return (true);
            }
            if (rollNo == LAST.rollNumber)
                return true;
            else 
                return (false);
        }

        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }

        public void traverse()
        {
            if (listEmpty())
                Console.WriteLine("\n List is empty");
            else
            {
                Console.WriteLine("\n Records in the list are: \n");
                Node currentNode;
                currentNode = LAST.next;
                while(currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber + "   " + currentNode.name + "\n");
                }
                Console.Write(LAST.rollNumber + "    " + LAST.name + "\n");
            }
        }

        public void firstNode()
        {
            if (listEmpty())
                Console.WriteLine("\n List is empty");
            else
                Console.WriteLine("\n The first record in the list is: \n\n" +
                    LAST.next.rollNumber + "   " + LAST.next.name);
        }
    }
}