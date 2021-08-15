using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class Pregunta
    {
        private String oracion;
        private String materia;
        private List<Respuesta> respuestas;

        public Pregunta(string oracion, string materia, List<Respuesta> respuestas)
        {
            this.oracion = oracion;
            this.materia = materia;
            this.respuestas = respuestas;
        }

        public void revisar(int inciso)
        {

        }

       public List<Respuesta> getRespuestas()
        {
            return this.respuestas;
        }

        public string Oracion { get => oracion; set => oracion = value; }
        public string Materia { get => materia; set => materia = value; }
        internal List<Respuesta> Respuestas { get => respuestas; set => respuestas = value; }
    }
}
