namespace DoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(12);
            doublyLinkedList.AppendList(13);
            doublyLinkedList.AppendList(15);
            doublyLinkedList.AppendList(5);
            doublyLinkedList.AppendList(7);
            doublyLinkedList.PrintList();

            doublyLinkedList.InsertNode(99, 5);
            doublyLinkedList.PrintList(); 
        }
    }
}
