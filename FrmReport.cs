using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestX
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            Nexus.CrystalReports.cr1 crpt = new Nexus.CrystalReports.cr1();
            crpViewer.ReportSource = null;
            crpViewer.ReportSource = crpt;
        }
    }
}

