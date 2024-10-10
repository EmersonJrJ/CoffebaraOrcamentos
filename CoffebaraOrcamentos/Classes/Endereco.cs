namespace WindowsFormsEstudoPessoal
{
    internal class Endereco
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        public Endereco()
        {
        }
        public Endereco(string cep, string estado, string localidade, string bairro, string logradouro)
        {
            this.Cep = cep;
            this.Estado = estado;
            this.Localidade = localidade;
            this.Bairro = bairro;
            this.Logradouro = logradouro;
        }
    }
}
