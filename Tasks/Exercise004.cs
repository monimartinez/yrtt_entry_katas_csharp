using System;
using System.Collections.Generic;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

//Changed namespace to "my App" instead of TechReturners.Tasks - as I ran it like this on my Desktop .Net (please see files submitted in Google Classroom with screenshot)
namespace myApp
{
    class Program
    {
     public static string ToMovefirstletter(string sentencetext)
    {
        string vowels = "AEIOUaeiou";
        string cons = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
        List<string> newWords = new List<string>();           

        foreach (string word in sentencetext.Split(' '))
        {
            if (word.Length == 1)
            {
                newWords.Add(word + "ay");
            }

            if (word.Length == 2 && vowels.Contains(word[0]))
            {
                newWords.Add(word + "ay");
            }

            if (word.Length == 2 && vowels.Contains(word[1]) && !vowels.Contains(word[0]))
            {
                newWords.Add(word.Substring(1) + word.Substring(0, 1) + "ay");
            }

            if (word.Length == 2 && !vowels.Contains(word[1]) && !vowels.Contains(word[0]))
            {
                newWords.Add(word + "ay");
            }                

            for (int i = 1; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]) && (vowels.Contains(word[0])))
                {
                    newWords.Add(word.Substring(i) + word.Substring(0, i) + "ay");
                    break;
                }
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]) && !(vowels.Contains(word[0])) && word.Length > 2)
                {
                    newWords.Add(word.Substring(i) + word.Substring(0, i) + "ay");
                    break;
                }

            }
        }            
            return string.Join(" ", newWords);          

    }

    static void Main(string[] args)
    {
            string Movefirstletter = ToMovefirstletter("Move first letter of words to final position plus ay");
            Console.WriteLine(Movefirstletter);
    }
  }
}
