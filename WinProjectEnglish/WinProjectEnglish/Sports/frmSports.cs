/* 
 * Adrián Mena Manciati
 * Fecha: 09-07-2015
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinProjectEnglish
{
    public partial class frmSports : Form
    {
        //Constructor sin parámetros del formulario.
        public frmSports()
        {
            InitializeComponent();
        }

        //Acción del botón de salida del formulario.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   //Cierra el formulario actual.
        }

        //Acción que se ejecuta al abrir este formulario. Vacío.
        private void frmSports_Load(object sender, EventArgs e)
        {

        }
    }
}
