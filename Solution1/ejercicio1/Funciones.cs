using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        //procedimiento no devuelven valores (void no devuelve nada)
        private void LimpiarControles()
        {
        //->Limpiar texbox
            txt_numero1.Clear();
            txt_numero2.Text=""; 
            //txt_numero1.text=string.empty:
        }
         

        //Tipo de dato que va a devolver
        private int Sumar(int valor1, int valor2) //se puede colocar parametros em los parentesis
        {
           return valor1 + valor2;
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Sumar(Convert.ToInt32(txt_numero1.Text), Convert.ToInt32(txt_numero2.Text)).ToString();
        }





        private int Resta(int valor1, int valor2) //se puede colocar parametros em los parentesis
        {
            int resta = valor1 - valor2;
            return resta;
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = Resta(Convert.ToInt32(txt_numero1.Text), Convert.ToInt32(txt_numero2.Text)).ToString();

        }





        private int multiplicar(int valor1, int valor2) //se puede colocar parametros em los parentesis
        {
            return valor1*valor2;
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {

            lbl_resultado.Text = multiplicar(Convert.ToInt32(txt_numero1.Text), Convert.ToInt32(txt_numero2.Text)).ToString();

        }





        private int dividir(int valor1, int valor2) //se puede colocar parametros em los parentesis
        {
            return valor1 / valor2;
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = dividir(Convert.ToInt32(txt_numero1.Text), Convert.ToInt32(txt_numero2.Text)).ToString();

        }
    }
}
