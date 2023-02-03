namespace tarea1_20181030120
{
    partial class tarea1
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
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btt_calcular = new System.Windows.Forms.Button();
            this.txb_ingresar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_resultado.Location = new System.Drawing.Point(224, 306);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(25, 24);
            this.lbl_resultado.TabIndex = 13;
            this.lbl_resultado.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Resultado:";
            // 
            // btt_calcular
            // 
            this.btt_calcular.Location = new System.Drawing.Point(287, 233);
            this.btt_calcular.Name = "btt_calcular";
            this.btt_calcular.Size = new System.Drawing.Size(111, 37);
            this.btt_calcular.TabIndex = 11;
            this.btt_calcular.Text = "Calcular";
            this.btt_calcular.UseVisualStyleBackColor = true;
            this.btt_calcular.Click += new System.EventHandler(this.btt_calcular_Click);
            // 
            // txb_ingresar
            // 
            this.txb_ingresar.Location = new System.Drawing.Point(275, 187);
            this.txb_ingresar.Name = "txb_ingresar";
            this.txb_ingresar.Size = new System.Drawing.Size(166, 29);
            this.txb_ingresar.TabIndex = 10;
            this.txb_ingresar.TextChanged += new System.EventHandler(this.txb_ingresar_TextChanged);
            this.txb_ingresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_ingresar_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingrese un valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Par,Impar,Positivo o Negativo.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Determina si un valor es:";
            // 
            // tarea1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(560, 392);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btt_calcular);
            this.Controls.Add(this.txb_ingresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "tarea1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btt_calcular;
        private System.Windows.Forms.TextBox txb_ingresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

