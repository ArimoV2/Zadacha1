using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] strs = { "game", "gang", "girl" };
            Console.WriteLine(Prefix(strs));
            Console.ReadKey();

        }


        static string Prefix(string[] strs)
        {
            string prefix = strs.Length > 0 ? strs[0] : "";

            for (int i = 1; i < strs.Length && prefix != ""; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                }
            }
            return prefix;
            
        }
    }


}
