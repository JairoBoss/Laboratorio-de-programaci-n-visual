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
    public partial class ResponderCuestionario : Form
    {

        private List<Pregunta> preguntas;

        static String dir = Directory.GetCurrentDirectory();
        String serializationFile = Path.Combine(dir, "Preguntas.bin");
        private int contador = 0;
        public ResponderCuestionario()
        {
            InitializeComponent();
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                preguntas = (List<Pregunta>)bformatter.Deserialize(stream);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Pregunta x = preguntas[contador];
            lblPregunta.Text = (x.Oracion);

            List<Respuesta> respuestas = x.getRespuestas();
            radioButton1.Text = respuestas[0].Inciso;
            radioButton2.Text = respuestas[1].Inciso;
            radioButton3.Text = respuestas[2].Inciso;


            contador++;
        }

        private void mostrar()
        {
            
        }
    }
}
