using Database;
using Database.Modelos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BuinesLayer
{
    public class ServiciosResultados
    {
        public SqlConnection Connection;

        public RepositorioResultadosLaboratorio repositorio;

        public ServiciosResultados(SqlConnection connection)
        {
            this.Connection = connection;
            repositorio = new RepositorioResultadosLaboratorio(connection); 
        }

        public bool Add(Resultados item)
        {
            return repositorio.Add(item);
        }

        public bool Update(Resultados item)
        {
            return repositorio.Update(item);
        }

        public bool Delete(int id)
        {
            return repositorio.Delete(id);
        }

        public Resultados GetById(int id)
        {
            return repositorio.GetById(id);
        }

        public bool GetDependecy(int id, string campo)
        {
            return repositorio.GetDependecy(id, campo);
        }

        public DataTable GetAll()
        {
            return repositorio.GetAll();
        }
    }
}
