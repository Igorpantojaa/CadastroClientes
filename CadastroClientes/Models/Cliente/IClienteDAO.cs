using System.Collections.Generic;

namespace CadastroClientes.Models
{
    internal interface IClienteDAO
    {
        void Salvar(Cliente c);
        void Remover(Cliente c);
        IList<Cliente> Clientes();
        Cliente InfoCliente(int id);
    }
}
