/* 
 * Adrián Mena Manciati
 * Fecha: 30-07-2015
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AxShockwaveFlashObjects;
using ShockwaveFlashObjects;

namespace WinProjectEnglish
{
    public partial class frmHelp : Form
    {
        private int nAct;
        private string mPath;
        

        public frmHelp()
        {
            InitializeComponent();
            mPath = "";
        }

        public frmHelp(int act)
        {
            InitializeComponent();
            mPath = "";
            nAct = act;
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            
            switch (nAct)
            {
                 
                case 1:
                    //mPath = System.Environment.CurrentDirectory;
                    //mPath += @"\Media\Animation\Help_3\interaction.swf";
                    ////swfHelp = new AxShockwaveFlash();
                    //swfHelp.LoadMovie(0, mPath);
                    break;
                case 2:
                    //mPath = System.Environment.CurrentDirectory;
                    //mPath += @"\Media\Animation\Help_3\interaction.swf";
                    ////swfHelp = new AxShockwaveFlash();
                    //swfHelp.LoadMovie(0, mPath);
                    break;
                case 3:
                    mPath = System.Environment.CurrentDirectory;
                    mPath += @"\Media\Animation\Help_3\interaction.swf";
                    //swfHelp = new AxShockwaveFlash();
                    swfHelp.LoadMovie(0, mPath); 
                    break;
                case 4:
                    break;
                default:
                    break;

            }

            swfHelp.Play();
        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            swfHelp.Stop();
            this.Close();
        }
    }
}
