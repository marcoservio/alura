using ByteBank.Portal.Controller;
using ByteBank.Portal.Infraestrutura.IoC;
using ByteBank.Service;
using ByteBank.Service.Cambio;
using ByteBank.Service.Cartao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura
{
    public class CartaoServiceTesteContainer : ICartaoService
    {
        public string ObterCartaoCreditoDestaque() => "Cartão de Credito do teste de container";

        public string ObterCartaoDebitoDestaque() => "Cartão de Debito do teste de container";
    }

    public class WebApplication
    {
        private readonly string[] _prefixos;
        private readonly IContainer _container = new ContainerSimples();

        public WebApplication(string[] prefixos)
        {
            if (prefixos == null)
                throw new ArgumentNullException(nameof(prefixos));

            _prefixos = prefixos;

            Configurar();
        }

        private void Configurar()
        {
            //_container.Registrar(typeof(ICambioService), typeof(CambioTesteService));
            //_container.Registrar(typeof(ICartaoService), typeof(CartaoServiceTeste));
            _container.Registrar<ICambioService, CambioTesteService>();
            _container.Registrar<ICartaoService, CartaoServiceTesteContainer>();
        }

        public void Iniciar()
        {
            while (true)
                ManipularRequisiçao();
        }

        private void ManipularRequisiçao()
        {
            var httpListener = new HttpListener();

            foreach (var item in _prefixos)
            {
                httpListener.Prefixes.Add(item);
            }

            httpListener.Start();

            var contexto = httpListener.GetContext();
            var requisicao = contexto.Request;
            var resposta = contexto.Response;

            var path = requisicao.Url.PathAndQuery;

            if (Utilidades.EhArquivo(path))
            {
                var manipulador = new ManipuladorRequisicaoArquivo();
                manipulador.Manipular(resposta, path);
            }
            else
            {
                var manipulador = new ManipuladorRequisicaoController(_container);
                manipulador.Manipular(resposta, path);
            }

            httpListener.Stop();
        }
    }
}
