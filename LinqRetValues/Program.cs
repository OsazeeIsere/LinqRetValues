using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqRetValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ return values");
            IEnumerable<string> subset = GetStringSubset();

            foreach(string item in subset)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("LINQ return values as array");

            foreach (string item in GetStringSubsetAsArray()
)
            {
                Console.WriteLine(item);

            }

            Console.ReadLine();

        }

        private static string[] GetStringSubsetAsArray()
        {
            string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };

            // Note the subset is an IEnumerable<string>- compactible object
            var theRedColors = from c in colors where c.Contains("Red") select c;
            return theRedColors.ToArray();
        }

        private static IEnumerable<string> GetStringSubset()
        {
            string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };

            // Note the subset is an IEnumerable<string>- compactible object
            IEnumerable<string> theRedColors = from c in colors where c.Contains("Red") select c;
            return theRedColors;
        }
    }
}
