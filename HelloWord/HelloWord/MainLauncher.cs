using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWord;

namespace HelloWord
{
    class MainLauncher
    {
        

        public static void Main(string[] args)
        {
            ExampleApp app=new Program();
            
            app.RunExample(args);
#if DEBUG
            Console.WriteLine("Press enter to Close...");
            Console.ReadLine();
#endif
        }
    }
}