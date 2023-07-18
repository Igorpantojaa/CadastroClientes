using CadastroClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CadastroClientes.Database
{
    public class ClienteDAO : IClienteDAO, IDisposable
    {
        private readonly ClienteContext context ;
        public ClienteDAO() { context = new ClienteContext(); }

        private int NovoId()
        {
            try
            {
                var c = context.Clientes.Last() ?? new Cliente();
                return c.IdCliente + 1;
            }
            catch
            {
                return 1;
            }
        }
        public void Dispose()
        {
            context.Dispose();
        }
        public void Salvar(Cliente c)
        {
            try
            {
                if (c.IdCliente == 0)
                {
                    c.IdCliente = NovoId();
                    context.Clientes.Add(c);
                    context.SaveChanges();
                }
                else
                {
                    context.Clientes.Update(c);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao salvar informações: {e}");
            }
        }
        public void Remover(Cliente c)
        {
            try
            {
                context.Clientes.Remove(c);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao remover informações: {e}");
            }            
        }
        public IList<Cliente> Clientes()
        {
            try
            {
                return context.Clientes.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao recuperar informações: {e}");
                IList<Cliente> l = new List<Cliente>();
                return l;
            }                      
        }
        public Cliente InfoCliente(int id)
        {
            try
            {
                return context.Clientes.Find(id);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao recuperar informações: {e}");
                Cliente c = new Cliente();
                return c;
            }           
        }      
    }
}
