
namespace ZapateriaShu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ñe = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncerrarsesion = new System.Windows.Forms.Button();
            this.btniniciar = new System.Windows.Forms.Button();
            this.richtxbmenuprincipal = new System.Windows.Forms.RichTextBox();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.richtxbperfilusuario = new System.Windows.Forms.RichTextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.timerZapateria_Shu = new System.Windows.Forms.Timer(this.components);
            this.contenedor = new System.Windows.Forms.Panel();
            this.ñe.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ñe
            // 
            this.ñe.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ñe.Controls.Add(this.label1);
            this.ñe.Dock = System.Windows.Forms.DockStyle.Top;
            this.ñe.Location = new System.Drawing.Point(0, 0);
            this.ñe.Name = "ñe";
            this.ñe.Size = new System.Drawing.Size(740, 55);
            this.ñe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(245, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "ZapateriaShu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btncerrarsesion);
            this.panel2.Controls.Add(this.btniniciar);
            this.panel2.Controls.Add(this.richtxbmenuprincipal);
            this.panel2.Controls.Add(this.lblhora);
            this.panel2.Controls.Add(this.lblfecha);
            this.panel2.Controls.Add(this.richtxbperfilusuario);
            this.panel2.Controls.Add(this.btnsalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 418);
            this.panel2.TabIndex = 1;
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.BackColor = System.Drawing.Color.DarkOrange;
            this.btncerrarsesion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrarsesion.ForeColor = System.Drawing.Color.Black;
            this.btncerrarsesion.Location = new System.Drawing.Point(22, 252);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(113, 32);
            this.btncerrarsesion.TabIndex = 5;
            this.btncerrarsesion.Text = "Cerrar Sesion";
            this.btncerrarsesion.UseVisualStyleBackColor = false;
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.DarkOrange;
            this.btniniciar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.ForeColor = System.Drawing.Color.Black;
            this.btniniciar.Location = new System.Drawing.Point(22, 203);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(113, 32);
            this.btniniciar.TabIndex = 4;
            this.btniniciar.Text = "Iniciar Sesion";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // richtxbmenuprincipal
            // 
            this.richtxbmenuprincipal.BackColor = System.Drawing.Color.Gold;
            this.richtxbmenuprincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxbmenuprincipal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxbmenuprincipal.Location = new System.Drawing.Point(10, 177);
            this.richtxbmenuprincipal.Name = "richtxbmenuprincipal";
            this.richtxbmenuprincipal.Size = new System.Drawing.Size(135, 141);
            this.richtxbmenuprincipal.TabIndex = 3;
            this.richtxbmenuprincipal.Text = "Menu Principal";
            // 
            // lblhora
            // 
            this.lblhora.BackColor = System.Drawing.Color.Orange;
            this.lblhora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblhora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblhora.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(22, 100);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(113, 24);
            this.lblhora.TabIndex = 2;
            this.lblhora.Text = "Hora";
            // 
            // lblfecha
            // 
            this.lblfecha.BackColor = System.Drawing.Color.Orange;
            this.lblfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblfecha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(22, 52);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(113, 23);
            this.lblfecha.TabIndex = 0;
            this.lblfecha.Text = "Fecha";
            // 
            // richtxbperfilusuario
            // 
            this.richtxbperfilusuario.BackColor = System.Drawing.Color.Gold;
            this.richtxbperfilusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxbperfilusuario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxbperfilusuario.Location = new System.Drawing.Point(10, 7);
            this.richtxbperfilusuario.Name = "richtxbperfilusuario";
            this.richtxbperfilusuario.Size = new System.Drawing.Size(135, 141);
            this.richtxbperfilusuario.TabIndex = 1;
            this.richtxbperfilusuario.Text = "Perfil Usuario";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Maroon;
            this.btnsalir.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnsalir.Location = new System.Drawing.Point(22, 371);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(113, 39);
            this.btnsalir.TabIndex = 0;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // timerZapateria_Shu
            // 
            this.timerZapateria_Shu.Enabled = true;
            this.timerZapateria_Shu.Tick += new System.EventHandler(this.timerZapateria_Shu_Tick);
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(167, 55);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(573, 418);
            this.contenedor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 473);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ñe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ñe.ResumeLayout(false);
            this.ñe.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ñe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.RichTextBox richtxbmenuprincipal;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.RichTextBox richtxbperfilusuario;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Timer timerZapateria_Shu;
        private System.Windows.Forms.Button btncerrarsesion;
        private System.Windows.Forms.Panel contenedor;
    }
}

