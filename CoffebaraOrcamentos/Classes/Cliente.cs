using System.Collections.Generic;

namespace WindowsFormsEstudoPessoal
{
    internal class Cliente
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public Orcamento Orcamento { get; set; }
        public Cep Cep { get; set; }
        public string FormaDePagamento { get; set; }
        public string PossuiGarantia { get; set; }

        public static Cliente CriarCliente(string nome, string telefone, string email, Endereco endereco, Orcamento orcamento, List<Produto> listaProdutos)
        {
            Cliente cliente = new Cliente
            {
                Nome = nome,
                Telefone = telefone,
                Email = email,
                Endereco = endereco,
                Orcamento = orcamento,
                Produtos = listaProdutos
            };
            return cliente;
        }
    }
}
