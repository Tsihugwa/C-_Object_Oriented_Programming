using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaffBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree  = new Tree();
            String insertName;
            
            Console.WriteLine("Entering staff names into binary tree . . .");
            Console.WriteLine();

            Console.Write("Enter name of staff member: ");
            insertName = Console.ReadLine();
            
            while (insertName != "end")
            { 
                //insert the staff name into the tree
                tree.InsertNode(insertName); 

                //get next staff name
                Console.Write("Enter name of staff member or 'end' to finish: ");
                insertName = Console.ReadLine();
 
            }

            Console.WriteLine();
            Console.WriteLine("Names of staff in alphabetic order . . .");
            Console.WriteLine();

            //display the tree using an inorder traversal
            tree.InOrderTraversal();

            Console.WriteLine("Press any key to finish");
            Console.ReadKey();

        }

    }
}
