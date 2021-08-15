using System;
using System.Collections.Generic;
using System.Text;

//Esta es la clase que va a responder las preguntas

namespace Quiz
{
    class Estudiante : Persona
    {
        private String noControl;
        private int calificacion;

        public Estudiante(string nombre, string apellidoPaterno, string apellidoMaterno, int edad, string noControl)
            :base(nombre,apellidoPaterno, apellidoMaterno,edad)
        {
            this.noControl = noControl;
        }

        public string NoControl { get => noControl; set => noControl = value; }
        public int Calificacion { get => calificacion; set => calificacion = value; }
    }
}
