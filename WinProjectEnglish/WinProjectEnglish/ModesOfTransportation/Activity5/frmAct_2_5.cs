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
    public partial class frmAct_2_5 : Form
    {

        //Se declara un obdeto de tipo Actividad 5, clase creada para controlar el resultado
        public Activity5 objAct5 = new Activity5();

        public frmAct_2_5()
        {
            InitializeComponent();
        }

        private void frmAct_2_5_Load(object sender, EventArgs e)
        {
            //Se Declara un objeto de tipo aleatorio el cual generará un número aleatorio entre 1 y 2 
            Random rand = new Random();
            //Se asigna el vlaor alatorio a una variable
            int a = rand.Next(1, 3);
            //Se compara el valor de la variable
            if (a == 1)     //En caso de ser 1, activa y hace visible al primer groupbox el cual contiene el primer parrafo
            {
                grbParagraph1.Enabled = true;
                grbParagraph1.Visible = true;
                txtA.Focus();
            }
            else        //En caso de ser 2, activa y hace visible al segundo groupbox el cual contiene el segundo parrafo
            {
                grbParagraph2.Enabled = true;
                grbParagraph2.Visible = true;
                txtA2.Focus(); 
            }
        }

        //Evento del botón Finish
        private void btnFinish_Click(object sender, EventArgs e)
        {
            //Se realiza una comparación para ver cual groupbox está activo
            if (grbParagraph1.Enabled)  //Compara en caso de que el primer groupbox este activo
            {
                //Se declara un objeto de tipo formulario de resultado en donde se envía por parámetro el valor de respuestas acertadas, haciendo uso de la función calculateAnswers de la clase Activity 5
                frmResult objresult = new frmResult(objAct5.calculateAnswers(txtA, txtB, txtC, txtD, txtE, lblA, lblB, lblC, lblD, lblE, picTick1, picTick2, picTick3, picTick4, picTick5, picCross1, picCross2, picCross3, picCross4, picCross5),"5");
                objresult.Show();       //Se llama al evento show del objeto formulario del resultado creado para visualizar las respuestas
                grbParagraph1.Enabled = false;  //Se desactiva al groupbox 1 en este caso para que no se pueda realziar ninguna acción sobre el mismo
                //objAct5.LockData(txtA, txtB, txtC, txtD, txtE, btnFinish);
                btnNext.Enabled = true;     //Se habilita al botón next el cual permite cambiar al siguiente groupbox, es decir al siguiente parrafo
                btnFinish.Enabled = false;  //Se deshabilita el botón finish para que no pueda usarse nuevamente una vez ya aplastado
            }
            else if (grbParagraph2.Enabled)     //En caso de que el segundo groupbox este activo
            {
                //Se declara un objeto de tipo formulario de resultado en donde se envía por parámetro el valor de respuestas acertadas, haciendo uso de la función calculateAnswers de la clase Activity 5
                frmResult objresult = new frmResult(objAct5.calculateAnswers(txtA2, txtB2, txtC2, txtD2, txtE2, lblA2, lblB2, lblC2, lblD2, lblE2, picTick_1, picTick_2, picTick_3, picTick_4, picTick_5, picCross_1, picCross_2, picCross_3, picCross_4, picCross_5),"5");
                objresult.Show();       //Se llama al evento show del objeto formulario del resultado creado para visualizar las respuestas
                grbParagraph2.Enabled = false;      //Se desactiva al groupbox 1 en este caso para que no se pueda realziar ninguna acción sobre el mismo
                //objAct5.LockData(txtA2, txtB2, txtC2, txtD2, txtE2, btnFinish);
                btnNext.Enabled = true;     //Se habilita al botón next el cual permite cambiar al siguiente groupbox, es decir al siguiente parrafo
                btnFinish.Enabled = false;      //Se deshabilita el botón finish para que no pueda usarse nuevamente una vez ya aplastado
            }
        }

        //Evento del botón Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            //objAct5.InitializeData(txtA, txtB, txtC, txtD, txtE, picTick1, picTick2, picTick3, picTick4, picTick5);
            if(grbParagraph1.Visible)   //Compara en caso de que el primer groupbox este visible
            {
                grbParagraph1.Enabled = true;       //Activa al groupbox para poder interactuar en éste

                //Se llama el método InitializeData para inicializar los textBox,PictureBox del groupbox desde 0 todo para volver a completar el párrafo
                objAct5.InitializeData(txtA, txtB, txtC, txtD, txtE, picTick1, picTick2, picTick3, picTick4, picTick5, picCross1, picCross2, picCross3, picCross4, picCross5);
                btnFinish.Enabled = true;       //Se habilita al botón finish 
                txtA.Focus();       //Se activa el evento de focus, para que el cursor apunte en el primer TextBox
                btnNext.Enabled = false;        //Se deshabilita al botón Next para que no pueda cambiar de parrafo hasta no haber respondido al primero
            }
            else if (grbParagraph2.Visible)     //Compara en caso de que el segundo groupbox este visible
            {
                grbParagraph2.Enabled = true;       //Activa al groupbox para poder interactuar en éste

                //Se llama el método InitializeData para inicializar los textBox,PictureBox del groupbox desde 0 todo para volver a completar el párrafo
                objAct5.InitializeData(txtA2, txtB2, txtC2, txtD2, txtE2, picTick_1, picTick_2, picTick_3, picTick_4, picTick_5, picCross_1, picCross_2, picCross_3, picCross_4, picCross_5);
                btnFinish.Enabled = true;       //Se habilita al botón finish 
                txtA2.Focus();      //Se activa el evento de focus, para que el cursor apunte en el primer TextBox
                btnNext.Enabled = false;        //Se deshabilita al botón Next para que no pueda cambiar de parrafo hasta no haber respondido al primero
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();       //Cierra la ventana actual, es decir del formulario de la actividad
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (grbParagraph1.Visible)      //Compara en caso de que el primer groupbox este visible
            {
                //Se llama el método InitializeData para inicializar los textBox,PictureBox del groupbox desde 0 todo para volver a completar el párrafo
                objAct5.InitializeData(txtA2, txtB2, txtC2, txtD2, txtE2, picTick_1, picTick_2, picTick_3, picTick_4, picTick_5, picCross_1, picCross_2, picCross_3, picCross_4, picCross_5);
                grbParagraph1.Enabled = false;      //Desactiva al primer groupbox
                grbParagraph1.Visible = false;      //Quita la visibilidad al primer groupbox
                grbParagraph2.Enabled = true;       //Activa al segundo groupbox
                grbParagraph2.Visible = true;       //Hace visible al segundo groupbox
                btnNext.Enabled = false;            //Deshabilita al botón next para que no pueda cambiar de parrafo
                btnFinish.Enabled = true;           //Habilita nuevamente al botón Finish para poder hacer el check de las respuestas
            }
            else if (grbParagraph2.Visible)      //Compara en caso de que el segundo groupbox este visible
            {
                //Se llama el método InitializeData para inicializar los textBox,PictureBox del groupbox desde 0 todo para volver a completar el párrafo
                objAct5.InitializeData(txtA, txtB, txtC, txtD, txtE, picTick1, picTick2, picTick3, picTick4, picTick5, picCross1, picCross2, picCross3, picCross4, picCross5);
                grbParagraph1.Enabled = true;       //Activa al primer groupbox
                grbParagraph1.Visible = true;       //Hace visible al primer groupbox
                grbParagraph2.Enabled = false;      //Desactiva al segundo groupbox
                grbParagraph2.Visible = false;      //Quita la visibilidad al segundo groupbox
                btnNext.Enabled = false;            //Deshabilita al botón next para que no pueda cambiar de parrafo
                btnFinish.Enabled = true;           //Habilita nuevamente al botón Finish para poder hacer el check de las respuestas
            }
        }
    }
}
