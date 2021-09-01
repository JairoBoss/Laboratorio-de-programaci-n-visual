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
    
    public partial class Identificate : Form
    {
        static String dir = Directory.GetCurrentDirectory();
        String serializationFile = Path.Combine(dir, "Estudiante.bin");
        public Identificate()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "" || txtApellidoPaterno.Text == "" || txtApeliidoMaterno.Text == "" || txtNoControl.Text == "")
            {
                MessageBox.Show("Ingresa todos los datos");
            }
            else
            {
                Estudiante estudiante = new Estudiante(txtNombre.Text, txtApellidoPaterno.Text, txtApeliidoMaterno.Text, txtNoControl.Text);

                using (Stream stream = File.Open(serializationFile, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, estudiante);
                }

                limpiarControles();

                MessageBox.Show("Se guardado con exito el ingreso");
            }
            
        }

        public void limpiarControles()
        {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApeliidoMaterno.Clear();
            txtNoControl.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
