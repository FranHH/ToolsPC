
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsPC));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbRuta = new System.Windows.Forms.TextBox();
            this.btnInstalar = new System.Windows.Forms.Button();
            this.btnDesinstalar = new System.Windows.Forms.Button();
            this.tbNameService = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlServicios = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pbEstado = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbCancelarApagado = new System.Windows.Forms.CheckBox();
            this.cbApagar = new System.Windows.Forms.CheckBox();
            this.cbReiniciar = new System.Windows.Forms.CheckBox();
            this.cbHibernar = new System.Windows.Forms.CheckBox();
            this.cbCerrarSesion = new System.Windows.Forms.CheckBox();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtHoraEjecucion = new System.Windows.Forms.DateTimePicker();
            this.pCuentaAtras = new System.Windows.Forms.Panel();
            this.lbSeg = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbHoras = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.btnDetener = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programarApagadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moverRatónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbApagar = new System.Windows.Forms.RadioButton();
            this.rbCancelarApagado = new System.Windows.Forms.RadioButton();
            this.pnlApagar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMover = new System.Windows.Forms.Panel();
            this.btnMoverRaton = new System.Windows.Forms.Button();
            this.pnlProgApagado = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlServicios.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTime.SuspendLayout();
            this.pCuentaAtras.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlApagar.SuspendLayout();
            this.pnlMover.SuspendLayout();
            this.pnlProgApagado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRuta
            // 
            this.tbRuta.Enabled = false;
            this.tbRuta.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRuta.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbRuta.Location = new System.Drawing.Point(3, 25);
            this.tbRuta.Name = "tbRuta";
            this.tbRuta.Size = new System.Drawing.Size(296, 20);
            this.tbRuta.TabIndex = 11;
            this.tbRuta.Text = "...";
            // 
            // btnInstalar
            // 
            this.btnInstalar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInstalar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstalar.Location = new System.Drawing.Point(309, 25);
            this.btnInstalar.Name = "btnInstalar";
            this.btnInstalar.Size = new System.Drawing.Size(86, 20);
            this.btnInstalar.TabIndex = 12;
            this.btnInstalar.Text = "Examinar";
            this.btnInstalar.UseVisualStyleBackColor = true;
            this.btnInstalar.Click += new System.EventHandler(this.btnInstalar_Click);
            // 
            // btnDesinstalar
            // 
            this.btnDesinstalar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesinstalar.Location = new System.Drawing.Point(284, 27);
            this.btnDesinstalar.Name = "btnDesinstalar";
            this.btnDesinstalar.Size = new System.Drawing.Size(109, 20);
            this.btnDesinstalar.TabIndex = 14;
            this.btnDesinstalar.Text = "Desinstalar servicio";
            this.btnDesinstalar.UseVisualStyleBackColor = true;
            this.btnDesinstalar.Click += new System.EventHandler(this.btnDesinstalar_Click);
            // 
            // tbNameService
            // 
            this.tbNameService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameService.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbNameService.Location = new System.Drawing.Point(3, 27);
            this.tbNameService.Name = "tbNameService";
            this.tbNameService.Size = new System.Drawing.Size(275, 20);
            this.tbNameService.TabIndex = 15;
            this.tbNameService.Text = "Nombre del servicio...";
            this.tbNameService.Click += new System.EventHandler(this.tbNameService_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Desinstalar Servicio";
            // 
            // pnlServicios
            // 
            this.pnlServicios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlServicios.Controls.Add(this.panel6);
            this.pnlServicios.Controls.Add(this.panel5);
            this.pnlServicios.Location = new System.Drawing.Point(0, 43);
            this.pnlServicios.Name = "pnlServicios";
            this.pnlServicios.Size = new System.Drawing.Size(412, 129);
            this.pnlServicios.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.tbNameService);
            this.panel6.Controls.Add(this.btnDesinstalar);
            this.panel6.Location = new System.Drawing.Point(3, 64);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(402, 56);
            this.panel6.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.tbRuta);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.btnInstalar);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 55);
            this.panel5.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Instalar Servicio";
            // 
            // pbEstado
            // 
            this.pbEstado.BackColor = System.Drawing.Color.SlateGray;
            this.pbEstado.Location = new System.Drawing.Point(0, 27);
            this.pbEstado.Name = "pbEstado";
            this.pbEstado.Size = new System.Drawing.Size(412, 15);
            this.pbEstado.TabIndex = 10;
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
            this.panel2.Location = new System.Drawing.Point(530, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 109);
            this.panel2.TabIndex = 9;
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
            // pnlTime
            // 
            this.pnlTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTime.Controls.Add(this.label1);
            this.pnlTime.Controls.Add(this.dtHoraEjecucion);
            this.pnlTime.Location = new System.Drawing.Point(235, 6);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(128, 52);
            this.pnlTime.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hora de apagado";
            // 
            // dtHoraEjecucion
            // 
            this.dtHoraEjecucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtHoraEjecucion.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHoraEjecucion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraEjecucion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtHoraEjecucion.Location = new System.Drawing.Point(20, 20);
            this.dtHoraEjecucion.Name = "dtHoraEjecucion";
            this.dtHoraEjecucion.ShowUpDown = true;
            this.dtHoraEjecucion.Size = new System.Drawing.Size(86, 20);
            this.dtHoraEjecucion.TabIndex = 8;
            this.dtHoraEjecucion.Value = new System.DateTime(2022, 7, 12, 0, 0, 0, 0);
            this.dtHoraEjecucion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtHoraEjecucion_KeyPress);
            // 
            // pCuentaAtras
            // 
            this.pCuentaAtras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pCuentaAtras.Controls.Add(this.lbSeg);
            this.pCuentaAtras.Controls.Add(this.lbInfo);
            this.pCuentaAtras.Controls.Add(this.lbHoras);
            this.pCuentaAtras.Controls.Add(this.lbMin);
            this.pCuentaAtras.Location = new System.Drawing.Point(3, 66);
            this.pCuentaAtras.Name = "pCuentaAtras";
            this.pCuentaAtras.Size = new System.Drawing.Size(207, 80);
            this.pCuentaAtras.TabIndex = 15;
            this.pCuentaAtras.Visible = false;
            // 
            // lbSeg
            // 
            this.lbSeg.AutoSize = true;
            this.lbSeg.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeg.Location = new System.Drawing.Point(125, 35);
            this.lbSeg.Name = "lbSeg";
            this.lbSeg.Size = new System.Drawing.Size(27, 13);
            this.lbSeg.TabIndex = 15;
            this.lbSeg.Text = "00 s";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(36, 11);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(132, 13);
            this.lbInfo.TabIndex = 13;
            this.lbInfo.Text = "El equipo se apagará en ";
            // 
            // lbHoras
            // 
            this.lbHoras.AutoSize = true;
            this.lbHoras.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbHoras.Location = new System.Drawing.Point(59, 35);
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(29, 13);
            this.lbHoras.TabIndex = 14;
            this.lbHoras.Text = "00 h";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(89, 35);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(32, 13);
            this.lbMin.TabIndex = 10;
            this.lbMin.Text = "00 m";
            // 
            // btnDetener
            // 
            this.btnDetener.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDetener.FlatAppearance.BorderSize = 4;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Location = new System.Drawing.Point(3, 42);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(90, 31);
            this.btnDetener.TabIndex = 14;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Aceptar.FlatAppearance.BorderSize = 2;
            this.Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Aceptar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.Location = new System.Drawing.Point(257, 93);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(86, 23);
            this.Aceptar.TabIndex = 0;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(74, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviciosToolStripMenuItem,
            this.programarApagadoToolStripMenuItem,
            this.moverRatónToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // programarApagadoToolStripMenuItem
            // 
            this.programarApagadoToolStripMenuItem.Name = "programarApagadoToolStripMenuItem";
            this.programarApagadoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.programarApagadoToolStripMenuItem.Text = "Programar Apagado";
            this.programarApagadoToolStripMenuItem.Click += new System.EventHandler(this.programarApagadoToolStripMenuItem_Click);
            // 
            // moverRatónToolStripMenuItem
            // 
            this.moverRatónToolStripMenuItem.Name = "moverRatónToolStripMenuItem";
            this.moverRatónToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.moverRatónToolStripMenuItem.Text = "Mover ratón";
            this.moverRatónToolStripMenuItem.Click += new System.EventHandler(this.moverRatónToolStripMenuItem_Click);
            // 
            // rbApagar
            // 
            this.rbApagar.AutoSize = true;
            this.rbApagar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbApagar.Location = new System.Drawing.Point(3, 24);
            this.rbApagar.Name = "rbApagar";
            this.rbApagar.Size = new System.Drawing.Size(62, 17);
            this.rbApagar.TabIndex = 22;
            this.rbApagar.TabStop = true;
            this.rbApagar.Text = "Apagar";
            this.rbApagar.UseVisualStyleBackColor = true;
            this.rbApagar.CheckedChanged += new System.EventHandler(this.rdBtnPrueba_CheckedChanged);
            // 
            // rbCancelarApagado
            // 
            this.rbCancelarApagado.AutoSize = true;
            this.rbCancelarApagado.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCancelarApagado.Location = new System.Drawing.Point(68, 24);
            this.rbCancelarApagado.Name = "rbCancelarApagado";
            this.rbCancelarApagado.Size = new System.Drawing.Size(119, 17);
            this.rbCancelarApagado.TabIndex = 23;
            this.rbCancelarApagado.TabStop = true;
            this.rbCancelarApagado.Text = "Cancelar Apagado";
            this.rbCancelarApagado.UseVisualStyleBackColor = true;
            // 
            // pnlApagar
            // 
            this.pnlApagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlApagar.Controls.Add(this.label2);
            this.pnlApagar.Controls.Add(this.rbCancelarApagado);
            this.pnlApagar.Controls.Add(this.rbApagar);
            this.pnlApagar.Location = new System.Drawing.Point(3, 6);
            this.pnlApagar.Name = "pnlApagar";
            this.pnlApagar.Size = new System.Drawing.Size(207, 52);
            this.pnlApagar.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Programar apagado";
            // 
            // pnlMover
            // 
            this.pnlMover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMover.Controls.Add(this.btnMoverRaton);
            this.pnlMover.Controls.Add(this.btnDetener);
            this.pnlMover.Location = new System.Drawing.Point(415, 359);
            this.pnlMover.Name = "pnlMover";
            this.pnlMover.Size = new System.Drawing.Size(100, 82);
            this.pnlMover.TabIndex = 33;
            // 
            // btnMoverRaton
            // 
            this.btnMoverRaton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnMoverRaton.FlatAppearance.BorderSize = 6;
            this.btnMoverRaton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMoverRaton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverRaton.Location = new System.Drawing.Point(3, 5);
            this.btnMoverRaton.Name = "btnMoverRaton";
            this.btnMoverRaton.Size = new System.Drawing.Size(90, 31);
            this.btnMoverRaton.TabIndex = 15;
            this.btnMoverRaton.Text = "Mover ratón";
            this.btnMoverRaton.UseVisualStyleBackColor = true;
            this.btnMoverRaton.Click += new System.EventHandler(this.btnMoverRaton_Click);
            // 
            // pnlProgApagado
            // 
            this.pnlProgApagado.BackColor = System.Drawing.Color.Transparent;
            this.pnlProgApagado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProgApagado.Controls.Add(this.Aceptar);
            this.pnlProgApagado.Controls.Add(this.pnlApagar);
            this.pnlProgApagado.Controls.Add(this.pnlTime);
            this.pnlProgApagado.Controls.Add(this.pCuentaAtras);
            this.pnlProgApagado.Location = new System.Drawing.Point(465, 186);
            this.pnlProgApagado.Name = "pnlProgApagado";
            this.pnlProgApagado.Size = new System.Drawing.Size(372, 153);
            this.pnlProgApagado.TabIndex = 36;
            // 
            // ToolsPC
            // 
            this.AccessibleDescription = "Herramientas para PC";
            this.AccessibleName = "ToolsPC";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(74, 25);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlProgApagado);
            this.Controls.Add(this.pnlMover);
            this.Controls.Add(this.pnlServicios);
            this.Controls.Add(this.pbEstado);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ToolsPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolsPC";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToolsPC_KeyPress);
            this.pnlServicios.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.pCuentaAtras.ResumeLayout(false);
            this.pCuentaAtras.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlApagar.ResumeLayout(false);
            this.pnlApagar.PerformLayout();
            this.pnlMover.ResumeLayout(false);
            this.pnlProgApagado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbRuta;
        private System.Windows.Forms.Button btnInstalar;
        private System.Windows.Forms.Button btnDesinstalar;
        private System.Windows.Forms.TextBox tbNameService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlServicios;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbEstado;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtHoraEjecucion;
        private System.Windows.Forms.Panel pCuentaAtras;
        private System.Windows.Forms.Label lbSeg;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbHoras;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.CheckBox cbCancelarApagado;
        private System.Windows.Forms.CheckBox cbApagar;
        private System.Windows.Forms.CheckBox cbReiniciar;
        private System.Windows.Forms.CheckBox cbHibernar;
        private System.Windows.Forms.CheckBox cbCerrarSesion;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbApagar;
        private System.Windows.Forms.RadioButton rbCancelarApagado;
        private System.Windows.Forms.Panel pnlApagar;
        private System.Windows.Forms.Panel pnlMover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlProgApagado;
        private System.Windows.Forms.Button btnMoverRaton;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programarApagadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moverRatónToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

