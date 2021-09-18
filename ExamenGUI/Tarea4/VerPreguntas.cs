using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea4.Clases;

namespace Tarea4
{
    public partial class VerPreguntas : Form
    {

        private List<Pregunta> preguntas;
        static String dir = Directory.GetCurrentDirectory();
        String serializationFile = Path.Combine(dir, "Preguntas.bin");

        public VerPreguntas()
        {
            InitializeComponent();
            listView1.Scrollable = true;
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                preguntas = (List<Pregunta>)bformatter.Deserialize(stream);
            }

            foreach (Pregunta pregunta in preguntas)
            {
                ListViewItem filita = new ListViewItem(pregunta.Oracion.ToString());
                filita.SubItems.Add(pregunta.Materia.ToString());
                int respuestaCorrecta = 0;
                int numero = 0;
                foreach(Respuesta x in pregunta.Respuestas)
                {
                    filita.SubItems.Add(x.Inciso.ToString());
                    respuestaCorrecta++;
                    if (x.Calificacion == true)
                    {
                        numero = respuestaCorrecta;
                    }
                    
                }

                respuestaCorrecta = 0;
                filita.SubItems.Add(numero.ToString());


                listView1.Items.Add(filita);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
