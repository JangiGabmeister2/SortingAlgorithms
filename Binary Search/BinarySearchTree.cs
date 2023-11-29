using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class BinarySearchTree
    {
        Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        Node Insert(Node root, int data)
        {
            //if the root node does not exist
            if (root == null)
            {
                //data becomes new node, taking place at root
                root = new Node(data);
                //Console.WriteLine(root.data);
                return root;
            }

            //if the data is less than the root node, it becomes the root's left node
            if (data < root.data)
            {
                root.left = Insert(root.left, data);
            }
            //otherwise it becomes the root's right node
            else if (data > root.data)
            {
                root.right = Insert(root.right, data);
            }

            return root;
        }
        
        //prints the binary tree into an actual tree
        void PrintTree(Node root, int level)
        {
            if (root == null)
                return;

            PrintTree(root.right, level + 1);
            Console.WriteLine($"{new string(' ', level * 8)}{root.data:00}");
            PrintTree(root.left, level + 1);
        }
        
        public void PrintTree()
        {
            PrintTree(root, 0);
        }

        Node Search(Node root, int key)
        {
            //if root node does not exist OR root node's data is what is being searched for, return root node
            if (root == null || root.data == key)
            {
                return root;
            }

            //if the key is smaller than the root's key, then it searches the root's left node.
            if (key < root.data)
            {
                return Search(root.left, key);
            }

            //otherwise ...
            return Search(root.right, key);
        }

        public Node Search(int key)
        {
            return Search(root, key);
        }

        static void Main()
        {
            BinarySearchTree tree = new BinarySearchTree();

            Console.WriteLine("The tree is as follows:");

            tree.root = tree.Insert(tree.root, 8);
            tree.Insert(tree.root, 4);
            tree.Insert(tree.root, 2);
            tree.Insert(tree.root, 1);
            tree.Insert(tree.root, 3);
            tree.Insert(tree.root, 6);
            tree.Insert(tree.root, 5);
            tree.Insert(tree.root, 7);
            tree.Insert(tree.root, 12);
            tree.Insert(tree.root, 10);
            tree.Insert(tree.root, 9);
            tree.Insert(tree.root, 11);
            tree.Insert(tree.root, 14);
            tree.Insert(tree.root, 13);
            tree.Insert(tree.root, 15);

            tree.PrintTree();

            Console.WriteLine("\nType a number to search for it.");
            int keyToSearchFor = Convert.ToInt32(Console.ReadLine());
            Node result = tree.Search(keyToSearchFor);

            if (result != null)
            {
                Console.WriteLine($"Key {keyToSearchFor:00} found.");
            }
            else
            {
                Console.WriteLine($"Key {keyToSearchFor:00} not found.");
            }
        }
    }
}
