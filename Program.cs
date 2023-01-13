using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Linked List Problem");
            SearchLS list = new SearchLS();
            list.insertNode(56);
            list.insertNode(30);
            list.insertNode(70);
            list.printNodes();

            Console.WriteLine("----------------");
            Console.WriteLine("Finding 30 in the Lineked list");
            list.findNode(30);
            list.printNodes();

        }
    }
}

