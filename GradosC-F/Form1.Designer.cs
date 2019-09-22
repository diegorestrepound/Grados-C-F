namespace GradosC_F
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
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtgrados = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(132, 238);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(53, 13);
            this.lblresultado.TabIndex = 0;
            this.lblresultado.Text = "resultado:";
            this.lblresultado.Visible = false;
            this.lblresultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtgrados
            // 
            this.txtgrados.Location = new System.Drawing.Point(122, 117);
            this.txtgrados.Name = "txtgrados";
            this.txtgrados.Size = new System.Drawing.Size(100, 20);
            this.txtgrados.TabIndex = 1;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(135, 173);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Covertir";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtgrados);
            this.Controls.Add(this.lblresultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtgrados;
        private System.Windows.Forms.Button btncalcular;
    }
}

