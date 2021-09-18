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
    public partial class AñadirPregunta : Form
    {

        private List<Pregunta> preguntas;
        static String dir = Directory.GetCurrentDirectory();
        String serializationFile = Path.Combine(dir, "Preguntas.bin");


        public AñadirPregunta()
        {
            InitializeComponent();
            preguntas = new List<Pregunta>();
            
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtRespuesta1.Text == "" || txtR2.Text == "" || txtR3.Text == "" || txtRespuesta.Text == "")
            {
                MessageBox.Show("Ingresa todos los datos");
            }
            else
            {
                Respuesta r1 = new Respuesta(txtRespuesta1.Text, false);
                Respuesta r2 = new Respuesta(txtR2.Text, false);
                Respuesta r3 = new Respuesta(txtR3.Text, false);


                switch (Convert.ToInt16(comboBoxRespuetaCorrecta.SelectedItem.ToString()))
                {
                    case 1:
                        r1 = new Respuesta(txtRespuesta1.Text, true);
                        break;
                    case 2:
                        r2 = new Respuesta(txtR2.Text, true);
                        break;
                    case 3:
                        r3 = new Respuesta(txtR3.Text, true);
                        break;

                }
                List<Respuesta> answers = new List<Respuesta>();
                answers.Add(r1);
                answers.Add(r2);
                answers.Add(r3);

                Pregunta pregunta = new Pregunta(txtRespuesta.Text, comboBoxMateria.SelectedItem.ToString(), answers);

                preguntas.Add(pregunta);
                limpiarControles();

                MessageBox.Show("Se ha agregado la pregunta con exito");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, preguntas);
            }

            limpiarControles();

            MessageBox.Show("Se guardado con exito");
        }

        private void limpiarControles()
        {
            txtRespuesta.Clear();
            
            txtRespuesta1.Clear();
            txtR2.Clear();
            txtR3.Clear();
            

        }
    
    }
}
