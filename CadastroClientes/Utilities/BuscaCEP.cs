using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace CadastroClientes.Utilities
{
    public class BuscaCEP
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("state")]
        public string Estado { get; set; }

        [JsonProperty("city")]
        public string Municipio { get; set; }

        [JsonProperty("neighborhood")]
        public string Bairro { get; set; }

        [JsonProperty("street")]
        public string Logradouro { get; set; }

        [JsonProperty("service")]
        public string Entregas { get; set; }

        private BuscaCEP() { }

        public static string GeraJSONCEP(string cep)
        {
            try
            {
                string url = $"https://brasilapi.com.br/api/cep/v1/{cep}";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();
                int cont;
                byte[] buffer = new byte[1000];
                StringBuilder sb = new StringBuilder();
                string temp;
                Stream stream = resposta.GetResponseStream();
                do
                {
                    cont = stream.Read(buffer, 0, buffer.Length);
                    temp = Encoding.UTF8.GetString(buffer, 0, cont).Trim();
                    sb.Append(temp);
                } while (cont > 0);
                return sb.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        private static BuscaCEP DesSerializedClassBuscaCEP(string json)
        {
            if(json == string.Empty)
            {
                MessageBox.Show("Não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscaCEP objetoVazio = new BuscaCEP();
                return objetoVazio;
            }
            return JsonConvert.DeserializeObject<BuscaCEP>(json);
        }

        public static BuscaCEP Consulta(string cep)
        {
            var json = GeraJSONCEP(cep);
            return DesSerializedClassBuscaCEP(json);
        }
    }
}