using System;

namespace fisica
{
    class Program
    {
        public static int op;
        public static string x, resp1, resp2, resp3, resp4, resp5;
        static void Main(string[] args)
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
                Console.Write("em relação ao conceito de temperatura, assinale a alternativa correta:");
                Console.SetCursorPosition(3, 4);
                Console.WriteLine("a- é possível atribuir uma tempearatura ao vácuo ideal");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("b- a temperatura é uma grande macroscópica.");
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("c- quando um corpo recebe calor, sua temperatura necessariamente aumenta.");
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
                Console.Write("Um amolador de facas, ao operar um esmeril, é atingido por fagulhas incandescentes, mas não se queima.");
                Console.SetCursorPosition(3, 4);
                Console.Write("Isso acontece porque as fagulhas:");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("a- tem calor específico muito grande");
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("b- tem temperatura muito baixa");
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("c- tem capacidade térmica muito pequena");
                Console.SetCursorPosition(3, 8);
                Console.WriteLine("d- half-duplex");
                Console.SetCursorPosition(3, 9);
                Console.WriteLine("digite a resposta da 2");
                Console.SetCursorPosition(3, 10);
                Console.WriteLine("[ ]");
                Console.SetCursorPosition(4, 10);
                resp2 = Console.ReadLine();

                switch (resp2)
                {
                    case "a":
                        Console.SetCursorPosition(3, 11);
                        Console.Write("resposta incorreta :(");
                        break;
                    case "b":
                        Console.SetCursorPosition(3, 11);
                        Console.Write("resposta incorreta :(");
                        break;
                    case "c":
                        Console.SetCursorPosition(3, 11);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("resposta correta!!");
                        break;
                }
            }
            void quest3()
            {
                mold();
                Console.SetCursorPosition(3, 3);
                Console.Write("Como consequência da compressão adiabática sofrida por um gás, pode - se afirmar que: ");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("a- a densidade do gás aumenta, e sua temperatura diminui.");
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("b- a densidade do gás e sua temperatura permanecem constantes.");
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("c- a densidade do gás e sua temperatura aumentam.");
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
                Console.Write("Suponha que sobre uma mesa haja um livro. Qual será a força que a mesa exerce sobre o livro,");
                Console.SetCursorPosition(3, 4);
                Console.Write(" sabendo que a força com que a Terra o atrai é de 10 N?");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("a- 5N");
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("b- 10N");
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("c- 25N");
                Console.SetCursorPosition(3, 8);
                Console.WriteLine("digite a resposta da 4");
                Console.SetCursorPosition(3, 9);
                Console.WriteLine("[ ]");
                Console.SetCursorPosition(4, 9);
                resp4 = Console.ReadLine();

                switch (resp4)
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
            void quest5()
            {
                mold();
                Console.SetCursorPosition(3, 3);
                Console.Write("Uma corrente consistindo de sete anéis, cada um de massa 200 gramas, está sendo puxada verticalmente,");
                Console.SetCursorPosition(3, 4);
                Console.Write("para cima, com aceleração constante de 2, 0 m / s². A força para cima no anel do meio é:");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("a- 16,8N");
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("b- 9,6N");
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("c- 2,4N");
                Console.SetCursorPosition(3, 8);
                Console.WriteLine("digite a resposta da 5");
                Console.SetCursorPosition(3, 9);
                Console.WriteLine("[ ]");
                Console.SetCursorPosition(4, 9);
                resp5 = Console.ReadLine();

                switch (resp5)
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
            void result()
            {
                int[] array_points = new int[5];

                if (resp1 == "b" || resp1 == "B")
                {
                    array_points[0] = 1;
                }
                if (resp2 == "c" || resp2 == "C")
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
                if (resp5 == "b" || resp4 == "B")
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
            do{
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
                switch (op)
                {
                case 1:
                quest1();
                Console.SetCursorPosition(3, 10);
                Console.Write("aperte Enter para próxima pergunta.");
                Console.ReadKey();
                Console.Clear();
                quest2();
                Console.SetCursorPosition(3, 12);
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
                Console.ReadKey();
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
