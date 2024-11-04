namespace Proyecto_Estructuras
{
    partial class Preguntas
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
            this.BTCancelar = new System.Windows.Forms.Button();
            this.BTAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBNombreMascota = new System.Windows.Forms.TextBox();
            this.TBColorFav = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNombrePapa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTCancelar
            // 
            this.BTCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.BTCancelar.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTCancelar.Location = new System.Drawing.Point(230, 372);
            this.BTCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(92, 35);
            this.BTCancelar.TabIndex = 0;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = false;
            this.BTCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTAgregar
            // 
            this.BTAgregar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BTAgregar.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTAgregar.Location = new System.Drawing.Point(27, 372);
            this.BTAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.Size = new System.Drawing.Size(92, 35);
            this.BTAgregar.TabIndex = 1;
            this.BTAgregar.Text = "Agregar";
            this.BTAgregar.UseVisualStyleBackColor = false;
            this.BTAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de tu primera mascota?";
            // 
            // TBNombreMascota
            // 
            this.TBNombreMascota.Location = new System.Drawing.Point(50, 106);
            this.TBNombreMascota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBNombreMascota.Name = "TBNombreMascota";
            this.TBNombreMascota.Size = new System.Drawing.Size(246, 20);
            this.TBNombreMascota.TabIndex = 3;
            this.TBNombreMascota.TextChanged += new System.EventHandler(this.TBNombreMascota_TextChanged);
            // 
            // TBColorFav
            // 
            this.TBColorFav.Location = new System.Drawing.Point(50, 311);
            this.TBColorFav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBColorFav.Name = "TBColorFav";
            this.TBColorFav.Size = new System.Drawing.Size(246, 20);
            this.TBColorFav.TabIndex = 5;
            this.TBColorFav.TextChanged += new System.EventHandler(this.TBColorFav_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Color Favorito?";
            // 
            // TBNombrePapa
            // 
            this.TBNombrePapa.Location = new System.Drawing.Point(50, 216);
            this.TBNombrePapa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBNombrePapa.Name = "TBNombrePapa";
            this.TBNombrePapa.Size = new System.Drawing.Size(246, 20);
            this.TBNombrePapa.TabIndex = 7;
            this.TBNombrePapa.TextChanged += new System.EventHandler(this.TBNombrePapa_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre de tu papá?";
            // 
            // Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TBNombrePapa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBColorFav);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBNombreMascota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTAgregar);
            this.Controls.Add(this.BTCancelar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Preguntas";
            this.Size = new System.Drawing.Size(352, 429);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.Button BTAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNombreMascota;
        private System.Windows.Forms.TextBox TBColorFav;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNombrePapa;
        private System.Windows.Forms.Label label3;
    }
}
