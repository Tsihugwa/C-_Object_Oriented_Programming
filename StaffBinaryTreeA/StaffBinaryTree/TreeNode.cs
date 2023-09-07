using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaffBinaryTree
{
    class TreeNode
    {
        public TreeNode LeftNode { get; set; }
        public string Name { get; set; }
        public TreeNode RightNode { get; set; }

        //Constructor - initialise data and make this a leaf node
        public TreeNode(String insertName)
        {
            Name = insertName;
            LeftNode = RightNode = null; //node has no children
        }

        //insert TreeNode into Tree that contains nodes
        public void Insert(String insertName)
        {
            //if name to insert is alphabetically less than name at current node
            //traverse left subtree
            if (String.Compare(insertName,Name) < 0)
            {
                if (LeftNode == null)  //insert node
                {
                    LeftNode = new TreeNode(insertName);
                }
                else //continue traversing left subtree
                {
                    LeftNode.Insert(insertName);
                }
            }
            else  //traverse right subtree
            {
                if (RightNode == null)  //insert node
                {
                    RightNode = new TreeNode(insertName);
                }
                else  //continue traversing right subtree
                {
                    RightNode.Insert(insertName);
                }
            }
        } 
    }
}
