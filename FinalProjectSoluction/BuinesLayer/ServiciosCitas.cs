using Database;
using Database.Modelos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BuinesLayer
{
    public class ServiciosCitas
    {
        public SqlConnection Connection;

        public RepositorioCitas repositorio;

        public ServiciosCitas(SqlConnection connection)
        {
            this.Connection = connection;
        }

        public bool Add(Cita item)
        {
            return repositorio.Add(item);
        }

        public bool Update(Cita item)
        {
            return repositorio.Update(item);
        }

        public bool Delete(int id)
        {
            return repositorio.Delete(id);
        }

        public Cita GetById(int id)
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
