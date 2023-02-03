using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea1_20181030120
{
    public partial class tarea1 : Form
    {
        public tarea1()
        {
            InitializeComponent();
        }

        private void btt_calcular_Click(object sender, EventArgs e)
        {

            string validarPar = esPar(int.Parse(txb_ingresar.Text));
            string validarNegativo = positivoNegativo(int.Parse(txb_ingresar.Text));

            lbl_resultado.Text = validarNegativo + ", " + validarPar;
        }

        // 
        private static string esPar(int valor)
        {
            if (valor % 2 == 0)
            {
                return "Numero par";
            }
            else return "Numero impar";

        }
        private static string positivoNegativo(int valor)
        {
            if (valor >= 0)
            {
                return "Numero positivo";
            }
            else return "Numero negativo";
        }

        private void txb_ingresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Esto bloquea para que no se ingrese texto.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txb_ingresar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
