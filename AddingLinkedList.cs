namespace LinkedList
{
    public class AddingLinkedList
    {
        private int size;
        private Nodes head;

        public AddingLinkedList()
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


        public int ListSize()
        {
            return size;
        }

    }
}
