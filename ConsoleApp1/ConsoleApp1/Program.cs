﻿using System;  
public class  arrays
{  
    public static void Main() 
    {
        int i, n;
        int[] a= new int[100];
   
        Console.Write("\n\n Read n number of values in an array and display it in reverse order: \n");
        Console.Write("------------------------------------------------------------------------\n");
   
        Console.Write("Input the number of elements to store in the array :");
        n = Convert.ToInt32(Console.ReadLine());    
   
   
        Console.Write("Input {0} number of elements in the array :\n",n);
        for(i=0; i<n; i++)
        {
            Console.Write("element - {0} : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine()); 
        }
      
        Console.Write("\n The values store into the array are : \n");
        for(i=0; i<n; i++)
        {
            Console.Write("{0}  ",a[i]);
        }
 
        Console.Write("\n\n The values store into the array in reverse are : \n");
        for(i=n-1; i>=0; i--)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.Write("\n\n");
    } 
} 