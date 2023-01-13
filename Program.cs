using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Linked List Problem");
            Delete40 list = new Delete40();
            Console.WriteLine("Current Size of the list is: " + list.getListSize());

            list.insertNode(56);
            list.insertNode(30);
            list.insertNode(40);
            list.insertNode(70);
            list.printNodes();
            Console.WriteLine("Current Size of the list is: " + list.getListSize());

            Console.WriteLine("-------------");
            Console.WriteLine("Deleting node from 2nd location");
            list.deleteNthNode(2);
            list.printNodes();
            Console.WriteLine("Current Size of the list is: " + list.getListSize());

        }
    }
}

