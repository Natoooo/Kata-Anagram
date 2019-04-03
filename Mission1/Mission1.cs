using System;
using System.IO;
using System.Linq;

namespace Katas
{
    class Mission1
    {
        static void Main(string[] args)
        {
            var words = System.IO.File.ReadAllLines("mission1.txt");
            var baseStr = new string("Atelier".ToLower().OrderBy(ch => ch).ToArray());
            var count = 0;

            for(var i = 0; i < words.Length; i++)
            {
                for(var j = i; j < words.Length; j++)
                {
                    if (words[i].Length+ words[j].Length == baseStr.Length)
                    {
                        if (Match(baseStr, words[i], words[j]))
                        {
                            Console.WriteLine(words[i] + " " + words[j]);
                            count++;
                        }
                    }
                }
            }        

            Console.WriteLine("count=" + count); 
        }

        public static bool Match(string baseStr, string str1, string str2)
        {        
            var str = new string((str1 + str2).OrderBy(ch => ch).ToArray());

            return (baseStr == str);
        }
    }
}
