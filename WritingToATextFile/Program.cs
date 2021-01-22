using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace WritingToATextFile
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                // get the integers 1 to 10:
                var integers = Enumerable.Range(1, 20).Select(x => $"{x}");
                File.AppendAllLines("f1.txt", integers);
                

                using (var sw = new StreamWriter("sw.txt"))
                {
                    foreach (var s in integers)
                    {
                        sw.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                var fullname = System.Reflection.Assembly.GetEntryAssembly().Location;
                var progname = Path.GetFileNameWithoutExtension(fullname);
                Console.Error.WriteLine($"{progname} Error: {ex.Message}");
            }

        }
    }
}
