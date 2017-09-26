namespace PowerPointConverter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_Convertir = new System.Windows.Forms.Button();
            this.Button_Seleccion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_Convertir);
            this.groupBox1.Controls.Add(this.Button_Seleccion);
            this.groupBox1.Location = new System.Drawing.Point(2, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 198);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Button_Convertir
            // 
            this.Button_Convertir.Location = new System.Drawing.Point(10, 48);
            this.Button_Convertir.Name = "Button_Convertir";
            this.Button_Convertir.Size = new System.Drawing.Size(251, 23);
            this.Button_Convertir.TabIndex = 1;
            this.Button_Convertir.Text = "Convertir";
            this.Button_Convertir.UseVisualStyleBackColor = true;
            this.Button_Convertir.Click += new System.EventHandler(this.ButtonConvertirClick);
            // 
            // Button_Seleccion
            // 
            this.Button_Seleccion.Location = new System.Drawing.Point(10, 19);
            this.Button_Seleccion.Name = "Button_Seleccion";
            this.Button_Seleccion.Size = new System.Drawing.Size(251, 23);
            this.Button_Seleccion.TabIndex = 0;
            this.Button_Seleccion.Text = "Seleccionar Folder";
            this.Button_Seleccion.UseVisualStyleBackColor = true;
            this.Button_Seleccion.Click += new System.EventHandler(this.ButtonSeleccionClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Power Point Converter";
            this.Load += new System.EventHandler(this.Form1Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_Convertir;
        private System.Windows.Forms.Button Button_Seleccion;
    }
}

