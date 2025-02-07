// See https://aka.ms/new-console-template for more information
using System.Data;
using myProject;

GerenciarCliente cliente = new GerenciarCliente();
bool executando = true;

while(executando)
{
    Console.Clear();
    Console.WriteLine("\n --- Menu --- \n");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Listar Cliente");
    Console.WriteLine("3 - Sair");
    Console.Write("Selecionar Opção: ");
    var option = int.Parse(Console.ReadLine());

    switch(option)
    {
        case 1:
        cliente.CadastrarCliente();
        break;
        case 2:
        cliente.ListarCliente();
        break;
        case 3:
        executando = false;
        break;
        default:
        Console.WriteLine("Opção não encontrada!");
        break;
    }
}

Console.ReadLine();
