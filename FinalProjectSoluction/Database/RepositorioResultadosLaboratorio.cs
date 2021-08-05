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

            SqlCommand command = new SqlCommand("inser into ResultadosDeLaboratorio(IdCita, IdPacientes, IdPruebaDeLaboratorio, IdDoctor, ResultadosDeLaPrueba, EstadoDelResultado) value(@idCita, @idPacientes, @idPruebaDeLaboratorio, @idDoctor, @resultadosDeLaPrueba, @estadoDelResultado)", connection);

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

            SqlCommand command = new SqlCommand("update IdCita = @idCita, IdPacientes = @idPacientes, IdPruebaDeLaboratorio = @idPruebaDeLaboratorio, IdDoctor = @idDoctor, ResultadosDeLaPrueba = @ResultadosDeLaPrueba, EstadoDelResultado = @estadoDelResultado from ResultadosDeLaboratorio where Id = @id", connection);

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

                SqlDataAdapter query = new SqlDataAdapter("Select R.Id as ID, C.EstadoDeLaCita as Cita, P.Nombre as Pacientes, PL.Nombre as PruebasDeLaboratorio, D.Nombre as Doctor, R.ResultadoDeLaPrueba, R.EstadoDelResultado from ResultadosDeLaboratorio R join Citas C on C.Id = R.IdCita join Pacientes P on P.Id = R.IdPacientes join PruebasDeLaboratorio PL on PL.Id = R.IdPruebaDeLaboratorio join Doctores D on D.Id = R.IdDoctor", connection);
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
