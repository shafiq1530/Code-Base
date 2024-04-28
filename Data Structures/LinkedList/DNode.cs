using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Struct.Data_Structures.LinkedList
{
    internal class DNode
    {
        internal int data;
        internal DNode Next;
        internal DNode Prev;
        public DNode(int _data)
        {
            this.data = _data;
            Next = null;
            Prev = null;
        }
    }
}
