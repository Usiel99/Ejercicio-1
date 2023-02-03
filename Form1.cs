using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            int valor = 0;
            int parimpar = 0;
            valor = int.Parse(Valor1TextBox.Text);
            
            //Llamado a la funcion que determina si el valor es par o impar
            
            Par(valor, parimpar);

            //Llamado a la funcion que determina si el valor es positivo o negativo
            Posneg(valor);
        }

        //Funcion para determinar si el valor digitado por el usuario es par o impar
        private int Par(int valor, int parimpar)
        {
            //dividimos el valor entre 2 si este nos da distinto a 0 el numero es impar
            parimpar = valor % 2;
            //Validamos que el numero sea impar 
            if (parimpar > 0)
            {
                Respuesta1TextBox.Text = "El Valor " + valor + " es Impar ";
                return valor;

            }
            else 
            {
                Respuesta1TextBox.Text = "El Valor " + valor + " es Par ";
                return valor;
                
            }
            
        }

        //Funcion para detirminar si el valor es positivo o negativo
        private int Posneg(int valor)
        {
            if (valor > 0)
            {
                Respuesta2TextBox.Text = "El Valor " + valor + " es Positivo ";
                return valor;
            }
            else 
            {
                Respuesta2TextBox.Text = "El Valor " + valor + " es Negativo ";
                return valor;
            }
        }
    }
}
