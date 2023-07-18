using CadastroClientes.Models;
using System;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using CadastroClientes.Utilities;
using Microsoft.VisualBasic;

namespace CadastroClientes
{
    public partial class FRM_CadastroClientes : Form
    {
        public int Param_0 { set { id = value; } }
        private int id = 0;
        public FRM_CadastroClientes()
        {
            InitializeComponent();
            NomearItens();
        }

        private void NomearItens()
        {
            GP_Contatos.Text = "Informações de Contato";
            GP_Identificacao.Text = "Informações Pessoais";
            GP_Endereco.Text = "Endereço";

            BTN_Descartar.Text = "Descartar";
            BTN_Salvar.Text = "Salvar";

            LBL_Nome.Text = "Nome do Cliente";
            LBL_NomeMae.Text = "Nome da Mãe";
            LBL_NomePai.Text = "Nome do Pai";
            LBL_Gemero.Text = "Gênero";
            LBL_CPF.Text = "CPF";
            LBL_RG.Text = "RG";
            LBL_DataNascimento.Text = "Data de Nascimento";
            CHK_SemPaternidade.Text = "Não declarado";

            LBL_Logradouro.Text = "Logradouro";
            LBL_Numero.Text = "Número";
            LBL_Complemento.Text = "Complemento";
            LBL_Bairro.Text = "Bairro";
            LBL_Municipio.Text = "Município";
            LBL_Estado.Text = "Estado (UF)";
            LBL_CEP.Text = "CEP";
            
            LBL_Celular.Text = "Celular";
            LBL_Telefone.Text = "Telefone Fixo/Alternativo";
            LBL_Email.Text = "E-mail";
            LBL_Outro.Text = "Contato Alternativo";
        }
        private void RecuperarFormulario()
        {
            if (id != 0)
            {
                Cliente c = new Cliente();
                TXB_CPF.Text = c.Cpf;
                TXB_RG.Text = c.Rg;
                TXB_Nome.Text = c.Nome;
                TXB_NomeMae.Text = c.NomeMae;
                TXB_NomePai.Text = c.NomePai;
                CB_Genero.Text = c.Genero;
                TXB_DataNascimento.Text = c.DataNascimento;
                TXB_Logradouro.Text = c.Logradouro;
                TXB_Numero.Text = c.Numero;
                TXB_Complemento.Text = c.Complemento;
                TXB_Bairro.Text = c.Bairro;
                TXB_Municipio.Text = c.Municipio;
                TXB_Estado.Text = c.Estado;
                TXB_Cep.Text = c.Cep;
                TXB_Celular.Text = c.Celular;
                TXB_Telefone.Text = c.Telefone;
                TXB_Email.Text = c.Email;
                TXB_OutroContato.Text = c.ContatoAlternativo;
                if(c.NomePai == "")
                {
                    CHK_SemPaternidade.Checked = true;
                }
                BTN_Descartar.Text = "Fechar";
            }
        }
        private Cliente LeituraFormulario()
        {
            Cliente c = new Cliente()
            {
                IdCliente = id,
                Cpf = TXB_CPF.Text,
                Rg = TXB_RG.Text,
                Nome = TXB_Nome.Text,
                NomeMae = TXB_NomeMae.Text,
                NomePai = TXB_NomePai.Text,
                Genero = CB_Genero.Text,
                DataNascimento = TXB_DataNascimento.Text,
                Logradouro = TXB_Logradouro.Text,
                Numero = TXB_Numero.Text,
                Complemento = TXB_Complemento.Text,
                Bairro = TXB_Bairro.Text,
                Municipio = TXB_Municipio.Text,
                Estado = TXB_Estado.Text,
                Cep = TXB_Cep.Text,
                Celular = TXB_Celular.Text,
                Telefone = TXB_Telefone.Text,
                Email = TXB_Email.Text,
                ContatoAlternativo = TXB_OutroContato.Text,
            };
            return c;
        }
        private void TXB_Cep_Leave(object sender, EventArgs e)
        {
            if (TXB_Cep.Text != "" && TXB_Cep.Text.Length == 8
                && Information.IsNumeric(TXB_Cep.Text))
            {
                var Consulta = BuscaCEP.Consulta(TXB_Cep.Text);
                TXB_Logradouro.Text = Consulta.Logradouro;
                TXB_Bairro.Text = Consulta.Bairro;
                TXB_Municipio.Text = Consulta.Municipio;
                TXB_Estado.Text = Consulta.Estado;
            }
        }
        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                var c = LeituraFormulario();
                c.ValidaClasse();
                c.SalvarCliente();
                Close();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
        }
        private void BTN_Descartar_Click(object sender, EventArgs e)
        {
            if(Text == "Cadastrar Cliente")
            {
                if (MessageBox.Show("As informações inseridas serão descartadas!" +
                    "\nDeseja continuar?", "Sair", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes) { Close(); }
            }
            else
            {
                if (MessageBox.Show("As informações alteradas serão descartadas!" +
                    "\nDeseja continuar?", "Sair", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes) { Close(); }
            }         
        }
        private void FRM_CadastroClientes_Load(object sender, EventArgs e)
        {
            RecuperarFormulario();
        }
        private void CHK_SemPaternidade_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_SemPaternidade.Checked == true)
            {
                TXB_NomePai.Enabled = false;
                TXB_NomePai.Text = string.Empty;
            }
            else
            {
                TXB_NomePai.Enabled = true;
            }
        }
    }
}
