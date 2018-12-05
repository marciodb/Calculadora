using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        Double Total;
        Double UltimoNumero;
        String Operador;

        private void Limpar()
        {
            Total = 0;
            UltimoNumero = 0;
            Operador = "+";
            mtmResultado.Text = "0";
        }

        private void Calcular()
        {
            switch (Operador)
            {
                case "+":
                    Total = Total + UltimoNumero;
                    break;

                case "-":
                    Total = Total - UltimoNumero;
                    break;

                case "x":
                    Total = Total * UltimoNumero;
                    break;

                case "/":
                    Total = Total / UltimoNumero;
                    break;           
            }

            UltimoNumero = 0;
            mtmResultado.Text = Total.ToString();
}

        public Form1()
        {
            InitializeComponent();

            Limpar();
        }
       
        private void button16_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btNumero(object sender, EventArgs e)
        {
            if(UltimoNumero == 0)
            {
                mtmResultado.Text = (sender as Button).Text;
            }else
            {
                mtmResultado.Text = mtmResultado.Text + (sender as Button).Text;
            }
            
            UltimoNumero = Convert.ToDouble(mtmResultado.Text);
        }

        private void btOperador(object sender, EventArgs e)
        {
            UltimoNumero = Convert.ToDouble(mtmResultado.Text);
            Calcular();
            Operador = (sender as Button).Text;
        }

        private void Igualar(object sender, EventArgs e)
        {
            UltimoNumero = Convert.ToDouble(mtmResultado.Text);
            Calcular();
            Operador = "+";
            Total = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }


