using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Modelos
{
    public class Cita
    {
        public int Id { get; set; }
        public int IdPacientes { get; set; }
        public int IdDoctor { get; set; }
        public DateTime FechaYHoraDeLaCita { get; set; }
        public string CausaDeLaCita { get; set; }
        public int EstadoDeLaCita { get; set; }
    }
}
