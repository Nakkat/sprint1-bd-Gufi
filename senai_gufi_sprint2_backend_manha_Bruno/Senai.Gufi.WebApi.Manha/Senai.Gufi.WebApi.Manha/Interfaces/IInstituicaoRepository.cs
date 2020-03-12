﻿using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IInstituicaoRepository
    {
        List<Instituicao> Listar();

        void Cadastrar(Instituicao novoIntituicao);

        void Atualizar(int id, Instituicao IntituicaoAtualizada);

        void Deletar(int id);

        Instituicao BuscarPorId(int id);
    }
}