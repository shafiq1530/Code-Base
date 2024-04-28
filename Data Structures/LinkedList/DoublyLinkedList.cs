namespace Data_Struct.Data_Structures.LinkedList
{
    internal class DoublyLinkedList
    {

        internal DNode head;


        internal static void InsertFirstNode(DoublyLinkedList doublyLinkedList, int data)
        {
            DNode new_node = new DNode(data);
            new_node.Prev = null;
            new_node.Next = doublyLinkedList.head;
            if (doublyLinkedList.head != null)
                doublyLinkedList.head.Prev = new_node;

            doublyLinkedList.head = new_node;

        }

        internal static void InsertLastNode(DoublyLinkedList doublyLinkedList, int data)
        {
            DNode new_node = new DNode(data);
            if (doublyLinkedList.head == null)
            {
                doublyLinkedList.head = new_node;
                return;
            }

            var lastnode = GetLastNode(doublyLinkedList);
            lastnode.Next = new_node;
            new_node.Prev = lastnode;
        }

        internal static void InsertAfterNode(DNode prev_node, int data)
        {
            if (prev_node == null)
                return;

            DNode new_node = new DNode(data);
            new_node.Prev = prev_node;
            new_node.Next = prev_node.Next;

            prev_node.Next = new_node;

            if (new_node.Next != null)
            {
                new_node.Next.Prev = new_node;
            }

        }

        internal static DNode GetLastNode(DoublyLinkedList doublyLinkedList)
        {
            var temp = doublyLinkedList.head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }


        internal static void DeleteNodebyKey(DoublyLinkedList doublyLinkedList, int key)
        {
            DNode temp = doublyLinkedList.head;


            //Check if temp data is not null and key is matched to the head node's data.If matched removed the head node by making head.next to head
            if (temp != null && temp.data == key)
            {
                doublyLinkedList.head = temp.Next;
                return;
            }
            //Iterating head.Next for removing matching node and make previous node next  equal to temp node next 

            while (temp.Next != null && temp.data != key)
                temp = temp.Next;


            if (temp == null)
                return;

            if (temp.Prev != null)
                temp.Prev.Next = temp.Next;

            if (temp.Next != null)
                temp.Next.Prev = temp.Prev;

        }
    }
}
