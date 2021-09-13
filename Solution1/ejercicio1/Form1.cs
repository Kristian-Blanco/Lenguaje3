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
    public partial class FuncionesDeTexto : Form
    {
        public FuncionesDeTexto()
        {
            InitializeComponent();
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            string cadena = txt_cadena.Text;

            //obtener la longitud de la cadena ingresada
            txt_longitud.Text = cadena.Length.ToString();

            //obtener el primer elemento o caracter 
            txt_primercaracter.Text=cadena.Substring(0,1)

            //Obterner el ultimo elemento o caracter 
            txt_ultimocaracter.Text = cadena.Substring(cadena.Length - 1, 1);

            //Obtener rango 
            txt_rango.Text = cadena.Substring(5, 15);

            //Convertir a mayuscula
            txt_mayusculas.Text = cadena.ToUpper();

            //convertir minuscula
            txt_minuscula.Text = cadena.ToLower();

            //Reemplazar
            txt_reemplazar.Text = cadena.Replace("a", "b");

            //Obtener primera mayuscula
            txt_primeramayuscula.Text = cadena.Substring(0, 1).ToUpper() + cadena.Substring(1, cadena.Length - 1).ToLower;

        }
    }
}
