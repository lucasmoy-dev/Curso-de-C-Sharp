using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProgramacion
{
    class Cliente
    {

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string TarjetaDeCredito { get; set; }

        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
