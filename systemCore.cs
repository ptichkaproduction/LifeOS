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
    internal class t3stCore
    {
        public void core()
        {

            string device = Environment.MachineName;
            string buffer = "";
            string buffer_text = "";
            DateTime now = DateTime.Now;
            bool start = true;

            try
            {
                Console.Write("-------\nWelcome to "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("Life"); Console.ForegroundColor = ConsoleColor.White; Console.Write("OS!\nVer 0.02 pre-alpha\n-------\n");
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.Write("Critical Error."); Console.ForegroundColor = ConsoleColor.White;
            }

            while (start)
            {
                Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(device); Console.ForegroundColor = ConsoleColor.White; Console.Write("$> ");
                string command = Console.ReadLine();

                switch (command)
                {
                    default:
                        bool file_check = File.Exists(command);
                        if (file_check) { try { Process.Start(command); } catch (Exception e) { Console.WriteLine("Err. Comments:\n" + e.ToString()); } }
                        else
                        {
                            Console.WriteLine($"Command '{command}' not exist.");
                        }
                        break;

                    case "help":
                        Console.WriteLine(@"
Total commands: 6

help - help list
time - print time and date
ver - print app version
clear - clear screen
echo - print your text
exit - exit from 'OS'
");
                        break;

                    case "ver":
                         Console.Write(@"  _     _  __       ___  ____  
 | |   (_)/ _| ___ / _ \/ ___|  LifeOS ver 0.02 pre-alpha (August 2025)
 | |   | | |_ / _ \ | | \___ \  Created by perryBalo0n
 | |___| |  _|  __/ |_| |___) | Based on C# (CSharp)
 |_____|_|_|  \___|\___/|____/

");
                        break;

                    case "clear":
                        Console.Clear();
                        break;

                    case "exit":
                        Console.WriteLine("Exiting...");
                        start = false;
                        break;

                    case "reboot":
                        Console.WriteLine("Rebooting...");
                        start = false;
                        var core = new t3stCore();
                        core.core();
                        break;

                    case "time":
                        Console.WriteLine(DateTime.Now);
                        break;

                    case "":
                        break;

                    case "testAnimation":
                        Console.Clear();
                        Console.WriteLine("O");
                        Thread.Sleep(100);
                        Console.Clear();
                        Console.WriteLine("o");
                        Thread.Sleep(100);
                        Console.Clear();
                        Console.WriteLine("O");
                        Thread.Sleep(100);
                        Console.Clear();
                        Console.WriteLine("o");
                        Thread.Sleep(100);
                        Console.Clear();
                        break;

                    case "echo":
                        try
                        {
                            Console.Write("Enter text: ");
                            buffer_text = Console.ReadLine();
                            Console.WriteLine(buffer_text);
                        }
                        catch (Exception e) { Console.WriteLine("Unknown err"); }
                        break;
                }
            }

        }

    }

}
