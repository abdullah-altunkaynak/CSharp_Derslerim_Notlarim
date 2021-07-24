using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders1odev
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo ilkBasilan;
            string basilan;
            int kontrol = 0;
            Console.TreatControlCAsInput = true;
            Console.WriteLine("CTRL+W veya ALT+F4 tuşları ile çıkış sağlayabilirsiniz.\nCTRL+C kombini ile hello world yazdırabilirsiniz. Ayrıca program bastığınız tuşları ekrana yazacaktır!");
            do
            {
                /* .modifiers(enum) - Klavyede SHIFT, ALT ve CTRL değiştirici tuşlarını temsil eder. */
                ilkBasilan = Console.ReadKey();
                basilan = ilkBasilan.Key.ToString();
                Console.WriteLine("{0}", ilkBasilan.Key);
                if ((ilkBasilan.Modifiers & ConsoleModifiers.Alt) != 0)
                {
                    if (basilan == "F4")
                    {
                        Environment.Exit(42);
                        kontrol = 1;
                    }
                }
                if ((ilkBasilan.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    Console.Write("SHIFT+");
                }  
                if ((ilkBasilan.Modifiers & ConsoleModifiers.Control) != 0)
                {
                    if(basilan == "C")
                    {
                        Console.WriteLine("Hello World!");
                    }
                    if (basilan == "W")
                    {
                        Environment.Exit(42);
                        kontrol = 1;
                    }
                }
            } while (kontrol != 1);
        }
    }
}
