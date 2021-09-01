using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4.Clases
{
    [Serializable]
    class Estudiante : Persona
    {
        private String noControl;
        private int calificacion;

        public Estudiante(string nombre, string apellidoPaterno, string apellidoMaterno, string noControl)
            : base(nombre, apellidoPaterno, apellidoMaterno)
        {
            this.noControl = noControl;
        }

        public string NoControl { get => noControl; set => noControl = value; }
        public int Calificacion { get => calificacion; set => calificacion = value; }
    }
}
