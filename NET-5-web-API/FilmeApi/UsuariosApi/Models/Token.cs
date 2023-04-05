namespace UsuariosApi.Models
{
    public class Token
    {
        public string Valor { get; }

        public Token(string valor)
        {
            Valor = valor;
        }
    }
}
