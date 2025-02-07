using System.Data;
using Microsoft.VisualBasic;

namespace myProject;

public class Cliente
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate {get; set;}
    private List<Cliente> clientes;

    public Cliente(string name, string email, DateTime date)
    {
        Name = name;
        Email = email;
        BirthDate = date;
    }

    public override string ToString()
    {
        return 
            $"Name: {Name}, E-mail: {Email}, BirthDay: {BirthDate}"; 
    }

   
}

