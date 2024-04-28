using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Structures.LinkedList
{


    /// <summary>
    /// Typically linked list is used for insertion and deletion purpose
    /// </summary>
    internal class SingleLinkedList
    {
        internal Node head;

        #region Insert-Operation
        internal static void InsertFront(SingleLinkedList singlyList, int new_data)
        {

            Node new_node = new Node(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;

        }

        internal static void InsertEnd(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(singlyList);
            lastNode.next = new_node;
        }

        static Node GetLastNode(SingleLinkedList singleLinkedList)
        {
            var temp = singleLinkedList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal static void InsertAfter(Node prev_node, int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }
        #endregion


        #region Delete-Operation
        internal static void DeleteNodebyKey(SingleLinkedList singleLinkedList, int key)
        {
            //Assign head to temp variable ; 
            Node temp = singleLinkedList.head;

            Node prev = null;

            //Check if temp data is not null and key is matched to the head node's data.If matched removed the head node by making head.next to head
            if (temp != null && temp.data == key)
            {
                singleLinkedList.head = temp.next;
                return;
            }

            //Iterating head.Next for removing matching node and make previous node next  equal to temp node next 

            while (temp.next != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;

            prev.next = temp.next;

        }
        #endregion


        #region Reverse-linked-list
        internal static void ReverseLinkedList(SingleLinkedList singleLinkedList)
        {
            try
            {
                //List contains two data {1,2}


                //Assign head to temp variable
                Node temp = singleLinkedList.head;                              //temp = {d : 1, N : 2}
                //Create a new pointer to track the previoius data :  For example : for first node prev = {data:1 ,next : = null}
                Node prev = new(temp.data);

                //iterate loop until last record
                while (temp.next != null)
                {

                    //Create new  pointer to track the current data 
                    var current = new Node(temp.next.data);              //c ={ d:2 N : null}

                    //set next of the current data  to previous.Swap the current node next to previous node
                    current.next = prev;   // c = {d:2 N : 1}

                    //Then set the prev node to current node .By doing this swapping of two nodes happend
                    prev = current;    // P = { d: 2 , N : 1}

                    temp = temp.next;   //temp = {null}
                }
                singleLinkedList.head = prev;


            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion


    }
}
