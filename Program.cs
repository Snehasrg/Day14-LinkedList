using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Linked List Problem");
            insert40 list = new insert40();
            list.insertNode(56);
            list.insertNode(30);
            list.insertNode(70);
            list.printNodes();
            Console.WriteLine("---------------");
            Console.WriteLine("Adding 40 at second Location");
            list.insertNth(40, 2);
            list.printNodes();

        }
    }
}

