using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmds = System.Environment.GetCommandLineArgs();
            //コマンドライン引数を列挙する
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            StreamWriter writer =  new StreamWriter("arg.txt", true, sjisEnc);

            foreach (string cmd in cmds)
            {
                Console.WriteLine(cmd);
                writer.WriteLine(cmd);
            }
            writer.Close();

        }
    }
}
