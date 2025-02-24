// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
 - Develop a console application that calculates the average grade of a student.
 - Use arrays to store grades and loops to iterate through them.
 - Implement methods to calculate the average and determine the grade (A, B, C, etc.).
*/

//Prompting the user for marks input
Console.WriteLine("Enter the number of student marks to be entered: ");
string number=Console.ReadLine()!;

//Datatype conversion from string to int
int n=int.Parse(number);

//declaration and initialization of array
int[] marks=new int[n];

//for loop
for(int i=0;i<n;i++)
{
    Console.WriteLine($"Enter Mark {i+1}: ");
    marks[i]=int.Parse(Console.ReadLine()!);
}

//looping through array elements to compute the total marks of a student
int sum=0;
for(int i=0;i<n;i++)
{
    sum+=marks[i];
}

//Calculating the average marks of a student
float average=(float)sum/n;
Console.WriteLine($"The Average Mark is {average:F3}");

//Assigning grades to the student according to the average mark scored by the student
if(average>=90 && average<=100)
{
    Console.WriteLine("The grade is 'O'");
}
else if(average>=80 && average<90)
{
    Console.WriteLine("The grade is 'A'");
}
else if(average>=70 && average<80)
{
    Console.WriteLine("The grade is 'B'");
}
else if(average>=60 && average<70)
{
    Console.WriteLine("The grade is 'C'");
}
else if(average>=50 && average<60)
{
    Console.WriteLine("The grade is 'D'");
}
else if(average>=40 && average<50)
{
    Console.WriteLine("The grade is 'E'");
}
else
{
    Console.WriteLine("Fail");
}