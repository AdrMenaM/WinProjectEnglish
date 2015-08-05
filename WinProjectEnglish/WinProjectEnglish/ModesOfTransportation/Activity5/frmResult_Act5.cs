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
    public partial class frmResult_Act5 : Form
    {

        private int mResult;        //Dato miembro el cual almacenara el resultado de la actividad proveniente de el formulario de la actividad

        //Constructor por defecto
        public frmResult_Act5()
        {
            InitializeComponent();
            mResult = 0;
        }

        //Constructor por parámetros
        //Recibe como parámetor un dato entero
        public frmResult_Act5(int result)
        {
            mResult = result;       //Asigna el valor del dato parametrizado al dato miembro
            InitializeComponent();
        }

        //función encargada de hacer la impresión del resultado en un TextBox
        private void PrintData(TextBox txtResult)
        {
            txtResult.Text = mResult.ToString();        //Impresión del valor del dato miembro en un textBox
        }

        private void frmResult_Act5_Load(object sender, EventArgs e)
        {
            PrintData(txtResult);       //Llamado de la función imprimir al momento de cargar el formulario
        }

        //private void btnRepeat_Click(object sender, EventArgs e)
        //{
             
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();       //Cierra la ventana actual del formulario de resultado
        }
    }
}
