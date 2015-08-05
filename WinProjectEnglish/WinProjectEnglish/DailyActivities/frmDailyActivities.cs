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
    public partial class frmDailyActivities : Form
    {
        //Constructor sin parámetros del formulario.
        public frmDailyActivities()
        {
            InitializeComponent();
        }

        //Acción del botón que abre el formulario de la actividad 1.
        private void btnActivity1_Click(object sender, EventArgs e)
        {
            
        }

        //Acción del botón de salida del formulario.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   //Cierra el formulario actual.
        }

        //Acción del botón que abre el formulario de la actividad 2.
        private void btnActivity2_Click(object sender, EventArgs e)
        {

        }

        //Acción del botón que abre el formulario de la actividad 3.
        private void btnActivity3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAct_1_3 objFrm = new frmAct_1_3();
            objFrm.Show();
        }

        //Acción del botón que abre el formulario de la actividad 4.
        private void btnActivity4_Click(object sender, EventArgs e)
        {
            
        }

        //Acción del botón que abre el formulario de la actividad 5.
        private void btnActivity5_Click(object sender, EventArgs e)
        {

        }

        //Acción que se ejecuta al abrir este formulario. Vacío.
        private void frmDailyActivities_Load(object sender, EventArgs e)
        {

        }
    }
}
