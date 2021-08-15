using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class Quiz
    {
        private List<Pregunta> preguntas;
        private float calificacion;
        private int preguntasCorrectas;
        public Quiz(List<Pregunta> preguntas)
        {
            this.preguntas = preguntas;
            this.preguntasCorrectas = 0;
        }


        public int PreguntasCorrectas { get => preguntasCorrectas; set => preguntasCorrectas = value; }
        internal List<Pregunta> Preguntas { get => preguntas; set => preguntas = value; }

        public void responder()
        {
            int contador = 0;
            foreach(Pregunta pregunta in preguntas)
            {

                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n\n");
                
                contador++;
                Console.WriteLine("\t\t\t\tContestalo con honestidad, solo tienes una oportunidad");
                Console.WriteLine("\t\t\t\tMateria: " + pregunta.Materia+", Pregunta no: "+contador);
                Console.WriteLine("\t\t\t\t"+pregunta.Oracion);
                Console.WriteLine("\t\t\t\tSelecciona un inciso");

                List<Respuesta> respuestasPregunta = pregunta.getRespuestas();
                int contadorRespuestas = 0;
                foreach(Respuesta re in respuestasPregunta)
                {
                    contadorRespuestas++;
                    Console.WriteLine("\t\t\t\t[" + contadorRespuestas+"]"+" "+re.Inciso);
                }

                
                Console.Write("\t\t\t=======>  "); int seleccionUser = Convert.ToInt16(Console.ReadLine());
                //Console.WriteLine("El usuario selecciono: "+seleccionUser);
                if (respuestasPregunta[seleccionUser-1].Calificacion == true)
                {
                    this.preguntasCorrectas++;
                }
            }

            
        }

       

    }
}
