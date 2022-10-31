using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;

using System;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultAdminService : IAdminService
    {
        ILeilaoDao _dao;
        ICategoriaDao _categoryDao;

        public DefaultAdminService(ILeilaoDao dao, ICategoriaDao categoryDao)
        {
            _dao = dao;
            _categoryDao = categoryDao;
        }

        public void CadastraLeilao(Leilao leilao)
        {
            _dao.Incluir(leilao);
        }

        public IEnumerable<Categoria> ConsultaCaregorias()
        {
            return _categoryDao.BuscarTodos();
        }

        public IEnumerable<Leilao> ConsultaLeilao()
        {
            return _dao.BuscarTodos();
        }

        public Leilao ConsultaLeilaoPorId(int id)
        {
            return _dao.BuscarPorId(id);
        }

        public void FinalizaPregaoDoLeilaoComId(int id)
        {
            var leilao = _dao.BuscarPorId(id);
            if(leilao != null && leilao.Situacao == SituacaoLeilao.Rascunho)
            {
                leilao.Situacao = SituacaoLeilao.Finalizado;
                leilao.Inicio = DateTime.Now;
                _dao.Alterar(leilao);
            }
        }

        public void IniciaPregaoDoLeilaoComId(int id)
        {
            var leilao = _dao.BuscarPorId(id);
            if(leilao != null && leilao.Situacao == SituacaoLeilao.Rascunho)
            {
                leilao.Situacao = SituacaoLeilao.Pregao;
                leilao.Inicio = DateTime.Now;
                _dao.Alterar(leilao);
            }
        }

        public void ModificaLeilao(Leilao leilao)
        {
            _dao.Alterar(leilao);
        }

        public void RemoveLeilao(Leilao leilao)
        {
            if(leilao != null && leilao.Situacao != SituacaoLeilao.Pregao)
            {
                _dao.Excluir(leilao);
            }
        }
    }
}
