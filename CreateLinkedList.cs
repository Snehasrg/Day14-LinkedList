using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class CreateLinkedList
    {
        public Nodes head;

        public void Add(int value)
        {
            Nodes node = new Nodes(value);
            if (head == null)
            {
                head = node;
            }

            else
            {
                Nodes temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }

            Console.WriteLine("{0} is inserted in Linked List.", value);
        }


        public void Display()
        {
            Nodes temp = head; //temp variable is created.

            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            Console.WriteLine();
            Console.WriteLine("Display Method is Executed");

            while (temp != null)
            {

                Console.Write(temp.data + " ");

                temp = temp.next;

                if (temp != null)
                {
                    Console.Write("->");
                }
            }

        }
    }
}
        
    

