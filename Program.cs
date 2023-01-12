namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Linked List Problem");

            AddingLinkedList list = new AddingLinkedList();
            list.insertNode(30);
            list.insertNode(70);
            list.insertNode(56);
            list.printNodes();
        }
    }
}

