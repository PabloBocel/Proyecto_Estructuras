namespace Proyecto_Estructuras
{
    partial class TbValorNuevo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TbValorNuevo));
            this.label1 = new System.Windows.Forms.Label();
            this.TBNuevaContraMaestra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBBuscarId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBNuevoValor = new System.Windows.Forms.TextBox();
            this.BTGuardarMaestra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBGuardarCampoNuevo = new System.Windows.Forms.Button();
            this.BTRegresar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TBValorViejo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBBuscarArchivo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BTBuscarArchivo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TBEscribirIdBuscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(252, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "EDICIÓN DE ARCHIVOS";
            this.label1.UseWaitCursor = true;
            // 
            // TBNuevaContraMaestra
            // 
            this.TBNuevaContraMaestra.Location = new System.Drawing.Point(185, 146);
            this.TBNuevaContraMaestra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBNuevaContraMaestra.Name = "TBNuevaContraMaestra";
            this.TBNuevaContraMaestra.Size = new System.Drawing.Size(352, 22);
            this.TBNuevaContraMaestra.TabIndex = 2;
            this.TBNuevaContraMaestra.TextChanged += new System.EventHandler(this.TBNuevaContraMaestra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(181, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Colocar Nueva contraseña Maestra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escriba id :";
            // 
            // TBBuscarId
            // 
            this.TBBuscarId.Location = new System.Drawing.Point(8, 268);
            this.TBBuscarId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBBuscarId.Name = "TBBuscarId";
            this.TBBuscarId.Size = new System.Drawing.Size(167, 22);
            this.TBBuscarId.TabIndex = 4;
            this.TBBuscarId.TextChanged += new System.EventHandler(this.TBBuscarId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(253, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor nuevo:";
            // 
            // TBNuevoValor
            // 
            this.TBNuevoValor.Location = new System.Drawing.Point(259, 318);
            this.TBNuevoValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBNuevoValor.Name = "TBNuevoValor";
            this.TBNuevoValor.Size = new System.Drawing.Size(264, 22);
            this.TBNuevoValor.TabIndex = 6;
            this.TBNuevoValor.TextChanged += new System.EventHandler(this.TBNuevoValor_TextChanged);
            // 
            // BTGuardarMaestra
            // 
            this.BTGuardarMaestra.BackColor = System.Drawing.Color.Transparent;
            this.BTGuardarMaestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTGuardarMaestra.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGuardarMaestra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTGuardarMaestra.Location = new System.Drawing.Point(635, 127);
            this.BTGuardarMaestra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTGuardarMaestra.Name = "BTGuardarMaestra";
            this.BTGuardarMaestra.Size = new System.Drawing.Size(212, 36);
            this.BTGuardarMaestra.TabIndex = 8;
            this.BTGuardarMaestra.Text = "Guardar";
            this.BTGuardarMaestra.UseVisualStyleBackColor = false;
            this.BTGuardarMaestra.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(-5, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1220, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(-5, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1170, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(-1, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1215, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // TBGuardarCampoNuevo
            // 
            this.TBGuardarCampoNuevo.BackColor = System.Drawing.Color.Transparent;
            this.TBGuardarCampoNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TBGuardarCampoNuevo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBGuardarCampoNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TBGuardarCampoNuevo.Location = new System.Drawing.Point(629, 261);
            this.TBGuardarCampoNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBGuardarCampoNuevo.Name = "TBGuardarCampoNuevo";
            this.TBGuardarCampoNuevo.Size = new System.Drawing.Size(212, 36);
            this.TBGuardarCampoNuevo.TabIndex = 12;
            this.TBGuardarCampoNuevo.Text = "Guardar";
            this.TBGuardarCampoNuevo.UseVisualStyleBackColor = false;
            this.TBGuardarCampoNuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTRegresar
            // 
            this.BTRegresar.BackColor = System.Drawing.Color.DarkRed;
            this.BTRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTRegresar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTRegresar.Location = new System.Drawing.Point(757, 489);
            this.BTRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTRegresar.Name = "BTRegresar";
            this.BTRegresar.Size = new System.Drawing.Size(124, 47);
            this.BTRegresar.TabIndex = 14;
            this.BTRegresar.Text = "Regresar";
            this.BTRegresar.UseVisualStyleBackColor = false;
            this.BTRegresar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(253, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 23);
            this.label8.TabIndex = 28;
            this.label8.Text = "valor campo a cambiar:";
            // 
            // TBValorViejo
            // 
            this.TBValorViejo.Location = new System.Drawing.Point(259, 240);
            this.TBValorViejo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBValorViejo.Name = "TBValorViejo";
            this.TBValorViejo.Size = new System.Drawing.Size(264, 22);
            this.TBValorViejo.TabIndex = 29;
            this.TBValorViejo.TextChanged += new System.EventHandler(this.TBValorViejo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(-41, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1215, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // TBBuscarArchivo
            // 
            this.TBBuscarArchivo.Location = new System.Drawing.Point(259, 415);
            this.TBBuscarArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBBuscarArchivo.Name = "TBBuscarArchivo";
            this.TBBuscarArchivo.Size = new System.Drawing.Size(264, 22);
            this.TBBuscarArchivo.TabIndex = 37;
            this.TBBuscarArchivo.TextChanged += new System.EventHandler(this.TBBuscarArchivo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(253, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "Campo de arhivo:";
            // 
            // BTBuscarArchivo
            // 
            this.BTBuscarArchivo.BackColor = System.Drawing.Color.Transparent;
            this.BTBuscarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBuscarArchivo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTBuscarArchivo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTBuscarArchivo.Location = new System.Drawing.Point(635, 404);
            this.BTBuscarArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTBuscarArchivo.Name = "BTBuscarArchivo";
            this.BTBuscarArchivo.Size = new System.Drawing.Size(212, 36);
            this.BTBuscarArchivo.TabIndex = 35;
            this.BTBuscarArchivo.Text = "Buscar";
            this.BTBuscarArchivo.UseVisualStyleBackColor = false;
            this.BTBuscarArchivo.Click += new System.EventHandler(this.BTBuscarArchivo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(3, 384);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 23);
            this.label12.TabIndex = 32;
            this.label12.Text = "Escriba id :";
            // 
            // TBEscribirIdBuscar
            // 
            this.TBEscribirIdBuscar.Location = new System.Drawing.Point(8, 415);
            this.TBEscribirIdBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBEscribirIdBuscar.Name = "TBEscribirIdBuscar";
            this.TBEscribirIdBuscar.Size = new System.Drawing.Size(167, 22);
            this.TBEscribirIdBuscar.TabIndex = 31;
            this.TBEscribirIdBuscar.TextChanged += new System.EventHandler(this.TBEscribirIdBuscar_TextChanged);
            // 
            // TbValorNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Estructuras.Properties.Resources.fondo_4;
            this.Controls.Add(this.TBBuscarArchivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BTBuscarArchivo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TBEscribirIdBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBValorViejo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTRegresar);
            this.Controls.Add(this.TBGuardarCampoNuevo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTGuardarMaestra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBNuevoValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBBuscarId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBNuevaContraMaestra);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TbValorNuevo";
            this.Size = new System.Drawing.Size(911, 544);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNuevaContraMaestra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBBuscarId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBNuevoValor;
        private System.Windows.Forms.Button BTGuardarMaestra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button TBGuardarCampoNuevo;
        private System.Windows.Forms.Button BTRegresar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBValorViejo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBBuscarArchivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BTBuscarArchivo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBEscribirIdBuscar;
    }
}
