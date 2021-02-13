using System;
using System.IO;
namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int count = System.IO.File.ReadAllLines(args[0]).Length;
            int[] nums = new int[count];
            int i = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(args[0]);
            while ((line = file.ReadLine()) != null)
            {
                nums[i] = int.Parse(line);
                i++;
            }
            Array.Sort(nums);
            Array.Reverse(nums);
            Console.WriteLine(nums[0] + nums[1]);
            file.Close();
        }
    }
}