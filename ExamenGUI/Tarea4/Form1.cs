using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormEnPanel(Object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;

            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            fh.Show();
        }

        private void btnAñadirCuestionario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new AñadirPregunta());
        }

        private void btnResponderCuestionario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ResponderCuestionario());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.panelContenedor.Controls.RemoveAt(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Identificate());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
