using System;
using System.Collections.Generic;

// Scenario
// Several people are standing in a row divided into two teams. The first person goes into team 1, the second goes into team 2, the third goes into team 1, and so on.

// Task
// Given an array of positive integers (the weights of the people), return a new array of two integers, where the first one is the total weight of team 1, and the second one is the total weight of team 2.

// Notes
// Array size is at least 1.
// All numbers will be positive.

// Input >> Output Examples
// rowWeights([13, 27, 49])  ==>  return (62, 27)
// Explanation:
// The first element 62 is the total weight of team 1, and the second element 27 is the total weight of team 2.

// rowWeights([50, 60, 70, 80])  ==>  return (120, 140)
// Explanation:
// The first element 120 is the total weight of team 1, and the second element 140 is the total weight of team 2.

// rowWeights([80])  ==>  return (80, 0)
// Explanation:
// The first element 80 is the total weight of team 1, and the second element 0 is the total weight of team 2.


//Changed namespace to "Test" instead of TechReturners.Tasks (created another project) - as I ran it like this on my Desktop .Net (please see files submitted in Google Classroom with screenshot)
namespace Test
{
     class Program
    {
    public static int MinimumCost(int []cost, int n, int W) 
    { 
          
        // val[] and wt[] arrays 
        // val[] array to 'weight' of Team members
        List<int> val = new List<int>(); 
        List<int> wt = new List<int>(); 
  
  	// Traverse the wt[] array and skip 
        // unavailable weights and make val[] and wt[] 
        // array. Size variable tells the available 
        // number of distinct weights (values)
        // for each Team member. 

        int size = 0; 
        for (int i = 0; i < n; i++) 
        { 
            if (cost[i] != -1) 
            { 
                val.Add(cost[i]); 
                wt.Add(i + 1); 
                size++; 
            } 
        } 
     
        n = size; 
        int [,]min_cost = new int[n+1,W+1];
        
        // Fill 0th row with infinity 
        for (int i = 0; i <= W; i++) 
           min_cost[0,i] = int.MaxValue; 
        
	// Fill 0th column with 0 
        for (int i = 1; i <= n; i++) 
            min_cost[i,0] = 0;  
  
	// Now check for each weight one by one and 
        // fill the matrix according to the condition 
        for (int i = 1; i <= n; i++) 
        { 
            for (int j = 1; j <= W; j++) 
            { 
                // wt[i-1]>j means capacity of bag is 
                // less than weight of item 
                if (wt[i-1] > j) 
                    min_cost[i,j] = min_cost[i-1,j]; 
     
                // here we check we get minimum value of weight 
                // either by including it or excluding 
                // it 
                else
                    min_cost[i,j] = Math.Min(min_cost[i-1,j], 
                                min_cost[i,j-wt[i-1]] + val[i-1]); 
  		} 
       	 } 
     
        // Exactly weight W can not be made by 
        // given weights 
        return (min_cost[n,W] == int.MaxValue )? -1: min_cost[n,W]; 
    } 
  
    // Driver Code 
    public static void Main() 
    { 
//      int []cost = {13, 27, 49};
//          int W = 3; 
//          int n = cost.Length; 
//          Console.WriteLine("Return (62," + MinimumCost(cost, n, W) + ")"); 

//        int []cost = {50, 60, 70, 80};
//            int W = 4; 
//            int n = cost.Length; 
//	    Console.WriteLine("Return (120," + MinimumCost(cost, n, W) + ")"); 
	
	int []cost = {0};
           int W = 1; 
           int n = cost.Length; 
	   Console.WriteLine("Return (80," + MinimumCost(cost, n, W) + ")"); 
      } 
  } 
}
