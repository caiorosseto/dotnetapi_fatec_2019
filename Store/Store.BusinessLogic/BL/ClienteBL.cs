﻿using Store.BusinessLogic.BL.Interfaces;
using Store.Model.Entities;
using Store.Model.Infrastucture.DataAcess;
using Store.Model.Infrastucture.Hash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BusinessLogic.BL
{
    public class ClienteBL : IClienteBL
    {
        private ClienteDao _clienteDao;
        public ClienteBL()
        {
            _clienteDao = new ClienteDao();
        }

        public Cliente Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente Consultar(int idCliente)
        {
            throw new NotImplementedException();
        }

        public Cliente Inserir(Cliente cliente)
        {
            return _clienteDao.Insert(cliente);
        }

        public List<Cliente> Listar()
        {
            throw new NotImplementedException();
        }

        public Cliente Logar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _clienteDao.Dispose();
        }
    }
}
