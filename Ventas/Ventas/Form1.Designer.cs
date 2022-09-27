namespace Ventas
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
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.btnNumero = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnReinicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFactura
            // 
            this.dgvFactura.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(206, 197);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(535, 207);
            this.dgvFactura.TabIndex = 0;
            // 
            // btnNumero
            // 
            this.btnNumero.BackColor = System.Drawing.Color.Azure;
            this.btnNumero.Location = new System.Drawing.Point(206, 148);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(168, 43);
            this.btnNumero.TabIndex = 1;
            this.btnNumero.Text = "Factura Mayores a 1000";
            this.btnNumero.UseVisualStyleBackColor = false;
            this.btnNumero.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.Azure;
            this.btnEmpleado.Location = new System.Drawing.Point(573, 148);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(168, 43);
            this.btnEmpleado.TabIndex = 2;
            this.btnEmpleado.Text = "Facturas por Juan Perez";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnReinicio
            // 
            this.btnReinicio.BackColor = System.Drawing.Color.Azure;
            this.btnReinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinicio.Location = new System.Drawing.Point(410, 62);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(161, 35);
            this.btnReinicio.TabIndex = 3;
            this.btnReinicio.Text = "Reinicar";
            this.btnReinicio.UseVisualStyleBackColor = false;
            this.btnReinicio.Click += new System.EventHandler(this.btnReinicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 538);
            this.Controls.Add(this.btnReinicio);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnNumero);
            this.Controls.Add(this.dgvFactura);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Button btnNumero;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnReinicio;
    }
}

