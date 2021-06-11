using System;

namespace principal
{
    class Program
    {
        static void Main(string[] args)
        {
            void mold()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("██████████████████████████████████████████████████████");
                for (int x = 0; x <= 24; x++)
                    Console.WriteLine("█                                                    █");
                Console.SetCursorPosition(0, 27);
                Console.WriteLine("██████████████████████████████████████████████████████");
            }
            mold();
            int op;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("MENU");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("1 - REDES1");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("2 - FÍSICA");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("3 - QUÍMICA");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("[ ]");
            Console.SetCursorPosition(4, 7);
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo si1 = new
                    System.Diagnostics.ProcessStartInfo();

                    si1.UseShellExecute = true;
                    si1.FileName = "E:/projetof.logica/redes1/redes1/bin/Debug/netcoreapp3.1/redes1.exe";
                    si1.Arguments = " /newsonly";

                    p1.StartInfo = si1;
                    p1.Start();
                    break;
                case 2:
                    System.Diagnostics.Process p2 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo si2 = new
                    System.Diagnostics.ProcessStartInfo();

                    si2.UseShellExecute = true;
                    si2.FileName = "E:/projetof.logica/fisica/fisica/bin/Debug/netcoreapp3.1/fisica.exe";
                    si2.Arguments = " /newsonly";

                    p2.StartInfo = si2;
                    p2.Start();
                    break;
                case 3:
                    System.Diagnostics.Process p3 = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo si3 = new
                    System.Diagnostics.ProcessStartInfo();

                    si3.UseShellExecute = true;
                    si3.FileName = "E:/projetof.logica/quimica/quimica/bin/Debug/netcoreapp3.1/quimica.exe";
                    si3.Arguments = " /newsonly";

                    p3.StartInfo = si3;
                    p3.Start();
                    break;
               
            }
        }
    }
}
