
namespace List
{
    internal class LinkedList
    {
        static void Main(string[] args)
        {
            // Linked List
            var list1 = new LinkedList<int>();
            list1.AddFirst(1);
            list1.AddFirst(2);
            list1.AddFirst(3);
            list1.AddFirst(4);
            list1.AddFirst(5);
            list1.AddFirst(6);
            list1.AddFirst(7);
            LinkedListNode<int> node = list1.Find(5);
            list1.AddBefore(node, 5);
            LinkedListNode<int> node1 = list1.FindLast(5);
            list1.AddBefore(node1, 6);
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }

            // 

        }
    }
}
