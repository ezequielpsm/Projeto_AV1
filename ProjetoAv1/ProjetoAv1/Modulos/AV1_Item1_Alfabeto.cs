
using System;
using ProjetoAv1.Core;

namespace ProjetoAv1.Modulos
{
    public static class AV1_Item1_Alfabeto
    {
        public static void Executar()
        {
            Console.WriteLine("Item 1 — Verificador Σ={a,b,c,d,e}");
            string simboloStr = LeituraConsole.LerNaoVazio("Digite um símbolo: ");
            char c = simboloStr[0];
            Console.WriteLine(ValidadorAlfabeto.SimboloEmSigma(c) ? "símbolo válido no alfabeto" : "símbolo inválido no alfabeto");

            string cadeia = LeituraConsole.LerNaoVazio("Digite uma cadeia: ");
            Console.WriteLine(ValidadorAlfabeto.CadeiaEmSigma(cadeia) ? "cadeia válida em Σ*" : "cadeia inválida (há símbolos fora de Σ)");
        }
    }
}
