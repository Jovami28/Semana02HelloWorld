using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02HelloWorld
{
    public class Persona
    {
        public int DNI { get; set; }
        public string NombreCompleto { get; set; }
        public string telefono { get; set; }
        public bool Estado { get; set; }

        public Persona(int DNI, string NombreCompleto, string telefono, bool Estado) {
            DNI = DNI;
            NombreCompleto = NombreCompleto;
            telefono = telefono;
            Estado = Estado;
        }

        public Persona()
        {
            
        }
    }
}
