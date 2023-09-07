using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace STUDENT_GRADE_ALLOCATION_MOD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            string StdName;
            string sStudentNumber;

            //Input student's name
            Console.WriteLine("Enter Student's name: ");
            StdName = Console.ReadLine();

            //Ask user to input student number
            Console.WriteLine("Enter Student Number: ");
            sStudentNumber = Console.ReadLine();

            //Make the input an integer and strictly 9 integers 
            while (!Regex.IsMatch(sStudentNumber, "^\\d{9}$"))
            {
                Console.WriteLine("Invalid entry! Try again.");
                sStudentNumber = Console.ReadLine();
            }
            Console.WriteLine();

            //Giving module marks a title
            Console.WriteLine("INPUT MODULE MARKS");            
            //declare and initialise parallel arrays
            string[] sModules = new string[] { "Module 1", "Module 2", "Module 3", "Module 4", "Module 5", "Module 6" };
            const int count = 6;
            int[] iMarks = new int[count];

            //Create the loop for the size of the test scores that have been input 
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter Module Mark {0}: ", i + 1 );
                iMarks[i] = int.Parse(Console.ReadLine());
                while (iMarks[i] < 0 || iMarks[i] > 100)
                {
                    Console.WriteLine("Invalid Input!Retry Module Mark {0}: ", i + 1);
                    iMarks[i] = int.Parse(Console.ReadLine());
                }                               
            }

            //Determine Individual grade in comparison to the marks and modules
            int iSubject;  
            for (iSubject = 0; iSubject < iMarks.Length; iSubject++)
            {                
                string[] sIndGrades = new string[] { "E", "D", "C", "B", "A" };
                int[] iRanges = new int[] { 19, 39, 55, 75, 100 };
                int iCurrentMark;
                Console.WriteLine();

                //loop to display grade for each module
                for (iSubject = 0; iSubject < iMarks.Length; iSubject++)
                {
                    iCurrentMark = iMarks[iSubject];  //get current Module mark

                    int iSub = 0;  //initialise the search subscript

                    //search grade array to find correct grade for this mark
                    while (iSub < iRanges.Length && iCurrentMark > iRanges[iSub])
                    {
                        iSub++;
                    }
                    //display module, mark and grade
                   Console.WriteLine(sModules[iSubject] + " \t" + iMarks[iSubject] + " \t" + sIndGrades[iSub]);                   
                }
                    //Write Summary of the entries made
                    Console.WriteLine();
                    Console.WriteLine("STUDENT SUMMARY");
                    //Compile all the entries into one statement
                    Console.WriteLine("STUDENT NAME: " + StdName + "\r\nSTUDENT NUMBER: " + sStudentNumber +
                        "\r\n  "+"\r\nPERFORMANCE SUMMARY " +
                        "\r\n"+ sModules[0] +"\t "+ "Marks: "+iMarks[0]+
                        "\r\n" + sModules[1] + "\t " + "Marks: " + iMarks[1] +
                        "\r\n" + sModules[2] + "\t " + "Marks: " + iMarks[2] + 
                        "\r\n" + sModules[3] + "\t " + "Marks: " + iMarks[3] + 
                        "\r\n" + sModules[4] + "\t " + "Marks: " + iMarks[4] +
                        "\r\n" + sModules[5] + "\t " + "Marks: " + iMarks[5] +
                        "\r\nTotal Marks: " + AddMarks(iMarks) +
                        "\r\nAverage Mark:" + CalculateAverage(iMarks) + 
                        "\r\nAverage Grade: " + DetermineGrade(iMarks) + 
                        "\r\nAverage Score: " + DetermineScore(iMarks));
                 Console.ReadKey();
            }

           
        }
        //Calculate Total Marks
        static int AddMarks(int[] iMarks)
        {
            //declare variables
            int iTotal;
            iTotal = iMarks[0] + iMarks[1] + iMarks[2] + iMarks[3] + iMarks[4] + iMarks[5];
            return iTotal;
        }

        //Working out the average 
        static double CalculateAverage(int[] iMarks)
        {
            //declare variables
            int iSubject;
            int iTotalMarks = 0;
            double dAverageMark;

            //loop to count up all marks scored
            for (iSubject = 0; iSubject < iMarks.Length; iSubject++)
            {
                //add current mark to the total
                iTotalMarks = iTotalMarks + iMarks[iSubject];
            }
            //calculate and display average mark
            dAverageMark = (double)iTotalMarks / iMarks.Length;
            //Ensure the Average Mark has a maximum of three decimal places
            dAverageMark = Math.Truncate(dAverageMark * 100) / 100;
            //return value
            return dAverageMark;
        }

        //Determine Mean Grade
        static string DetermineGrade(int[] iMarks)
        {
            //declare variables
            string sGrade;
            double dAverageMark = iMarks.Average();
            //Assign grade to different marks ranges
            if (dAverageMark > 0 && dAverageMark < 40)
            {
                sGrade = "D";
            }
            else if (dAverageMark >= 40 && dAverageMark < 60)
            {
                sGrade = "C";
            }
            else if (dAverageMark >= 60 && dAverageMark < 75)
            {
                sGrade = "B";
            }
            else if (dAverageMark >= 75 && dAverageMark < 90)
            {
                sGrade = "A";
            }
            else
            {
                sGrade = "A+";
            }
            //return value
            return sGrade;
        }

        static string DetermineScore(int[] iMarks)
        {
            //declare variables
            string sScore;
            double dAverageMark = iMarks.Average();
            //Assign score to different marks ranges
            if (dAverageMark > 0 && dAverageMark < 40)
            {
                sScore = "FAIL";
            }
            else if (dAverageMark >= 40 && dAverageMark < 55)
            {
                sScore = "PASS";
            }
            else if (dAverageMark >= 55 && dAverageMark < 65)
            {
                sScore = "CREDIT";
            }
            else if (dAverageMark >= 65 && dAverageMark < 85)
            {
                sScore = "MERIT";
            }
            else
            {
                sScore = "DISTINCTION";
            }
            //return value
            return sScore;
        }
    }
}
