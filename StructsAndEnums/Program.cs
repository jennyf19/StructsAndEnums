#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        private static Date weddingAnniversary;

        static void doWork()
        {
            /*Month first = Month.January;
            Console.WriteLine(first);
            //increment the first variable and display its value to the console
            first++;
            Console.WriteLine(first);*/
            Date defaultDate = new Date();
            Console.WriteLine(defaultDate);

            Date weddingAnniversary = new Date(2015, Month.July, 4);
            Console.WriteLine(weddingAnniversary);

            Date weddingAnniversityCopy = weddingAnniversary;
            Console.WriteLine($"Value of copy is {weddingAnniversityCopy}");

            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"New value of weddingAnniversary is {weddingAnniversary}");
            Console.WriteLine($"Value of copy is still {weddingAnniversityCopy}");

            Console.ReadLine();
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
