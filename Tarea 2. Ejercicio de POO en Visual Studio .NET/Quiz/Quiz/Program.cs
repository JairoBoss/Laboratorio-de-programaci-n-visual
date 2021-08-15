using System;
using System.Collections.Generic;
using System.Threading;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio();
            List<Pregunta> preguntas = new List<Pregunta>();

            int opcion = -1;

            while(opcion != 3)
            {
                Console.Clear();
                centrar();                
                menu();
                Console.WriteLine("\t\t\t\tSeleccione una opcion:");
                Console.WriteLine("\t\t\t\t[1] Agregar pregunta");
                Console.WriteLine("\t\t\t\t[2] Responder Quiz");
                Console.WriteLine("\t\t\t\t[3] Salir");
                Console.WriteLine("");
                Console.Write("\t\t\t=======>  ");
                opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        centrar();

                        Console.WriteLine("\t\t\t\t¿De que materia es tu pregunta?");
                        Console.Write("\t\t\t=======>  "); String materia = (Console.ReadLine());

                        Console.Clear();
                        centrar();
                        Console.WriteLine("\t\t\t\t¿Cual es tu pregunta?");
                        Console.Write("\t\t\t=======>  "); String textoPregunta = (Console.ReadLine());

                        Console.Clear();
                        centrar();
                        Console.WriteLine("\t\t\tAhora vas a ingresar 3 respeustas");
                        Console.WriteLine("\t\t\tAl final te pediremos que indiques cual de los 3 es el correcto");
                        
                        Console.WriteLine("\t\t\t\tInciso numero [1]");
                        Console.Write("\t\t\t=======>  "); String in1 = (Console.ReadLine());
                        Respuesta r1 = new Respuesta(in1, false);

                        Console.WriteLine("\t\t\t\tInciso numero [2]");
                        Console.Write("\t\t\t=======>  "); String in2 = (Console.ReadLine());
                        Respuesta r2 = new Respuesta(in2, false);

                        Console.WriteLine("\t\t\t\tInciso numero [3]");
                        Console.Write("\t\t\t=======>  "); String in3 = (Console.ReadLine());
                        Respuesta r3 = new Respuesta(in3, false);

                        Console.WriteLine("\t\t\tDe las 3 respuestas anteriores, ¿Cual es la correcta?");
                        Console.Write("\t\t\t=======>  "); int respuetaCorrecta = Convert.ToInt16(Console.ReadLine());

                        List<Respuesta> respuesta = new List<Respuesta>();
                        respuesta.Add(r1);
                        respuesta.Add(r2);
                        respuesta.Add(r3);
                        respuesta[respuetaCorrecta-1].Calificacion = true;

                        Pregunta pregunta = new Pregunta(textoPregunta, materia, respuesta);
                        preguntas.Add(pregunta);

                        Console.WriteLine("\t\t\t---- Pregunta agregada con exito ---- ");

                        Console.Clear();
                        break;

                    case 2:                                         
                        Console.Clear();
                        centrar();
                        Console.WriteLine("\t\t\t\tPara guardar tu progreso te tienes que registrar");
                        Console.WriteLine("\t\t\t\t¿Cual es tu primer nombre?");
                        Console.Write("\t\t\t=======>  "); String nombre= (Console.ReadLine());

                        Console.Clear();
                        centrar();
                        Console.WriteLine("\t\t\t\t¿Cual es tu primer apellido paterno?");
                        Console.Write("\t\t\t=======>  "); String paternoApellido = (Console.ReadLine());

                        Console.Clear();
                        centrar();
                        Console.WriteLine("\t\t\t\t¿Cual es tu apellido materno?");
                        Console.Write("\t\t\t=======>  "); String apellidoMaterno = (Console.ReadLine());

                        Console.Clear();
                        centrar();
                        Console.WriteLine("\t\t\t\t¿Cual es tu edad?");
                        Console.Write("\t\t\t=======>  "); int edad= Convert.ToInt16(Console.ReadLine());

                        Console.Clear();
                        centrar();
                        Console.WriteLine("\t\t\t\t¿Cual es tu primer noControl?");
                        Console.Write("\t\t\t=======>  "); String noControl = (Console.ReadLine());

                        Estudiante student = new Estudiante(nombre, paternoApellido, apellidoMaterno, edad, noControl);

                        Console.Clear();
                        centrar();

                        

                        Quiz cuestionario = new Quiz(preguntas);
                        cuestionario.responder();

                        
                        student.Calificacion = cuestionario.PreguntasCorrectas;
                        user(student.Nombre,student.Calificacion,preguntas.Count);

                        break;

                    case 3:
                        Console.WriteLine("\t\t\t**** Saliendo ****");
                        break;

                    default:
                        Console.Write("\t\t\t\tIngrese una opcion correcta");
                        Console.WriteLine("");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
                
            }

            
        }

        public static void menu()
        {
            
            Console.WriteLine("\t\t\t\t▒█▀▄▀█ ▒█▀▀▀ ▒█▄░▒█ ▒█░▒█ ");
            Console.WriteLine("\t\t\t\t▒█▒█▒█ ▒█▀▀▀ ▒█▒█▒█ ▒█░▒█ ");
            Console.WriteLine("\t\t\t\t▒█░░▒█ ▒█▄▄▄ ▒█░░▀█ ░▀▄▄▀");
            Console.WriteLine();
        }

        public static void centrar()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n");
        }

        public static void inicio()
        {
            Console.WriteLine("░██╗░░░░░░░██╗███████╗██╗░░░░░░█████╗░░█████╗░███╗░░░███╗███████╗  ██████╗░░█████╗░░█████╗░██╗░░██╗");
            Console.WriteLine("░██║░░██╗░░██║██╔════╝██║░░░░░██╔══██╗██╔══██╗████╗░████║██╔════╝  ██╔══██╗██╔══██╗██╔══██╗██║░██╔╝");
            Console.WriteLine("░╚██╗████╗██╔╝█████╗░░██║░░░░░██║░░╚═╝██║░░██║██╔████╔██║█████╗░░  ██████╦╝███████║██║░░╚═╝█████═╝░");
            Console.WriteLine("░░████╔═████║░██╔══╝░░██║░░░░░██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░  ██╔══██╗██╔══██║██║░░██╗██╔═██╗░");
            Console.WriteLine("░░╚██╔╝░╚██╔╝░███████╗███████╗╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗  ██████╦╝██║░░██║╚█████╔╝██║░╚██╗");
            Console.WriteLine("░░░╚═╝░░░╚═╝░░╚══════╝╚══════╝░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝  ╚═════╝░╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝");
            Console.WriteLine("");
            Console.WriteLine("                                                   d8b             ");
            Console.WriteLine("                         d8P                 d8P   ?88             ");
            Console.WriteLine("                      d888888P            d888888P  88b            ");
            Console.WriteLine("                        ?88'   d8888b       ?88'    888888b  d8888b");
            Console.WriteLine("                        88P   d8P' ?88      88P     88P `?8bd8b_,dP");
            Console.WriteLine("                        88b   88b  d88      88b    d88   88P88b    ");
            Console.WriteLine("                        `?8b  `?8888P'      `?8b  d88'   88b`?888P'");
            Console.WriteLine("");
            Console.WriteLine("                           ░██████╗░██╗░░░██╗██╗███████╗");
            Console.WriteLine("                           ██╔═══██╗██║░░░██║██║╚════██║");
            Console.WriteLine("                           ██║██╗██║██║░░░██║██║░░███╔═╝");
            Console.WriteLine("                           ╚██████╔╝██║░░░██║██║██╔══╝░░");
            Console.WriteLine("                           ░╚═██╔═╝░╚██████╔╝██║███████╗");
            Console.WriteLine("                           ░░░╚═╝░░░░╚═════╝░╚═╝╚══════╝");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("                             Cargando ");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(600);
                Console.Write(".");
            }
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void user(String nombre,int correctas,int total)
        {
            
            Console.Clear();
            centrar();
            Console.WriteLine("\t\t\t\t██████╗░███████╗░██████╗██╗░░░██╗██╗░░░░░████████╗░█████╗░██████╗░░█████╗░");
            Console.WriteLine("\t\t\t\t██╔══██╗██╔════╝██╔════╝██║░░░██║██║░░░░░╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗");
            Console.WriteLine("\t\t\t\t██████╔╝█████╗░░╚█████╗░██║░░░██║██║░░░░░░░░██║░░░███████║██║░░██║██║░░██║");
            Console.WriteLine("\t\t\t\t██╔══██╗██╔══╝░░░╚═══██╗██║░░░██║██║░░░░░░░░██║░░░██╔══██║██║░░██║██║░░██║");
            Console.WriteLine("\t\t\t\t██║░░██║███████╗██████╔╝╚██████╔╝███████╗░░░██║░░░██║░░██║██████╔╝╚█████╔╝");
            Console.WriteLine("\t\t\t\t╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚══════╝░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░░╚════╝░");            


            Console.WriteLine("\t\t\t\tEstudiante: "+nombre);
            Console.WriteLine("\t\t\t\tTuvo un total de "+correctas+" preguntas correctas , de: "+total);
            Console.Write("                             Volviendo al menu ");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(600);
                Console.Write(".");
            }

            Thread.Sleep(10000);
        }
    }
}
