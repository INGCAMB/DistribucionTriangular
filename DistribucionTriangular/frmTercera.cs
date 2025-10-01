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
    public partial class frmTercera : Form
    {
        double[] NumerosAleatorios = new double[VariablesGlobales.NActivo];
        int[] S = new int[VariablesGlobales.NActivo];

        public frmTercera()
        {
            InitializeComponent();
            gBPrueba1.Visible = false;
            gBPrueba2.Visible = false;
            dataGVPrueba2.Visible = false;
            Mostrar();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            gBPrueba1.Visible = true;
            gBPrueba2.Visible = false;
            dataGVPrueba2.Visible = false;

            // Declaración de datos
            int N = lbxOpNumeros2.Items.Count;
            double X = 0, Li, Ls;
            string U;

            // Ciclo para sacar el promedio de los números pseudoaleatorios
            foreach (double item in lbxOpNumeros2.Items)
                X += item;
            X /= N;

            // Cálculo del límite inferior y el límite superior
            Li = 0.5 - 1.96 / Math.Sqrt(12 * (double)lbxOpNumeros2.Items.Count);
            Ls = 0.5 + 1.96 / Math.Sqrt(12 * (double)lbxOpNumeros2.Items.Count);

            // Determina si está dentro de los límites
            if (Li <= X && X <= Ls)
            {
                U = "Los números aleatorios son uniformes";
            }
            else
            {
                U = "Los números aleatorios son no uniformes";
            }

            //Probabilidad del 95%
            lblLi.Text = "Limite inferior: " + Math.Round(Li, 5);
            lblLs.Text = "Limite superior: " + Math.Round(Ls, 5);
            lblPn.Text = "Promedio de numeros: " + Math.Round(X, 5);
            lblResultadoPrueba1.Text = U;
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            gBPrueba1.Visible = false;
            gBPrueba2.Visible = true;
            dataGVPrueba2.Visible = true;
            dataGVPrueba2.Columns.Clear();
            dataGVPrueba2.Rows.Clear();

            int Co, n0 = 0, n1 = 0, n;
            double M, V, Z;
            string Uni;
            dataGVPrueba2.Columns.Add("posicion del numero", "Posicion del numero");
            dataGVPrueba2.Columns.Add("secuencia (0,1)", "Secuencia (0,1)");
            for (int i = 0; i < VariablesGlobales.NActivo; i++)
            {
                if (NumerosAleatorios[i] > 0.5)
                {
                    dataGVPrueba2.Rows.Add(i + 1, 1);
                    S[i] = 1;
                }
                else if (NumerosAleatorios[i] < 0.5)
                {
                    dataGVPrueba2.Rows.Add(i + 1, 0);
                    S[i] = 0;
                }
            }
            for(int j = 0; j < VariablesGlobales.NActivo; j++)
            {
                if (S[j] == 0)
                {
                    n0++;
                }
                else
                {
                    n1++;
                }
            }

            int C0 = 0, C1 = 0;
            
            bool Repetido = false, Extra = false;

            for (int i = 0; i < S.Count(); i++)
            {
                if (S[i] == 0)
                {
                    if (Repetido)
                    {
                        C0++;
                        if (!Extra)
                        {
                            C0++;
                            Extra = true;
                        }
                    }
                    else
                        Repetido = true;
                }
                else
                {
                    Repetido = false;
                    Extra = false;
                }
            }

            for (int i = 0; i < S.Count(); i++)
            {
                if (S[i] == 1)
                {
                    if (Repetido)
                    {
                        C1++;
                        if (!Extra)
                        {
                            C1++;
                            Extra = true;
                        }
                    }
                    else
                        Repetido = true;
                }
                else
                {
                    Repetido = false;
                    Extra = false;
                }
            }

            //Condicion
            Co = C0 < C1 ? C1 : C0;

            MessageBox.Show("C0 = " + C0 +
                "\nC1 = " + C1 +
                "\nCo = " + Co);

            n = n0 + n1;
            M = (2*n0*n1/n) + 0.5;
            V = 2*n0*n1 *((2*n0*n1)-n) / (Math.Pow(n, 2)*(n-1));
            Z = (Co - M) / V;

            //Probabilidad de 95%
            if (-1.96 <= Z  && Z <= 1.96)
            {
                Uni = "Los números aleatorios son uniformes";
            }
            else
            {
                Uni = "Los números aleatorios son no uniformes";
            }

            lblCo.Text = "Co: " + Co;
            lblN0.Text = "N0: " + n0;
            lblN1.Text = "N1: " + n1;
            lblN.Text = "N: " + n;
            lblM.Text = "M: " + Math.Round(M, 5);
            lblV.Text = "V: " + Math.Round(V, 5);
            lblZo.Text = "Zo: " + Math.Round(Z, 5);
            lblResultadoPrueba2.Text = Uni;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Mostrar()
        {
            lbxOpNumeros2.Items.Clear();
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
                lbxOpNumeros2.Items.Add(Math.Round(R, 5));
                NumerosAleatorios[i] = Math.Round(R, 5);
            }
        }
    }
}
