using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonic1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fs1 = new StreamReader(args[0]);
            StreamWriter result = new StreamWriter(args[0] + ".email");

            string s = "";
            while (s != null)
            {
                s = fs1.ReadLine();
                if (s != null)
                {
                    var ss = s.Split(',');
                    if (ss.Count() > 4)
                        if (ss[4].Length > 3) result.WriteLine(ss[4].Substring(1, ss[4].Length - 2));
                }
            }
            result.Close();
        }
    }
}
