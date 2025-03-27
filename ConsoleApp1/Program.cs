using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(reverse("ggbn"));
            Console.WriteLine(isPalindrom("Maam"));
            Console.WriteLine(CountVowels("tsfv"));
            Console.WriteLine(removeDuplicate( new int[] { 7, 8 , 7, 4}));
            Console.WriteLine(calculate(8, 5, "+"));
            Console.WriteLine(identyfyIsPrime(30));
            Console.WriteLine(MaxNum(new int[] { 7, 8, 7, 4 }));
           
            Console.WriteLine(Captalize("vf dv"));
            Console.WriteLine(accending(new int[] { 7, 8, 3, 4 }));


            Console.ReadLine();
        }



        public static string reverse(string str)
        {
       string sum = "";
        
            for (int i = str.Length - 1; i >= 0; i--)
            {

                string val = "";

                val = str[i].ToString();
                sum = sum + val;
            }

            return sum;


        }

        public static bool isPalindrom(string str)
        {

            int left = 0;
            int right = str.Length - 1;
            str = str.ToLower();
            while (left < right)
            {
                if (str[left] == str[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }


            }

            return true;

        }


        public static int CountVowels(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            int count = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                str = str.ToLower();
                foreach (var item in vowels)
                {
                    if (item == str[i])
                    {
                        count++;
                    }
                }
            }
            return count;

        }
        public static List<int>  removeDuplicate(int[] strings)
        {

            List<int> list = new List<int>();


            foreach (int s in strings)
            {

                list.Add(s);

            }


            Console.WriteLine(list);

            for (int i = 0; i < strings.Length; i++)
            {

                for (int j = i + 1; j < strings.Length; j++)
                {
                    if (strings[i] == strings[j])
                    {
                        list.Remove(i);
                    }
                }
            }


            return list;

        }


        public static string calculate(int a, int b, string x)
        {

            if (x == "+")
            {
                return "Ans" + a + b;
            }
            else if (x == "-")
            {
                int r = a - b;


                return r.ToString();
            }
            else if (x == "*")
            {

                return "Ans" + a * b;

            }
            else if (x == "/")
            {
                return "Ans" + a / b;

            }

            return "checked valuue";
        }


        public static int MaxNum(int[] num) {

            {

                int inital = num[0];

                for (int j = 1; j < num.Length; j++)
                {
                    if (inital < num[j])
                    {
                        inital = num[j];
                    }




                }


                return inital;





            }






            


        }

        public static bool identyfyIsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public static string Captalize(string s)
        {

            string final = " ";


            for (int i = 0; i < s.Length; i++)
            {



                if (i == 0)
                {
                    final = s[i].ToString();

                    final = final.ToUpper();


                }
                else if (s[i] == ' ')
                {
                    string gg;

                    gg = s[i].ToString();



                    final += gg;



                    string val = "";

                    val = s[i + 1].ToString();

                    val = val.ToUpper();

                    final += val;
                    i = i + 1;
                }
                else
                {

                    string gg;

                    gg = s[i].ToString();



                    final += gg;

                }



               
                        

            }


            return final;

        }



        public static int[] accending(int[] s) {


            int[] arrayInt = s;

            for (int i = 0; i < arrayInt.Length; i++)
            {
             
                if (arrayInt[i + 1]< arrayInt.Length)
                {
                    if (arrayInt[i] > arrayInt[i + 1])
                    {
                        int R;
                        R = arrayInt[i];
                        arrayInt[i] = arrayInt[i + 1];
                        arrayInt[i + 1] = R;
                    }
                }
                else
                {
                    break;
                }
              
            }
            return arrayInt;

        }

    }
}
