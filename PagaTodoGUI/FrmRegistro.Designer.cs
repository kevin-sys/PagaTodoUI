namespace PagaTodoGUI
{
    partial class FrmRegistro
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
            this.label1 = new System.Windows.Forms.Label();
            this.CmbEntidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNumeroRecibo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtaFechaPago = new System.Windows.Forms.DateTimePicker();
            this.TxtValorPagado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnAbrirConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entidad de servicios publicos";
            // 
            // CmbEntidad
            // 
            this.CmbEntidad.FormattingEnabled = true;
            this.CmbEntidad.Items.AddRange(new object[] {
            "Electricaribe",
            "Gascaribe",
            "Emdupar"});
            this.CmbEntidad.Location = new System.Drawing.Point(250, 65);
            this.CmbEntidad.Name = "CmbEntidad";
            this.CmbEntidad.Size = new System.Drawing.Size(121, 21);
            this.CmbEntidad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de recibo de pago";
            // 
            // TxtNumeroRecibo
            // 
            this.TxtNumeroRecibo.Location = new System.Drawing.Point(254, 123);
            this.TxtNumeroRecibo.Name = "TxtNumeroRecibo";
            this.TxtNumeroRecibo.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroRecibo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de pago";
            // 
            // DtaFechaPago
            // 
            this.DtaFechaPago.Location = new System.Drawing.Point(254, 172);
            this.DtaFechaPago.Name = "DtaFechaPago";
            this.DtaFechaPago.Size = new System.Drawing.Size(200, 20);
            this.DtaFechaPago.TabIndex = 5;
            // 
            // TxtValorPagado
            // 
            this.TxtValorPagado.Location = new System.Drawing.Point(254, 221);
            this.TxtValorPagado.Name = "TxtValorPagado";
            this.TxtValorPagado.Size = new System.Drawing.Size(100, 20);
            this.TxtValorPagado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor pagado";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(234, 291);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnAbrirConsultar
            // 
            this.BtnAbrirConsultar.Location = new System.Drawing.Point(542, 399);
            this.BtnAbrirConsultar.Name = "BtnAbrirConsultar";
            this.BtnAbrirConsultar.Size = new System.Drawing.Size(234, 23);
            this.BtnAbrirConsultar.TabIndex = 9;
            this.BtnAbrirConsultar.Text = "Ir a consultar";
            this.BtnAbrirConsultar.UseVisualStyleBackColor = true;
            this.BtnAbrirConsultar.Click += new System.EventHandler(this.BtnAbrirConsultar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAbrirConsultar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.TxtValorPagado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtaFechaPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNumeroRecibo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbEntidad);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbEntidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumeroRecibo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtaFechaPago;
        private System.Windows.Forms.TextBox TxtValorPagado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnAbrirConsultar;
    }
}