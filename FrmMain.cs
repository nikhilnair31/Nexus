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
    public partial class FrmMain : Form
    {
        //private static readonly FrmMain frmMain;

        public FrmMain()
        {
            InitializeComponent();
            InitializeTimer();
            dateLabel.Text = DateTime.Now.ToString("MMMM dd yyyy");
        }

        private void _ToolStripButton1_Click(object sender, EventArgs e)
        {
            FrmPurchaseOrder FPO = new FrmPurchaseOrder();
            FPO.FM = this;
            FPO.Show();
        }

        private void _time_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void InitializeTimer()
        {
            _Timer1.Interval = 1000;
            _Timer1.Tick += new EventHandler(_time_Tick);
            _Timer1.Enabled = true;
        }

        private void _ToolStripButton2_Click(object sender, EventArgs e)
        {
            FrmManHours MH = new FrmManHours();
            MH.Show();
        }

        private void _EmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployee FE = new FrmEmployee();
            FE.Show();
        }

        private void _CustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomers FC = new FrmCustomers();
            FC.Show();
        }

        private void _ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducts FP = new FrmProducts();
            FP.Show();
            //this.Visible = false;
        }

        private void _ToolStripButton3_Click(object sender, EventArgs e)
        {
            FrmWorkOrder FWO = new FrmWorkOrder();
            FWO.FM = this;
            FWO.Show();
        }

        private void _RawMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRawMaterial RM = new FrmRawMaterial();
            RM.Show();
        }

        private void _ToolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void _ToolStripButton4_Click(object sender, EventArgs e)
        {
            FrmIssue fi = new FrmIssue();
            fi.Show();
        }

        private void _ToolStripButton5_Click(object sender, EventArgs e)
        {
            FrmSalesOrder FSO = new FrmSalesOrder();
            FSO.FM = this;
            FSO.Show();
        }

        private void _ToolStripButton6_Click(object sender, EventArgs e)
        {
            FrmPurchaseOrder FPO = new FrmPurchaseOrder();
            FPO.FM = this;
            FPO.Show();
        }

        private void _ToolStripButton7_Click(object sender, EventArgs e)
        {
            FrmPurchaseOrderProposal FPOP = new FrmPurchaseOrderProposal();
            FPOP.FM = this;
            FPOP.Show();
        }
    }
}
