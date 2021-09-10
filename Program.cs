using System;
using System.Numerics;
//using static ConsoleApp5.Solution1;

namespace ConsoleApp5
{
    public class Solution1
    {
        public static int[] TwoSum1(int[] nums, int target)
        {
            //int[] res = {0, 1};
            if (nums.Length > 2)
            {
                for (var i = 0; i < nums.Length - 1; i++)
                {
                    for (var j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                            return new[] {i, j};
                    }
                }
            }
            return new []{0, 1};
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ {0},{1} ]",Solution1.TwoSum1(new []{1,2},3)[0],Solution1.TwoSum1(new []{1,2},3)[1]);
        }
    }
        
        
    
}