using System;

namespace redes1
{
    class Program
    {
        public static int op;
        public static string x, resp1, resp2, resp3, resp4, resp5;
        static void Main(string[] args)
        //com mudanças do tico
        {
            //funçoes
            void mold()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                for (int x = 0; x <= 23; x++)
                    Console.WriteLine("║                                                                                                                 ║");
                Console.SetCursorPosition(0, 27);
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            }
            void quest1()
            {
                mold();
                Console.SetCursorPosition(3, 3);
                Console.Write("o intervalo de tempo que é necessário para que um ponto vibrante percorra  um ciclo completo é denominado: ");
                Console.SetCursorPosition(3, 4);
                Console.WriteLine("a- frequência");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("b- período");
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("c- ciclo");
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("digite a resposta da 1");
                Console.SetCursorPosition(3, 8);
                Console.WriteLine("[ ]");
                Console.SetCursorPosition(4, 8);
                resp1 = Console.ReadLine();
                switch (resp1)
                {
                    case "a":
                        Console.SetCursorPosition(3, 9);
                        Console.Write("resposta incorreta :(");
                        break;
                    case "b":
                        Console.SetCursorPosition(3, 9);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("resposta correta!!");
                        break;
                    case "c":
                        Console.SetCursorPosition(3, 9);
                        Console.Write("resposta incorreta :(");
                        break;
                }
            }
            void quest2()
            {
                mold();
                Console.SetCursorPosition(3, 3);
                Console.Write("qual destas formas NÃO é uma forma de transmissão de dados");
                Console.SetCursorPosition(3, 4);
                Console.WriteLine("a- simplex");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("b- síncrona");
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("c- full-duplex");
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("d- half-duplex");
                Console.SetCursorPosition(3, 8);
                Console.WriteLine("digite a resposta da 2");
                Console.SetCursorPosition(3, 9);
                Console.WriteLine("[ ]");
                Console.SetCursorPosition(4, 9);
                resp2 = Console.ReadLine();

                switch (resp2)
                {
                    case "a":
                        Console.SetCursorPosition(3, 10);
                        Console.Write("resposta incorreta :(");
                        break;
                    case "b":
                        Console.SetCursorPosition(3, 10);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("resposta correta!!");
                        break;
                    case "c":
                        Console.SetCursorPosition(3, 10);
                        Console.Write("resposta incorreta :(");
                        break;
                }
            }
            void quest3()
            {
                mold();
                Console.SetCursorPosition(3, 3);
                Console.Write("A classificação das redes está ligada à sua área cobertura e ao modo de comunicação entre seus componentes. ");
                Console.SetCursorPosition(3, 4);
                Console.Write("Quais das Redes abaixo não contempla uma classificação.");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("a- LAN");
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("b- WAN");
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("c- YAN");
                Console.SetCursorPosition(3, 8);
                Console.WriteLine("digite a resposta da 3");
                Console.SetCursorPosition(3, 9);
                Console.WriteLine("[ ]");
                Console.SetCursorPosition(4, 9);
                resp3 = Console.ReadLine();

                switch (resp3)
                {
                    case "a":
                        Console.SetCursorPosition(3, 10);
                        Console.Write("resposta incorreta :(");
                        break;
                    case "b":
                        Console.SetCursorPosition(3, 10);
                        Console.Write("resposta incorreta :(");
                        break;
                    case "c":
                        Console.SetCursorPosition(3, 10);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("resposta correta!!");
                        break;
                }
            }
            void quest4()
            {
                mold();
                Console.SetCursorPosition(3, 3);
                Console.Write("Nesta topologia existe um cabo coaxial atravessando toda a extensão da rede e interligando todos os dispositivo:");
                Console.SetCursorPosition(3, 4);
                Console.WriteLine("a- ANEL");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("b- BARRAMENTO");
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("c- ESTRELA");
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("digite a resposta da 4");
                Console.SetCursorPosition(3, 8);
                Console.WriteLine("[ ]");
                Console.SetCursorPosition(4, 8);
                resp4 = Console.ReadLine();

                switch (resp4)
                {
                    case "a":
                        Console.SetCursorPosition(3, 9);
                        Console.Write("resposta incorreta :(");
                        break;
                    case "b":
                        Console.SetCursorPosition(3, 9);                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("resposta correta!!");
                        break;
                    case "c":
                        Console.SetCursorPosition(3, 9);
                        Console.Write("resposta incorreta :(");
                        break;
                }
            }
            void quest5()
            {
                mold();
                Console.SetCursorPosition(3, 3);
                Console.Write("Nessas redes, os sistemas operacionais instalados em todos os dispositivos são do tipo cliente. ");
                Console.SetCursorPosition(3, 4);
                Console.WriteLine("a- Ponto a Ponto");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("b- Hardware");
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("c- Cliente Servidor");
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("digite a resposta da 5");
                Console.SetCursorPosition(3, 8);
                Console.WriteLine("[ ]");
                Console.SetCursorPosition(4, 8);
                resp5 = Console.ReadLine();

                switch (resp5)
                {
                    case "a":
                        Console.SetCursorPosition(3, 9);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("resposta correta!!");
                        break;
                    case "b":
                        Console.SetCursorPosition(3, 9);
                        Console.Write("resposta incorreta :(");
                        break;
                    case "c":
                        Console.SetCursorPosition(3, 9);
                        Console.Write("resposta incorreta :(");
                        break;
                }
            }
            void result()
            {
                int[] array_points = new int[5];

                if (resp1 == "b" || resp1 == "B")
                {
                    array_points[0] = 1;
                }
                if (resp2 == "b" || resp2 == "B")
                {
                    array_points[1] = 1;
                }
                if (resp3 == "c" || resp3 == "C")
                {
                    array_points[2] = 1;
                }
                if (resp4 == "b" || resp4 == "B")
                {
                    array_points[3] = 1;
                }
                if (resp5 == "a" || resp5 == "A")
                {
                    array_points[4] = 1;
                }
                else
                {
                    array_points[0] = 0;
                    array_points[1] = 0;
                    array_points[2] = 0;
                    array_points[3] = 0;
                    array_points[4] = 0;

                }
                int points = array_points[0] + array_points[1] + array_points[2] + array_points[3] + array_points[4];
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("███████████████████████████████████████████");
                for (int c = 8; c <= 18; c++)
                {
                    Console.SetCursorPosition(3, c);
                    Console.WriteLine("█                                         █");
                }
                Console.SetCursorPosition(3, 18);
                Console.WriteLine("██████████████████████████████████████████");
                Console.SetCursorPosition(5, 10);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("QUIZ FINALIZADO COM SUCESSO");
                Console.SetCursorPosition(5, 12);
                Console.Write("VOCÊ TEM " + points + " PONTOS");
                Console.SetCursorPosition(5, 14);
                Console.Write("aperte qualquer tecla p/ continuar");
                Console.SetCursorPosition(5, 15);
                Console.Write("ou digite X para sair: ");
                x = Console.ReadLine();
            }
            //menu
            do
            {
            mold();
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("MENU");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("1 - iniciar jogo");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("2 - sair do jogo");
            Console.SetCursorPosition(3, 6);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[ ]");
            Console.SetCursorPosition(4, 6);
            op = Convert.ToInt32(Console.ReadLine());
                switch (op) {
                    case 1:
                        quest1();
                        Console.SetCursorPosition(3, 10);
                        Console.Write("aperte Enter para próxima pergunta.");
                        Console.ReadKey();
                        Console.Clear();
                        quest2();
                        Console.SetCursorPosition(3, 11);
                        Console.Write("aperte Enter para próxima pergunta.");
                        Console.ReadKey();
                        Console.Clear();
                        quest3();
                        Console.SetCursorPosition(3, 11);
                        Console.Write("aperte Enter para próxima pergunta.");
                        Console.ReadKey();
                        Console.Clear();
                        quest4();
                        Console.SetCursorPosition(3, 10);
                        Console.Write("aperte Enter para próxima pergunta.");
                        Console.ReadKey();
                        Console.Clear();
                        quest5();
                        Console.SetCursorPosition(3, 10);
                        Console.Write("aperte Enter para próxima pergunta.");
                        Console.Clear();
                        result();
                        Console.ReadKey();
                        break;
                        case 2:
                        Console.Clear();
                        break;
                }
                
            } while (x != "x" || x != "X");
        }
    }
}
