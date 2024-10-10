namespace WindowsFormsEstudoPessoal
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Produto(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
        public Produto() { }
    }
}
