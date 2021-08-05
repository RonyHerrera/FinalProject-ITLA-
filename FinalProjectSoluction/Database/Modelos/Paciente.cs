using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Modelos
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public bool Fumador { get; set; }
        public string Alergias { get; set; }
        public string Foto { get; set; }
    }
}
