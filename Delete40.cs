﻿namespace LinkedList
{
    public class Delete40
    {
        private int size;
        private Nodes head;

        public Delete40()
        {
            this.size = 0;
            this.head = null;
        }
        public void insertNode(int data)
        {
            Nodes node = new Nodes();
            node.data = data;
            Nodes current = this.head;

            if (this.head == null)
            {
                this.head = node;
                this.head.next = null;
                this.size = 1;
                Console.WriteLine(this.head);
            }
            else
            {

                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
                node.next = null;
                this.size += 1;
            }
        }

        public void insertNth(int data, int position)
        {
            Nodes node = new Nodes();
            node.data = data;
            Nodes current = this.head;
            if (this.head != null && position <= this.size)
            {
                for (int i = 1; i < position; i++)
                {
                    current = current.next;
                }
                node.next = current.next;
                current.next = node;
                this.size += 1;
            }
            else
            {
                Console.WriteLine("Exceeded the linked list size. Current Size: " + size);
            }
        }

        public void deleteFirstNode()
        {
            if (head != null)
            {
                this.head = this.head.next;
                this.size--;
            }
            else
            {
                Console.WriteLine("Linked list is empty");
            }
        }

        public void deleteLastNode()
        {
            Nodes currentNode = this.head;
            if (size == 1)
            {
                head = null;
                size = 0;
            }
            else
            {
                Nodes prevNode = null;
                while (currentNode.next != null)
                {
                    prevNode = currentNode;
                    currentNode = currentNode.next;
                }
                prevNode.next = null;
                this.size--;
            }
        }

        public void deleteNthNode(int position)
        {
            if (position <= this.size && this.head != null)
            {
                Nodes currentNode = this.head;
                Nodes prevNode = null;
                for (int i = 0; i < position; i++)
                {
                    prevNode = currentNode;
                    currentNode = currentNode.next;
                }
                prevNode.next = currentNode.next;
                this.size--;
            }
            else
            {
                Console.WriteLine("No node exist at location: " + position);
            }
        }

        public void findNode(int data)
        {
            Nodes node = this.head;
            bool found = false;
            for (int i = 0; i < size; i++)
            {
                if (node.data == data)
                {
                    Console.WriteLine("data " + data + " was found at location " + i + " in the linked list");
                    found = true;
                }
                node = node.next;
            }

            if (!found)
                Console.WriteLine("data " + data + " was not found in the Linked list");
        }

        public void printNodes()
        {
            if (this.size < 1)
                Console.WriteLine("There are no nodes in the linked list");

            else
            {
                Nodes current = this.head;
                for (int i = 0; i < this.size; i++)
                {
                    Console.WriteLine("Node " + current.data + " is at location " + i);
                    current = current.next;
                }
            }
        }


        public int getListSize()
        {
            return size;
        }


    }
}
