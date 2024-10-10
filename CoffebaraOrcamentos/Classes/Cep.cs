namespace WindowsFormsEstudoPessoal
{
    internal class Cep
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string estado { get; set; }

        public Cep(string cep, string logradouro, string bairro, string localidade, string estado)
        {
            this.cep = cep;
            this.logradouro = logradouro;
            this.bairro = bairro;
            this.localidade = localidade;
            this.estado = estado;
        }
    }
}
