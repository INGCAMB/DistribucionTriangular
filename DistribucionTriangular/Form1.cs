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
    public partial class frmPrincipal : Form
    {
        //Variables y vectores
        int R;
        double[,] Matriz = new double[8, 6];
        double[] Btm = new double[8];
        double[] Bptm = new double[8];
        double[] Bstm = new double[8];
        double[] Ptbba = new double[8];
        double[] Ptbcb = new double[8];

        public frmPrincipal()
        {
            InitializeComponent();
            btnModificarPrueba.Enabled = false;
            btnPruebas.Enabled = false;
            Mostrar();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            //Desabilitar
            btnModificarPrueba.Enabled = true;
            btnPruebas.Enabled = true;
            btnIngreso.Enabled = false;

            VariablesGlobales.XNActivo = int.Parse(txtXn.Text);
            VariablesGlobales.CActivo = int.Parse(txtC.Text);
            VariablesGlobales.AActivo = int.Parse(txtA.Text);
            VariablesGlobales.MActivo = int.Parse(txtM.Text);
            VariablesGlobales.NActivo = int.Parse(txtN.Text);

            //Crea un objeto de la clase frmSegunda          
            frmSegunda FormaCaptura = new frmSegunda();

            //Ciclo For, para 5 experimentos
            for(R = 0; R < 8; R++)
            {
                FormaCaptura.txtVmi.Focus();

                //Condición
                if (FormaCaptura.ShowDialog() == DialogResult.OK)
                {
                    //Uso del try-catch para validar el formato
                    try
                    {
                        //Asignación de variable
                        //a
                        Matriz[R, 0] = System.Double.Parse(FormaCaptura.txtVmi.Text);
                        //b
                        Matriz[R, 1] = System.Double.Parse(FormaCaptura.txtVp.Text);
                        //c
                        Matriz[R, 2] = System.Double.Parse(FormaCaptura.txtVma.Text);
                        //R
                        Matriz[R, 3] = System.Double.Parse(FormaCaptura.txtNp.Text);

                        //Btm
                        Btm[R] = Matriz[R, 2] - Matriz[R, 0];
                        //Bptm
                        Bptm[R] = Matriz[R, 1] - Matriz[R, 0];
                        //Bstm
                        Bstm[R] = Matriz[R, 2] - Matriz[R, 1];
                        //Ptbba
                        Ptbba[R] = Bptm[R] / Btm[R];
                        //Ptbcb
                        Ptbcb[R] = Bstm[R] / Btm[R];

                        //Condicion para saber si R es = a (b-a)/(c-a) entonces se se hace para X1 y X2, si es R es < entonces solo habra X1 y X2 es 0 no hay numero ahi,
                        //y si R > entonces habra X2 y X1 es 0 no hay nada
                        if (Matriz[R, 3] == Ptbba[R])
                        {
                            //X1
                            Matriz[R, 4] = Matriz[R, 0] + Math.Sqrt(((Matriz[R, 1] - Matriz[R, 0]) * (Matriz[R, 2] - Matriz[R, 0]) * Matriz[R, 3]));
                            //X2
                            Matriz[R, 5] = Matriz[R, 2] - Math.Sqrt(((Matriz[R, 2] - Matriz[R, 1]) * (Matriz[R, 2] - Matriz[R, 0]) * (1 - Matriz[R, 3])));
                        }
                        if (Matriz[R, 3] < Ptbba[R])
                        {
                            //X1
                            Matriz[R, 4] = Matriz[R, 0] + Math.Sqrt(((Matriz[R, 1] - Matriz[R, 0]) * (Matriz[R, 2] - Matriz[R, 0]) * Matriz[R, 3]));
                            //X2
                            Matriz[R, 5] = 0;
                        }
                        if (Matriz[R, 3] > Ptbba[R])
                        {
                            //X1
                            Matriz[R, 4] = 0;
                            //X2
                            Matriz[R, 5] = Matriz[R, 2] - Math.Sqrt(((Matriz[R, 2] - Matriz[R, 1]) * (Matriz[R, 2] - Matriz[R, 0]) * (1 - Matriz[R, 3])));
                        }
                    }
                    catch (FormatException)
                    {
                        //Mensaje de caja
                        MessageBox.Show("Introduce valor correcto, experimento fallido", "Error");
                        FormaCaptura.txtVmi.Focus();
                    }
                }
                else
                {
                    Limpiar();
                }
                //Limpiamos la segunda forma
                FormaCaptura.txtVmi.Clear();
                FormaCaptura.txtVp.Clear();
                FormaCaptura.txtVma.Clear();
                FormaCaptura.txtNp.Clear();
                FormaCaptura.txtVmi.Focus();
            }

            dataGVResultadosDistribucionTriangular.Columns.Add("numero de prueba", "Numero de prueba");
            dataGVResultadosDistribucionTriangular.Columns.Add("a", "A");
            dataGVResultadosDistribucionTriangular.Columns.Add("b", "B");
            dataGVResultadosDistribucionTriangular.Columns.Add("c", "C");
            dataGVResultadosDistribucionTriangular.Columns.Add("ri", "Ri");
            dataGVResultadosDistribucionTriangular.Columns.Add("rj", "Rj");
            dataGVResultadosDistribucionTriangular.Columns.Add("x1", "X1");
            dataGVResultadosDistribucionTriangular.Columns.Add("x2", "X2");
            for(int i = 0; i < 8; i++)
            {
                dataGVResultadosDistribucionTriangular.Rows.Add(i+1, Matriz[i, 0], Matriz[i, 1], Matriz[i, 2], Matriz[i, 3], Ptbba[i], Matriz[i, 4], Matriz[i, 5]);
            }

            double numenterodecimal, numenterodecimal2;
            int numentero, numentero2;
            dataGVResultadosFinales.Columns.Add("tiempos calculados", "Tiempos calculados(Minutos)");
            dataGVResultadosFinales.Columns.Add("tiempos totales", "Tiempos totales(Minutos y segundos)");
            for (int j = 0; j < 8; j++)
            {
                if (Matriz[j, 4] != 0 && Matriz[j, 5] != 0)
                {
                    numenterodecimal = Matriz[j, 4];
                    numentero = (int)Math.Truncate(numenterodecimal);
                    numenterodecimal2 = Matriz[j, 5];
                    numentero2 = (int)Math.Truncate(numenterodecimal2);
                    dataGVResultadosFinales.Rows.Add(Matriz[j, 4] + " - " + Matriz[j, 5], (numentero + ":" + Math.Truncate((Math.Round(numenterodecimal - numentero, 5)) * 60)) + " - " + (numentero2 + ":" + Math.Truncate((Math.Round(numenterodecimal2 - numentero2, 5)) * 60)));
                }
                else if (Matriz[j, 4] != 0)
                {
                    numenterodecimal = Matriz[j, 4];
                    numentero = (int)Math.Truncate(numenterodecimal);
                    dataGVResultadosFinales.Rows.Add(Matriz[j, 4], (numentero + ":" + Math.Truncate((Math.Round(numenterodecimal - numentero, 5)) * 60)));
                }
                else if (Matriz[j, 5] != 0)
                {
                    numenterodecimal2 = Matriz[j, 5];
                    numentero2 = (int)Math.Truncate(numenterodecimal2);
                    dataGVResultadosFinales.Rows.Add(Matriz[j, 5], (numentero2 + ":" + Math.Truncate((Math.Round(numenterodecimal2 - numentero2, 5)) * 60)));
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnModificarPrueba.Enabled = false;
            btnPruebas.Enabled = false;
            btnIngreso.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNumerosPseudo_Click(object sender, EventArgs e)
        {
            lbx.Items.Clear();
            int XN, C, A, M, N;
            double R;
            XN = int.Parse(txtXn.Text);
            C = int.Parse(txtC.Text);
            A = int.Parse(txtA.Text);
            M = int.Parse(txtM.Text);
            N = int.Parse(txtN.Text);
            for (int i = 0; i < N; i++)
            {
                XN = (XN * A + C) % M;
                R = (double)XN / M;
                //lbx.Items.Add(R);
                lbx.Items.Add(Math.Round(R, 5));
            }
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            int Op;
            Op = int.Parse(txtPruebas.Text);
            if(Op >= 1 || Op <= 8)
            {
                PruebaImprimir(Op-1);
            }
            else
            {
                MessageBox.Show("Favor de poner una prueba existente entre el 1 y el 8");
            }
        }

        private void btnModificarPrueba_Click(object sender, EventArgs e)
        {
            VariablesGlobales.XNActivo = int.Parse(txtXn.Text);
            VariablesGlobales.CActivo = int.Parse(txtC.Text);
            VariablesGlobales.AActivo = int.Parse(txtA.Text);
            VariablesGlobales.MActivo = int.Parse(txtM.Text);
            VariablesGlobales.NActivo = int.Parse(txtN.Text);

            //Crea un objeto de la clase frmSegunda          
            frmSegunda FormaCaptura = new frmSegunda();

            int Op;
            Op = int.Parse(txtPruebas.Text);
            if (Op >= 1 || Op <= 8)
            {
                //Condición
                if (FormaCaptura.ShowDialog() == DialogResult.OK)
                {
                    //Uso del try-catch para validar el formato
                    try
                    {
                        //Asignación de variable
                        //a
                        Matriz[Op-1, 0] = System.Double.Parse(FormaCaptura.txtVmi.Text);
                        //b
                        Matriz[Op-1, 1] = System.Double.Parse(FormaCaptura.txtVp.Text);
                        //c
                        Matriz[Op-1, 2] = System.Double.Parse(FormaCaptura.txtVma.Text);
                        //R
                        Matriz[Op-1, 3] = System.Double.Parse(FormaCaptura.txtNp.Text);

                        //Btm
                        Btm[Op-1] = Matriz[Op-1, 2] - Matriz[Op-1, 0];
                        //Bptm
                        Bptm[Op-1] = Matriz[Op-1, 1] - Matriz[Op-1, 0];
                        //Bstm
                        Bstm[Op-1] = Matriz[Op-1, 2] - Matriz[Op-1, 1];
                        //Ptbba
                        Ptbba[Op-1] = Bptm[Op-1] / Btm[Op-1];
                        //Ptbcb
                        Ptbcb[Op-1] = Bstm[Op-1] / Btm[Op-1];

                        //Condicion para saber si R es = a (b-a)/(c-a) entonces se se hace para X1 y X2, si es R es < entonces solo habra X1 y X2 es 0 no hay numero ahi,
                        //y si R > entonces habra X2 y X1 es 0 no hay nada
                        if (Matriz[Op-1, 3] == Ptbba[Op-1])
                        {
                            //X1
                            Matriz[Op-1, 4] = Matriz[Op-1, 0] + Math.Sqrt(((Matriz[Op-1, 1] - Matriz[Op-1, 0]) * (Matriz[Op-1, 2] - Matriz[Op-1, 0]) * Matriz[Op-1, 3]));
                            //X2
                            Matriz[Op-1, 5] = Matriz[Op-1, 2] - Math.Sqrt(((Matriz[Op-1, 2] - Matriz[Op-1, 1]) * (Matriz[Op-1, 2] - Matriz[Op-1, 0]) * (1 - Matriz[Op-1, 3])));
                        }
                        if (Matriz[Op-1, 3] < Ptbba[Op-1])
                        {
                            //X1
                            Matriz[Op-1, 4] = Matriz[Op-1, 0] + Math.Sqrt(((Matriz[Op-1, 1] - Matriz[Op-1, 0]) * (Matriz[Op-1, 2] - Matriz[Op-1, 0]) * Matriz[Op-1, 3]));
                            //X2
                            Matriz[Op-1, 5] = 0;
                        }
                        if (Matriz[Op-1, 3] > Ptbba[Op-1])
                        {
                            //X1
                            Matriz[Op-1, 4] = 0;
                            //X2
                            Matriz[Op-1, 5] = Matriz[Op-1, 2] - Math.Sqrt(((Matriz[Op-1, 2] - Matriz[Op-1, 1]) * (Matriz[Op-1, 2] - Matriz[Op-1, 0]) * (1 - Matriz[Op-1, 3])));
                        }
                    }
                    catch (FormatException)
                    {
                        //Mensaje de caja
                        MessageBox.Show("Introduce valor correcto, experimento fallido", "Error");
                        FormaCaptura.txtVmi.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor de poner una prueba existente entre el 1 y el 8");
            }

            dataGVResultadosDistribucionTriangular.Columns.Clear();
            dataGVResultadosDistribucionTriangular.Rows.Clear();
            dataGVResultadosFinales.Columns.Clear();
            dataGVResultadosFinales.Rows.Clear();

            dataGVResultadosDistribucionTriangular.Columns.Add("numero de prueba", "Numero de prueba");
            dataGVResultadosDistribucionTriangular.Columns.Add("a", "A");
            dataGVResultadosDistribucionTriangular.Columns.Add("b", "B");
            dataGVResultadosDistribucionTriangular.Columns.Add("c", "C");
            dataGVResultadosDistribucionTriangular.Columns.Add("ri", "Ri");
            dataGVResultadosDistribucionTriangular.Columns.Add("rj", "Rj");
            dataGVResultadosDistribucionTriangular.Columns.Add("x1", "X1");
            dataGVResultadosDistribucionTriangular.Columns.Add("x2", "X2");
            for (int i = 0; i < 8; i++)
            {
                dataGVResultadosDistribucionTriangular.Rows.Add(i + 1, Matriz[i, 0], Matriz[i, 1], Matriz[i, 2], Matriz[i, 3], Ptbba[i], Matriz[i, 4], Matriz[i, 5]);
            }

            double numenterodecimal, numenterodecimal2;
            int numentero, numentero2;
            dataGVResultadosFinales.Columns.Add("tiempos calculados", "Tiempos calculados(Minutos)");
            dataGVResultadosFinales.Columns.Add("tiempos totales", "Tiempos totales(Minutos y segundos)");
            for (int j = 0; j < 8; j++)
            {
                if (Matriz[j, 4] != 0 && Matriz[j, 5] != 0)
                {
                    numenterodecimal = Matriz[j, 4];
                    numentero = (int)Math.Truncate(numenterodecimal);
                    numenterodecimal2 = Matriz[j, 5];
                    numentero2 = (int)Math.Truncate(numenterodecimal2);
                    dataGVResultadosFinales.Rows.Add(Matriz[j, 4] + " - " + Matriz[j, 5], (numentero + ":" + Math.Truncate((Math.Round(numenterodecimal - numentero, 5)) * 60)) + " - " + (numentero2 + ":" + Math.Truncate((Math.Round(numenterodecimal2 - numentero2, 5)) * 60)));
                }
                else if (Matriz[j, 4] != 0)
                {
                    numenterodecimal = Matriz[j, 4];
                    numentero = (int)Math.Truncate(numenterodecimal);
                    dataGVResultadosFinales.Rows.Add(Matriz[j, 4], (numentero + ":" + Math.Truncate((Math.Round(numenterodecimal - numentero, 5)) * 60)));
                }
                else if (Matriz[j, 5] != 0)
                {
                    numenterodecimal2 = Matriz[j, 5];
                    numentero2 = (int)Math.Truncate(numenterodecimal2);
                    dataGVResultadosFinales.Rows.Add(Matriz[j, 5], (numentero2 + ":" + Math.Truncate((Math.Round(numenterodecimal2 - numentero2, 5)) * 60)));
                }
            }
        }

        private void btnUniformes_Click(object sender, EventArgs e)
        {
            VariablesGlobales.XNActivo = int.Parse(txtXn.Text);
            VariablesGlobales.CActivo = int.Parse(txtC.Text);
            VariablesGlobales.AActivo = int.Parse(txtA.Text);
            VariablesGlobales.MActivo = int.Parse(txtM.Text);
            VariablesGlobales.NActivo = int.Parse(txtN.Text);
            frmTercera abrir = new frmTercera();
            abrir.ShowDialog();
        }

        public void Limpiar()
        {
            txtBaseTMCA.Clear();
            txtBaseTMBA.Clear();
            txtBaseTMCB.Clear();
            txtPTBba.Clear();
            txtPTBcb.Clear();
            lbx.Items.Clear();
            dataGVPruebas.Columns.Clear();
            dataGVPruebas.Rows.Clear();
            dataGVResultadosDistribucionTriangular.Columns.Clear();
            dataGVResultadosDistribucionTriangular.Rows.Clear();
            dataGVResultadosFinales.Columns.Clear();
            dataGVResultadosFinales.Rows.Clear();
            txtXn.Text = "17";
            txtC.Text = "221";
            txtA.Text = "101";
            txtM.Text = "17001";
            txtN.Text = "200";
            txtPruebas.Text = "1";
        }

        public void PruebaImprimir(int NumPrueba)
        {
            txtBaseTMCA.Text = Btm[NumPrueba].ToString();
            txtBaseTMBA.Text = Bptm[NumPrueba].ToString();
            txtBaseTMCB.Text = Bstm[NumPrueba].ToString();
            txtPTBba.Text = Ptbba[NumPrueba].ToString();
            txtPTBcb.Text = Ptbcb[NumPrueba].ToString();
        }

        public void Mostrar()
        {
            dataGVPruebas.Columns.Add("numero de prueba", "Numero de prueba");
            dataGVPruebas.Columns.Add("tiempo (minutos)", "Tiempo (Minutos)");
            dataGVPruebas.Rows.Add("1", "30");
            dataGVPruebas.Rows.Add("2", "34");
            dataGVPruebas.Rows.Add("3", "32");
            dataGVPruebas.Rows.Add("4", "33");
            dataGVPruebas.Rows.Add("5", "38");
            dataGVPruebas.Rows.Add("6", "31");
            dataGVPruebas.Rows.Add("7", "35");
            dataGVPruebas.Rows.Add("8", "34");
        }

        private void btnConclusion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Podemos determinar el valor en los que la maquina tarda en poder empaquetar y shampoos");
        }
    }
}
