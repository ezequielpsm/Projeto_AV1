
using System;
using ProjetoAv1.Core;
using ProjetoAv1.Modulos;

namespace ProjetoAv1
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("=== ProjetoAv1 ===");
                Console.WriteLine("AV1");
                Console.WriteLine(" 1) Verificador de alfabeto e cadeia em Σ={a,b}");
                Console.WriteLine(" 2) Classificador T/I/N por JSON");
                Console.WriteLine(" 3) Programa de decisão: termina com 'b'?");
                Console.WriteLine(" 4) Avaliador proposicional básico");
                Console.WriteLine(" 5) Reconhecedor Σ={a,b}: L_par_a e L = { w | w = a b* }");
                Console.WriteLine(" 0) Sair");
                int op = LeituraConsole.LerInteiro("Escolha: ", 0, 5);
                Console.WriteLine();

                try
                {
                    switch (op)
                    {
                        case 0: return;
                        case 1: AV1_Item1_Alfabeto.Executar(); break;
                        case 2: AV1_Item2_TIN_Quiz.Executar(); break;
                        case 3: AV1_Item3_TerminaComB.Executar(); break;
                        case 4: AV1_Item4_Proposicional.Executar(); break;
                        case 5: AV1_Item5_Reconhecedores.Executar(); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }

                Console.WriteLine();
            }
        }
    }
}
