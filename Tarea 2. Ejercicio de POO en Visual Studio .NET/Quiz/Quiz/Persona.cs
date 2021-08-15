using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class Persona
    {
        private String nombre;
        private String apellidoPaterno;
        private String apellidoMaterno;
        private int edad;

        public Persona(string nombre, string apellidoPaterno, string apellidoMaterno, int edad)
        {
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
