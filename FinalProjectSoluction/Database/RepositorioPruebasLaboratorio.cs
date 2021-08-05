using Database.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Database
{
    public class RepositorioPruebasLaboratorio
    {
        public SqlConnection connection;

        public RepositorioPruebasLaboratorio(SqlConnection sqlConnetion)
        {
            this.connection = sqlConnetion;
        }

        public bool Add(Prueba item)
        {

            SqlCommand command = new SqlCommand("inser into PruebasDeLaboratorio(Nombre) value(@nombre)", connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);

            return ExecuteDML(command);

        }

        public bool Update(Prueba item)
        {

            SqlCommand command = new SqlCommand("update Nombre = @nombre from PruebasDeLaboratorio where Id = @id", connection);

            command.Parameters.AddWithValue("@id", item.Id);
            command.Parameters.AddWithValue("@nombre", item.Nombre);

            return ExecuteDML(command);

        }

        public bool Delete(int id)
        {

            SqlCommand command = new SqlCommand("Delete PruebasDeLaboratorio where Id = @id", connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDML(command);

        }

        public Prueba GetById(int id)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from PruebasDeLaboratorio where Id = @id", connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Prueba data = new Prueba();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);               
                }

                reader.Close();
                reader.Dispose();

                connection.Close();

                return data;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable GetAll()
        {
            try
            {

                SqlDataAdapter query = new SqlDataAdapter("select Id as ID, Nombre from PruebasDeLaboratorio ", connection);
                return LoadData(query);

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Prueba> GetList()
        {
            try
            {
                List<Prueba> list = new List<Prueba>();

                connection.Open();

                SqlCommand command = new SqlCommand("Select * from PruebasDeLaboratorio", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Prueba
                    {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1)                       
                    });
                }

                reader.Close();
                reader.Dispose();

                connection.Close();

                return list;

            }
            catch (Exception e)
            {
                return null;
            }
        }


        private DataTable LoadData(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();

                connection.Open();

                query.Fill(data);

                connection.Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public bool ExecuteDML(SqlCommand query)
        {
            try
            {
                connection.Open();

                query.ExecuteNonQuery();

                connection.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
