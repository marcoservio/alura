using MimeKit;

using System.Collections.Generic;
using System.Linq;

namespace UsuariosApi.Models
{
    public class Mensagem
    {
        public List<MailboxAddress> Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }

        public Mensagem(IEnumerable<string> destinatario, string assunto, int usuarioId, string code)
        {
            Destinatario = new List<MailboxAddress>();
            Destinatario.AddRange(destinatario.Select(x => new MailboxAddress(x)));
            Assunto = assunto;
            Conteudo = $"https://localhost:5001/ativa?UsuarioId={usuarioId}&CodigoAtivacao={code}";
        }
    }
}
