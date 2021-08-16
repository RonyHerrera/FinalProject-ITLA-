using Database.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Database
{

    public class RepositorioDoctores
    {
        public SqlConnection connection;

        public RepositorioDoctores(SqlConnection sqlConnetion)
        {
            this.connection = sqlConnetion;
        }

        public bool Add(Doctor item)
        {

            SqlCommand command = new SqlCommand("insert into Doctores(Nombre, Apellido, Correo, Telefono, Cedula, Foto) values(@nombre, @apellido, @correo, @telefono, @cedula, @foto)", connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@telefono", item.Telefono);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@foto", item.Foto);

            return ExecuteDML(command);

        }

        public bool Update(Doctor item)
        {

            SqlCommand command = new SqlCommand("update Doctores SET Nombre = @nombre, Apellido = @apellido, Correo = @correo, Telefono = @telefono, Cedula = @cedula, Foto = @foto where Id = @id", connection);

            command.Parameters.AddWithValue("@id", item.Id);
            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@telefono", item.Telefono);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@foto", item.Foto);

            return ExecuteDML(command);

        }

        public bool Delete(int id)
        {

            SqlCommand command = new SqlCommand("Delete Doctores where Id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            return ExecuteDML(command);
        }

        public Doctor GetById(int id)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from Doctores where Id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();
                Doctor data = new Doctor();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Correo = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Telefono = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.Cedula = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.Foto = reader.IsDBNull(5) ? "" : reader.GetString(5);
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
                SqlDataAdapter query = new SqlDataAdapter("select * from Doctores", connection);
                return LoadData(query);

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Doctor> GetList()
        {
            try
            {
                List<Doctor> list = new List<Doctor>();

                connection.Open();

                SqlCommand command = new SqlCommand("Select * from Doctores", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Doctor
                    {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1),
                        Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        Correo = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        Telefono = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        Cedula = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        Foto = reader.IsDBNull(3) ? "" : reader.GetString(3),
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

        public DataTable GetByCedula(string cedula)
        {
            try
            {
                SqlDataAdapter query = new SqlDataAdapter("select * from Doctores where Cedula = @cedula", connection);
                query.SelectCommand.Parameters.Add(new SqlParameter { ParameterName = "@cedula", Value = cedula, SqlDbType = SqlDbType.NVarChar, Size = 2000 });
                return LoadData(query);
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
