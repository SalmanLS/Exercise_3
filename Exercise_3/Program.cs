using System;
using System.Security;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                while (currentNode != LAST)
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

        public void addNode()
        {
            int rollNo;
            string nm;
            Console.Write("\n Enter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the roll name of the student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            // the beginning of the node
            if (LAST.next != null || (rollNo <= LAST.next.rollNumber))
            {
                if((LAST.next != null) && (rollNo == LAST.next.rollNumber))
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = LAST.next;
                LAST.next = newnode;
                return;
            }

            Node previous, current;
            previous = null;
            current = LAST.next;

            while(current <=  || previous = LAST)
            {
                if(rollNo== current.rollNumber)
                {
                    Console.WriteLine();
                    return;
                }
                previous.next = current;
                current.next = newnode;
            }
            newnode.next = current;
            previous.next = newnode;
        }
        public bool delNode(int rollNO)
        {
            if(listEmpty() == false)
            {

            }
        }
        static void Main(string[] args)
        {
            CircularList obj = new CircularList();
            while (true)
            {
                try
                {
                    Console.WriteLine("\n Menu");
                    Console.WriteLine("1. View all the records in the list");
                    Console.WriteLine("2. Search for a record in the list");
                    Console.WriteLine("3. Display the first record in the list");
                    Console.WriteLine("4. Add a record to the list");
                    Console.WriteLine("6. Exit");
                    Console.Write("\n Enter your choice (1-4): ");
                    char ch = Convert.ToChar(Console.Read());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.traverse();
                            }
                            break;
                        case '2':
                            {
                                if (obj.listEmpty() == true)
                                {
                                    Console.WriteLine("\n List is empty");
                                    break;
                                }
                                Node prev, curr;
                                prev = curr = null;
                                Console.Write("\n Enter the roll number of the student whose record is to be searched: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if(obj.Search(num, ref prev, ref curr) == false)
                                    Console.WriteLine("\n Record no found");
                                else
                                {
                                    Console.WriteLine("\n Record found");
                                    Console.WriteLine("\n Roll number: " + curr.rollNumber);
                                    Console.WriteLine("\n Name: " + curr.name);
                                }

                            }
                            break;
                        case '3':
                            {
                                obj.firstNode();
                            }
                            break;
                        case '4':
                            {
                                obj.addNode();
                            }
                            break;
                        case '5':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option");
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());    
                }
            }
        }
    }
}