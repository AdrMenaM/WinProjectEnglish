/* 
 * Creado por: Diego Terán
 * Fecha: 14-07-2015
 * Editado por: Adrián Mena Manciati
 * Fecha: 28-07-2015
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

namespace WinProjectEnglish
{
    public partial class frmResult : Form
    {
        private int mCorrect;
        private string mTotal;
        private SoundPlayer sound;
        private string mPath;

        public frmResult()
        {
            InitializeComponent();
        }

        public frmResult(int Correct)
        {
            mCorrect = Correct;
            InitializeComponent();

        }

        public frmResult(int Correct, string Total)
        {
            mCorrect = Correct;
            
            InitializeComponent();
            mTotal = Total;
        }

        private void frmResult_Act4_Load(object sender, EventArgs e)
        {
            lblTotal.Text = mTotal;
            txtResult.Text = mCorrect.ToString();

            mPath = System.Environment.CurrentDirectory;

            if (mCorrect ==int.Parse(mTotal) || mCorrect == (int.Parse(mTotal)-1))
            {
                picCongrats1.Visible = true;
                picCongrats2.Visible = true;
                
                mPath += @"\Media\Audio\Result\Winner.wav";
                //Se usa un objeto SoundPlayer que permite reproducir archivos .wav 
                sound = new SoundPlayer(mPath);
                sound.Play();       //Reproduce el sonido del objeto creado.

            }
            else if (mCorrect == 0)
            {
                picRetry1.Visible = true;
                mPath += @"\Media\Audio\Result\Ohh.wav";
                //Se usa un objeto SoundPlayer que permite reproducir archivos .wav 
                sound = new SoundPlayer(mPath);
                sound.Play();       //Reproduce el sonido del objeto creado.

                
            }
            else
            {
                picMid1.Visible = true;
                lblTryAgain.Visible = true;
                mPath += @"\Media\Audio\Result\TryAgain.wav";
                //Se usa un objeto SoundPlayer que permite reproducir archivos .wav 
                sound = new SoundPlayer(mPath);
                sound.Play();       //Reproduce el sonido del objeto creado.
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
