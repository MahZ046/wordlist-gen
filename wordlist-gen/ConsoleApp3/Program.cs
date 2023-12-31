using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace ConsoleApp3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string gentitle = @" 
 ██████╗ ███████╗███╗   ██╗███████╗██████╗  █████╗ ████████╗ ██████╗ ██████╗ 
██╔════╝ ██╔════╝████╗  ██║██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██╔═══██╗██╔══██╗
██║  ███╗█████╗  ██╔██╗ ██║█████╗  ██████╔╝███████║   ██║   ██║   ██║██████╔╝
██║   ██║██╔══╝  ██║╚██╗██║██╔══╝  ██╔══██╗██╔══██║   ██║   ██║   ██║██╔══██╗
╚██████╔╝███████╗██║ ╚████║███████╗██║  ██║██║  ██║   ██║   ╚██████╔╝██║  ██║
 ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝";
            string logo = @"
███╗   ███╗ █████╗ ██╗  ██╗███████╗
████╗ ████║██╔══██╗██║  ██║╚══███╔╝
██╔████╔██║███████║███████║  ███╔╝ 
██║╚██╔╝██║██╔══██║██╔══██║ ███╔╝  
██║ ╚═╝ ██║██║  ██║██║  ██║███████╗
╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝";
        Main:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine(logo);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("options:");
            Thread.Sleep(1000);
            Console.ResetColor();
            Console.WriteLine("1)Go to generator");
            Console.WriteLine("2)info");
            Console.WriteLine("3)exit");
            Console.Write("option:");
           int islem = Int32.Parse(Console.ReadLine());
            
            if (islem == 1)
            {
                Random rnd = new Random();
                Console.Clear();
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(gentitle);
                Thread.Sleep(1000);
                Console.Write("min:");
                int min = Int32.Parse(Console.ReadLine());
                Console.Write("max:");
                int max = Int32.Parse(Console.ReadLine());
                Console.Write("file name to save(with extension):");
                string fl = Console.ReadLine();
                StreamWriter writer = new StreamWriter(fl);
                Console.Clear();
                for (int i = min -1; i < max +1; i++) {
                    Console.WriteLine(rnd.Next(min, max));
                    writer.WriteLine();
                    
                }
                
                Console.WriteLine("Done!");
           
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("press enter to back to main menu");
                Console.ReadLine();
                goto Main;
            }
            else if(islem == 2)
            {
                Console.Clear();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(logo);
                Console.ForegroundColor= ConsoleColor.Cyan; Console.WriteLine("This tool has been created by MahZ|AllianceHackTeam");
                Thread.Sleep(3000);
                goto Main;
            }
            else if(islem == 3)
            {
                EXİT:
                Console.Clear();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Are you sure to exit?[y/n]:");
                string sure = Console.ReadLine();
                if (sure == "y")
                {
                    Environment.Exit(0);
                }
                else if (sure == "n") {
                goto  Main;
                
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please select a vaild option y or n");
                    Thread.Sleep(2000);
                    goto EXİT;
                }

            }
            
                


                    
           

        }
    }
}