
namespace Tarea4
{
    partial class Form1
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnResponderCuestionario = new System.Windows.Forms.PictureBox();
            this.btnAñadirCuestionario = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResponderCuestionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAñadirCuestionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.pictureBox1);
            this.panelControl.Controls.Add(this.btnSalir);
            this.panelControl.Controls.Add(this.btnResponderCuestionario);
            this.panelControl.Controls.Add(this.btnAñadirCuestionario);
            this.panelControl.Controls.Add(this.btnHome);
            this.panelControl.Location = new System.Drawing.Point(0, 1);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(182, 450);
            this.panelControl.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(188, 1);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(610, 447);
            this.panelContenedor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tarea4.Properties.Resources.Group_7;
            this.pictureBox1.Location = new System.Drawing.Point(12, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Tarea4.Properties.Resources.Salir1;
            this.btnSalir.Location = new System.Drawing.Point(12, 373);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(155, 50);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResponderCuestionario
            // 
            this.btnResponderCuestionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponderCuestionario.Image = global::Tarea4.Properties.Resources.Responder;
            this.btnResponderCuestionario.Location = new System.Drawing.Point(12, 266);
            this.btnResponderCuestionario.Name = "btnResponderCuestionario";
            this.btnResponderCuestionario.Size = new System.Drawing.Size(155, 50);
            this.btnResponderCuestionario.TabIndex = 2;
            this.btnResponderCuestionario.TabStop = false;
            this.btnResponderCuestionario.Click += new System.EventHandler(this.btnResponderCuestionario_Click);
            // 
            // btnAñadirCuestionario
            // 
            this.btnAñadirCuestionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirCuestionario.Image = global::Tarea4.Properties.Resources.AñadirCuestionario;
            this.btnAñadirCuestionario.Location = new System.Drawing.Point(12, 112);
            this.btnAñadirCuestionario.Name = "btnAñadirCuestionario";
            this.btnAñadirCuestionario.Size = new System.Drawing.Size(155, 50);
            this.btnAñadirCuestionario.TabIndex = 1;
            this.btnAñadirCuestionario.TabStop = false;
            this.btnAñadirCuestionario.Click += new System.EventHandler(this.btnAñadirCuestionario_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::Tarea4.Properties.Resources.ULSALogo_1;
            this.btnHome.Location = new System.Drawing.Point(28, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(127, 47);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResponderCuestionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAñadirCuestionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.PictureBox btnResponderCuestionario;
        private System.Windows.Forms.PictureBox btnAñadirCuestionario;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

