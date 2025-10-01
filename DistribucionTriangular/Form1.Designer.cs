namespace DistribucionTriangular
{
    partial class frmPrincipal
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
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblBaseTMCA = new System.Windows.Forms.Label();
            this.lblBaseTMBA = new System.Windows.Forms.Label();
            this.lblBaseTMCB = new System.Windows.Forms.Label();
            this.lblPTBba = new System.Windows.Forms.Label();
            this.pbFormulas = new System.Windows.Forms.PictureBox();
            this.pbGrafica = new System.Windows.Forms.PictureBox();
            this.lblPTBcb = new System.Windows.Forms.Label();
            this.txtBaseTMCA = new System.Windows.Forms.TextBox();
            this.txtBaseTMBA = new System.Windows.Forms.TextBox();
            this.txtBaseTMCB = new System.Windows.Forms.TextBox();
            this.txtPTBba = new System.Windows.Forms.TextBox();
            this.txtPTBcb = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnNumerosPseudo = new System.Windows.Forms.Button();
            this.txtXn = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.lblXn = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lbx = new System.Windows.Forms.ListBox();
            this.dataGVPruebas = new System.Windows.Forms.DataGridView();
            this.dataGVResultadosDistribucionTriangular = new System.Windows.Forms.DataGridView();
            this.btnUniformes = new System.Windows.Forms.Button();
            this.btnModificarPrueba = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.dataGVResultadosFinales = new System.Windows.Forms.DataGridView();
            this.btnPruebas = new System.Windows.Forms.Button();
            this.txtPruebas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPruebas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVResultadosDistribucionTriangular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVResultadosFinales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(12, 533);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(143, 38);
            this.btnIngreso.TabIndex = 3;
            this.btnIngreso.Text = "Ingresar datos";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 596);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(143, 38);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(195, 596);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblBaseTMCA
            // 
            this.lblBaseTMCA.AutoSize = true;
            this.lblBaseTMCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBaseTMCA.Location = new System.Drawing.Point(467, 307);
            this.lblBaseTMCA.Name = "lblBaseTMCA";
            this.lblBaseTMCA.Size = new System.Drawing.Size(223, 20);
            this.lblBaseTMCA.TabIndex = 7;
            this.lblBaseTMCA.Text = "Base del triángulo mayor (c-a):";
            // 
            // lblBaseTMBA
            // 
            this.lblBaseTMBA.AutoSize = true;
            this.lblBaseTMBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBaseTMBA.Location = new System.Drawing.Point(467, 363);
            this.lblBaseTMBA.Name = "lblBaseTMBA";
            this.lblBaseTMBA.Size = new System.Drawing.Size(274, 20);
            this.lblBaseTMBA.TabIndex = 8;
            this.lblBaseTMBA.Text = "Base del primer triángulo menor (b-a):";
            // 
            // lblBaseTMCB
            // 
            this.lblBaseTMCB.AutoSize = true;
            this.lblBaseTMCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBaseTMCB.Location = new System.Drawing.Point(891, 236);
            this.lblBaseTMCB.Name = "lblBaseTMCB";
            this.lblBaseTMCB.Size = new System.Drawing.Size(291, 20);
            this.lblBaseTMCB.TabIndex = 9;
            this.lblBaseTMCB.Text = "Base del segundo triángulo menor (c-b):";
            // 
            // lblPTBba
            // 
            this.lblPTBba.AutoSize = true;
            this.lblPTBba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPTBba.Location = new System.Drawing.Point(893, 282);
            this.lblPTBba.Name = "lblPTBba";
            this.lblPTBba.Size = new System.Drawing.Size(277, 20);
            this.lblPTBba.TabIndex = 10;
            this.lblPTBba.Text = "Proporción del triángulo de base (b-a):";
            // 
            // pbFormulas
            // 
            this.pbFormulas.BackgroundImage = global::DistribucionTriangular.Properties.Resources.FormulasTriangular;
            this.pbFormulas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFormulas.Location = new System.Drawing.Point(12, 266);
            this.pbFormulas.Name = "pbFormulas";
            this.pbFormulas.Size = new System.Drawing.Size(307, 129);
            this.pbFormulas.TabIndex = 1;
            this.pbFormulas.TabStop = false;
            // 
            // pbGrafica
            // 
            this.pbGrafica.BackgroundImage = global::DistribucionTriangular.Properties.Resources.Grafica_triangular;
            this.pbGrafica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGrafica.Location = new System.Drawing.Point(12, 12);
            this.pbGrafica.Name = "pbGrafica";
            this.pbGrafica.Size = new System.Drawing.Size(307, 240);
            this.pbGrafica.TabIndex = 0;
            this.pbGrafica.TabStop = false;
            // 
            // lblPTBcb
            // 
            this.lblPTBcb.AutoSize = true;
            this.lblPTBcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPTBcb.Location = new System.Drawing.Point(891, 335);
            this.lblPTBcb.Name = "lblPTBcb";
            this.lblPTBcb.Size = new System.Drawing.Size(276, 20);
            this.lblPTBcb.TabIndex = 58;
            this.lblPTBcb.Text = "Proporción del triángulo de base (c-b):";
            // 
            // txtBaseTMCA
            // 
            this.txtBaseTMCA.Location = new System.Drawing.Point(747, 309);
            this.txtBaseTMCA.Name = "txtBaseTMCA";
            this.txtBaseTMCA.ReadOnly = true;
            this.txtBaseTMCA.Size = new System.Drawing.Size(101, 20);
            this.txtBaseTMCA.TabIndex = 61;
            // 
            // txtBaseTMBA
            // 
            this.txtBaseTMBA.Location = new System.Drawing.Point(747, 365);
            this.txtBaseTMBA.Name = "txtBaseTMBA";
            this.txtBaseTMBA.ReadOnly = true;
            this.txtBaseTMBA.Size = new System.Drawing.Size(101, 20);
            this.txtBaseTMBA.TabIndex = 62;
            // 
            // txtBaseTMCB
            // 
            this.txtBaseTMCB.Location = new System.Drawing.Point(1188, 236);
            this.txtBaseTMCB.Name = "txtBaseTMCB";
            this.txtBaseTMCB.ReadOnly = true;
            this.txtBaseTMCB.Size = new System.Drawing.Size(101, 20);
            this.txtBaseTMCB.TabIndex = 63;
            // 
            // txtPTBba
            // 
            this.txtPTBba.Location = new System.Drawing.Point(1190, 287);
            this.txtPTBba.Name = "txtPTBba";
            this.txtPTBba.ReadOnly = true;
            this.txtPTBba.Size = new System.Drawing.Size(101, 20);
            this.txtPTBba.TabIndex = 64;
            // 
            // txtPTBcb
            // 
            this.txtPTBcb.Location = new System.Drawing.Point(1188, 335);
            this.txtPTBcb.Name = "txtPTBcb";
            this.txtPTBcb.ReadOnly = true;
            this.txtPTBcb.Size = new System.Drawing.Size(101, 20);
            this.txtPTBcb.TabIndex = 65;
            // 
            // lblNota
            // 
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNota.Location = new System.Drawing.Point(467, 236);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(381, 47);
            this.lblNota.TabIndex = 66;
            this.lblNota.Text = "\"Nota: cuando Rj = (b-a)/(c-a) se saca X1 y X2, si es menor X1, y si es mayor X2\"" +
    "";
            // 
            // btnNumerosPseudo
            // 
            this.btnNumerosPseudo.Location = new System.Drawing.Point(12, 410);
            this.btnNumerosPseudo.Name = "btnNumerosPseudo";
            this.btnNumerosPseudo.Size = new System.Drawing.Size(143, 38);
            this.btnNumerosPseudo.TabIndex = 67;
            this.btnNumerosPseudo.Text = "Generador de numeros pseudoaleatorios";
            this.btnNumerosPseudo.UseVisualStyleBackColor = true;
            this.btnNumerosPseudo.Click += new System.EventHandler(this.btnNumerosPseudo_Click);
            // 
            // txtXn
            // 
            this.txtXn.Location = new System.Drawing.Point(383, 22);
            this.txtXn.Name = "txtXn";
            this.txtXn.Size = new System.Drawing.Size(78, 20);
            this.txtXn.TabIndex = 68;
            this.txtXn.Text = "17";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(383, 62);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(78, 20);
            this.txtC.TabIndex = 69;
            this.txtC.Text = "221";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(383, 102);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(78, 20);
            this.txtA.TabIndex = 70;
            this.txtA.Text = "101";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(383, 143);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(78, 20);
            this.txtM.TabIndex = 71;
            this.txtM.Text = "17001";
            // 
            // lblXn
            // 
            this.lblXn.AutoSize = true;
            this.lblXn.Location = new System.Drawing.Point(343, 29);
            this.lblXn.Name = "lblXn";
            this.lblXn.Size = new System.Drawing.Size(20, 13);
            this.lblXn.TabIndex = 72;
            this.lblXn.Text = "Xo";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(343, 69);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(14, 13);
            this.lblC.TabIndex = 73;
            this.lblC.Text = "C";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(343, 109);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 74;
            this.lblA.Text = "A";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(343, 150);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(16, 13);
            this.lblM.TabIndex = 75;
            this.lblM.Text = "M";
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(329, 179);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(132, 459);
            this.lbx.TabIndex = 76;
            // 
            // dataGVPruebas
            // 
            this.dataGVPruebas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVPruebas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVPruebas.Location = new System.Drawing.Point(471, 12);
            this.dataGVPruebas.Name = "dataGVPruebas";
            this.dataGVPruebas.ReadOnly = true;
            this.dataGVPruebas.Size = new System.Drawing.Size(342, 211);
            this.dataGVPruebas.TabIndex = 77;
            // 
            // dataGVResultadosDistribucionTriangular
            // 
            this.dataGVResultadosDistribucionTriangular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVResultadosDistribucionTriangular.Location = new System.Drawing.Point(471, 410);
            this.dataGVResultadosDistribucionTriangular.Name = "dataGVResultadosDistribucionTriangular";
            this.dataGVResultadosDistribucionTriangular.ReadOnly = true;
            this.dataGVResultadosDistribucionTriangular.Size = new System.Drawing.Size(818, 228);
            this.dataGVResultadosDistribucionTriangular.TabIndex = 78;
            // 
            // btnUniformes
            // 
            this.btnUniformes.Location = new System.Drawing.Point(12, 472);
            this.btnUniformes.Name = "btnUniformes";
            this.btnUniformes.Size = new System.Drawing.Size(143, 38);
            this.btnUniformes.TabIndex = 80;
            this.btnUniformes.Text = "Pruebas distribuidos uniformemente o no";
            this.btnUniformes.UseVisualStyleBackColor = true;
            this.btnUniformes.Click += new System.EventHandler(this.btnUniformes_Click);
            // 
            // btnModificarPrueba
            // 
            this.btnModificarPrueba.Location = new System.Drawing.Point(966, 366);
            this.btnModificarPrueba.Name = "btnModificarPrueba";
            this.btnModificarPrueba.Size = new System.Drawing.Size(98, 38);
            this.btnModificarPrueba.TabIndex = 79;
            this.btnModificarPrueba.Text = "Modificar prueba";
            this.btnModificarPrueba.UseVisualStyleBackColor = true;
            this.btnModificarPrueba.Click += new System.EventHandler(this.btnModificarPrueba_Click);
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(199, 410);
            this.txtN.Multiline = true;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(120, 38);
            this.txtN.TabIndex = 81;
            this.txtN.Text = "200";
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.Location = new System.Drawing.Point(199, 461);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(120, 120);
            this.lblAdvertencia.TabIndex = 82;
            this.lblAdvertencia.Text = "Favor de ingresar la cantidad de numeros pseudoaleatorios que quiere desplegar.";
            this.lblAdvertencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGVResultadosFinales
            // 
            this.dataGVResultadosFinales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVResultadosFinales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVResultadosFinales.Location = new System.Drawing.Point(830, 12);
            this.dataGVResultadosFinales.Name = "dataGVResultadosFinales";
            this.dataGVResultadosFinales.ReadOnly = true;
            this.dataGVResultadosFinales.Size = new System.Drawing.Size(459, 211);
            this.dataGVResultadosFinales.TabIndex = 84;
            // 
            // btnPruebas
            // 
            this.btnPruebas.Location = new System.Drawing.Point(1091, 366);
            this.btnPruebas.Name = "btnPruebas";
            this.btnPruebas.Size = new System.Drawing.Size(102, 38);
            this.btnPruebas.TabIndex = 85;
            this.btnPruebas.Text = "Mostrar prueba";
            this.btnPruebas.UseVisualStyleBackColor = true;
            this.btnPruebas.Click += new System.EventHandler(this.btnPruebas_Click);
            // 
            // txtPruebas
            // 
            this.txtPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPruebas.Location = new System.Drawing.Point(1225, 366);
            this.txtPruebas.Multiline = true;
            this.txtPruebas.Name = "txtPruebas";
            this.txtPruebas.Size = new System.Drawing.Size(37, 38);
            this.txtPruebas.TabIndex = 86;
            this.txtPruebas.Text = "1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 646);
            this.Controls.Add(this.txtPruebas);
            this.Controls.Add(this.btnPruebas);
            this.Controls.Add(this.dataGVResultadosFinales);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnUniformes);
            this.Controls.Add(this.btnModificarPrueba);
            this.Controls.Add(this.dataGVResultadosDistribucionTriangular);
            this.Controls.Add(this.dataGVPruebas);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblXn);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtXn);
            this.Controls.Add(this.btnNumerosPseudo);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtPTBcb);
            this.Controls.Add(this.txtPTBba);
            this.Controls.Add(this.txtBaseTMCB);
            this.Controls.Add(this.txtBaseTMBA);
            this.Controls.Add(this.txtBaseTMCA);
            this.Controls.Add(this.lblPTBcb);
            this.Controls.Add(this.lblPTBba);
            this.Controls.Add(this.lblBaseTMCB);
            this.Controls.Add(this.lblBaseTMBA);
            this.Controls.Add(this.lblBaseTMCA);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.pbFormulas);
            this.Controls.Add(this.pbGrafica);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPrincipal";
            this.Text = "Problema de sistema de distribucion triangular";
            ((System.ComponentModel.ISupportInitialize)(this.pbFormulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPruebas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVResultadosDistribucionTriangular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVResultadosFinales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGrafica;
        private System.Windows.Forms.PictureBox pbFormulas;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblBaseTMCA;
        private System.Windows.Forms.Label lblBaseTMBA;
        private System.Windows.Forms.Label lblBaseTMCB;
        private System.Windows.Forms.Label lblPTBba;
        private System.Windows.Forms.Label lblPTBcb;
        private System.Windows.Forms.TextBox txtBaseTMCA;
        private System.Windows.Forms.TextBox txtBaseTMBA;
        private System.Windows.Forms.TextBox txtBaseTMCB;
        private System.Windows.Forms.TextBox txtPTBba;
        private System.Windows.Forms.TextBox txtPTBcb;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnNumerosPseudo;
        private System.Windows.Forms.TextBox txtXn;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label lblXn;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.DataGridView dataGVPruebas;
        private System.Windows.Forms.DataGridView dataGVResultadosDistribucionTriangular;
        private System.Windows.Forms.Button btnUniformes;
        private System.Windows.Forms.Button btnModificarPrueba;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.DataGridView dataGVResultadosFinales;
        private System.Windows.Forms.Button btnPruebas;
        private System.Windows.Forms.TextBox txtPruebas;
    }
}

