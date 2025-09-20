
using System;

namespace ProjetoAv1.Modulos
{
    public static class AV1_Item4_Proposicional
    {
        private static bool Implicacao(bool p, bool q) => (!p) || q;

        private static bool Formula1(bool P, bool Q, bool R) => (P && Q) || R;
        private static bool Formula2(bool P, bool Q, bool R) => Implicacao(P && Q, R);

        public static void Executar()
        {
            Console.WriteLine("Item 4 — Avaliador proposicional (P, Q, R)");
            Console.WriteLine("1) (P ∧ Q) ∨ R");
            Console.WriteLine("2) (P ∧ Q) → R");
            Console.WriteLine("3) Imprimir tabela-verdade completa de uma das fórmulas");
            Console.Write("Escolha: ");
            string? s = Console.ReadLine();
            int op = int.TryParse(s, out int v) ? v : 0;

            if (op == 3)
            {
                ImprimirTabela();
                return;
            }

            bool P = LerBool("Valor de P (0/1): ");
            bool Q = LerBool("Valor de Q (0/1): ");
            bool R = LerBool("Valor de R (0/1): ");

            bool resultado = op switch
            {
                1 => Formula1(P, Q, R),
                2 => Formula2(P, Q, R),
                _ => throw new InvalidOperationException("Opção inválida.")
            };
            Console.WriteLine($"Resultado: {(resultado ? 1 : 0)}");
        }

        private static void ImprimirTabela()
        {
            Console.WriteLine("Escolha fórmula para tabela: 1 ou 2");
            string? s = Console.ReadLine();
            int op = int.TryParse(s, out int v) ? v : 0;

            Console.WriteLine("P Q R | Resultado");
            for (int mask = 0; mask < 8; mask++)
            {
                bool P = (mask & 0b100) != 0;
                bool Q = (mask & 0b010) != 0;
                bool R = (mask & 0b001) != 0;

                bool res = op == 1 ? Formula1(P, Q, R) : Formula2(P, Q, R);
                Console.WriteLine($"{(P?1:0)} {(Q?1:0)} {(R?1:0)} | {(res?1:0)}");
            }
        }

        private static bool LerBool(string prompt)
        {
            Console.Write(prompt);
            string? s = Console.ReadLine();
            while (s != "0" && s != "1")
            {
                Console.Write("Digite 0 ou 1: ");
                s = Console.ReadLine();
            }
            return s == "1";
        }
    }
}
