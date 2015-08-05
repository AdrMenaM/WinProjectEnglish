using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WinProjectEnglish
{
    public class Activity5
    {
        private int mCorrect;       //Atributo de la clase el cual va incrementando en base a las respuestas acertadas

        //Método de getter y setter del dato miembro
        public int MCorrect
        {
            get { return mCorrect; }
            set { mCorrect = value; }
        }

        private String A, B, C, D, E;       //Atributos de la clase los cuales almacenaran la respuesta ingresada


        //Constructor por defecto
        public Activity5()
        {
            mCorrect = 0;
            A = "";
            B = "";
            C = "";
            D = "";
            E = "";
        }

        //Método para inicializar los TextBox,PictureBox correspondientes a cada párrafo
        public void InitializeData(TextBox txtA, TextBox txtB, TextBox txtC, TextBox txtD, TextBox txtE,
                                    PictureBox picTick1, PictureBox picTick2, PictureBox picTick3, PictureBox picTick4, PictureBox picTick5,
                                    PictureBox picCross1, PictureBox picCross2, PictureBox picCross3, PictureBox picCross4, PictureBox picCross5)
        {
            mCorrect = 0;
            //Se inicializa los TextBox en vacío
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtE.Text = "";
            //Todos los pinctures en la visibilidad se inicia en false para no visualizarlso hasta no completar el párrafo
            picTick1.Visible = false;
            picTick2.Visible = false;
            picTick3.Visible = false;
            picTick4.Visible = false;
            picTick5.Visible = false;
            picCross1.Visible = false;
            picCross2.Visible = false;
            picCross3.Visible = false;
            picCross4.Visible = false;
            picCross5.Visible = false;
        }

        //Método el cual bloque los TextBox de la palabras y el botón Finish el cual se activará al momento de dar clic al botón Finish 
        public void LockData(TextBox txtA, TextBox txtB, TextBox txtC, TextBox txtD, TextBox txtE,Button btnFinish)
        {
            //Se cambia la propiedad de enable a false en los TextBox y el botón Finish
            txtA.Enabled = false;
            txtB.Enabled = false;
            txtC.Enabled = false;
            txtD.Enabled = false;
            txtE.Enabled = false;
            btnFinish.Enabled = false;

        }

        //Método encargado de hacer el cálculo de las respuestas correctas en base a el texto en los TextBox
        public int calculateAnswers(TextBox txtA, TextBox txtB, TextBox txtC, TextBox txtD, TextBox txtE,
                                    Label lblA,Label lblB,Label lblC,Label lblD,Label lblE,
                                    PictureBox picTick1, PictureBox picTick2, PictureBox picTick3, PictureBox picTick4, PictureBox picTick5,
                                    PictureBox picCross1, PictureBox picCross2, PictureBox picCross3, PictureBox picCross4, PictureBox picCross5)
        {
            //Se asigna el texto de los TextBox a los atributos miembro de tipo String correspondientes a cada palabra del párrafo
            A = txtA.Text;
            B = txtB.Text;
            C = txtC.Text;
            D = txtD.Text;
            E = txtE.Text;
            //Se realiza una comparación de el teto almacenado en cada atributo miembro
            //en caso de ser correcto se aumenta en uno al atributo de respuestas correctas
            if (A.Equals(lblA.Text))
            {
                mCorrect++;
                picTick1.Visible = true;    //En caso de ser la respuesta correcta se activa la propiedad visible de el picture box correspondiente al visto
            }
            else
            {
                picCross1.Visible = true;   //En caso de ser la respuesta incorrecta se activa la propiedad visible de el picture box correspondiente a al equis
            }
            if (B.Equals(lblB.Text))
            {
                mCorrect++;
                picTick2.Visible = true;    //En caso de ser la respuesta correcta se activa la propiedad visible de el picture box correspondiente al visto
            }
            else
            {
                picCross2.Visible = true;   //En caso de ser la respuesta incorrecta se activa la propiedad visible de el picture box correspondiente a al equis
            }
            if (C.Equals(lblC.Text))
            {
                mCorrect++;
                picTick3.Visible = true;    //En caso de ser la respuesta correcta se activa la propiedad visible de el picture box correspondiente al visto
            }
            else
            {
                picCross3.Visible = true;   //En caso de ser la respuesta incorrecta se activa la propiedad visible de el picture box correspondiente a al equis
            }
            if (D.Equals(lblD.Text))
            {
                mCorrect++;
                picTick4.Visible = true;    //En caso de ser la respuesta correcta se activa la propiedad visible de el picture box correspondiente al visto
            }
            else
            {
                picCross4.Visible = true;   //En caso de ser la respuesta incorrecta se activa la propiedad visible de el picture box correspondiente a al equis
            }
            if (E.Equals(lblE.Text))
            {
                mCorrect++;
                picTick5.Visible = true;    //En caso de ser la respuesta correcta se activa la propiedad visible de el picture box correspondiente al visto
            }
            else
            {
                picCross5.Visible = true;   //En caso de ser la respuesta incorrecta se activa la propiedad visible de el picture box correspondiente a al equis
            }
            return mCorrect;    //Se retorna el valor correspondiente al atributo de respuestas correctas
        }
    }
}
