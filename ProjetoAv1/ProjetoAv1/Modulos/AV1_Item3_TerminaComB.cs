
using System;
using ProjetoAv1.Core;

namespace ProjetoAv1.Modulos
{
    public static class AV1_Item3_TerminaComB
    {
        public static void Executar()
        {
            Console.WriteLine("Item 3 — Decisor: termina com 'b'?");
            string cadeia = Console.ReadLine() is null ? "" : "";
            do
            {
                cadeia = LeituraConsole.LerNaoVazio("Informe cadeia sobre Σ={a,b}: ");
            } while (!ValidadorAlfabeto.CadeiaEmSigma(cadeia));

            bool sim = cadeia.Length > 0 && cadeia[^1] == 'b';
            Console.WriteLine(sim ? "SIM" : "NAO");
        }
    }
}
