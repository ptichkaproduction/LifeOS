//created by perryBallo0n (2025)

using System;
using System.Data;
using System.Diagnostics;
using System.Text.Json;
using System.Xml.Schema;

namespace LifeOS
{
    internal class t3stCore
    {
        static void Main(string[] args)
        {

            string device = Environment.MachineName;
            string buffer = "";
            DateTime now = DateTime.Now;
            bool start = true;

            try
            {
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Loaded!"); Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Welcome to "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("Life"); Console.ForegroundColor = ConsoleColor.White; Console.Write("OS!\n-------\n");
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
Total commands: 5

help - help list
time - print time and date
ver - print app version
clear - clear screen
exit - exit from 'OS'
");
                        break;

                    case "ver":
                         Console.Write(@"  _     _  __       ___  ____  
 | |   (_)/ _| ___ / _ \/ ___|  LifeOS ver 0.01 pre-alpha (August 2025)
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

                    case "time":
                        Console.WriteLine(DateTime.Now);
                        break;

                    case "":
                        break;
                }
            }

        }

    }

}
