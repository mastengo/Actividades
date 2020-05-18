using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Arbol
{
    class Program
    {
        static void Main(string[] args)
        {

            BTSTree btsTree = new BTSTree();
            Node node;

            //{ 40, 10, 1, 3, 7, 16, 25, 63, 41, 38, 55, 20, 12, 78, 88, 77, 66, 53, 23, 20, 31 }
            int[] nums = { 1, 3, 7, 10, 12, 16, 20, 20, 23, 25, 31, 38, 40, 41, 53, 55, 63, 66, 77, 78, 88 };


            for (int i = 0; i < nums.Count(); i++)
            {
                node = new Node()
                {
                    Value = nums[i]
                };

                btsTree.AddNode(btsTree.Root, node);
            }

            bool Existe = btsTree.SearchNode(btsTree.Root, 145);
            Console.WriteLine(Existe ? "Se encontro el nodo" : "No se encontro el nodo");
            
        }
    }
}
