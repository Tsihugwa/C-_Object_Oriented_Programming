using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaffBinaryTree
{
    class Tree
    {
        private TreeNode root;

        //Constructor - construct an empty tree
        public Tree()
        {
            root = null;
        } 

        //Insert a new node in the binary tree
        public void InsertNode(String insertName)
        {
            if (root == null)  
            {
                //create the root node
                root = new TreeNode(insertName); 
            }
            else
            {
                //call the Insert method of class TreeNode
                root.Insert(insertName); 

            }
        } 

        //begin inorder traversal of the tree
        public void InOrderTraversal()
        {
            Traverse(root);
        }

        //recursive method to perform an inorder traversal
        private void Traverse(TreeNode current)
        {
            if (current != null)
            {
                //travserse left subtree
                Traverse(current.LeftNode);

                //output node data
                Console.WriteLine("Name: " + current.Name);
                Console.WriteLine();

                //travserse right subtree
                Traverse(current.RightNode);
            }
        } 
    }
}
