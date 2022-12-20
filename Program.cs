using System;
using System.Text;

namespace IronSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter keypaid input string");
            string str = Console.ReadLine();

            //string str = "33#";
            //str = "227**#";
            //str = "4433555 555666#";
            //str = "8 88777444666*664#";

            string[] arr = str.Split("*");
            StringBuilder input = new StringBuilder();
            StringBuilder output = new StringBuilder();


            if (arr.Length == 1)
            {
                //if there is no *(back) present in the input string then just call replace method
                output.Append(ReplaceNumberToChar(arr[0]));  
            }
            else
            {
                /*
                 if there is  *(back) present in the input string then split the input
                 delete a last char from string, if N number of * present then delete N last char
                 then call just call replace method ReplaceNumberToChar foreach string present in array
                */

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    string s2;
                    if (arr[i].Length > 0)
                    {
                        s2 = arr[i].Remove(arr[i].Length - 1);
                        input.Append(s2);

                        if (arr[i + 1].Length != 0)
                            output.Append(ReplaceNumberToChar(input.ToString()));

                    }
                    else if (arr[i].Length == 0)
                    {
                        if (input.Length > 0)
                            input.Remove(input.Length - 1, 1);

                        if ((i < arr.Length - 1) && arr[i + 1].Length != 0)
                            output.Append(ReplaceNumberToChar(input.ToString()));
                    }
                    output.Append(ReplaceNumberToChar(arr[arr.Length-1].ToString()));
                }
            }

            Console.WriteLine("Input is : " + str.ToString());
            Console.WriteLine("Output is : " + output.ToString());
            Console.ReadLine();
        } 

        //function to replace string numeric char to alpha char for mobile key paid
        public static string ReplaceNumberToChar(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            
            sb.Replace("222", "C");
            sb.Replace("22", "B");
            sb.Replace("2", "A");

            sb.Replace("333", "F");
            sb.Replace("33", "E");
            sb.Replace("3", "F");

            sb.Replace("444", "I");
            sb.Replace("44", "H");
            sb.Replace("4", "G");

            sb.Replace("555", "L");
            sb.Replace("55", "K");
            sb.Replace("5", "J");

            sb.Replace("666", "O");
            sb.Replace("66", "N");
            sb.Replace("6", "M");

            sb.Replace("7777", "S");
            sb.Replace("777", "R");
            sb.Replace("77", "Q");
            sb.Replace("7", "P");

            sb.Replace("888", "V");
            sb.Replace("88", "U");
            sb.Replace("8", "T");

            sb.Replace("999", "Z");
            sb.Replace("999", "Y");
            sb.Replace("99", "X");
            sb.Replace("9", "W");

            sb.Replace("#", "");
            sb.Replace(" ", "");
            return sb.ToString();
        }
    }
}
