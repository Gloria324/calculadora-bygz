using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_bygz
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;
        public Form1()
        {
            InitializeComponent();
        }
    
        private void agregarNumero (object sender, EventArgs e)
            
        {

            var boton = ((Button)sender);

            if (textResultado.Text == "0")
                textResultado.Text = "";

            textResultado.Text += boton.Text;

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(textResultado.Text);

            if (Operador == '+') 
            {
              textResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Tag);
            }else if (Operador == '-')
            {
                textResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Tag);
            }else if(Operador == '×')
            {
                textResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Tag);
            }else if(Operador == '÷')
            {
                textResultado.Text = (Numero1 / Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Tag);
            }

        }

        private void ClickOperador(object sender, EventArgs e)
        {


            var boton = ((Button)sender);


            Numero1 = Convert.ToDouble(textResultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            textResultado.Text = "0";
        }

            
        

    }
    }

