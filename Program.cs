﻿// 1st TASK ______________________________________________________
Console.WriteLine("Type first integer number");
int number01 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type second integer number");
int number02 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("You typed the following numbers: " + number01 + " " + number02);
Console.WriteLine("Let's find the biggest");


if (number01 > number02)
{
    Console.WriteLine("The number: " + number01 + " -is the biggest number!");
}
else if (number01 == number02)
{
    Console.WriteLine("Numbers are the same!");
}
else
{
    Console.WriteLine("The number: " + number02 + " -is the biggest number!");
}
//________________________________________________________________

// 2nd TASK ______________________________________________________
Console.WriteLine("Type first integer number");
number01 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type second integer number");
number02 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type third integer number");
int number03 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("You typed the following numbers: " + number01 + " " + number02 + " " + number03);
Console.WriteLine("Let's find the biggest");

int max;

if (number01 > number02)
{
    max = number01;
}
else
{
    max = number02;
}

if (max < number03)
{
    max = number03;
}

if (number01 == number02 & number01 == number03)
{
    Console.WriteLine("Numbers are the same!");
}
else
{
    Console.WriteLine("The number: " + max + " -is the biggest number!");
}
//________________________________________________________________

// 3rd TASK ______________________________________________________
Console.WriteLine("Type an integer number");
number01 = Convert.ToInt32(Console.ReadLine());
if (number01 % 2 == 0)
{
    Console.WriteLine("Your number " + number01 + " is even");
}
else 
{
    Console.WriteLine("Your number " + number01 + " is NOT even");
}
//________________________________________________________________

// 4th TASK ______________________________________________________
Console.WriteLine("Type a positive integer number");
number01 = Convert.ToInt32(Console.ReadLine());

int i = 1;
int end = number01 + 1;

Console.WriteLine("Let's find even numbers.. Here you go");

if (number01 == 0 || number01 == 1)
{
    Console.WriteLine("Nothing found..");
}
else
{
    while (end > i)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
        i++;
    }
}
