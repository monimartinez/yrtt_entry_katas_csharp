using System;
using System.Globalization;
using System.Text.RegularExpressions;

// The clock shows 'h' hours, 'm' minutes and 's' seconds after midnight.
// Your task is to make the 'past' function return the time converted to milliseconds.
// More examples in the test cases below.

//Changed namespace to "my App" instead of TechReturners.Tasks - as I ran it like this on my Desktop .Net (please see files submitted in Google Classroom with screenshot)
namespace myApp
{
    class Program
    {
      public static void Main()
   {
      string dateString = "11/19/2020 5:27:34.124 AM";

      try
      {
         DateTime dateValue = DateTime.Parse(dateString);
         DateTimeOffset dateOffsetValue = DateTimeOffset.Parse(dateString);

         // Display Milliseconds component alone.
         Console.WriteLine("Milliseconds component only: {0}",
                           dateValue.ToString("fff"));

         // Display Milliseconds component with full date and time.
         Console.WriteLine("Date and Time with Milliseconds: {0}",
                           dateValue.ToString("dd/MM/yyyy hh:mm:ss.fff tt"));

         // Append millisecond pattern to current culture's full date time pattern
         string fullPattern = DateTimeFormatInfo.CurrentInfo.FullDateTimePattern;
         fullPattern = Regex.Replace(fullPattern, "(:ss|:s)", "$1.fff");

         // Display Millisecond component with modified full date and time pattern.
         Console.WriteLine("Modified full date time pattern: {0}",
                           dateValue.ToString(fullPattern));

      }
      catch (FormatException)
      {
         Console.WriteLine("Unable to convert {0} to a date.", dateString);
      }
   }
}
}
