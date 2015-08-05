/* Adrián Mena Manciati
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnDailyActivities_Click_1(object sender, EventArgs e)
        {
            frmDailyActivities objFrm = new frmDailyActivities();
            objFrm.Show();
        }        

        private void btnTransportation_Click_1(object sender, EventArgs e)
        {
            frmModesOfTransportation objFrm = new frmModesOfTransportation();
            objFrm.Show();
        }

        private void btnOccupations_Click(object sender, EventArgs e)
        {
            frmOccupations objFrm = new frmOccupations();
            objFrm.Show();
        }

        private void btnSports_Click(object sender, EventArgs e)
        {
            frmSports objFrm = new frmSports();
            objFrm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }


    }
}
