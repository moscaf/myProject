using myProject;

public class GerenciarCliente
{
    private List<Cliente> clientes;
    
    public GerenciarCliente()
    {
        clientes = new List<Cliente>();
    }


     public void CadastrarCliente()
    {
        Console.Clear();
        Console.WriteLine(" --- Cadastro de Cliente ---\n");
        
        Console.Write("Name: ");
        string name = Console.ReadLine();
        
        Console.Write("E-mail: ");
        string email = Console.ReadLine();
        
        Console.Write("Birth: (yyyy, MM, dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        
        Cliente c1 = new Cliente(name, email, date);
        clientes.Add(c1);
    }

    public void ListarCliente()
    {
        Console.Clear();
        Console.WriteLine("\n --- Listagem de Clientes ---\n");
        if(clientes == null)
        {
            Console.WriteLine("Nenhum cadastrado!");
        }else
            {
            foreach (var list in clientes)
            {
                Console.WriteLine(list);            
            }
        }
        Console.WriteLine("Pressione umlca para continuar!");
        Console.ReadLine();
    }
}