using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Arbol
{
    class Node
    {
        public int Value { get; set; }

        public Node RightNode { get; set; }

        public Node LeftNode { get; set; }

        public Node()
        {
            RightNode = null;
            LeftNode = null;

        }
    }
}
