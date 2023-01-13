namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Linked List Problem");

            AddingLinkedList list = new AddingLinkedList();

            Console.WriteLine("Current Size of the list is: " + list.getListSize());
            list.insertNode(56);
            list.insertNode(30);
            list.insertNode(70);
            list.printNodes();
        }
    }
}

