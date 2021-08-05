using Database;
using Database.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BuinesLayer
{
    public class ServiciosDoctores
    {
        public SqlConnection Connection;

        public RepositorioDoctores repositorio;

        public ServiciosDoctores(SqlConnection connection)
        {
            this.Connection = connection;
        }

        public bool Add(Doctor item)
        {
            return repositorio.Add(item);
        }

        public bool Update(Doctor item)
        {
            return repositorio.Update(item);
        }

        public bool Delete(int id)
        {
            return repositorio.Delete(id);
        }

        public Doctor GetById(int id)
        {
            return repositorio.GetById(id);
        }

        public List<Doctor> GetList()
        {
            return repositorio.GetList();
        }

        public DataTable GetAll()
        {
            return repositorio.GetAll();
        }
    }
}
