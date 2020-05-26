using System;

namespace CS_Advanced_Topics___Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<DateTime> date = null;
            //DateTime? date = null;                    // Shorthand version of Nullable<DateTime>            
            //DateTime? date = new DateTime(2014, 1, 1);  // Still Nullable
            //DateTime date2 = date;                      // Can't put nullable datetime in a regular datetime

            //Console.WriteLine(date.GetValueOrDefault());
            //Console.WriteLine(date.HasValue);
            //Console.WriteLine("Value: " + date.Value);

            //DateTime? date = new DateTime(2014, 1, 1);
            //DateTime date2 = date.GetValueOrDefault();
            //DateTime? date3 = date2;

            //Console.WriteLine(date3.GetValueOrDefault());

            //DateTime? date = null;
            //DateTime date2;

            //if (date != null)
            //    date2 = date.GetValueOrDefault();
            //else
            //    date2 = DateTime.Today;

            //Console.WriteLine(date2);

            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;    // SHort hand of if statement - if has value use left, otherwise use right
            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;    // Otherway to write that.

            Console.WriteLine(date2);
        }
    }
}
