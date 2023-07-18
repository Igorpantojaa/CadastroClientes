using System;
using System.Windows.Forms;
using CadastroClientes.Models;

namespace CadastroClientes
{
    public partial class FRM_Inicio : Form
    {
        public FRM_Inicio()
        {
            InitializeComponent();
            NomearItens();
            ListarClientes();
        }
       
        private void BTN_Novo_Click(object sender, EventArgs e) => NovoCadastro();
        private void BTN_Abrir_Click(object sender, EventArgs e) => AbrirCadastro();
        private void BTN_Excluir_Click(object sender, EventArgs e) => ExcluirCadastro();
        private void TB_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e) => PreviaCadastro();
        private void TB_Clientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) => AbrirCadastro();
        
        #region Métodos Personalizados

        private void NomearItens()
        {
            GP_TabelaClientes.Text = "Clientes Cadastrados";
            GP_Previa.Text = string.Empty;
            GP_Acoes.Text = "Ações";

            BTN_Abrir.Text = "Editar Cadastro";
            BTN_Novo.Text = "Novo Cadastro";
            BTN_Excluir.Text = "Excluir Cadastro";

            LBL_Nome.Text = "Nome:";
            LBL_Endereco.Text = "Endereço:";
            LBL_Cidade.Text = "Cidade - UF:";
            LBL_Celular.Text = "Celular:";
            LBL_Telefone.Text = "Telefone:";
            LBL_Email.Text = "E-Mail:";
        }
        private void AbrirCadastro()
        {
            FRM_CadastroClientes cad = new FRM_CadastroClientes() { Text = "Exibir Cadastro" };
            int Id = Convert.ToInt32(TB_Clientes.SelectedRows[0].Cells[0].Value);
            if (TB_Clientes.SelectedRows.Count >= 0)
            {
                cad.Param_0 = Id;
                cad.ShowDialog();
                ListarClientes();
            }
        }
        private void NovoCadastro()
        {
            FRM_CadastroClientes c = new FRM_CadastroClientes() { Text = "Cadastrar Cliente", };
            c.ShowDialog();
            ListarClientes();
        }
        private void PreviaCadastro()
        {
            if (TB_Clientes.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(TB_Clientes.SelectedRows[0].Cells[0].Value);
                Cliente c = new Cliente();
                c = c.CarregaInfo(id);
                TXB_Nome.Text = c.Nome;
                TXB_Endereco.Text = $"{c.Logradouro}, {c.Numero} - {c.Bairro}";
                TXB_Cidade.Text = $"{c.Municipio} - {c.Estado}";
                TXB_Celular.Text = c.Celular;
                TXB_Telefone.Text = c.Telefone;
                TXB_Email.Text = c.Email;
            }
        }
        private void ListarClientes()
        {
            Cliente c = new Cliente();
            TB_Clientes.DataSource = c.ListarClientes();
        }
        private void ExcluirCadastro()
        {
            int id = Convert.ToInt32(TB_Clientes.SelectedRows[0].Cells[0].Value);
            if (TB_Clientes.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("As informações alteradas serão descartadas!" +
                    "\nDeseja continuar?", "Sair", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cliente c = new Cliente();
                    c = c.CarregaInfo(id);
                    c.RemoverCliente();
                    TXB_Nome.Text = string.Empty;
                    TXB_Endereco.Text = string.Empty;
                    TXB_Cidade.Text = string.Empty;
                    TXB_Celular.Text = string.Empty;
                    TXB_Telefone.Text = string.Empty;
                    TXB_Email.Text = string.Empty;
                }
                ListarClientes();
            }
        }
        #endregion
    }
}
