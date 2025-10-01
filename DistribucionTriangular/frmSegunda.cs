using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistribucionTriangular
{
    public partial class frmSegunda : Form
    {
        public frmSegunda()
        {
            InitializeComponent();
            lbxOpNumeros.Items.Clear();
            int XN, C, A, M, N;
            double R;
            XN = VariablesGlobales.XNActivo;
            C = VariablesGlobales.CActivo;
            A = VariablesGlobales.AActivo;
            M = VariablesGlobales.MActivo;
            N = VariablesGlobales.NActivo;
            for (int i = 0; i < N; i++)
            {
                XN = (XN * A + C) % M;
                R = (double)XN / M;
                //lbx.Items.Add(R);
                lbxOpNumeros.Items.Add(Math.Round(R, 5));
            }
        }

        private void frmSegunda_Load(object sender, EventArgs e)
        {
            //Limpia la caja y pone el cursor en la caja
            txtVmi.Clear();
            txtVp.Clear();
            txtVma.Clear();
            txtNp.Clear();
            txtVmi.Focus();
            txtVmi.Text = "30";
            txtVp.Text = "34";
            txtVma.Text = "38";
            txtNp.Text = "0";
        }

        private void lbxOpNumeros_Click(object sender, EventArgs e)
        {
            txtNp.Text = lbxOpNumeros.SelectedItem.ToString();
        }
    }
}
