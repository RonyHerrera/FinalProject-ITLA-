using Database;
using Database.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BuinesLayer
{
    public class ServiciosPruebas
    {
        public SqlConnection Connection;

        public RepositorioPruebasLaboratorio repositorio;

        public ServiciosPruebas(SqlConnection connection)
        {
            this.Connection = connection;
            repositorio = new RepositorioPruebasLaboratorio(connection);
        }

        public bool Add(Prueba item)
        {
            return repositorio.Add(item);
        }

        public bool Update(Prueba item)
        {
            return repositorio.Update(item);
        }

        public bool Delete(int id)
        {
            return repositorio.Delete(id);
        }

        public Prueba GetById(int id)
        {
            return repositorio.GetById(id);
        }

        public List<Prueba> GetList()
        {
            return repositorio.GetList();
        }

        public DataTable GetAll()
        {
            return repositorio.GetAll();
        }
    }
}
