﻿/* 
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
    public partial class frmModesOfTransportation : Form
    {
        //Constructor sin parámetros del formulario.
        public frmModesOfTransportation()
        {
            InitializeComponent();
        }

        //Acción del botón de salida del formulario.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   //Cierra el formulario actual.
        }

        //Acción del botón que abre el formulario de la actividad 5.
        private void btnActivity5_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAct_2_5 objForm = new frmAct_2_5();  //Instanciación del formulario.
            objForm.Show();                         //Muestra el formulario creado.
        }

        //Acción del botón que abre el formulario de la actividad 5.
        private void btnActivity3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAct_2_3 objFrm = new frmAct_2_3();   //Instanciación del formulario.
            objFrm.Show();                          //Muestra el formulario creado.
        }

        //Acción que se ejecuta al abrir este formulario. Vacío.
        private void frmModesOfTransportation_Load(object sender, EventArgs e)
        {

        }
    }
}
