using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            //ObsoleteClass obsoleteClass = new ObsoleteClass();
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //Console.WriteLine(obsoleteClass.OldMethod());
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedTicks);
            ConditionalClass conditionalClass = new ConditionalClass();
//#if DEBUG
            conditionalClass.Login();
//#else
            conditionalClass.Login("user", "pass");
//#endif
            Console.Read();
        }
    }
}
