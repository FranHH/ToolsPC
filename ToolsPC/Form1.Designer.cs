
namespace ToolsPC
{
    partial class ToolsPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsPC));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbApagar = new System.Windows.Forms.CheckBox();
            this.cbReiniciar = new System.Windows.Forms.CheckBox();
            this.cbHibernar = new System.Windows.Forms.CheckBox();
            this.cbCerrarSesion = new System.Windows.Forms.CheckBox();
            this.dtHoraEjecucion = new System.Windows.Forms.DateTimePicker();
            this.pbEstado = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbCancelarApagado = new System.Windows.Forms.CheckBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbHoras = new System.Windows.Forms.Label();
            this.pCuentaAtras = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbSeg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pCuentaAtras.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(303, 134);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pCuentaAtras);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 168);
            this.panel1.TabIndex = 1;
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(50, 44);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(30, 13);
            this.lbMin.TabIndex = 10;
            this.lbMin.Text = "00 m";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciona la hora para ejecutar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cbCancelarApagado);
            this.panel2.Controls.Add(this.cbApagar);
            this.panel2.Controls.Add(this.cbReiniciar);
            this.panel2.Controls.Add(this.cbHibernar);
            this.panel2.Controls.Add(this.cbCerrarSesion);
            this.panel2.Location = new System.Drawing.Point(8, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 109);
            this.panel2.TabIndex = 9;
            // 
            // cbApagar
            // 
            this.cbApagar.AutoSize = true;
            this.cbApagar.Location = new System.Drawing.Point(13, 12);
            this.cbApagar.Name = "cbApagar";
            this.cbApagar.Size = new System.Drawing.Size(60, 17);
            this.cbApagar.TabIndex = 4;
            this.cbApagar.Text = "Apagar";
            this.cbApagar.UseVisualStyleBackColor = true;
            this.cbApagar.CheckedChanged += new System.EventHandler(this.cbApagar_CheckedChanged);
            // 
            // cbReiniciar
            // 
            this.cbReiniciar.AutoSize = true;
            this.cbReiniciar.Location = new System.Drawing.Point(13, 35);
            this.cbReiniciar.Name = "cbReiniciar";
            this.cbReiniciar.Size = new System.Drawing.Size(67, 17);
            this.cbReiniciar.TabIndex = 5;
            this.cbReiniciar.Text = "Reiniciar";
            this.cbReiniciar.UseVisualStyleBackColor = true;
            this.cbReiniciar.CheckedChanged += new System.EventHandler(this.cbReiniciar_CheckedChanged);
            // 
            // cbHibernar
            // 
            this.cbHibernar.AutoSize = true;
            this.cbHibernar.Location = new System.Drawing.Point(13, 81);
            this.cbHibernar.Name = "cbHibernar";
            this.cbHibernar.Size = new System.Drawing.Size(66, 17);
            this.cbHibernar.TabIndex = 7;
            this.cbHibernar.Text = "Hibernar";
            this.cbHibernar.UseVisualStyleBackColor = true;
            this.cbHibernar.CheckedChanged += new System.EventHandler(this.cbHibernar_CheckedChanged);
            // 
            // cbCerrarSesion
            // 
            this.cbCerrarSesion.AutoSize = true;
            this.cbCerrarSesion.Location = new System.Drawing.Point(13, 58);
            this.cbCerrarSesion.Name = "cbCerrarSesion";
            this.cbCerrarSesion.Size = new System.Drawing.Size(87, 17);
            this.cbCerrarSesion.TabIndex = 6;
            this.cbCerrarSesion.Text = "Cerrar sesión";
            this.cbCerrarSesion.UseVisualStyleBackColor = true;
            this.cbCerrarSesion.CheckedChanged += new System.EventHandler(this.cbCerrarSesion_CheckedChanged);
            // 
            // dtHoraEjecucion
            // 
            this.dtHoraEjecucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtHoraEjecucion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraEjecucion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtHoraEjecucion.Location = new System.Drawing.Point(308, 7);
            this.dtHoraEjecucion.Name = "dtHoraEjecucion";
            this.dtHoraEjecucion.ShowUpDown = true;
            this.dtHoraEjecucion.Size = new System.Drawing.Size(75, 20);
            this.dtHoraEjecucion.TabIndex = 8;
            this.dtHoraEjecucion.Value = new System.DateTime(2022, 7, 12, 0, 0, 0, 0);
            // 
            // pbEstado
            // 
            this.pbEstado.BackColor = System.Drawing.Color.SlateGray;
            this.pbEstado.Location = new System.Drawing.Point(2, 1);
            this.pbEstado.Name = "pbEstado";
            this.pbEstado.Size = new System.Drawing.Size(414, 10);
            this.pbEstado.TabIndex = 10;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // cbCancelarApagado
            // 
            this.cbCancelarApagado.AutoSize = true;
            this.cbCancelarApagado.Location = new System.Drawing.Point(141, 12);
            this.cbCancelarApagado.Name = "cbCancelarApagado";
            this.cbCancelarApagado.Size = new System.Drawing.Size(114, 17);
            this.cbCancelarApagado.TabIndex = 12;
            this.cbCancelarApagado.Text = "Cancelar Apagado";
            this.cbCancelarApagado.UseVisualStyleBackColor = true;
            this.cbCancelarApagado.CheckedChanged += new System.EventHandler(this.cbCancelarApagado_CheckedChanged);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(0, 25);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(125, 13);
            this.lbInfo.TabIndex = 13;
            this.lbInfo.Text = "El equipo se apagará en ";
            // 
            // lbHoras
            // 
            this.lbHoras.AutoSize = true;
            this.lbHoras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbHoras.Location = new System.Drawing.Point(20, 44);
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(28, 13);
            this.lbHoras.TabIndex = 14;
            this.lbHoras.Text = "00 h";
            // 
            // pCuentaAtras
            // 
            this.pCuentaAtras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pCuentaAtras.Controls.Add(this.lbSeg);
            this.pCuentaAtras.Controls.Add(this.lbInfo);
            this.pCuentaAtras.Controls.Add(this.lbHoras);
            this.pCuentaAtras.Controls.Add(this.lbMin);
            this.pCuentaAtras.Location = new System.Drawing.Point(278, 48);
            this.pCuentaAtras.Name = "pCuentaAtras";
            this.pCuentaAtras.Size = new System.Drawing.Size(127, 80);
            this.pCuentaAtras.TabIndex = 15;
            this.pCuentaAtras.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dtHoraEjecucion);
            this.panel4.Location = new System.Drawing.Point(8, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 38);
            this.panel4.TabIndex = 16;
            // 
            // lbSeg
            // 
            this.lbSeg.AutoSize = true;
            this.lbSeg.Location = new System.Drawing.Point(86, 44);
            this.lbSeg.Name = "lbSeg";
            this.lbSeg.Size = new System.Drawing.Size(27, 13);
            this.lbSeg.TabIndex = 15;
            this.lbSeg.Text = "00 s";
            // 
            // ToolsPC
            // 
            this.AccessibleDescription = "Herramientas para PC";
            this.AccessibleName = "ToolsPC";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(426, 181);
            this.Controls.Add(this.pbEstado);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolsPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolsPC";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pCuentaAtras.ResumeLayout(false);
            this.pCuentaAtras.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtHoraEjecucion;
        private System.Windows.Forms.CheckBox cbHibernar;
        private System.Windows.Forms.CheckBox cbCerrarSesion;
        private System.Windows.Forms.CheckBox cbReiniciar;
        private System.Windows.Forms.CheckBox cbApagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar pbEstado;
        private System.Windows.Forms.Label lbMin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbCancelarApagado;
        private System.Windows.Forms.Label lbHoras;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Panel pCuentaAtras;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbSeg;
    }
}

