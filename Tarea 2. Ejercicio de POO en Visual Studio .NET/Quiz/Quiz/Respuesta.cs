using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class Respuesta
    {
        private String inciso;
        private Boolean calificacion;

        public Respuesta(string inciso, bool calificacion)
        {
            this.inciso = inciso;
            this.calificacion = calificacion;
        }

        public string Inciso { get => inciso; set => inciso = value; }
        public bool Calificacion { get => calificacion; set => calificacion = value; }
    }        
}
