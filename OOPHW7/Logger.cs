using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPHW7
{
    public class Logger{
        public static void log(String str)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine(str);
            File.AppendAllText("CalcLog.csv", current + ": " + str + "\n");
        }
    }
}