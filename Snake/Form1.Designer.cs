namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.puntos = new System.Windows.Forms.Label();
            this.bucle = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.vel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(22, 64);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(675, 304);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Allegro", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntaje";
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.Font = new System.Drawing.Font("Allegro", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntos.ForeColor = System.Drawing.Color.White;
            this.puntos.Location = new System.Drawing.Point(325, 373);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(44, 59);
            this.puntos.TabIndex = 2;
            this.puntos.Text = "0";
            // 
            // bucle
            // 
            this.bucle.Enabled = true;
            this.bucle.Tick += new System.EventHandler(this.bucle_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Allegro", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "Snake Visual Studio";
            // 
            // vel
            // 
            this.vel.AutoSize = true;
            this.vel.Font = new System.Drawing.Font("Allegro", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vel.ForeColor = System.Drawing.Color.White;
            this.vel.Location = new System.Drawing.Point(653, 370);
            this.vel.Name = "vel";
            this.vel.Size = new System.Drawing.Size(44, 59);
            this.vel.TabIndex = 4;
            this.vel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Allegro", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(508, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "Velocidad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(720, 466);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Culebrita";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label puntos;
        private System.Windows.Forms.Timer bucle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label vel;
        private System.Windows.Forms.Label label4;
    }
}

