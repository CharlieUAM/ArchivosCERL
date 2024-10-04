namespace ArchivosPeroConVista
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
            this.LBSoli = new System.Windows.Forms.Label();
            this.tbinfo = new System.Windows.Forms.TextBox();
            this.Btnsend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbage = new System.Windows.Forms.TextBox();
            this.tbgrade = new System.Windows.Forms.TextBox();
            this.tbgender = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBSoli
            // 
            this.LBSoli.AutoSize = true;
            this.LBSoli.Location = new System.Drawing.Point(155, 31);
            this.LBSoli.Name = "LBSoli";
            this.LBSoli.Size = new System.Drawing.Size(95, 13);
            this.LBSoli.TabIndex = 0;
            this.LBSoli.Text = "Escribe un nombre";
            // 
            // tbinfo
            // 
            this.tbinfo.Location = new System.Drawing.Point(256, 28);
            this.tbinfo.Name = "tbinfo";
            this.tbinfo.Size = new System.Drawing.Size(100, 20);
            this.tbinfo.TabIndex = 1;
            // 
            // Btnsend
            // 
            this.Btnsend.Location = new System.Drawing.Point(379, 31);
            this.Btnsend.Name = "Btnsend";
            this.Btnsend.Size = new System.Drawing.Size(75, 23);
            this.Btnsend.TabIndex = 2;
            this.Btnsend.Text = "Enviar";
            this.Btnsend.UseVisualStyleBackColor = true;
            this.Btnsend.Click += new System.EventHandler(this.Btnsend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "escriba su edad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Escriba su nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "escriba su genero";
            // 
            // tbage
            // 
            this.tbage.Location = new System.Drawing.Point(256, 62);
            this.tbage.Name = "tbage";
            this.tbage.Size = new System.Drawing.Size(100, 20);
            this.tbage.TabIndex = 6;
            // 
            // tbgrade
            // 
            this.tbgrade.Location = new System.Drawing.Point(256, 91);
            this.tbgrade.Name = "tbgrade";
            this.tbgrade.Size = new System.Drawing.Size(100, 20);
            this.tbgrade.TabIndex = 7;
            // 
            // tbgender
            // 
            this.tbgender.Location = new System.Drawing.Point(256, 119);
            this.tbgender.Name = "tbgender";
            this.tbgender.Size = new System.Drawing.Size(100, 20);
            this.tbgender.TabIndex = 8;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(379, 58);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 9;
            this.btnLeer.Text = "leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 180);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(513, 160);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.tbgender);
            this.Controls.Add(this.tbgrade);
            this.Controls.Add(this.tbage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnsend);
            this.Controls.Add(this.tbinfo);
            this.Controls.Add(this.LBSoli);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBSoli;
        private System.Windows.Forms.TextBox tbinfo;
        private System.Windows.Forms.Button Btnsend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbage;
        private System.Windows.Forms.TextBox tbgrade;
        private System.Windows.Forms.TextBox tbgender;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.TextBox textBox1;
    }
}

