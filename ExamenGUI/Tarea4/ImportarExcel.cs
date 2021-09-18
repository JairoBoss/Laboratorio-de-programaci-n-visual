using SpreadsheetLight;
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
    public partial class ImportarExcel : Form
    {

        private List<Pregunta> preguntas;
        static String dir = Directory.GetCurrentDirectory();
        String serializationFile = Path.Combine(dir, "Preguntas.bin");

        public ImportarExcel()
        {
            InitializeComponent();
            preguntas = new List<Pregunta>();

            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                preguntas = (List<Pregunta>)bformatter.Deserialize(stream);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                SLDocument sl = new SLDocument(openFileDialog1.FileName);
                int iRow = 2;
                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                {
                    string pregunta = sl.GetCellValueAsString(iRow, 1);
                    string materia = sl.GetCellValueAsString(iRow, 2);
                    Respuesta r1 = new Respuesta(sl.GetCellValueAsString(iRow, 3), false);
                    Respuesta r2 = new Respuesta(sl.GetCellValueAsString(iRow, 4), false);
                    Respuesta r3 = new Respuesta(sl.GetCellValueAsString(iRow, 5), false);

                    switch (sl.GetCellValueAsInt32(iRow, 6))
                    {
                        case 1:
                            r1 = new Respuesta(sl.GetCellValueAsString(iRow, 3), true);
                            break;
                        case 2:
                            r2 = new Respuesta(sl.GetCellValueAsString(iRow, 4), true);
                            break;
                        case 3:
                            r3 = new Respuesta(sl.GetCellValueAsString(iRow, 5), true);
                            break;
                    }

                    List<Respuesta> answers = new List<Respuesta>();
                    answers.Add(r1);
                    answers.Add(r2);
                    answers.Add(r3);

                    Pregunta preguntaA = new Pregunta(pregunta, materia, answers);
                    preguntas.Add(preguntaA);
                    iRow++;
                }
                MessageBox.Show("Se importo con exito");

            }

            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, preguntas);
            }

        }
    }
}
