using Database.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Database
{
    public class RepositorioPacientes
    {
        public SqlConnection connection;

        public RepositorioPacientes(SqlConnection sqlConnetion)
        {
            this.connection = sqlConnetion;
        }

        public bool Add(Paciente item)
        {

            SqlCommand command = new SqlCommand("inser into Pacientes(Nombre, Apellido, Telefono, Direccion, Cedula, FechaDeNacimiento, Fumador, Alergias, Foto) value(@nombre, @apellido, @telefono, @direccion, @cedula, @fechaDeNacimiento, @fumador, @alergias, @foto)", connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@telefono", item.Telefono);
            command.Parameters.AddWithValue("@direccion", item.Direccion);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@fechaDeNacimiento", item.FechaDeNacimiento);
            command.Parameters.AddWithValue("@fumador", item.Fumador);
            command.Parameters.AddWithValue("@alergias", item.Alergias);
            command.Parameters.AddWithValue("@foto", item.Foto);

            return ExecuteDML(command);

        }

        public bool Update(Paciente item)
        {

            SqlCommand command = new SqlCommand("update Nombre = @nombre, Apellido = @apellido, Telefono = @telefono, Direccion = @direccion, Cedula = @cedula, FechaDeNacimiento = @fechaDeNacimiento, Fumador = @fumador, Alergias = @alergias, Foto = @foto from Pacientes where Id = @id", connection);

            command.Parameters.AddWithValue("@id", item.Id);
            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@telefono", item.Telefono);
            command.Parameters.AddWithValue("@direccion", item.Direccion);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@fechaDeNacimiento", item.FechaDeNacimiento);
            command.Parameters.AddWithValue("@fumador", item.Fumador);
            command.Parameters.AddWithValue("@alergias", item.Alergias);
            command.Parameters.AddWithValue("@foto", item.Foto);

            return ExecuteDML(command);

        }

        public bool Delete(int id)
        {

            SqlCommand command = new SqlCommand("Delete Pacientes where Id = @id", connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDML(command);

        }

        public Paciente GetById(int id)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from Pacientes where Id = @id", connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Paciente data = new Paciente();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Telefono = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Direccion = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.Cedula = reader.IsDBNull(5) ? "" : reader.GetString(6);
                    data.FechaDeNacimiento = reader.IsDBNull(6) ? new DateTime(0000,00,00) : reader.GetDateTime(6);
                    data.Fumador = reader.IsDBNull(7) ? new bool() : reader.GetBoolean(7);
                    data.Alergias = reader.IsDBNull(8) ? "" : reader.GetString(8);
                    data.Foto = reader.IsDBNull(9) ? "" : reader.GetString(9);
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

                SqlDataAdapter query = new SqlDataAdapter("select * from Pacientes ", connection);
                return LoadData(query);

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Paciente> GetList()
        {
            try
            {
                List<Paciente> list = new List<Paciente>();

                connection.Open();

                SqlCommand command = new SqlCommand("Select * from Pacientes", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Paciente
                    {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1),
                        Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        Telefono = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        Direccion = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        Cedula = reader.IsDBNull(5) ? "" : reader.GetString(6),
                        FechaDeNacimiento = reader.IsDBNull(6) ? new DateTime(0000, 00, 00) : reader.GetDateTime(6),
                        Fumador = reader.IsDBNull(7) ? new bool() : reader.GetBoolean(7),
                        Alergias = reader.IsDBNull(8) ? "" : reader.GetString(8),
                        Foto = reader.IsDBNull(9) ? "" : reader.GetString(9)
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
