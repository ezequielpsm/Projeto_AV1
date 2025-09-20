
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ProjetoAv1.Modulos
{
    public static class AV1_Item2_TIN_Quiz
    {
        private static readonly string JsonItens = @"[
          { ""id"": 1, ""descricao"": ""Decidir se uma cadeia em Σ={a,b} termina com 'b'"", ""gabarito"": ""T"" },
          { ""id"": 2, ""descricao"": ""Descobrir se um programa C# qualquer irá parar em toda entrada"", ""gabarito"": ""N"" },
          { ""id"": 3, ""descricao"": ""Encontrar o menor caminho em um grafo com pesos não negativos"", ""gabarito"": ""T"" },
          { ""id"": 4, ""descricao"": ""Resolver exatamente o TSP para N muito grande em tempo polinomial"", ""gabarito"": ""I"" }
        ]";

        private record Item(int id, string descricao, string gabarito);

        public static void Executar()
        {
            Console.WriteLine("Item 2 — Classificador T/I/N por JSON");
            List<Item>? itens = JsonSerializer.Deserialize<List<Item>>(JsonItens);
            if (itens is null) { Console.WriteLine("Falha ao carregar itens."); return; }

            int acertos = 0, erros = 0;
            foreach (var it in itens)
            {
                Console.WriteLine($"\n{it.id}) {it.descricao}");
                Console.Write("Digite T (tratável), I (intratável) ou N (não computável): ");
                string? resp = Console.ReadLine()?.Trim().ToUpperInvariant();
                while (resp != "T" && resp != "I" && resp != "N")
                {
                    Console.Write("Entrada inválida. Digite T/I/N: ");
                    resp = Console.ReadLine()?.Trim().ToUpperInvariant();
                }
                if (resp == it.gabarito)
                    acertos++;
                else erros++;
            }

            Console.WriteLine($"\nResumo: acertos={acertos}, erros={erros}, total={acertos+erros}");
        }
    }
}
