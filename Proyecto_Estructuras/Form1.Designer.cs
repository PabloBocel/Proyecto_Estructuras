namespace Proyecto_Estructuras
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBContraMaestra = new System.Windows.Forms.TextBox();
            this.BTIngresar = new System.Windows.Forms.Button();
            this.BTCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(67, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa Contraseña:";
            // 
            // TBContraMaestra
            // 
            this.TBContraMaestra.BackColor = System.Drawing.Color.Silver;
            this.TBContraMaestra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBContraMaestra.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContraMaestra.Location = new System.Drawing.Point(70, 210);
            this.TBContraMaestra.Name = "TBContraMaestra";
            this.TBContraMaestra.Size = new System.Drawing.Size(257, 19);
            this.TBContraMaestra.TabIndex = 1;
            this.TBContraMaestra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BTIngresar
            // 
            this.BTIngresar.BackColor = System.Drawing.Color.SaddleBrown;
            this.BTIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTIngresar.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTIngresar.Location = new System.Drawing.Point(70, 254);
            this.BTIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTIngresar.Name = "BTIngresar";
            this.BTIngresar.Size = new System.Drawing.Size(257, 33);
            this.BTIngresar.TabIndex = 2;
            this.BTIngresar.Text = "Ingresar";
            this.BTIngresar.UseVisualStyleBackColor = false;
            this.BTIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTCerrar
            // 
            this.BTCerrar.BackColor = System.Drawing.Color.DarkRed;
            this.BTCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTCerrar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTCerrar.Location = new System.Drawing.Point(343, 10);
            this.BTCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTCerrar.Name = "BTCerrar";
            this.BTCerrar.Size = new System.Drawing.Size(34, 28);
            this.BTCerrar.TabIndex = 3;
            this.BTCerrar.Text = "X";
            this.BTCerrar.UseVisualStyleBackColor = false;
            this.BTCerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Proyecto_Estructuras.Properties.Resources.Fondo_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(386, 418);
            this.Controls.Add(this.BTCerrar);
            this.Controls.Add(this.BTIngresar);
            this.Controls.Add(this.TBContraMaestra);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBContraMaestra;
        private System.Windows.Forms.Button BTIngresar;
        private System.Windows.Forms.Button BTCerrar;
    }
}

