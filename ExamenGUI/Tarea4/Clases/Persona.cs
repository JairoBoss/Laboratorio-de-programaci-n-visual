using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4.Clases
{
    [Serializable]
    class Persona
    {
        private String nombre;
        private String apellidoPaterno;
        private String apellidoMaterno;
        
        public Persona(string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;            
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
    }
}
