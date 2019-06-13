using System;

namespace Examen_Parcial_3
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
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listJugadores = new System.Windows.Forms.ListBox();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.btnEliminarJugador = new System.Windows.Forms.Button();
            this.textNombreJugador = new System.Windows.Forms.TextBox();
            this.textEdadJugador = new System.Windows.Forms.TextBox();
            this.textNumeroJugador = new System.Windows.Forms.TextBox();
            this.textNacionalidadJugador = new System.Windows.Forms.TextBox();
            this.textPosicionJugador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listEquipos = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listLocales = new System.Windows.Forms.ListBox();
            this.listVisitantes = new System.Windows.Forms.ListBox();
            this.textGolesLocal = new System.Windows.Forms.TextBox();
            this.textGolesVisitante = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnEnfrentamiento = new System.Windows.Forms.Button();
            this.listJornadas = new System.Windows.Forms.ListBox();
            this.listEnfrentamientos = new System.Windows.Forms.ListBox();
            this.checkSejugo = new System.Windows.Forms.CheckBox();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddJornada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reiniciarToolStripMenuItem});
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciarToolStripMenuItem.Text = "Iniciar ";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(114, 169);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(129, 20);
            this.txtNombreEquipo.TabIndex = 0;
            this.txtNombreEquipo.TextChanged += new System.EventHandler(this.txtNombreEquipo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jugadores del equipo";
            // 
            // listJugadores
            // 
            this.listJugadores.FormattingEnabled = true;
            this.listJugadores.Location = new System.Drawing.Point(626, 51);
            this.listJugadores.Name = "listJugadores";
            this.listJugadores.Size = new System.Drawing.Size(133, 147);
            this.listJugadores.TabIndex = 4;
            this.listJugadores.SelectedIndexChanged += new System.EventHandler(this.listJugadores_SelectedIndexChanged);
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.Location = new System.Drawing.Point(249, 169);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(97, 26);
            this.btnAgregarEquipo.TabIndex = 5;
            this.btnAgregarEquipo.Text = "Agregar equipo";
            this.btnAgregarEquipo.UseVisualStyleBackColor = true;
            this.btnAgregarEquipo.Click += new System.EventHandler(this.btnAgregarEquipo_Click);
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Location = new System.Drawing.Point(410, 179);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(98, 29);
            this.btnAgregarJugador.TabIndex = 6;
            this.btnAgregarJugador.Text = "Agregar jugador";
            this.btnAgregarJugador.UseVisualStyleBackColor = true;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // btnEliminarJugador
            // 
            this.btnEliminarJugador.Location = new System.Drawing.Point(514, 179);
            this.btnEliminarJugador.Name = "btnEliminarJugador";
            this.btnEliminarJugador.Size = new System.Drawing.Size(98, 29);
            this.btnEliminarJugador.TabIndex = 7;
            this.btnEliminarJugador.Text = "Eliminar Jugador";
            this.btnEliminarJugador.UseVisualStyleBackColor = true;
            this.btnEliminarJugador.Click += new System.EventHandler(this.btnEliminarJugador_Click);
            // 
            // textNombreJugador
            // 
            this.textNombreJugador.Location = new System.Drawing.Point(483, 51);
            this.textNombreJugador.Name = "textNombreJugador";
            this.textNombreJugador.Size = new System.Drawing.Size(100, 20);
            this.textNombreJugador.TabIndex = 9;
            this.textNombreJugador.TextChanged += new System.EventHandler(this.textNombreJugador_TextChanged);
            // 
            // textEdadJugador
            // 
            this.textEdadJugador.Location = new System.Drawing.Point(483, 76);
            this.textEdadJugador.Name = "textEdadJugador";
            this.textEdadJugador.Size = new System.Drawing.Size(100, 20);
            this.textEdadJugador.TabIndex = 10;
            this.textEdadJugador.TextChanged += new System.EventHandler(this.textEdadJugador_TextChanged);
            // 
            // textNumeroJugador
            // 
            this.textNumeroJugador.Location = new System.Drawing.Point(483, 127);
            this.textNumeroJugador.Name = "textNumeroJugador";
            this.textNumeroJugador.Size = new System.Drawing.Size(100, 20);
            this.textNumeroJugador.TabIndex = 11;
            this.textNumeroJugador.TextChanged += new System.EventHandler(this.textNumeroJugador_TextChanged);
            // 
            // textNacionalidadJugador
            // 
            this.textNacionalidadJugador.Location = new System.Drawing.Point(483, 101);
            this.textNacionalidadJugador.Name = "textNacionalidadJugador";
            this.textNacionalidadJugador.Size = new System.Drawing.Size(100, 20);
            this.textNacionalidadJugador.TabIndex = 12;
            this.textNacionalidadJugador.TextChanged += new System.EventHandler(this.textNacionalidadJugador_TextChanged);
            // 
            // textPosicionJugador
            // 
            this.textPosicionJugador.Location = new System.Drawing.Point(483, 153);
            this.textPosicionJugador.Name = "textPosicionJugador";
            this.textPosicionJugador.Size = new System.Drawing.Size(100, 20);
            this.textPosicionJugador.TabIndex = 13;
            this.textPosicionJugador.TextChanged += new System.EventHandler(this.textPosicionJugador_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nacionalidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Numero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Posicion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Equipos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Datos del Jugador";
            // 
            // listEquipos
            // 
            this.listEquipos.FormattingEnabled = true;
            this.listEquipos.Location = new System.Drawing.Point(77, 29);
            this.listEquipos.Name = "listEquipos";
            this.listEquipos.Size = new System.Drawing.Size(120, 134);
            this.listEquipos.TabIndex = 21;
            this.listEquipos.SelectedIndexChanged += new System.EventHandler(this.listEquipos_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Jornadas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Enfrentamientos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Equipo Local";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(633, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Equipo Visitante";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // listLocales
            // 
            this.listLocales.FormattingEnabled = true;
            this.listLocales.Location = new System.Drawing.Point(388, 241);
            this.listLocales.Name = "listLocales";
            this.listLocales.Size = new System.Drawing.Size(120, 95);
            this.listLocales.TabIndex = 26;
            this.listLocales.SelectedIndexChanged += new System.EventHandler(this.listLocales_SelectedIndexChanged);
            // 
            // listVisitantes
            // 
            this.listVisitantes.FormattingEnabled = true;
            this.listVisitantes.Location = new System.Drawing.Point(626, 241);
            this.listVisitantes.Name = "listVisitantes";
            this.listVisitantes.Size = new System.Drawing.Size(120, 95);
            this.listVisitantes.TabIndex = 27;
            this.listVisitantes.SelectedIndexChanged += new System.EventHandler(this.listVisitantes_SelectedIndexChanged);
            // 
            // textGolesLocal
            // 
            this.textGolesLocal.Location = new System.Drawing.Point(388, 369);
            this.textGolesLocal.Name = "textGolesLocal";
            this.textGolesLocal.Size = new System.Drawing.Size(100, 20);
            this.textGolesLocal.TabIndex = 28;
            this.textGolesLocal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textGolesVisitante
            // 
            this.textGolesVisitante.Location = new System.Drawing.Point(636, 369);
            this.textGolesVisitante.Name = "textGolesVisitante";
            this.textGolesVisitante.Size = new System.Drawing.Size(100, 20);
            this.textGolesVisitante.TabIndex = 29;
            this.textGolesVisitante.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 376);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Goles Local:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(546, 372);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Goles Visitante:";
            // 
            // btnEnfrentamiento
            // 
            this.btnEnfrentamiento.Location = new System.Drawing.Point(483, 415);
            this.btnEnfrentamiento.Name = "btnEnfrentamiento";
            this.btnEnfrentamiento.Size = new System.Drawing.Size(143, 23);
            this.btnEnfrentamiento.TabIndex = 32;
            this.btnEnfrentamiento.Text = "Guardar enfrentamiento";
            this.btnEnfrentamiento.UseVisualStyleBackColor = true;
            this.btnEnfrentamiento.Click += new System.EventHandler(this.button1_Click);
            // 
            // listJornadas
            // 
            this.listJornadas.FormattingEnabled = true;
            this.listJornadas.Location = new System.Drawing.Point(12, 273);
            this.listJornadas.Name = "listJornadas";
            this.listJornadas.Size = new System.Drawing.Size(115, 147);
            this.listJornadas.TabIndex = 33;
            this.listJornadas.SelectedIndexChanged += new System.EventHandler(this.listJornadas_SelectedIndexChanged);
            // 
            // listEnfrentamientos
            // 
            this.listEnfrentamientos.FormattingEnabled = true;
            this.listEnfrentamientos.Location = new System.Drawing.Point(147, 273);
            this.listEnfrentamientos.Name = "listEnfrentamientos";
            this.listEnfrentamientos.Size = new System.Drawing.Size(127, 147);
            this.listEnfrentamientos.TabIndex = 34;
            this.listEnfrentamientos.SelectedIndexChanged += new System.EventHandler(this.listEnfrentamientos_SelectedIndexChanged);
            // 
            // checkSejugo
            // 
            this.checkSejugo.AutoSize = true;
            this.checkSejugo.Location = new System.Drawing.Point(388, 346);
            this.checkSejugo.Name = "checkSejugo";
            this.checkSejugo.Size = new System.Drawing.Size(65, 17);
            this.checkSejugo.TabIndex = 35;
            this.checkSejugo.Text = " Se jugo";
            this.checkSejugo.UseVisualStyleBackColor = true;
            this.checkSejugo.CheckedChanged += new System.EventHandler(this.checkSejugo_CheckedChanged);
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(232, 76);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(0, 13);
            this.lblSeleccionado.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(248, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "label16";
            // 
            // btnAddJornada
            // 
            this.btnAddJornada.Location = new System.Drawing.Point(66, 218);
            this.btnAddJornada.Name = "btnAddJornada";
            this.btnAddJornada.Size = new System.Drawing.Size(90, 23);
            this.btnAddJornada.TabIndex = 40;
            this.btnAddJornada.Text = "Añadir Jornada";
            this.btnAddJornada.UseVisualStyleBackColor = true;
            this.btnAddJornada.Click += new System.EventHandler(this.btnAddJornada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddJornada);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.checkSejugo);
            this.Controls.Add(this.listEnfrentamientos);
            this.Controls.Add(this.listJornadas);
            this.Controls.Add(this.btnEnfrentamiento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textGolesVisitante);
            this.Controls.Add(this.textGolesLocal);
            this.Controls.Add(this.listVisitantes);
            this.Controls.Add(this.listLocales);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listEquipos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPosicionJugador);
            this.Controls.Add(this.textNacionalidadJugador);
            this.Controls.Add(this.textNumeroJugador);
            this.Controls.Add(this.textEdadJugador);
            this.Controls.Add(this.textNombreJugador);
            this.Controls.Add(this.btnEliminarJugador);
            this.Controls.Add(this.btnAgregarJugador);
            this.Controls.Add(this.btnAgregarEquipo);
            this.Controls.Add(this.listJugadores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreEquipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listJugadores;
        private System.Windows.Forms.Button btnAgregarEquipo;
        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.Button btnEliminarJugador;
        private System.Windows.Forms.TextBox textNombreJugador;
        private System.Windows.Forms.TextBox textEdadJugador;
        private System.Windows.Forms.TextBox textNumeroJugador;
        private System.Windows.Forms.TextBox textNacionalidadJugador;
        private System.Windows.Forms.TextBox textPosicionJugador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listEquipos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listLocales;
        private System.Windows.Forms.ListBox listVisitantes;
        private System.Windows.Forms.TextBox textGolesLocal;
        private System.Windows.Forms.TextBox textGolesVisitante;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnEnfrentamiento;
        private System.Windows.Forms.ListBox listJornadas;
        private System.Windows.Forms.ListBox listEnfrentamientos;
        private System.Windows.Forms.CheckBox checkSejugo;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAddJornada;
    }
}

