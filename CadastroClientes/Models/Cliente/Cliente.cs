using System.Text;
using Newtonsoft.Json;
using CadastroClientes.Database;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CadastroClientes.Models
{
    public class Cliente
    {
        #region Propriedades do Cliente

        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Nome do cliente é um campo obrigatório")]
        [StringLength(50, ErrorMessage = "O campo nome do cliente deve possuir no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Nome da mãe é um campo obrigatório")]
        [StringLength(50, ErrorMessage = "O campo nome da mãe deve possuir no máximo 50 caracteres")]
        public string NomeMae { get; set; }

        [StringLength(50, ErrorMessage = "O Campo nome do pai deve possuir no máximo 50 caracteres")]
        public string NomePai { get; set; }

        [Required(ErrorMessage = "Gênero é um campo obrigatório")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "CPF é um campo obrigatório")]
        [StringLength(11, ErrorMessage = "O campo CPF deve possuir 11 dígitos")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "RG é um campo obrigatório")]
        [StringLength(20, ErrorMessage = "O campo RG deve possuir no máximo 20 dígitos")]
        public string Rg { get; set; }

        public string DataNascimento { get; set; }

        [Required(ErrorMessage = "Logradouro é um campo obrigatório")]
        [StringLength(200, ErrorMessage = "O campo logradouro deve possuir no máximo 200 caracteres")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Número é um campo obrigatório")]
        [StringLength(10, ErrorMessage = "O campo número deve possuir no máximo 10 dígitos")]
        public string Numero { get; set; }

        [StringLength(50, ErrorMessage = "O campo complemento deve possuir no máximo 50 caracteres")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Bairro é um campo obrigatório")]
        [StringLength(50, ErrorMessage = "O campo bairro deve possuir no máximo 50 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Município é um campo obrigatório")]
        [StringLength(50, ErrorMessage = "O campo município deve possuir no máximo 50 caracteres")]
        public string Municipio { get; set; }

        [Required(ErrorMessage = "Estado é um campo obrigatório")]
        [StringLength(50, ErrorMessage = "O campo estado deve possuir no máximo 50 caracteres")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "CEP é um campo obrigatório")]
        [StringLength(50, ErrorMessage = "O campo CEP deve possuir 8 dígitos")]
        public string Cep { get; set; }

        [StringLength(20, ErrorMessage = "O campo estado deve possuir no máximo 20 dígitos")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Telefone é um campo obrigatório")]
        [StringLength(20, ErrorMessage = "O campo estado deve possuir no máximo 20 dígitos")]
        public string Telefone { get; set; }

        [StringLength(50, ErrorMessage = "O campo E-Mail deve possuir no máximo 50 caracteres")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "O campo contato alternativo deve possuir no máximo 100 caracteres")]
        public string ContatoAlternativo { get; set; }

        private readonly IClienteDAO DAO;

        #endregion

        public Cliente()
        {
            IdCliente = 0;
            DAO = new ClienteDAO();
        }
        public void ValidaClasse()
        {
            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if (isValid == false)
            {
                StringBuilder sbrErrors = new StringBuilder();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErrors.ToString());
            }
        }        
        public void SalvarCliente() => DAO.Salvar(this);
        public void RemoverCliente() => DAO.Remover(this);
        public IList<Cliente> ListarClientes() => DAO.Clientes();
        public Cliente CarregaInfo(int id) => DAO.InfoCliente(id);
    }
}
