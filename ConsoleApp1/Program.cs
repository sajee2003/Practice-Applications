using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{

            //----------- Square Star Pattern  --------------------

            //-----------------------------------
            //*****
            //*****
            //*****
            //*****
            //*****


            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            // Right Triangle Star Pattern-------------------

            //*
            //**
            //***
            //****
            //*****

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < i+1; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}



            //Inverted Half-Pyramid of *

            // *****
            //****
            //***
            //**
            //*


            //for (int i = 0; i < 5; i++)
            //{
            //    for ( int j = 5; j > i; j--)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}


            //Console.WriteLine("Please enter the desired max number to display prime numbers: ");
            //int nMaxNumber;


            //while (!int.TryParse(Console.ReadLine(), out nMaxNumber) || nMaxNumber < 2)
            //{
            //    Console.WriteLine("Invalid input. Please enter an integer greater than or equal to 2: ");
            //}

            //Console.WriteLine("Prime numbers between {0} and {1} are:", 2, nMaxNumber);


            //for (int i = 2; i <= nMaxNumber; i++)
            //{
            //    bool isPrimeNumber = true;


            //    for (int j = 2; j * j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrimeNumber = false;
            //            break;
            //        }
            //    }

            //    // Print the prime number if it's still marked as prime
            //    if (isPrimeNumber)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            // -----------reverse 

            //string name = "hello";

            //int length = name.Length;

            //Console.WriteLine(length);

            //string retuned = "";
            //for (int i = length ; i > 0 ; i--) { 

            //    retuned += name[i-1];

            //}

            //Console.WriteLine(retuned);






            //-------------------palindrom------------------------

            //Console.WriteLine(IsPalindrome("racecar")); // Output: true
            //Console.WriteLine(IsPalindrome("hello")); // Output: false

            //Console.WriteLine(isPalindrom("hello"));


            //Console.WriteLine(SwapNum(5, 20));

            //Console.WriteLine(identyfyIsPrime(87));
            //Console.WriteLine(factorial(5));

            Console.WriteLine(FindDuplicateElements("eEc dqd")) ;
            Console.WriteLine(FindDuplicateElementsinArray(new string[] { "y","d", "d" }));

            Console.ReadLine();
		}

        //-------------------palindrom------------------------
        //public static bool IsPalindrome(string str)
        //{
        //    int left = 0, right = str.Length - 1;
        //    while (left < right)
        //    {
        //        if (str[left] !=  str[right])
        //            return false;
        //        left++;
        //        right--;
        //    }
        //    return true;
        //}


        //public static int CountVowels(string str)
        //{
        //    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        //    int count = 0;

        //    for (int i = 0; i < str.Length -1; i++)
        //    {
        //        str = str.ToLower();
        //        foreach (var item in vowels)
        //        {
        //            if (item == str[i])
        //            {
        //                count++;
        //            }
        //        }
        //    }
        //    return count;

        //}








        //public static bool isPalindrom(string str) { 

        //    int left = 0;
        //    int right = str.Length-1 ;
        //    str = str.ToLower() ;
        //    while (left<right)
        //    {
        //        if (str[left] == str[right])
        //        {
        //            left++;
        //            right--;
        //        }
        //        else { 
        //            return false;
        //       }


        //    }

        //    return true;

        //}




        //public static String SwapNum(int x, int y)
        //{

        //    x = x + y;
        //    y = x - y;
        //    x = x - y;
           
        //    return "x: " + x + ", y: " + y;
        //}


        
        public static bool identyfyIsPrime(int n) {
            for (int i = 2; i < n; i++)
            {
                if (n%i==0)
                {
                    return false;
                }
            }
            return true; 
        }


        public static int factorial(int num)
        {

            int value = 1;
            for (int i = num; i > 0; i--)
            {
                value = value * i;

            }

            return value;

        }


        public static char FindDuplicateElements(string element)
        {
            element = element.ToLower();  

            for (int i = 0; i < element.Length ; i++)
            {
                for (int j = i + 1; j < element.Length; j++)
                {
                    // If a duplicate is found, return it
                    if (element[i] == element[j])
                    {
                        Console.WriteLine(element[i]);
                    }
                }
            }

            return '\0';  // Return null character to indicate no duplicate
        }


        public static string  FindDuplicateElementsinArray(string[] element)
        {
                        
            for (int i = 0; i < element.Length ; i++)
            {
                
                for (int j = i + 1; j < element.Length ; j++)
                {
                 
                    if (element[i].ToLower() == element[j].ToLower())
                    {
                        Console.WriteLine(element[i]);
                    }
                }
            }
            
            return null; 
        }









        //public static string RemoveDuplicateElementsinArray(string[] element)
        //{
        //    List<string> resultList = new List<string>();

        //    // Loop through each character in the string
        //    for (int i = 0; i < element.Length; i++)
        //    {
        //        for (int j = i + 1; j < element.Length; j++)
        //        {

        //            if (element[i].ToLower() != element[j].ToLower())
        //            {
        //                resultList.Add(element[i]);
        //            }
        //        }
        //    }


        //    return null;  
        //}




        public static bool AreAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            str1 = str1. ToLower();
            str2 = str2. ToLower();

            for (int i = 0; i < str1.Length; i++)
            {
                bool found = false;

                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {  
                        str2 = str2.Remove(j, 1);
                        found = true;
                        break;
                    }
                }
     
                if (!found)
                {
                    return false;
                }
            }
      
            return true;
        }

 
       

    }
}

	


	 