using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


class TabelaHash
{
    private List<string>[] tabela = new List<string>[5];

    public TabelaHash()
        {
        for (int i = 0; i < tabela.Length; i++)
            tabela[i] = new List<string>();
    
    }
    private int FuncaoHash(string chave)
    {
        return chave.Length % 5;
    }
    public void Adicionar(string palavra)
    {
        int indice = FuncaoHash(palavra);
        tabela[indice].Add(palavra);
        Console.WriteLine($"Palavra '{palavra}' armazenada no indice {indice}.");
    }

    public void ExibirTabela()
    {
        Console.WriteLine("\n--- Estado da Tabela Hash ---");
        for (int i = 0; i < tabela.Length; i++)
        {
            Console.Write($"Indice {i}; ");
            foreach (var item in tabela[i])
            {
                Console.Write($"[{item}] ->");
            }
            Console.WriteLine("null");

        }
     }

        class Program
        {
         static void Main()
        { 
            TabelaHash dicionario = new TabelaHash();

            dicionario.Adicionar("Cat");
            dicionario.Adicionar("Dog"); // Colisão
            dicionario.Adicionar("Bird");
            dicionario.Adicionar("Ox");

                }
         }

    }

