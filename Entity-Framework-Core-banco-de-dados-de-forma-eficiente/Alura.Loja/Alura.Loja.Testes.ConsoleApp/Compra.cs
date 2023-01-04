namespace Alura.Loja.Testes.ConsoleApp
{
    public class Compra
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            return $"Compra de {Quantidade} do produto {Produto.Nome}";
        }
    }
}