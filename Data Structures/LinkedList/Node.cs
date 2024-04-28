using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Structures.LinkedList
{
    internal class Node
    {
        internal int data;
        internal Node next;
        public Node(int _data)
        {
            data = _data;
            next = null;
        }
    }
}
