using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaProgramacionDistanciaPuntos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(this.txtX1.Text);
            double y1 = double.Parse(this.txtY1.Text);
            double x2 = double.Parse(this.txtX2.Text);
            double y2 = double.Parse(this.txtY2.Text);
            double distancia;

            Punto2D objPuntos = new Punto2D(x1, y1, x2, y2);
            distancia = Punto2D.CalcularDistancia;
            txtDistancia.Text = distancia.ToString();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            txtX1.Clear();
            txtX2.Clear();
            txtY1.Clear();
            txtY2.Clear();
            txtDistancia.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
