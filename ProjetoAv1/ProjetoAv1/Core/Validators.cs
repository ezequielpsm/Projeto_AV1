
using System;
using System.Collections.Generic;

namespace ProjetoAv1.Core
{
    public static class ValidadorAlfabeto
    {
        private static readonly HashSet<char> Sigma = new HashSet<char> { 'a', 'b', 'c', 'd', 'e' };

        public static bool SimboloEmSigma(char c) => Sigma.Contains(c);

        public static bool CadeiaEmSigma(string cadeia)
        {
            if (cadeia is null) return false;
            foreach (char c in cadeia)
            {
                if (!Sigma.Contains(c)) return false;
            }
            return true;
        }
    }

    public static class LeituraConsole
    {
        public static string LerNaoVazio(string prompt)
        {
            Console.Write(prompt);
            string? s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.Write("Entrada vazia. Tente novamente: ");
                s = Console.ReadLine();
            }
            return s.Trim();
        }

        public static int LerInteiro(string prompt, int min, int max)
        {
            Console.Write(prompt);
            string? s = Console.ReadLine();
            int v;
            while (!int.TryParse(s, out v) || v < min || v > max)
            {
                Console.Write($"Valor inválido. Digite um inteiro entre {min} e {max}: ");
                s = Console.ReadLine();
            }
            return v;
        }
    }
}
