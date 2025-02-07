using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GerenciarCliente
{
    private List<Cliente> clientes;
    private string caminhoArquivo = "clientes.json";

    public GerenciarCliente()
    {
        clientes = new List<Cliente>();
        Carregar();
    }

    public void CadastrarCliente()
    {
        Console.Clear();
        Console.WriteLine(" --- Cadastro de Cliente ---\n");

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("E-mail: ");
        string email = Console.ReadLine();

        Console.Write("Birth (yyyy-MM-dd): ");
        DateTime date;
        while (!DateTime.TryParse(Console.ReadLine(), out date))
        {
            Console.WriteLine("Formato inválido. Use o formato yyyy-MM-dd.");
            Console.Write("Birth (yyyy-MM-dd): ");
        }

        Cliente c1 = new Cliente(name, email, date);
        clientes.Add(c1);
        Salvar();

        Console.WriteLine("Cliente cadastrado com sucesso!");
    }

    public void ListarCliente()
    {
        Console.Clear();
        Console.WriteLine("\n --- Listagem de Clientes ---\n");

        if (clientes.Count == 0)
        {
            Console.WriteLine("Nenhum cliente cadastrado!");
        }
        else
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
        }

        Console.WriteLine("\nPressione uma tecla para continuar!");
        Console.ReadLine();
    }

    private void Salvar()
    {
        try
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(clientes, options);
            File.WriteAllText(caminhoArquivo, json);
            Console.WriteLine("Dados salvos com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar os dados: {ex.Message}");
        }
    }

    private void Carregar()
    {
        try
        {
            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                clientes = JsonSerializer.Deserialize<List<Cliente>>(json);
                Console.WriteLine("Dados carregados com sucesso!");
            }
            else
            {
                Console.WriteLine("Arquivo não encontrado. Criando uma nova lista.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao carregar os dados: {ex.Message}");
        }
    }
}