using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLetraEnPalabra
{
    public partial class frmLetra : Form
    {
        public frmLetra()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            Char[]  Frase = txtFrase.Text.ToCharArray(); //Convierte el valor de la caja de texto en un vector de tipo char
            Char Letra = Convert.ToChar(txtLetra.Text); //Convierte el valor de la caja de texto en una variable de tipo char
            Int32 Indice = 0;
            Int32 Cantidad = 0;

            while (Indice < Frase.Length) //"Frase.lenght" sirve para contar la cantidad de caracteres que tiene el vector
            {
                if (Frase[Indice] == Letra) //si el valor en la posisicion del indice es igual hacer...
                {
                    Cantidad++;     // incrementa la cantidad en 1                
                }
                Indice++; //incrementa la posicion del indice en 1
            }
            lblCantidad.Text = Cantidad.ToString();
        }
    }
}
