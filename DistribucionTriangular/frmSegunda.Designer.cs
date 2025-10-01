namespace DistribucionTriangular
{
    partial class frmSegunda
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
            this.lblVmi = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.txtVp = new System.Windows.Forms.TextBox();
            this.lblVp = new System.Windows.Forms.Label();
            this.txtVmi = new System.Windows.Forms.TextBox();
            this.txtVma = new System.Windows.Forms.TextBox();
            this.lblVma = new System.Windows.Forms.Label();
            this.txtNp = new System.Windows.Forms.TextBox();
            this.lblNp = new System.Windows.Forms.Label();
            this.lbxOpNumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblVmi
            // 
            this.lblVmi.AutoSize = true;
            this.lblVmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVmi.Location = new System.Drawing.Point(129, 23);
            this.lblVmi.Name = "lblVmi";
            this.lblVmi.Size = new System.Drawing.Size(153, 24);
            this.lblVmi.TabIndex = 0;
            this.lblVmi.Text = "&Valor mínimo (a):";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancelar.Location = new System.Drawing.Point(273, 209);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(103, 35);
            this.cmdCancelar.TabIndex = 9;
            this.cmdCancelar.Text = "&Cancelar experimento";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdAceptar.Location = new System.Drawing.Point(93, 209);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(103, 35);
            this.cmdAceptar.TabIndex = 8;
            this.cmdAceptar.Text = "&Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            // 
            // txtVp
            // 
            this.txtVp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVp.Location = new System.Drawing.Point(310, 59);
            this.txtVp.Name = "txtVp";
            this.txtVp.Size = new System.Drawing.Size(115, 29);
            this.txtVp.TabIndex = 5;
            this.txtVp.Text = "34";
            // 
            // lblVp
            // 
            this.lblVp.AutoSize = true;
            this.lblVp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVp.Location = new System.Drawing.Point(109, 64);
            this.lblVp.Name = "lblVp";
            this.lblVp.Size = new System.Drawing.Size(173, 24);
            this.lblVp.TabIndex = 1;
            this.lblVp.Text = "&Valor promedio (b):";
            // 
            // txtVmi
            // 
            this.txtVmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVmi.Location = new System.Drawing.Point(310, 18);
            this.txtVmi.Name = "txtVmi";
            this.txtVmi.Size = new System.Drawing.Size(115, 29);
            this.txtVmi.TabIndex = 4;
            this.txtVmi.Text = "30";
            // 
            // txtVma
            // 
            this.txtVma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVma.Location = new System.Drawing.Point(310, 105);
            this.txtVma.Name = "txtVma";
            this.txtVma.Size = new System.Drawing.Size(115, 29);
            this.txtVma.TabIndex = 6;
            this.txtVma.Text = "38";
            // 
            // lblVma
            // 
            this.lblVma.AutoSize = true;
            this.lblVma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVma.Location = new System.Drawing.Point(124, 110);
            this.lblVma.Name = "lblVma";
            this.lblVma.Size = new System.Drawing.Size(158, 24);
            this.lblVma.TabIndex = 2;
            this.lblVma.Text = "&Valor máximo (c):";
            // 
            // txtNp
            // 
            this.txtNp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNp.Location = new System.Drawing.Point(310, 152);
            this.txtNp.Name = "txtNp";
            this.txtNp.Size = new System.Drawing.Size(115, 29);
            this.txtNp.TabIndex = 7;
            this.txtNp.Text = "0";
            // 
            // lblNp
            // 
            this.lblNp.AutoSize = true;
            this.lblNp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNp.Location = new System.Drawing.Point(28, 157);
            this.lblNp.Name = "lblNp";
            this.lblNp.Size = new System.Drawing.Size(254, 24);
            this.lblNp.TabIndex = 3;
            this.lblNp.Text = "&Número pseudoaleatorio (R):";
            // 
            // lbxOpNumeros
            // 
            this.lbxOpNumeros.FormattingEnabled = true;
            this.lbxOpNumeros.Location = new System.Drawing.Point(452, 18);
            this.lbxOpNumeros.Name = "lbxOpNumeros";
            this.lbxOpNumeros.Size = new System.Drawing.Size(149, 225);
            this.lbxOpNumeros.TabIndex = 10;
            this.lbxOpNumeros.Click += new System.EventHandler(this.lbxOpNumeros_Click);
            // 
            // frmSegunda
            // 
            this.AcceptButton = this.cmdAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancelar;
            this.ClientSize = new System.Drawing.Size(624, 249);
            this.ControlBox = false;
            this.Controls.Add(this.lbxOpNumeros);
            this.Controls.Add(this.txtNp);
            this.Controls.Add(this.lblNp);
            this.Controls.Add(this.txtVma);
            this.Controls.Add(this.lblVma);
            this.Controls.Add(this.txtVmi);
            this.Controls.Add(this.lblVmi);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.txtVp);
            this.Controls.Add(this.lblVp);
            this.Name = "frmSegunda";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.frmSegunda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVmi;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdAceptar;
        public System.Windows.Forms.TextBox txtVp;
        private System.Windows.Forms.Label lblVp;
        public System.Windows.Forms.TextBox txtVmi;
        public System.Windows.Forms.TextBox txtVma;
        private System.Windows.Forms.Label lblVma;
        public System.Windows.Forms.TextBox txtNp;
        private System.Windows.Forms.Label lblNp;
        private System.Windows.Forms.ListBox lbxOpNumeros;
    }
}