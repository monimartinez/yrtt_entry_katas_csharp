using System;
using System.Collections.Generic;

// Introduction
// The wave (known as the Mexican wave in the English-speaking world outside North America) is an example of metachronal rhythm achieved in a packed 
// stadium when successive groups of spectators briefly stand, yell, and raise their arms. Immediately upon stretching to full height, the spectator 
// returns to the usual seated position.

// The result is a wave of standing spectators that travels through the crowd, even though individual spectators never move away from their seats. 
// In many large arenas the crowd is seated in a contiguous circuit all the way around the sport field, and so the wave is able to travel continuously 
// around the arena; in discontiguous seating arrangements, the wave can instead reflect back and forth through the crowd. When the gap in seating is narrow, 
// the wave can sometimes pass through it. Usually only one wave crest will be present at any given time in an arena, although simultaneous, counter-rotating 
// waves have been produced. (Source Wikipedia)

// Task
// In this simple Kata your task is to create a function that turns a string into a Mexican Wave. You will be passed a string and you must return that string in an array where an uppercase letter is a person standing up. 

// Rules
//  1.  The input string will always be lower case but maybe empty.
//  2.  If the character in the string is whitespace then pass over it as if it was an empty seat
// Example
// wave("hello") => ["Hello", "hEllo", "heLlo", "helLo", "hellO"]

//Changed namespace to "Test" instead of TechReturners.Tasks (created another project) as I ran it like this on my Desktop .Net (please see files submitted in Google Classroom with screenshot)
namespace Test
{
    class Program
    {

    // Function that takes
    //string and zigzag offset 
    static void fun(string s, int n) 
    { 
	 // if offset is 1 
    	if (n == 1)  
       
    { 
        // Simply print the  
        // string and return 
        Console.Write(s);              
        return; 
    } 

    // Get length of the string 
    int len = s.Length;  
      
    // Create a 2d character array 
    char[,] a = new char[len,len]; 
    char[] c = s.ToCharArray(); 
      
    // for counting the 
    // rows of the ZigZag 
    int row = 0;          
    bool down = true; 
      
    for (int i = 0; i < len; i++) 
    { 
        // put characters  
        // in the matrix 
        a[row, i] = c[i];  
          
        // You have reached the bottom 
        if (row == n - 1) 
            down = false;      
        else if (row == 0) 
            down = true;  
              
        if(down) 
            row++; 
        else
            row--; 
    } 
      
    // Print the Zig-Zag String 
    for (int i = 0; i < n; i++) 
    {  
        for (int j = 0; j < len; j++) 
        { 
            Console.Write(a[i, j] + " "); 
        } 
        Console.Write("\n"); 
    } 
    } 
      
    // Driver Code 
    public static void Main()  
    { 
        string s = "HellohElloheLloHelLoHellO"; 
        int n = 3; 
        fun(s, n); 
    } 
} 
}
