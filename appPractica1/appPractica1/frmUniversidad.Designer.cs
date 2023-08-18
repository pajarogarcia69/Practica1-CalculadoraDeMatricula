
namespace appPractica1
{
    partial class frmUniversidad
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
            this.cmbTipoEst = new System.Windows.Forms.ComboBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.gpbRpta = new System.Windows.Forms.GroupBox();
            this.txtVrPagar = new System.Windows.Forms.TextBox();
            this.txtVrCred = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDscto = new System.Windows.Forms.TextBox();
            this.txtNroCred = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMsj = new System.Windows.Forms.TextBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.gpbRpta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reglas de negocio ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbTipoEst
            // 
            this.cmbTipoEst.FormattingEnabled = true;
            this.cmbTipoEst.Location = new System.Drawing.Point(252, 192);
            this.cmbTipoEst.Name = "cmbTipoEst";
            this.cmbTipoEst.Size = new System.Drawing.Size(259, 21);
            this.cmbTipoEst.TabIndex = 1;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(252, 72);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(259, 20);
            this.txtCarnet.TabIndex = 2;
            this.txtCarnet.TextChanged += new System.EventHandler(this.txtCarnet_TextChanged);
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(252, 147);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(259, 20);
            this.txtPromedio.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(252, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de Estudiantes:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(44, 232);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(216, 29);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(288, 232);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(223, 29);
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "PROCESAR";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // gpbRpta
            // 
            this.gpbRpta.Controls.Add(this.txtVrPagar);
            this.gpbRpta.Controls.Add(this.txtVrCred);
            this.gpbRpta.Controls.Add(this.label9);
            this.gpbRpta.Controls.Add(this.txtDscto);
            this.gpbRpta.Controls.Add(this.txtNroCred);
            this.gpbRpta.Controls.Add(this.label8);
            this.gpbRpta.Controls.Add(this.label7);
            this.gpbRpta.Controls.Add(this.label6);
            this.gpbRpta.Location = new System.Drawing.Point(44, 267);
            this.gpbRpta.Name = "gpbRpta";
            this.gpbRpta.Size = new System.Drawing.Size(467, 167);
            this.gpbRpta.TabIndex = 8;
            this.gpbRpta.TabStop = false;
            // 
            // txtVrPagar
            // 
            this.txtVrPagar.Location = new System.Drawing.Point(190, 129);
            this.txtVrPagar.Name = "txtVrPagar";
            this.txtVrPagar.ReadOnly = true;
            this.txtVrPagar.Size = new System.Drawing.Size(137, 20);
            this.txtVrPagar.TabIndex = 18;
            // 
            // txtVrCred
            // 
            this.txtVrCred.Location = new System.Drawing.Point(190, 54);
            this.txtVrCred.Name = "txtVrCred";
            this.txtVrCred.ReadOnly = true;
            this.txtVrCred.Size = new System.Drawing.Size(137, 20);
            this.txtVrCred.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Valor a Pagar:";
            // 
            // txtDscto
            // 
            this.txtDscto.Location = new System.Drawing.Point(190, 88);
            this.txtDscto.Name = "txtDscto";
            this.txtDscto.ReadOnly = true;
            this.txtDscto.Size = new System.Drawing.Size(137, 20);
            this.txtDscto.TabIndex = 16;
            // 
            // txtNroCred
            // 
            this.txtNroCred.Location = new System.Drawing.Point(190, 19);
            this.txtNroCred.Name = "txtNroCred";
            this.txtNroCred.ReadOnly = true;
            this.txtNroCred.Size = new System.Drawing.Size(137, 20);
            this.txtNroCred.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Valor Descuento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor Credito:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nro. Creditos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Carné:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Promedio:";
            // 
            // txtMsj
            // 
            this.txtMsj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsj.Location = new System.Drawing.Point(44, 440);
            this.txtMsj.Multiline = true;
            this.txtMsj.Name = "txtMsj";
            this.txtMsj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsj.Size = new System.Drawing.Size(467, 40);
            this.txtMsj.TabIndex = 19;
            this.txtMsj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(118, 486);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(322, 38);
            this.btnTerminar.TabIndex = 20;
            this.btnTerminar.Text = "TERMINAR";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // frmUniversidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 536);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.txtMsj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpbRpta);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.cmbTipoEst);
            this.Controls.Add(this.label1);
            this.Name = "frmUniversidad";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmUniversidad_Load);
            this.gpbRpta.ResumeLayout(false);
            this.gpbRpta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoEst;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.GroupBox gpbRpta;
        private System.Windows.Forms.TextBox txtVrPagar;
        private System.Windows.Forms.TextBox txtVrCred;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDscto;
        private System.Windows.Forms.TextBox txtNroCred;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMsj;
        private System.Windows.Forms.Button btnTerminar;
    }
}

