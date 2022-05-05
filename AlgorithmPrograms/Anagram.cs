using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class Anagram
    {
        public void AnagramOrNot()
        {
            Console.WriteLine("Enter 1st string value: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd string value: ");
            string str2 = Console.ReadLine();
            //get lengths of strings
            char[] length1 = str1.ToLower().ToCharArray();
            char[] length2 = str2.ToLower().ToCharArray();
            if (length1.Length != length2.Length)//length are not same then string is not anagram
            {
                Console.WriteLine("Strings Are Not Anagram");
            }
            Array.Sort(length1);//sort both string
            Array.Sort(length2);
            for (int i = 0; i < length1.Length; i++) //compare sorted string
            {
                if (length1[i] != length2[i])
                {
                    Console.WriteLine("Enterd String Is Not Anagram\n");
                    return;
                }
                else
                {
                    Console.WriteLine("Enterd String Is Anagram\n");
                    return;
                }
            }

        }
    }
}
