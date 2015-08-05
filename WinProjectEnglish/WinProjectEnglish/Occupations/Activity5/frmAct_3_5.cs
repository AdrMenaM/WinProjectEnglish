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
    public partial class frmAct_3_5 : Form
    {

        public Activity5 objAct5 = new Activity5();

        public frmAct_3_5()
        {
            InitializeComponent();
        }

        private void frmAct_2_5_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int a = rand.Next(1, 3);
            if (a == 1)
            {
                grbParagraph1.Enabled = true;
                grbParagraph1.Visible = true;
                txtA.Focus();
            }
            else
            {
                grbParagraph2.Enabled = true;
                grbParagraph2.Visible = true;
                txtA2.Focus();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (grbParagraph1.Enabled)
            {
                frmResult_Act5 objresult = new frmResult_Act5(objAct5.calculateAnswers(txtA, txtB, txtC, txtD, txtE, lblA, lblB, lblC, lblD, lblE, picTick1, picTick2, picTick3, picTick4, picTick5, picCross1, picCross2, picCross3, picCross4, picCross5));
                objresult.Show();
                objresult.BackColor=Color.MediumTurquoise;
                grbParagraph1.Enabled = false;
                //objAct5.LockData(txtA, txtB, txtC, txtD, txtE, btnFinish);
                btnNext.Enabled = true;
                btnFinish.Enabled = false;
            }
            else if (grbParagraph2.Enabled)
            {
                frmResult_Act5 objresult = new frmResult_Act5(objAct5.calculateAnswers(txtA2, txtB2, txtC2, txtD2, txtE2, lblA2, lblB2, lblC2, lblD2, lblE2, picTick_1, picTick_2, picTick_3, picTick_4, picTick_5, picCross_1, picCross_2, picCross_3, picCross_4, picCross_5));
                objresult.Show();
                grbParagraph2.Enabled = false;
                //objAct5.LockData(txtA2, txtB2, txtC2, txtD2, txtE2, btnFinish);
                btnNext.Enabled = true;
                btnFinish.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Focus();
            if(grbParagraph1.Visible)
            {
                grbParagraph1.Enabled = true;
                objAct5.InitializeData(txtA, txtB, txtC, txtD, txtE, picTick1, picTick2, picTick3, picTick4, picTick5, picCross1, picCross2, picCross3, picCross4, picCross5);
                btnFinish.Enabled = true;
                txtA.Focus();
                btnNext.Enabled = false;
            }
            else if (grbParagraph2.Visible)
            {
                grbParagraph2.Enabled = true;
                objAct5.InitializeData(txtA2, txtB2, txtC2, txtD2, txtE2, picTick_1, picTick_2, picTick_3, picTick_4, picTick_5, picCross_1, picCross_2, picCross_3, picCross_4, picCross_5);
                btnFinish.Enabled = true;
                txtA2.Focus();
                btnNext.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (grbParagraph1.Visible)
            {
                objAct5.InitializeData(txtA2, txtB2, txtC2, txtD2, txtE2, picTick_1, picTick_2, picTick_3, picTick_4, picTick_5, picCross_1, picCross_2, picCross_3, picCross_4, picCross_5);
                grbParagraph1.Enabled = false;
                grbParagraph1.Visible = false;
                grbParagraph2.Enabled = true;
                grbParagraph2.Visible = true;
                btnNext.Enabled = false;
                btnFinish.Enabled = true;
            }
            else if(grbParagraph2.Visible)
            {
                objAct5.InitializeData(txtA, txtB, txtC, txtD, txtE, picTick1, picTick2, picTick3, picTick4, picTick5, picCross1, picCross2, picCross3, picCross4, picCross5);
                grbParagraph1.Enabled = true;
                grbParagraph1.Visible = true;
                grbParagraph2.Enabled = false;
                grbParagraph2.Visible = false;
                btnNext.Enabled = false; 
                btnFinish.Enabled = true;
            }
        }
    }
}
