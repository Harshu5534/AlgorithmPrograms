using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmPrograms
{
    public class BinarySearch
    {
        public void Binary()
        {
            bool check = false;
            const string Data_filepath= @"E:\VisualPractise\AlgorithmPrograms\AlgorithmPrograms\Data.txt";
            string list=File.ReadAllText(Data_filepath);
            string[] arr = list.Split(" ");
            Console.WriteLine("Enter The Word");
            string name = Console.ReadLine();
            foreach (string word in arr)
            {
                if (word.Equals(name))
                {
                    check = true;
                    Console.WriteLine("Word Is Exist");
                }
                
            }
            if(check==false)
            {
                Console.WriteLine("Word Is not Exist");
            }
            
        }
    }
}
