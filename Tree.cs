using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBinaryTree
{
    public class Tree
    {
        public Node Root;
                                                       
        public Tree(int data)                       //           9
        {                                          //        5       11
            this.Root = new Node(data);           //     3       7       12
        }                                        //        4   6   8         15
                                                //                        14    18
        public Node Add(Node root, int data)           
        {

            if (root == null)
            {
                root = new Node(data);

                return root;
            }

            if (data < root.data)
            {
                root.leftNode = Add(root.leftNode, data);
            }

            else if (data > root.data)
            {
                root.rightNode = Add(root.rightNode, data);
            }

            return root;
        }



        public Node Delete(Node nodeToDelete, int valueData)
        {
            if (nodeToDelete == null)
            {
                return nodeToDelete;
            }
            else if (nodeToDelete.data < valueData)
            {
                nodeToDelete.rightNode = Delete(nodeToDelete.rightNode, valueData);
            }
            else if (nodeToDelete.data > valueData)
            {
                nodeToDelete.leftNode = Delete(nodeToDelete.leftNode, valueData);
            }
            else
            {
                Node tmp = null;

                if (nodeToDelete.rightNode == null && nodeToDelete.leftNode == null)
                {
                    nodeToDelete = null;
                }
                else if (nodeToDelete.rightNode != null && nodeToDelete.leftNode == null)
                {
                    tmp = nodeToDelete.rightNode;
                    nodeToDelete = tmp;
                }
                else if (nodeToDelete.rightNode == null && nodeToDelete.leftNode != null)
                {
                    tmp = nodeToDelete.leftNode;
                    nodeToDelete = tmp;
                }
                else
                {
                    tmp = nodeToDelete.rightNode;

                    while(tmp != null)
                    {
                        if (tmp.leftNode == null)
                        {
                            break;
                        }

                        tmp = tmp.leftNode;
                    }

                    nodeToDelete.data = tmp.data;
                    nodeToDelete.rightNode = Delete(nodeToDelete.rightNode, nodeToDelete.data);
                }
            }

            return nodeToDelete;
        }

        public void Show(Node current, int depth = 0)
        {
            if (current == null)
            {
                return;
            }

            for (int i = 0; i < depth; i++)
            {
                Console.Write("  ");
            }
            Console.WriteLine(current.data);
            Show(current.leftNode, depth + 1);
            Show(current.rightNode, depth + 1);
        }
    }
}