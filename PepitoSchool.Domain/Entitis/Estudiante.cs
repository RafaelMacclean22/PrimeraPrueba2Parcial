using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchool.Domain.Entitis
{
    class Estudiante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Numero { get; set; }
        public string Correo { get; set; }
        public string Matematica { get; set; }
        public string Contabilidad { get; set; }
        public string Programacion { get; set; }
        public string Estadistica { get; set; }
    }
}
