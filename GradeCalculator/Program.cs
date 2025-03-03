// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
 - Develop a console application that calculates the average grade of a student.
 - Use arrays to store grades and loops to iterate through them.
 - Implement methods to calculate the average and determine the grade (A, B, C, etc.).
*/
using System;
class Program
{
    //enum usage to store grade values and assign them based on certain conditions in if-else blocks
    enum grades{
        O,
        A,
        B,
        C,
        D,
        E,
        Fail
    }
    //main method
    static void Main(string[] args)
    {
        while(true) //while loop
        {
            try //try block
            {
                //Prompting the user for marks input
                Console.WriteLine("\nEnter the number of student marks to be entered: ");
                string number=Console.ReadLine()!;

                //input validation block
                if(string.IsNullOrEmpty(number))
                {
                    throw new Exception("The number of marks entered can't be null! Please provide a valid input!");
                }

                //Datatype conversion from string to int
                int n=int.Parse(number);

                //declaration and initialization of array
                int[] marks=new int[n];

                //for loop
                for(int i=0;i<n;i++)
                {
                    Console.WriteLine($"\nEnter Mark {i+1}: ");
                    marks[i]=int.Parse(Console.ReadLine()!);

                    //input validation block
                    if(marks[i]==null || marks[i]<0)
                    {
                        throw new Exception("Marks can't be null or negative! Please enter a valid input!");
                    }
                }

                //looping through array elements to compute the total marks of a student
                int sum=0;
                for(int i=0;i<n;i++)
                {
                    sum+=marks[i];
                }

                //Calculating the average marks of a student
                float average=(float)sum/n;
                Console.WriteLine($"\nThe Average Mark is {average:F3}");

                //Assigning grades to the student according to the average mark scored by the student
                grades grade; //enum variable declaration

                //assigning enum values to grade var based on average mark criteria
                if(average>=90 && average<=100)
                {
                    grade=grades.O;
                }
                else if(average>=80 && average<90)
                {
                    grade=grades.A;
                }
                else if(average>=70 && average<80)
                {
                    grade=grades.B;
                }
                else if(average>=60 && average<70)
                {
                    grade=grades.C;
                }
                else if(average>=50 && average<60)
                {
                    grade=grades.D;
                }
                else if(average>=40 && average<50)
                {
                    grade=grades.E;
                }
                else
                {
                    grade=grades.Fail;
                }
                Console.WriteLine($"The grade is {grade}");
            }
            catch(Exception e) //catch block
            {
                Console.WriteLine(e.Message);
                continue; //continues to next iteration in case of error in the current iteration
            }
            finally //finally block
            {
                Console.WriteLine("\nThe program has been executed.");
            }
            break;
        }
    }
}