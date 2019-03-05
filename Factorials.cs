using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApplication2
{
    class Factorials
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number of choice for factorial");
            int n = int.Parse(Console.ReadLine());
            string result = "1";
            while (n > 1)
            {
                result = Multipy(n.ToString(), result);
                n--;
            }
            Console.WriteLine(result.MyFormat());
            Console.ReadKey();
        }
        public static string Multipy(string a, string b)
        {
            string result = string.Empty;
            int carry = 0, i = 0, j = 0, temp = 0,index=-1;
            char nc1 = '\0', nc2 = '\0';
            for (i = a.Length - 1; i >= 0; i--)
            {
                temp = 0;
                nc2 = a[i];
                string inner ;
                inner = (nc2 == '0') ? "0" : string.Empty;
                for (j = b.Length - 1; j >= 0; j--)
                {
                    nc1 = b[j];
                    temp = (int.Parse(nc2.ToString()) * int.Parse(nc1.ToString()))+carry;
                    inner = temp % 10 + inner;
                    carry = temp / 10;

                }
                index++;
                if (carry != 0)
                {
                    inner = carry + inner;
                }
                
                if (inner.Any(m => m != 0)) {
                    result = add(inner, result, index);
                }
            }
            return result;
        }
        public static string add(string a, string b, int ind)
        {
            string result = string.Empty;
            int carry = 0, i = a.Length - 1, j = b.Length - ind - 1, temp = 0;
            char nc1 = '\0', nc2 = '\0';
            if (b.Length > 0) result = b.Substring(j + 1);
            while (j >= 0)
            {
                nc1 = b[j];
                nc2 = a[i];
                temp = (int.Parse(nc2.ToString()) + int.Parse(nc1.ToString())) + carry;
                result = temp % 10 + result;
                carry = temp / 10;
                i--;
                j--;
            }
            while (i >= 0)
            {
                nc2 = a[i];
                temp = int.Parse(nc2.ToString()) + carry;
                result = temp % 10 + result;
                carry = temp / 10;
                i--;
            }
            if (carry != 0) result += carry + result;
            return result;
        }
    }
    /// <summary>
    /// Extension method for formating output
    /// </summary>
    public static class Test
    {
        public static string MyFormat(this string str)
        {
            string result = "";
            for(int i = str.Length - 3; i >=0; i -= 3)
            {
                if (result != string.Empty)  result = "," + result; 
                result = str.Substring(i, 3)+result;
            }
            if (str.Length %3!=0)
            {
                result = str.Substring(0,str.Length%3)+","+result;
            }
            return result;
        }
    }
}
