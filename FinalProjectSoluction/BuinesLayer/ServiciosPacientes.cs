using Database;
using Database.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BuinesLayer
{
    public class ServiciosPacientes
    {
        public SqlConnection Connection;

        public RepositorioPacientes repositorio;

        public ServiciosPacientes(SqlConnection connection)
        {
            this.Connection = connection;
            repositorio = new RepositorioPacientes(connection);
        }

        public bool Add(Paciente item)
        {
            return repositorio.Add(item);
        }

        public bool Update(Paciente item)
        {
            return repositorio.Update(item);
        }

        public bool Delete(int id)
        {
            return repositorio.Delete(id);
        }

        public Paciente GetById(int id)
        {
            return repositorio.GetById(id);
        }

        public List<Paciente> GetList()
        {
            return repositorio.GetList();
        }

        public DataTable GetAll()
        {
            return repositorio.GetAll();
        }
    }
}
