//created by perryBallo0n (2025)

using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Xml.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LifeOS
{
    internal class boot
    {
        static void Main(string[] args)
        {

            try
            {
                var core = new t3stCore();
                Console.Write("["); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("BOOT"); Console.ForegroundColor = ConsoleColor.White; Console.Write("]: Loading.");
                Thread.Sleep(100);
                Console.Clear();
                Console.Write("["); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("BOOT"); Console.ForegroundColor = ConsoleColor.White; Console.Write("]: Loading..");
                Thread.Sleep(100);
                Console.Clear();
                Console.Write("["); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("BOOT"); Console.ForegroundColor = ConsoleColor.White; Console.Write("]: Loading...");
                Thread.Sleep(100);
                Console.Clear();
                Console.Write("["); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("BOOT"); Console.ForegroundColor = ConsoleColor.White; Console.Write("]: Loading...COMPLETE!\n");
                core.core();
                Console.Write("["); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("BOOT"); Console.ForegroundColor = ConsoleColor.White; Console.Write("]: Exited with code: 0x0\n");
            }
            catch (Exception e)
            {
                Console.Write("["); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("BOOT"); Console.ForegroundColor = ConsoleColor.White; Console.Write("]: Critical error.");
                Console.WriteLine(e.ToString());
            }
        }
    }
}