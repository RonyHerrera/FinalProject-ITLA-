using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Modelos
{
    public class Resultados
    {
        public int Id { get; set; }
        public int IdCita { get; set; }
        public int IdPacientes { get; set; }
        public int IdPruebaDeLaboratorio { get; set; }
        public int IdDoctor { get; set; }
        public string ResultadosDeLaPrueba { get; set; }
        public int EstadoDelResultado { get; set; }
    }
}
