
using System;
using ProjetoAv1.Core;

namespace ProjetoAv1.Modulos
{
    public static class AV1_Item5_Reconhecedores
    {
        private static bool LParA(string w)
        {
            int countA = 0;
            foreach (char c in w) if (c == 'a') countA++;
            return (countA % 2) == 0;
        }

        private static bool LA_bEstrela(string w)
        {
            if (w.Length == 0) return false;
            if (w[0] != 'a') return false;
            for (int i = 1; i < w.Length; i++)
            {
                if (w[i] != 'b') return false;
            }
            return true;
        }

        public static void Executar()
        {
            Console.WriteLine("Item 5 — Reconhecedores");
            string w;
            do
            {
                w = LeituraConsole.LerNaoVazio("Informe cadeia sobre Σ={a,b}: ");
            } while (!ValidadorAlfabeto.CadeiaEmSigma(w));

            Console.WriteLine("Escolha linguagem: 1) L_par_a  2) L = { w | w = a b* }");
            string? s = Console.ReadLine();
            int op = int.TryParse(s, out int v) ? v : 0;

            bool aceita = op switch
            {
                1 => LParA(w),
                2 => LA_bEstrela(w),
                _ => throw new InvalidOperationException("Opção inválida.")
            };

            Console.WriteLine(aceita ? "ACEITA" : "REJEITA");
        }
    }
}
