namespace PagaTodoGUI
{
    partial class FrmFiltro
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CmbEntidad = new System.Windows.Forms.ComboBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // CmbEntidad
            // 
            this.CmbEntidad.FormattingEnabled = true;
            this.CmbEntidad.Items.AddRange(new object[] {
            "Electricaribe",
            "Gascaribe",
            "Emdupar"});
            this.CmbEntidad.Location = new System.Drawing.Point(374, 124);
            this.CmbEntidad.Name = "CmbEntidad";
            this.CmbEntidad.Size = new System.Drawing.Size(171, 21);
            this.CmbEntidad.TabIndex = 2;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(308, 192);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(124, 53);
            this.Buscar.TabIndex = 3;
            this.Buscar.Text = "BUSCAR";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // FrmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.CmbEntidad);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FrmFiltro";
            this.Text = "FrmFiltro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CmbEntidad;
        private System.Windows.Forms.Button Buscar;
    }
}