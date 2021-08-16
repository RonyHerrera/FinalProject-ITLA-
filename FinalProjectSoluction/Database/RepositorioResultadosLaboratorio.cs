using Database.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Database
{
    public class RepositorioResultadosLaboratorio
    {
        public SqlConnection connection;

        public RepositorioResultadosLaboratorio(SqlConnection sqlConnetion)
        {
            this.connection = sqlConnetion;
        }

        public bool Add(Resultados item)
        {

            SqlCommand command = new SqlCommand("insert into ResultadosDeLaboratorio(IdCita, IdPacientes, IdPruebaDeLaboratorio, IdDoctor, ResultadosDeLaPrueba, EstadoDelResultado) values(@idCita, @idPacientes, @idPruebaDeLaboratorio, @idDoctor, @resultadosDeLaPrueba, @estadoDelResultado)", connection);

            command.Parameters.AddWithValue("@idCita", item.IdCita);
            command.Parameters.AddWithValue("@idPacientes", item.IdPacientes);
            command.Parameters.AddWithValue("@idPruebaDeLaboratorio", item.IdPruebaDeLaboratorio);
            command.Parameters.AddWithValue("@idDoctor", item.IdDoctor);
            command.Parameters.AddWithValue("@resultadosDeLaPrueba", item.ResultadosDeLaPrueba);
            command.Parameters.AddWithValue("@estadoDelResultado", item.EstadoDelResultado);

            return ExecuteDML(command);

        }

        public bool Update(Resultados item)
        {

            SqlCommand command = new SqlCommand("update ResultadosDeLaboratorio Set IdCita = @idCita, IdPacientes = @idPacientes, IdPruebaDeLaboratorio = @idPruebaDeLaboratorio, IdDoctor = @idDoctor, ResultadosDeLaPrueba = @ResultadosDeLaPrueba, EstadoDelResultado = @estadoDelResultado where Id = @id", connection);

            command.Parameters.AddWithValue("@id", item.Id);
            command.Parameters.AddWithValue("@idCita", item.IdCita);
            command.Parameters.AddWithValue("@idPacientes", item.IdPacientes);
            command.Parameters.AddWithValue("@idPruebaDeLaboratorio", item.IdPruebaDeLaboratorio);
            command.Parameters.AddWithValue("@idDoctor", item.IdDoctor);
            command.Parameters.AddWithValue("@resultadosDeLaPrueba", item.ResultadosDeLaPrueba);
            command.Parameters.AddWithValue("@estadoDelResultado", item.EstadoDelResultado);

            return ExecuteDML(command);

        }

        public bool Delete(int id)
        {

            SqlCommand command = new SqlCommand("Delete ResultadosDeLaboratorio where Id = @id", connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDML(command);

        }

        public Resultados GetById(int id)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from ResultadosDeLaboratorio where Id = @id", connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Resultados data = new Resultados();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.IdCita = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    data.IdPacientes = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                    data.IdPruebaDeLaboratorio = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                    data.IdDoctor = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                    data.ResultadosDeLaPrueba = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.EstadoDelResultado = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);                    
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

                SqlDataAdapter query = new SqlDataAdapter("select CONCAT(P.Nombre,P.Apellido) AS Nombre, P.Cedula as Cedula, PR.Nombre as NombrePrueba from ResultadosDeLaboratorio R join Pacientes P on P.Id = R.IdPacientes join PruebasDeLaboratorio PR on PR.Id = R.IdPruebaDeLaboratorio", connection);
                return LoadData(query);

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool GetDependecy(int id, string campo)
        {
            try
            {
                int elemento1 = -1;

                connection.Open();

                SqlCommand command1 = new SqlCommand("Select @campo from Libros where @campo = @id", connection);

                command1.Parameters.AddWithValue("@id", id);
                command1.Parameters.AddWithValue("@campo", campo);

                SqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    elemento1 = reader1.IsDBNull(0) ? -1 : reader1.GetInt32(0);
                }

                reader1.Close();
                reader1.Dispose();

                connection.Close();

                if (elemento1 == id)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataTable GetByCedula(string cedula)
        {
            try
            {
                SqlDataAdapter query = new SqlDataAdapter("select CONCAT(P.Nombre,P.Apellido) AS Nombre, P.Cedula as Cedula, PR.Nombre as NombrePrueba from ResultadosDeLaboratorio R join Pacientes P on P.Id = R.IdPacientes join PruebasDeLaboratorio PR on PR.Id = R.IdPruebaDeLaboratorio where P.Cedula = @cedula", connection);
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
