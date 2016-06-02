using System;

namespace Microsoft
{
    class Program
    {
        /**
         * It takes in two already sorted linked lists (in ascendant order, duplicates allowed) and
         * is supposed to merge them into a single sorted linked list (in ascendant order, duplicates allowed) 
         * and returns the new head.
         */
        static Node Merge(Node h1, Node h2)
        {
            var head = new Node(-1, null);
            var tail = head;

            while (h1 != null || h2 != null)
            {
                if (h1 == null)
                {
                    tail.Next = h2.Clone();
                    h2 = h2.Next;
                }
                else if (h2 == null)
                {
                    tail.Next = h1.Clone();
                    h1 = h1.Next;
                }

                else if (h1.Data <= h2.Data)
                {
                    tail.Next = h1.Clone();
                    h1 = h1.Next;
                }
                else
                {
                    tail.Next = h2.Clone();
                    h2 = h2.Next;
                }
                tail = tail.Next;
            }

            return head.Next;
        }

        static void Main(string[] args)
        {
            var n1 = new 
                Node(1, new
                Node(2, new
                Node(4, new
                Node(4, new
                Node(8, null)))));

            var n2 = new
                Node(2, new
                Node(3, new
                Node(5, new
                Node(7, new
                Node(8, new
                Node(9, new
                Node(12, null)))))));

            var n = Merge(n1, n2);

            Print(n);

            Console.Write("Press Enter to exit !");
            Console.Read();
        }

        private static void Print(Node node)
        {
            PrintNode(node);
            Console.WriteLine("");
        }

        private static void PrintNode(Node node)
        {
            if (node != null)
            {
                Console.Write(node.Data + " -> ");
                PrintNode(node.Next);
            }
        }
    }
}
