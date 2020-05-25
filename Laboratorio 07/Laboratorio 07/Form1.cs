using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Laboratorio_07
{
    public partial class Form1 : Form
    {
        double primero=0;
        double segundo=0;
        double ans=0;
        string operador = "";
        int condicion = 1;
        int inicio = 0;
        int hist = 1;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonCircular1_Click(object sender, EventArgs e)
        {
            if (condicion==1)
            {
                restaurar();
            }
            textBoxEcuaciones.Text += 1;
        }

        private void botonCircular2_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                restaurar();
            }
            textBoxEcuaciones.Text += 2;
        }

        private void botonCircular3_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                restaurar();
            }
            textBoxEcuaciones.Text += 3;
        }

        private void botonCircular4_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                restaurar();
            }
            textBoxEcuaciones.Text += 4;
        }

        private void botonCircular5_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                restaurar();
            }
            textBoxEcuaciones.Text += 5;
        }

        private void botonCircular6_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                restaurar();
            }
            textBoxEcuaciones.Text += 6;
        }

        private void botonCircular7_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                restaurar();
            }
            textBoxEcuaciones.Text += 7;
        }

        private void botonCircular8_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                restaurar();
            }
            textBoxEcuaciones.Text += 8;
        }

        private void botonCircular9_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                restaurar();
            }
            textBoxEcuaciones.Text += 9;
        }

        private void botonCircular0_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                restaurar();
            }
            textBoxEcuaciones.Text += 0;
        }

        private void botonCircularAC_Click(object sender, EventArgs e)
        {
            restaurar();
            primero = 0;
            segundo = 0;
            ans = 0;
            operador = "";
            condicion = 1;
            textBoxEcuaciones.Text = "0";
            listHistorial.Items.Clear();
            inicio = 0;
            hist = 1;
        }

        private void botonCircularDel_Click(object sender, EventArgs e)
        {
            textBoxEcuaciones.Text = textBoxEcuaciones.Text.Remove(textBoxEcuaciones.Text.Length - 1, 1);
        }

        private void botonCircularMasYMenos_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {

                textBoxEcuaciones.Text += "Syntax Error";
            }
            textBoxEcuaciones.Text = (Convert.ToDouble(textBoxEcuaciones.Text) *-1).ToString();
        }

        private void botonCircularComa_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                restaurar();
                textBoxEcuaciones.Text += 0;
            }
            textBoxEcuaciones.Text += ",";

        }

        private void botonCircularANS_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {
                restaurar();
            }
            textBoxEcuaciones.Clear();
            textBoxEcuaciones.Text += ans;

        }

        private void botonCircularporcentaje_Click(object sender, EventArgs e)
        {
            if (condicion == 1)
            {

                textBoxEcuaciones.Text += "Syntax Error";
            }
            textBoxEcuaciones.Text = (Convert.ToDouble(textBoxEcuaciones.Text) / 100).ToString();
        }

        private void resultado()
        {
            switch (operador)
            {
                case "+":
                    ans = primero + segundo;
                    primero = 0;
                    segundo = 0;
                    break;
                case "-":
                    ans = primero - segundo;
                    primero = 0;
                    segundo = 0;
                    break;
                case "/":
                    ans = primero / segundo;
                    primero = 0;
                    segundo = 0;
                    break;
                case "*":
                    ans = primero * segundo;
                    primero = 0;
                    segundo = 0;
                    break;
                case "^":
                    ans = Math.Pow(primero, segundo);
                    primero = 0;
                    segundo = 0;
                    break;
                default:
                    break;
            }
        }

        private void botonCircularExponente_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                ans = Convert.ToDouble(textBoxEcuaciones.Text);
            }
            botonCircularExponente.BackColor = Color.DeepSkyBlue;
            condicion = 1;
            primero = ans;
            botonCircularIgual_Click(sender, e);
            operador = "^";
        }
        
        private void botonCircularRaiz_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                ans = Convert.ToDouble(textBoxEcuaciones.Text);
            }
            botonCircularRaiz.BackColor = Color.DeepSkyBlue;
            textBoxEcuaciones.Text = (Math.Sqrt(Convert.ToDouble(textBoxEcuaciones.Text))).ToString();
            botonCircularRaiz.BackColor = Color.DarkOrange;
        }

        private void botonCircularMultiplicar_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                ans = Convert.ToDouble(textBoxEcuaciones.Text);
            }
            botonCircularMultiplicar.BackColor = Color.DeepSkyBlue;
            condicion = 1;
            primero = ans;
            botonCircularIgual_Click(sender, e);
            operador = "*";
        }

        private void botonCircularDividir_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                ans = Convert.ToDouble(textBoxEcuaciones.Text);
            }
            botonCircularDividir.BackColor = Color.DeepSkyBlue;
            condicion = 1;
            primero = ans;
            botonCircularIgual_Click(sender, e);
            operador = "/";

        }

        private void botonCircularSuma_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                ans = Convert.ToDouble(textBoxEcuaciones.Text);
            }
            botonCircularSuma.BackColor = Color.DeepSkyBlue;
            condicion = 1;
            primero = ans;
            botonCircularIgual_Click(sender, e);
            operador = "+";
        }

        private void botonCircularResta_Click(object sender, EventArgs e)
        {
            if (inicio == 0)
            {
                ans = Convert.ToDouble(textBoxEcuaciones.Text);
            }
            botonCircularResta.BackColor = Color.DeepSkyBlue;
            condicion = 1;
            primero = ans;
            botonCircularIgual_Click(sender, e);
            operador = "-";
        }

        private void botonCircularIgual_Click(object sender, EventArgs e)
        {            
            inicio = 1;
            segundo = double.Parse(textBoxEcuaciones.Text);
            string temp = (primero + operador + segundo + "=");
            resultado();
            temp += ans;
            listHistorial.Items.Add(temp);
            textBoxEcuaciones.Text = ans.ToString();
            if (condicion == 0)
            {
                operador = "";
            }
            else
            {
                listHistorial.Items.Remove(temp);
            }
        }

        private void restaurar()
        {
            condicion = 0;
            botonCircularSuma.BackColor = Color.DarkOrange;
            botonCircularResta.BackColor = Color.DarkOrange;
            botonCircularMultiplicar.BackColor = Color.DarkOrange;
            botonCircularDividir.BackColor = Color.DarkOrange;
            botonCircularExponente.BackColor = Color.DarkOrange;
            listHistorial.ForeColor = Color.Black;
            textBoxEcuaciones.Clear();
        }

        private void botonCircularHist_Click(object sender, EventArgs e)
        {
            if (hist==-1)
            {
                listHistorial.ForeColor = Color.Black;
            }
            else
            {
                listHistorial.ForeColor = Color.White;
            }
            
            hist = hist * -1;
        }
    }
}
