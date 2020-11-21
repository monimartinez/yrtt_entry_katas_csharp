using System;
using System.Collections.Generic;

// In this Kata, you will be given an array of numbers in which two numbers occur once and the rest occur only twice. 
// Your task will be to return the sum of the numbers that occur only once.
// For example, repeats([4,5,7,5,4,8]) = 15 because only the numbers 7 and 8 occur once, and their sum is 15.
// More examples in the test cases below.

// Good luck!

namespace myApp
{
  class Program
{
// Function to find the number
static int singleNumber(int[] nums, int n) 
    { 
        Dictionary<int,int> m = new Dictionary<int,int>(); 
        long sum1 = 0, sum2 = 0; 
        for (int i = 0; i < n; i++) 
        { 
            if (!m.ContainsKey(nums[i])) 
            { 
                sum1 += nums[i]; 
                m.Add(nums[i], 1); 
            } 
            sum2 += nums[i]; 
        } 
  
        // Applying formula 
        return (int)(2 * (sum1) - sum2);  
    } 

    // Driver code 
  public static void Main(String []args) 
    { 
        int[] arr = {4, 5, 7, 5, 4, 8}; 
	int n = arr.Length;
        Console.WriteLine("The sum of the numbers that occur only once is: " + singleNumber(arr,n)); 
      } 
   }  
}
