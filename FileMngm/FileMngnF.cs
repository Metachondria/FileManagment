using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileMngm
{
    public partial class frmFileMngm : Form
    {
        CFileMngm FM = new CFileMngm();
        FileMngmSDS FMSDS = new FileMngmSDS();
        FileMngnHSH FMHSH = new FileMngnHSH();
        FileMngmES FMES = new FileMngmES();
        public frmFileMngm()
        {
            InitializeComponent();

            dgErr.Visible = false;            
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (odCars.ShowDialog() == DialogResult.OK)
                FM.Convert(odCars.FileName, dgErr);
        } 
        private void btnShow_Click(object sender, EventArgs e)
        {
            // if (odCars.ShowDialog() == DialogResult.OK)
                // FM.Load(odCars.FileName, dgCars);
                FM.Load("Cars.dat", dgCars);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            FMSDS.FileSort("Cars.dat");
            FM.Load("Cars.dat", dgCars);
        }

        private void btnDSearch_Click(object sender, EventArgs e)
        {
            //lblDS.Text = FMSDS.DSearch("Cars.dat", "220NISSAN ALMERA                 1,4").ToString();
            //lblDS.Text = FMSDS.DSearch("Cars.dat", "200KIA Sportage                  2,3").ToString();
            lblDS.Text = FMSDS.DSearch("Cars.dat", binarySearchInput.Text).ToString();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            //lblHash.Text = FMHSH.Hash("Nissan Almera").ToString();
            //lblHash.Text = FMHSH.Hash("NISSAN ALMERA").ToString();
            //lblHash.Text = FMHSH.Hash("СмолГУ").ToString();
            FMHSH.CreHSH("Cars.dat", dgErr);
            FM.Load("Cars.hsh", dgCars);
            //lblDS.Text = FMHSH.HSearch("Cars.hsh", "220Nissan Almera                 1,8");
            //lblDS.Text = FMHSH.HSearch("Cars.hsh", "200KIA Sportage                  2,3");
            lblDS.Text = FMHSH.HSearch("Cars.hsh", binarySearchInput.Text);
        }

        private void btnExtSort_Click(object sender, EventArgs e)
        {
            FMES.Divide("Cars.dat");
            lblDS.Text = FMES.Merge();
        }
    }
}