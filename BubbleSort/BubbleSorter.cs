using System;

namespace BubbleSort
{
    class BubbleSorter
    {
        Node head;

        public void AddNode(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void PrintList()
        {
            Node current = head;

            while (current != null)
            {
                Console.Write($"{current.data} ");
                current = current.next;
            }

            Console.WriteLine();
        }

        public void Sort()
        {
            if (head == null || head.next == null)
            {
                // No need to sort an empty list or a list with a single node
                return;
            }

            bool swapped;
            do
            {
                swapped = false;
                Node current = head;
                Node previous = null;

                while (current.next != null)
                {
                    if (current.data > current.next.data)
                    {
                        // Swap nodes
                        Node temp = current.next;
                        current.next = current.next.next;
                        temp.next = current;

                        if (previous == null)
                        {
                            // Update the head if swapping the first node
                            head = temp;
                        }
                        else
                        {
                            previous.next = temp;
                        }

                        previous = temp;
                        swapped = true;
                    }
                    else
                    {
                        previous = current;
                        current = current.next;
                    }
                }

                Console.WriteLine(".");
                PrintList();

            } while (swapped);
        }

        static void Main()
        {
            BubbleSorter list = new BubbleSorter();

            list.AddNode(5);
            list.AddNode(1);
            list.AddNode(9);
            list.AddNode(0);
            list.AddNode(7);
            list.AddNode(3);
            list.AddNode(6);
            list.AddNode(2);

            Console.WriteLine("Original List:");
            list.PrintList();

            list.Sort();

            Console.WriteLine("\nSorted List:");
            list.PrintList();
        }
    }
}
