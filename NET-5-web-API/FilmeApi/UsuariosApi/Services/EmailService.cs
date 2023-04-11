//using MailKit.Net.Smtp;

using Microsoft.Extensions.Configuration;

using MimeKit;

using System;
using System.Net;
using System.Net.Mail;

using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class EmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //public void EnviarEmail(string[] destinatario, string assunto, int usuarioId, string code)
        //{
        //    Mensagem mensagem = new Mensagem(destinatario, assunto, usuarioId, code);

        //    var mensagemEmail = CriaCorpoEmail(mensagem);

        //    Enviar(mensagemEmail);
        //}

        public void EnviarEmail(string[] destinatario, string assunto, int usuarioId, string code)
        {
            Mensagem mensagem = new Mensagem(destinatario, assunto, usuarioId, code);

            var mensagemEmail = CriaCorpoEmailNew(mensagem);

            Enviar(mensagemEmail);
        }

        //private void Enviar(MimeMessage mensagemEmail)
        //{
        //    using (var client = new SmtpClient())
        //    {
        //        try
        //        {
        //            client.Connect(_configuration.GetValue<string>("EmailSettings:SmtpServer"),
        //                _configuration.GetValue<int>("EmailSettings:Port"), true);
        //            client.AuthenticationMechanisms.Remove("XOUATH2");
        //            client.Authenticate(_configuration.GetValue<string>("EmailSettings:From"),
        //                _configuration.GetValue<string>("EmailSettings:Password"));

        //            client.Send(mensagemEmail);
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //        finally
        //        {
        //            client.Disconnect(true);
        //            client.Dispose();
        //        }
        //    }
        //}

        private void Enviar(MailMessage mensagemEmail)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient(_configuration.GetValue<string>("EmailSettings:SmtpServer"),
                    _configuration.GetValue<int>("EmailSettings:Port"));
                smtpClient.Credentials = new NetworkCredential(_configuration.GetValue<string>("EmailSettings:From"),
                    _configuration.GetValue<string>("EmailSettings:Password"));

                smtpClient.Send(mensagemEmail);
            }
            catch
            {
                throw;
            }
        }

        private MimeMessage CriaCorpoEmail(Mensagem mensagem)
        {
            var mensagemEmail = new MimeMessage();
            mensagemEmail.From.Add(new MailboxAddress(_configuration.GetValue<string>("EmailSettings:From")));
            mensagemEmail.To.AddRange(mensagem.Destinatario);
            mensagemEmail.Subject = mensagem.Assunto;
            mensagemEmail.Body = new TextPart(MimeKit.Text.TextFormat.Text)
            {
                Text = mensagem.Conteudo
            };

            return mensagemEmail;
        }

        private MailMessage CriaCorpoEmailNew(Mensagem mensagem)
        {
            var mensagemEmail = new MailMessage();
            mensagemEmail.From = new MailAddress(_configuration.GetValue<string>("EmailSettings:From"));
            mensagemEmail.To.Add(mensagem.DestinatarioNew);
            mensagemEmail.Subject = mensagem.Assunto;
            mensagemEmail.Body = mensagem.Conteudo;

            return mensagemEmail;
        }
    }
}
