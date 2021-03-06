﻿using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    // Intancio minha interface com meus metódos
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        // Instancio meu contexto
        GufiContext ctx = new GufiContext();

        /// <summary>
        /// Atualiza um tipo de usuário
        /// </summary>
        /// <param name="id">Id do tipo usuário que será buscado</param>
        /// <param name="tipoUsuarioAtualizado">Objeto tipoUsuarioAtualizado que será alterado</param>
        public void Atualizar(int id, TipoUsuario tipoUsuarioAtualizado)
        {
            TipoUsuario tipoUsuarioBuscado = ctx.TipoUsuario.Find(id);

            tipoUsuarioBuscado.TituloTipoUsuario = tipoUsuarioAtualizado.TituloTipoUsuario;

            ctx.TipoUsuario.Update(tipoUsuarioBuscado);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Buscar um tipo de usuário por Id
        /// </summary>
        /// <param name="id">Id do tipo de usuário que será buscado</param>
        /// <returns>Retorna um tipo de usuário específico pelo Id</returns>
        public TipoUsuario BuscarPorId(int id)
        {
            return ctx.TipoUsuario.FirstOrDefault(te => te.IdTipoUsuario == id);
        }

        /// <summary>
        /// Cadastrar um novo tipo de usuário
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto novoTipoUsuario que será cadastrado</param>

        public void Cadastrar(TipoUsuario novoTipoUsuario)
        {
            ctx.TipoUsuario.Add(novoTipoUsuario);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Deletar um tipo de usuário
        /// </summary>
        /// <param name="id">Id do tipo de usuário que será buscado</param>
        public void Deletar(int id)
        {
            ctx.TipoUsuario.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        /// <summary>
        /// Listar tipos de usuários
        /// </summary>
        /// <returns>Retorna uma lista dos tipos de usuários</returns>
        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuario.ToList();
        }
    }
}
