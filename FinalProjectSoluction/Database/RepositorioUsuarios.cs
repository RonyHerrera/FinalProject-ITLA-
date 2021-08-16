using Database.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
 
namespace Database
{
    public class RepositorioUsuarios
    {
        public SqlConnection connection;

        public RepositorioUsuarios(SqlConnection sqlConnetion)
        {
            this.connection = sqlConnetion;
        }

        public bool Add(Usuarios item)
        {

            SqlCommand command = new SqlCommand("insert into Usuarios(Nombre, Apellido, Correo, Contraseña, TipoDeUsuario, NombreDeUsuario) values(@nombre, @apellido, @correo, @contraseña, @tipoDeUsuario, @nombreDeUsuario)", connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@nombreDeUsuario", item.NombreDeUsuario);
            command.Parameters.AddWithValue("@contraseña", item.Contraseña);
            command.Parameters.AddWithValue("@tipoDeUsuario", item.TipoDeUsuario);

            return ExecuteDML(command);

        }

        public bool Update(Usuarios item)
        {

            SqlCommand command = new SqlCommand("update Usuarios Set Nombre = @nombre, Apellido = @apellido, NombreDeUsuario = @nombreDeUsuario, Correo = @correo, Contraseña = @contraseña, TipoDeUsuario = @tipoDeUsuario from Usuarios where Id = @id", connection);

            command.Parameters.AddWithValue("@id", item.Id);
            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido); 
            command.Parameters.AddWithValue("@nombreDeUsuario", item.NombreDeUsuario);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@contraseña", item.Contraseña);
            command.Parameters.AddWithValue("@tipoDeUsuario", item.TipoDeUsuario);

            return ExecuteDML(command);

        }

        public bool Delete(int id)
        {

            SqlCommand command = new SqlCommand("Delete Usuarios where Id = @id", connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDML(command);

        }

        public Usuarios GetName(string userName)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from Usuarios where NombreDeUsuario = @userName", connection);

                command.Parameters.AddWithValue("@userName", userName);

                SqlDataReader reader = command.ExecuteReader();

                Usuarios data = new Usuarios();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Correo = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Contraseña = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.TipoDeUsuario = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
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

        public Usuarios GetById(int id)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from Usuarios where Id = @id", connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Usuarios data = new Usuarios();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Correo = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Contraseña = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.TipoDeUsuario = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                    data.NombreDeUsuario = reader.IsDBNull(6) ? "" : reader.GetString(6);
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

                SqlDataAdapter query = new SqlDataAdapter("select Id as ID, Nombre, Apellido, NombreDeUsuario, Correo, Contraseña, TipoDeUsuario from Usuarios ", connection);
                return LoadData(query);

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Usuarios> GetList()
        {
            try
            {
                List<Usuarios> list = new List<Usuarios>();

                connection.Open();

                SqlCommand command = new SqlCommand("Select * from Usuarios", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Usuarios
                    {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1),
                        Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        Correo = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        Contraseña = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        TipoDeUsuario = reader.IsDBNull(5) ? 0 : reader.GetInt32(5)
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
