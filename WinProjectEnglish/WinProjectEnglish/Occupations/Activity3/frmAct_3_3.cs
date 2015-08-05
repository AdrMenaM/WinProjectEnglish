/* 
 * Adrián Mena Manciati
 * Fecha: 14-07-2015
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WinProjectEnglish
{
    public partial class frmAct_3_3 : Form
    {
        //Activity4 Puntajes = new Activity4();
        private int mCorrect;   //Variable que cuenta el numero de aciertos para mostrarlos al final en frmResult_3
        private string mPath;
        private string recordPath;
        private bool recordFlag = false;
        private bool playFlag = false;
        Audio record = new Audio();

        //Constructor por defecto
        public frmAct_3_3()
        {
            InitializeComponent();
        }

        //Funcion de carga al abrir el formulario
        private void frmAct_1_Load(object sender, EventArgs e)
        {
            grbPart1.Enabled = true;    //Activa el grbPart1 que contiene las 3 primeras palabras
            grbPart1.Visible = true;    //Activa la visibilidad del groupbox
        }

        //Accion del boton Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   //Cierra el formulario actual
        }

        //Evento genérico que permite realizar la accion DragDrop desde un label. Este evento se llama en cada label.
        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;                      //Crea un objeto label generico y lo usa como sender.
            label.DoDragDrop(label.Text, DragDropEffects.Copy); //Accion de DragDrop para copiar el texto del label.
            //label.Enabled = false;
        }

        //Evento genérico para label donde se va a pegar el texto. Este evento se llama en cada label.
        private void label_DragDrop(object sender, DragEventArgs e)
        {
            Label label = sender as Label;                          //Crea un objeto label generico y lo usa como sender.
            label.Text = (String)e.Data.GetData(DataFormats.Text);  //Permite obtener el texto que se esta arrastrando.
        }

        //Evento genérico para label donde se va a pegar el texto. Este evento se llama en cada label.
        private void label_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;    //Muestra un icono de "pegar" cuando el mouse ingresa al label que recibirá el texto.
        }

        //Acción que se ejecuta al presionar el botón de la palabra 1.
        private void btnPlay1_Click(object sender, EventArgs e)
        {
            //mPath = System.Environment.CurrentDirectory;
            //mPath += @"\Media\Audio\Occupations\How_to_Pronounce_Butler.wav";
            //Se usa un objeto SoundPlayer que permite reproducir archivos .wav 
            SoundPlayer sound = new SoundPlayer(Properties.Resources.How_to_Pronounce_Butler);
            sound.Play();       //Reproduce el sonido del objeto creado.
        }

        //Acción que se ejecuta al presionar el botón de la palabra 2.
        private void btnPlay2_Click(object sender, EventArgs e)
        {
            //mPath = System.Environment.CurrentDirectory;
            //mPath += @"\Media\Audio\Occupations\How_to_Pronounce_Guide.wav";
            //Se usa un objeto SoundPlayer que permite reproducir archivos .wav 
            SoundPlayer sound = new SoundPlayer(Properties.Resources.How_To_Pronounce_Guide);
            sound.Play();       //Reproduce el sonido del objeto creado.
        }

        //Acción que se ejecuta al presionar el botón de la palabra 3.
        private void btnPlay3_Click(object sender, EventArgs e)
        {
            //mPath = System.Environment.CurrentDirectory;
            //mPath += @"\Media\Audio\Occupations\How_to_Pronounce_Fireman.wav";
            //Se usa un objeto SoundPlayer que permite reproducir archivos .wav 
            SoundPlayer sound = new SoundPlayer(Properties.Resources.How_to_Pronounce_Fireman);
            sound.Play();       //Reproduce el sonido del objeto creado.
        }

        //Acción que se ejecuta al presionar el botón de la palabra 4.
        private void btnPlay4_Click(object sender, EventArgs e)
        {
            //mPath = System.Environment.CurrentDirectory;
            //mPath += @"\Media\Audio\Occupations\How_to_Pronounce_Cook.wav";
            //Se usa un objeto SoundPlayer que permite reproducir archivos .wav 
            SoundPlayer sound = new SoundPlayer(Properties.Resources.How_to_Pronounce_Cook);
            sound.Play();       //Reproduce el sonido del objeto creado.
        }

        //Acción que se ejecuta al presionar el botón de la palabra 5.
        private void btnPlay5_Click(object sender, EventArgs e)
        {
            //mPath = System.Environment.CurrentDirectory;
            //mPath += @"\Media\Audio\Occupations\How_to_Pronounce_Detective.wav";
            //Se usa un objeto SoundPlayer que permite reproducir archivos .wav 
            SoundPlayer sound = new SoundPlayer(Properties.Resources.How_to_Pronounce_Detective);
            sound.Play();       //Reproduce el sonido del objeto creado.
        }

        //Acción que se ejecuta al presionar el botón de la palabra 6.
        private void btnPlay6_Click(object sender, EventArgs e)
        {
            //mPath = System.Environment.CurrentDirectory;
            //mPath += @"\Media\Audio\Occupations\How_to_Pronounce_Driver.wav";
            //Se usa un objeto SoundPlayer que permite reproducir archivos .wav 
            SoundPlayer sound = new SoundPlayer(Properties.Resources.How_to_Pronounce_Driver);
            sound.Play();       //Reproduce el sonido del objeto creado.
        }

        //Acción que se ejecuta al presionar el botón de la palabra 7.
        private void btnPlay7_Click(object sender, EventArgs e)
        {
            //mPath = System.Environment.CurrentDirectory;
            //mPath += @"\Media\Audio\Occupations\How_to_Pronounce_Pilot.wav";
            //Se usa un objeto SoundPlayer que permite reproducir archivos .wav 
            SoundPlayer sound = new SoundPlayer(Properties.Resources.How_to_Pronounce_Pilot);
            sound.Play();       //Reproduce el sonido del objeto creado.
        }

        //Acción que se ejecuta al presionar el botón de la palabra 8.
        private void btnPlay8_Click(object sender, EventArgs e)
        {
            //mPath = System.Environment.CurrentDirectory;
            //mPath += @"\Media\Audio\Occupations\How_to_Pronounce_Racer.wav";
            //Se usa un objeto SoundPlayer que permite reproducir archivos .wav 
            SoundPlayer sound = new SoundPlayer(Properties.Resources.How_to_Pronounce_Racer);
            sound.Play();       //Reproduce el sonido del objeto creado.
        }

        //Acción que se ejecuta al presionar el botón de la palabra 9.
        private void btnPlay9_Click(object sender, EventArgs e)
        {
            //mPath = System.Environment.CurrentDirectory;
            //mPath += @"\Media\Audio\Occupations\How_to_Pronounce_Sailor.wav";
            //Se usa un objeto SoundPlayer que permite reproducir archivos .wav 
            SoundPlayer sound = new SoundPlayer(Properties.Resources.How_to_Pronounce_Sailor);
            sound.Play();       //Reproduce el sonido del objeto creado.
        }

        //Acción que se ejecuta al presionar el boton Check para comprobar respuestas.
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Si el grbPart1 esta activo, es decir, se trabaja con las 3 primeras palabras
            if (grbPart1.Enabled)
            {

                //Se crea un string para cada palabra y se concatenan las letras  
                //que se encuentran en los labels de respuesta.

                String word1 = "";
                word1 += lblAnsW1L1.Text;
                word1 += lblAnsW1L2.Text;
                word1 += lblAnsW1L3.Text;
                word1 += lblAnsW1L4.Text;
                word1 += lblAnsW1L5.Text;
                word1 += lblAnsW1L6.Text;

                String word2 = "";
                word2 += lblAnsW2L1.Text;
                word2 += lblAnsW2L2.Text;
                word2 += lblAnsW2L3.Text;
                word2 += lblAnsW2L4.Text;
                word2 += lblAnsW2L5.Text;

                String word3 = "";
                word3 += lblAnsW3L1.Text;
                word3 += lblAnsW3L2.Text;
                word3 += lblAnsW3L3.Text;
                word3 += lblAnsW3L4.Text;
                word3 += lblAnsW3L5.Text;
                word3 += lblAnsW3L6.Text;
                word3 += lblAnsW3L7.Text;


                if (word1.Equals("") || word2.Equals("") || word3.Equals(""))       //Valida que no existan palabras vacías.
                {
                    //Si encuentra palabras que no han sido llenadas, muestra un mensaje de error.
                    MessageBox.Show("Complete all the words first!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    //Comprueba que el string de la palabra sea igual a la palabra correcta "BUTLER".
                    if (word1.Equals("BUTLER"))
                    {
                        picTick1.Visible = true;        //Muestra la imagen del visto si esta correcto. 
                        picCross1.Visible = false;      //Oculta la imagen de la x.
                        //Puntajes.Correct += 1;
                        mCorrect++;                     //Incrementa el puntaje en 1.
                    }
                    else    //Si la respuesta es incorrecta.
                    {
                        picTick1.Visible = false;       //Oculta la imagen del visto.
                        picCross1.Visible = true;       //Muestra la imagen de la x.
                    }

                    //Comprueba que el string de la palabra sea igual a la palabra correcta "GUIDE".
                    if (word2.Equals("GUIDE"))
                    {
                        picTick2.Visible = true;        //Muestra la imagen del visto si esta correcto.
                        picCross2.Visible = false;      //Oculta la imagen de la x.
                        //Puntajes.Correct += 1;
                        mCorrect++;                     //Incrementa el puntaje en 1.
                    }
                    else    //Si la respuesta es incorrecta.
                    {
                        picTick2.Visible = false;       //Oculta la imagen del visto.
                        picCross2.Visible = true;       //Muestra la imagen de la x.

                    }

                    //Comprueba que el string de la palabra sea igual a la palabra correcta "FIREMAN".
                    if (word3.Equals("FIREMAN"))
                    {
                        picTick3.Visible = true;        //Muestra la imagen del visto si esta correcto.
                        picCross3.Visible = false;      //Oculta la imagen de la x.
                        //Puntajes.Correct += 1;
                        mCorrect++;                     //Incrementa el puntaje en 1.
                    }
                    else    //Si la respuesta es incorrecta.
                    {
                        picTick3.Visible = false;       //Oculta la imagen del visto.
                        picCross3.Visible = true;       //Muestra la imagen de la x.
                    }

                    grbPart1.Enabled = false;   //Bloquea el grb con las palabras 1,2,3.
                    btnCheck.Enabled = false;   //Bloquea el boton de Check.
                    btnNext.Enabled = true;     //Activa el botón Next.
                }

            }
            //Si el grbPart1 esta activo, es decir, se trabaja con las palabras 4,5,6.
            else if (grbPart2.Enabled)
            {

                //Se crea un string para cada palabra y se concatenan las letras  
                //que se encuentran en los labels de respuesta.

                String word4 = "";
                word4 += lblAnsW4L1.Text;
                word4 += lblAnsW4L2.Text;
                word4 += lblAnsW4L3.Text;
                word4 += lblAnsW4L4.Text;

                String word5 = "";
                word5 += lblAnsW5L1.Text;
                word5 += lblAnsW5L2.Text;
                word5 += lblAnsW5L3.Text;
                word5 += lblAnsW5L4.Text;
                word5 += lblAnsW5L5.Text;
                word5 += lblAnsW5L6.Text;
                word5 += lblAnsW5L7.Text;
                word5 += lblAnsW5L8.Text;
                word5 += lblAnsW5L9.Text;

                String word6 = "";
                word6 += lblAnsW6L1.Text;
                word6 += lblAnsW6L2.Text;
                word6 += lblAnsW6L3.Text;
                word6 += lblAnsW6L4.Text;
                word6 += lblAnsW6L5.Text;
                word6 += lblAnsW6L6.Text;



                if (word4.Equals("") || word5.Equals("") || word6.Equals(""))       //Valida que no existan palabras vacías.
                {
                    //Si encuentra palabras que no han sido llenadas, muestra un mensaje de error.
                    MessageBox.Show("Complete all the words first!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    //Comprueba que el string de la palabra sea igual a la palabra correcta "COOK".
                    if (word4.Equals("COOK"))
                    {
                        picTick4.Visible = true;        //Muestra la imagen del visto si esta correcto.
                        picCross4.Visible = false;      //Oculta la imagen de la x.
                        //Puntajes.Correct += 1;
                        mCorrect++;                     //Incrementa el puntaje en 1.
                    }
                    else    //Si la respuesta es incorrecta.
                    {
                        picTick4.Visible = false;       //Oculta la imagen del visto.
                        picCross4.Visible = true;       //Muestra la imagen de la x.
                    }


                    //Comprueba que el string de la palabra sea igual a la palabra correcta "DETECTIVE".
                    if (word5.Equals("DETECTIVE"))
                    {
                        picTick5.Visible = true;        //Muestra la imagen del visto si esta correcto.
                        picCross5.Visible = false;      //Oculta la imagen de la x.
                        //Puntajes.Correct += 1;
                        mCorrect++;                     //Incrementa el puntaje en 1.
                    }
                    else    //Si la respuesta es incorrecta.
                    {
                        picTick5.Visible = false;       //Oculta la imagen del visto.
                        picCross5.Visible = true;       //Muestra la imagen de la x.
                    }


                    //Comprueba que el string de la palabra sea igual a la palabra correcta "DRIVER".
                    if (word6.Equals("DRIVER"))
                    {
                        picTick6.Visible = true;        //Muestra la imagen del visto si esta correcto.
                        picCross6.Visible = false;      //Oculta la imagen de la x.
                        //Puntajes.Correct += 1;
                        mCorrect++;                     //Incrementa el puntaje en 1.
                    }
                    else    //Si la respuesta es incorrecta.
                    {
                        picTick6.Visible = false;       //Oculta la imagen del visto.
                        picCross6.Visible = true;       //Muestra la imagen de la x.
                    }


                    grbPart2.Enabled = false;   //Bloquea el grb con las palabras 4,5,6.
                    btnCheck.Enabled = false;   //Bloquea el boton de Check.
                    btnNext.Enabled = true;     //Activa el botón Next.
                }

            }
            //Si el grbPart3 esta activo, es decir, se trabaja con las palabras 7,8,9.
            else  //if(grbPart3.Enabled)
            {

                //Se crea un string para cada palabra y se concatenan las letras  
                //que se encuentran en los labels de respuesta.

                String word7 = "";
                word7 += lblAnsW7L1.Text;
                word7 += lblAnsW7L2.Text;
                word7 += lblAnsW7L3.Text;
                word7 += lblAnsW7L4.Text;
                word7 += lblAnsW7L5.Text;

                String word8 = "";
                word8 += lblAnsW8L1.Text;
                word8 += lblAnsW8L2.Text;
                word8 += lblAnsW8L3.Text;
                word8 += lblAnsW8L4.Text;
                word8 += lblAnsW8L5.Text;
                

                String word9 = "";
                word9 += lblAnsW9L1.Text;
                word9 += lblAnsW9L2.Text;
                word9 += lblAnsW9L3.Text;
                word9 += lblAnsW9L4.Text;
                word9 += lblAnsW9L5.Text;
                word9 += lblAnsW9L6.Text;



                if (word7.Equals("") || word8.Equals("") || word9.Equals(""))       //Valida que no existan palabras vacías.
                {
                    //Si encuentra palabras que no han sido llenadas, muestra un mensaje de error.
                    MessageBox.Show("Complete all the words first!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    //Comprueba que el string de la palabra sea igual a la palabra correcta "PILOT".
                    if (word7.Equals("PILOT"))
                    {
                        picTick7.Visible = true;        //Muestra la imagen del visto si esta correcto.
                        picCross7.Visible = false;      //Oculta la imagen de la x.
                        //Puntajes.Correct += 1;
                        mCorrect++;                     //Incrementa el puntaje en 1.
                    }
                    else    //Si la respuesta es incorrecta.
                    {
                        picTick7.Visible = false;       //Oculta la imagen del visto.
                        picCross7.Visible = true;       //Muestra la imagen de la x.
                    }

                    //Comprueba que el string de la palabra sea igual a la palabra correcta "RACER".
                    if (word8.Equals("RACER"))
                    {
                        picTick8.Visible = true;        //Muestra la imagen del visto si esta correcto.
                        picCross8.Visible = false;      //Oculta la imagen de la x.
                        //Puntajes.Correct += 1;
                        mCorrect++;                     //Incrementa el puntaje en 1.
                    }
                    else    //Si la respuesta es incorrecta.
                    {
                        picTick8.Visible = false;       //Oculta la imagen del visto.
                        picCross8.Visible = true;       //Muestra la imagen de la x.
                    }

                    //Comprueba que el string de la palabra sea igual a la palabra correcta "SAILOR".
                    if (word9.Equals("SAILOR"))
                    {
                        picTick9.Visible = true;        //Muestra la imagen del visto si esta correcto.
                        picCross9.Visible = false;      //Oculta la imagen de la x.
                        //Puntajes.Correct += 1;
                        mCorrect++;                     //Incrementa el puntaje en 1.
                    }
                    else    //Si la respuesta es incorrecta.
                    {
                        picTick9.Visible = false;       //Oculta la imagen del visto.
                        picCross9.Visible = true;       //Muestra la imagen de la x.
                    }


                    grbPart3.Enabled = false;   //Bloquea el grb con las palabras 7,8,9.
                    btnCheck.Enabled = false;   //Bloquea el boton de Check.
                    btnNext.Enabled = true;     //Activa el botón Next.
                }

                
            }

            
            
                
        }

        private void btnRecordPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnRecordRec_Click(object sender, EventArgs e)
        {

        }

        //Acción que se ejecuta al presionar el botón Next.
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (grbPart1.Visible)   //Comprueba que este activo el grb con las palabras 1,2,3.
            {
                grbPart1.Visible = false;   //Oculta el primer grb.
                grbPart1.Enabled = false;   //Desactiva el primer grb.
                grbPart2.Visible = true;    //Muestra el segundo grb.
                grbPart2.Enabled = true;    //Activa el segundo grb.
                btnNext.Enabled = false;    //Desactiva el boton Next.
            }
            else if (grbPart2.Visible)  //Comprueba que este activo el grb con las palabras 4,5,6.
            {
                grbPart2.Visible = false;   //Oculta el segundo grb.
                grbPart2.Enabled = false;   //Desactiva el segundo grb.
                grbPart3.Visible = true;    //Muestra el tercer grb.
                grbPart3.Enabled = true;    //Activa el tercer grb.
                btnNext.Enabled = false;    //Desactiva el botón Next.
            }
            else //(grbPart3.Visible)
            {
                //Mostrar ventana de resultados
                //frmResult objResult = new frmResult_Act4(Puntajes.Correct);
                frmResult objResult = new frmResult(mCorrect,"9");  //Se crea el formulario enviando el valor de respuestas correctas.
                
                objResult.Show();   //Se muestra el formulario creado.
                grbPart3.Enabled = false;   //Se oculta el ultimo groupbox.
                btnRetry.Visible = true;    //Se muestra el boton de Reintentar.
            }

            btnCheck.Enabled = true;    //Se activa el boton Check.
        }

        private void picCross5_Click(object sender, EventArgs e)
        {

        }

        //Acción que se ejecuta al hacer click en el boton Retry.
        //private void btnRetry_Click(object sender, EventArgs e)
        //{
        //    this.Close();   //Cierra el formulario actual.
        //    frmAct_3_3 objFrm = new frmAct_3_3();       //Crea un nuevo formulario de esta misma actividad.
        //    objFrm.Show();  //Muestra el formulario nuevo.
        //}

        private void btnRetry_Click_1(object sender, EventArgs e)
        {
            this.Close();   //Cierra el formulario actual.
            frmAct_3_3 objFrm = new frmAct_3_3();       //Crea un nuevo formulario de esta misma actividad.
            objFrm.Show();  //Muestra el formulario nuevo.
        }

        private void btnRecordPlay_Click_1(object sender, EventArgs e)
        {
            if (playFlag)       //Si hay una grabación creada.
            {
                mPath = Path.GetTempPath();     //Obtiene la dirección de la carpeta Temp del usuario.
                mPath += @"iLoveEnglishAudio.wav";
                //Se usa un objeto SoundPlayer que permite reproducir archivos .wav 
                SoundPlayer player = new SoundPlayer(mPath);
                player.Play();       //Reproduce el sonido del objeto creado.
                recordFlag = false;
                record = new Audio();   //Inicializa el objeto para poder realizar una nueva grabación.
            }
            else
            {
                MessageBox.Show("First, you must record something", "Record yourself!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRecordRec_Click_1(object sender, EventArgs e)
        {
            if (record.EnumerarDispositivos() != null)      //Verifica que existan dispositivos de entrada de audio.
            {

                if (!recordFlag)        //Si no hay una grabación en curso.
                {

                    recordPath = Path.GetTempPath();        //Obtiene la ruta de la carpeta Temp del usuario.
                    recordPath += @"iLoveEnglishAudio.wav";
                    record.Grabar(recordPath);
                    recordFlag = true;
                    playFlag = false;
                }
                else                    //Si hay una grabación en curso.
                {
                    record.Parar();
                    recordFlag = false;
                    playFlag = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmHelp objFrm = new frmHelp(3);
            objFrm.Show();
        }

        
    }
}
