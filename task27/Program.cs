﻿//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Enter number: ");
int a = int.Parse(Console.ReadLine());
            int s = 0;
            while (a > 0)
            {
 
                s = s + a % 10;
                a = a /10 ;
 
            }
 Console.WriteLine(s);