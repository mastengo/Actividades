using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Arbol
{
    class BTSTree
    {

        public Node Root { get; set; }

        public BTSTree()
        {
            Root = null;
        }

        public void AddNode(Node node, Node nodenew)
        {
            //El primer nodo
            if (Root == null)
            {
                Root = nodenew;
                return;
            }

            if (node.Value > nodenew.Value)
            {
                if (node.LeftNode == null)
                {
                    node.LeftNode = nodenew;
                    return;
                }
                else
                    AddNode(node.LeftNode, nodenew);
            }
            else if (node.Value < nodenew.Value)
            {
                if (node.RightNode == null)
                {
                    node.RightNode = nodenew;
                    return;
                }
                else
                    AddNode(node.RightNode, nodenew);
            }
            else
                return; //Son Iguales.
        }

        public int GetHeight(Node node)
        {
            if (node == null)
                return 0;

            return 1 + Math.Max(GetHeight(node.LeftNode), GetHeight(node.RightNode));
        }

        public bool SearchNode(Node node, int value)
        {
            if (node == null)
                return false;

            if (node.Value == value)
                return true;
            else
                return SearchNode(node.LeftNode, value) || SearchNode(node.RightNode, value);
        }
    }
}

