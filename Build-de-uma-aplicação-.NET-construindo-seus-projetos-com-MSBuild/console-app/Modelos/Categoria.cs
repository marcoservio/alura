namespace Alura.MsBuild.Modelos
{
	public class Categoria
	{
		public int Id { get; set; }
		public string Descricao { get; set; }
		
		public Categoria(string descricao)
		{
			Descricao = descricao;
		}
	}
}