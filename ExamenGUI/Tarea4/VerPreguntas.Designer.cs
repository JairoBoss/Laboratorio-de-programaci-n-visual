
namespace Tarea4
{
    partial class VerPreguntas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pregunta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Materia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Respuesta1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Respuesta2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Respuesta3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Correcta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 452);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pregunta,
            this.Materia,
            this.Respuesta1,
            this.Respuesta2,
            this.Respuesta3,
            this.Correcta});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(630, 312);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // pregunta
            // 
            this.pregunta.Text = "Pregunta";
            this.pregunta.Width = 250;
            // 
            // Materia
            // 
            this.Materia.Text = "Materia";
            this.Materia.Width = 100;
            // 
            // Respuesta1
            // 
            this.Respuesta1.Text = "Respuesta 1";
            this.Respuesta1.Width = 100;
            // 
            // Respuesta2
            // 
            this.Respuesta2.Text = "Respuesta 2";
            this.Respuesta2.Width = 100;
            // 
            // Respuesta3
            // 
            this.Respuesta3.Text = "Respuesta 3";
            this.Respuesta3.Width = 100;
            // 
            // Correcta
            // 
            this.Correcta.Text = "Correcta";
            this.Correcta.Width = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preguntas";
            // 
            // VerPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.panel1);
            this.Name = "VerPreguntas";
            this.Text = "VerPreguntas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader pregunta;
        private System.Windows.Forms.ColumnHeader Materia;
        private System.Windows.Forms.ColumnHeader Respuesta1;
        private System.Windows.Forms.ColumnHeader Respuesta2;
        private System.Windows.Forms.ColumnHeader Respuesta3;
        private System.Windows.Forms.ColumnHeader Correcta;
        private System.Windows.Forms.Label label1;
    }
}