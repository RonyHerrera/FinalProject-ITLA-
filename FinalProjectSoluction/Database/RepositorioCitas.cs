using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Database.Modelos;

namespace Database
{


    public class RepositorioCitas
    {
        public SqlConnection connection;

        public RepositorioCitas(SqlConnection sqlConnetion)
        {
            this.connection = sqlConnetion;
        }

        public bool Add(Cita item)
        {

            SqlCommand command = new SqlCommand("inser into Citas(IdPacientes, IdDoctor, FechaYHoraDeLaCita, CausaDeLaCita, EstadoDeLaCita) value(@idPacientes, @idDoctor, @fechaYHoraDeLaCita, @causaDeLaCita, @estadoDeLaCita)", connection);

            command.Parameters.AddWithValue("@idPacientes", item.IdPacientes);
            command.Parameters.AddWithValue("@idDoctor", item.IdDoctor);
            command.Parameters.AddWithValue("@fechaYHoraDeLaCita", item.FechaYHoraDeLaCita);
            command.Parameters.AddWithValue("@causaDeLaCita", item.CausaDeLaCita);
            command.Parameters.AddWithValue("@estadoDeLaCita", item.EstadoDeLaCita);

            return ExecuteDML(command);

        }

        public bool Update(Cita item)
        {

            SqlCommand command = new SqlCommand("update IdPacientes = @idPacientes, IdDoctor = @idDoctor, FechaYHoraDeLaCita = @fechaYHoraDeLaCita, CausaDeLaCita = @causaDeLaCita, EstadoDeLaCita = @estadoDeLaCita from Citas where Id = @id", connection);

            command.Parameters.AddWithValue("@id", item.Id);
            command.Parameters.AddWithValue("@idPacientes", item.IdPacientes);
            command.Parameters.AddWithValue("@idDoctor", item.IdDoctor);
            command.Parameters.AddWithValue("@fechaYHoraDeLaCita", item.FechaYHoraDeLaCita);
            command.Parameters.AddWithValue("@causaDeLaCita", item.CausaDeLaCita);
            command.Parameters.AddWithValue("@estadoDeLaCita", item.EstadoDeLaCita);

            return ExecuteDML(command);

        }

        public bool Delete(int id)
        {

            SqlCommand command = new SqlCommand("Delete Citas where Id = @id", connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDML(command);

        }

        public Cita GetById(int id)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from Citas where Id = @id", connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Cita data = new Cita();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.IdPacientes = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    data.IdDoctor = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                    data.FechaYHoraDeLaCita = reader.IsDBNull(3) ? new DateTime(0000, 00, 00, 00, 00, 00) : reader.GetDateTime(3);
                    data.CausaDeLaCita = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.EstadoDeLaCita = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
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

                SqlDataAdapter query = new SqlDataAdapter("Select C.Id as ID, P.Nombre as Paciente, D.Nombre as Doctor, C.FechaYHoraDeLaCita, C.CausaDeLaCita, C.EstadoDeLaCita from Citas C join Pacientes P on P.Id = C.IdPaciente join Doctores D on D.Id = C.IdDoctor", connection);
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

        //Inutiles para este repositorio
        public List<Cita> GetList()
        {
            try
            {
                List<Cita> list = new List<Cita>();

                connection.Open();

                SqlCommand command = new SqlCommand("Select C.Id as ID, P.Nombre as Paciente, D.Nombre as Doctor, C.FechaYHoraDeLaCita, C.CausaDeLaCita, C.EstadoDeLaCita from Citas C join Pacientes P on P.Id = C.IdPaciente join Doctores D on D.Id = C.IdDoctor", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Cita
                    {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        IdPacientes = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                        IdDoctor = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                        FechaYHoraDeLaCita = reader.IsDBNull(3) ? new DateTime(0000, 00, 00, 00, 00, 00) : reader.GetDateTime(3),
                        CausaDeLaCita = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        EstadoDeLaCita = reader.IsDBNull(5) ? 0 : reader.GetInt32(5)
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

    }
}
