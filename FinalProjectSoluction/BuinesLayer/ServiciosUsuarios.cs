using Database;
using Database.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BuinesLayer
{
    public class ServiciosUsuarios
    {
        public SqlConnection Connection;

        public RepositorioUsuarios repositorio;

        public ServiciosUsuarios(SqlConnection connection)
        {
            this.Connection = connection;
        }

        public bool Add(Usuarios item)
        {
            return repositorio.Add(item);
        }

        public bool Update(Usuarios item)
        {
            return repositorio.Update(item);
        }

        public bool Delete(int id)
        {
            return repositorio.Delete(id);
        }

        public Usuarios GetById(int id)
        {
            return repositorio.GetById(id);
        }

        public List<Usuarios> GetList()
        {
            return repositorio.GetList();
        }

        public DataTable GetAll()
        {
            return repositorio.GetAll();
        }
    }
}
