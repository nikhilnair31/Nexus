using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Web;
using Microsoft.Office.Interop.Excel;

namespace TestX
{
    public partial class FrmSalesOrder : Form
    {
        public FrmMain FM;
        string connectionString = @"Server=localhost; Database=projectdb; Uid=root; Pwd=abcXYZ@123";
        bool spwAdded = false;
        int le, id = 0;
        float sqm, value = float.NaN;
        float ta = 0;
        float l, h, w, q, u, s;
        string btnsotxt;

        public FrmSalesOrder()
        {
            InitializeComponent();
            //Pass();
            ClearAll();
            LoadcbSO();
            AssignSONum();
            LoadProdGroups();
            LoadCustNames();
            LoadUoM();
            //_woCurStatus.SelectedIndex = 0;
            _woGenStatus.SelectedIndex = 1;
        }

        void Pass()
        {
            var lines = File.ReadLines(@"C:\ERP\test.txt");
            foreach (var line in lines)
            {
                Console.WriteLine("line IS : " + line + "\n");
                string decSt = Decrypt(line);
                Console.WriteLine("decSt IS : " + decSt + "\n");
                Console.WriteLine("connectionString + decSt IS : " + (connectionString+decSt) + "\n");
                if (checkConnection(connectionString + decSt) == true)
                {
                    connectionString += decSt;
                }
            }
            Console.WriteLine("DECRYPTED IS : " + Encrypt("abcXYZ@123") + "\n");
        }

        public bool checkConnection(string conn)
        {
            bool result = false;
            MySqlConnection connection = new MySqlConnection(conn);
            try
            {
                connection.Open();
                result = true;
                connection.Close();
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static string Encrypt(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        public string Decrypt(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }

        void AssignSONum()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    //Auto assigns SO Number by previous SO Number
                    int le = cbSONum.Items.Count - 1;
                    string s = cbSONum.Items[le].ToString();
                    s = s.Substring(2);
                    if (float.TryParse(s, out value))
                    {
                        float num = float.TryParse(s, out value) ? float.Parse(s) : 0;
                        labelSONum.Text = "SO" + (++num);
                        cbSONum.Text = labelSONum.Text;
                    }
                    else
                    {
                        //Auto assigns SO Number by table count
                        mysqlCon.Open();
                        MySqlCommand mysqlCmd = new MySqlCommand("SELECT COUNT(*) FROM pswotable", mysqlCon);
                        le = Convert.ToInt32(mysqlCmd.ExecuteScalar());
                        labelSONum.Text = "SO" + (++le);
                        cbSONum.Text = labelSONum.Text;
                        mysqlCon.Close();
                    }
                }
                catch
                {
                    //Auto assigns SO Number by table count
                    mysqlCon.Open();
                    MySqlCommand mysqlCmd = new MySqlCommand("SELECT COUNT(*) FROM pswotable", mysqlCon);
                    le = Convert.ToInt32(mysqlCmd.ExecuteScalar());
                    labelSONum.Text = "SO" + (++le);
                    cbSONum.Text = labelSONum.Text;
                    mysqlCon.Close();
                }
            }
        }

        private void LoadProdGroups()
        {
            cbProdGroup.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT prodGroup FROM producttable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbProdGroup.Items.Count; i++)
                    {
                        if (cbProdGroup.Items[i].ToString() == reader.GetString(0))
                        {
                            cond = false;
                            break;
                        }
                        else
                        {
                            cond = true;
                        }
                    }
                    if (cond == true)
                    {
                        //Console.WriteLine("Added : " + reader.GetString(0));
                        cbProdGroup.Items.Add(reader.GetString(0));
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void LoadCustNames()
        {
            cbCustName.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT DISTINCT custName FROM customertable WHERE custsupp = 'customer' ", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbCustName.Items.Add(reader.GetString(0));
                }
            }
        }

        private void LoadUoM()
        {
            cbUoM.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT DISTINCT prodUOM FROM producttable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbUoM.Items.Add(reader.GetString(0));
                }
            }
        }

        private void LoadcbSO()
        {
            cbSONum.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT soNum FROM pswotable WHERE soNum <> ''", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbSONum.Items.Add(reader.GetString(0));
                }
                mysqlCon.Close();
            }
        }

        void ClearAll()
        {
            labelSONum.Text = cbSONum.Text = cbSONum.Text = cbCustName.Text = _txtProjName.Text = _txtPONum.Text = "";
            _txtBasicValue.Text = cbProdGroup.Text = "";
            //_woCurStatus.SelectedIndex = 0;
            _woGenStatus.SelectedIndex = 1;
            ClearBottom();
        }

        void ClearBottom()
        {
            cbProdGroup.Text = cbProductName.Text = txtProdCode.Text = txtDetails.Text = cbUoM.Text = "";
            txtSpecialNotes.Text = txtSQM.Text = txtQuantity.Text = txtTotalAmount.Text = "";
            txtLength.Text = txtHeight.Text = txtWidth.Text = cbColor.Text = txtUnitRate.Text = "";
            id = 0;
            if(chkboxEdit.Checked == false)
                btnSOAddProd.Text = "Insert Item";
        }

        void GridEmpty()
        {
            soGrid.DataSource = null;
            soGrid.Rows.Clear();
        }

        void Reload(ComboBox cbText)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM salesordertable WHERE soNum = '" + cbText.Text + "'", mysqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                soGrid.DataSource = table;
                soGrid.Columns[0].Visible = false;
                soGrid.Columns[1].Visible = false;
                soGrid.Columns[2].Visible = false;
                soGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                labelSONum.Text = cbText.Text;
                adapter.Dispose();
                mysqlCon.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //GridFill();
            cbSONum.Items.Clear();
            Reload(cbSONum);
            LoadcbSO();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd1 = new MySqlCommand(" DELETE FROM salesordertable WHERE id = '" + id + "' ", mysqlCon);
                mysqlCmd1.ExecuteNonQuery();
                Reload(cbSONum);
                mysqlCon.Close();
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd1 = new MySqlCommand(" DELETE FROM pswotable WHERE soNum like '%" + cbSONum.Text + "%'; DELETE FROM salesordertable WHERE soNum like '%" + cbSONum.Text + "%'", mysqlCon);
                mysqlCmd1.ExecuteNonQuery();
                cbSONum.Text = "";
                cbSONum.Items.Clear();
                LoadcbSO();
                GridEmpty();
                mysqlCon.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            soGrid.ReadOnly = false;
            btnSOAddProd.Text = "Update Values";
        }

        private void cbSONum_SelectedIndexChanged(object sender, EventArgs e)
        {
            spwAdded = true;
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM salesordertable WHERE CONCAT(`soNum`) like '%" + cbSONum.Text + "%'", mysqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                soGrid.DataSource = table;
                soGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                soGrid.Columns[0].Visible = false;
                soGrid.Columns[1].Visible = false;
                soGrid.Columns[2].Visible = false;
                labelSONum.Text = cbSONum.Text;

                MySqlCommand command1 = new MySqlCommand("SELECT * FROM pswotable WHERE CONCAT(`soNum`) like '%" + cbSONum.Text + "%'", mysqlCon);
                MySqlDataReader dbRead = command1.ExecuteReader();
                if (dbRead.Read())
                {
                    _dtpSODate.Text = dbRead.GetString("soDate");
                    cbCustName.Text = dbRead.GetString("customerName");
                    _txtProjName.Text = dbRead.GetString("projectName");
                    _txtPONum.Text = dbRead.GetString("poNum");
                    _dtpPODate.Text = dbRead.GetString("poDate");
                    _dtpPODDate.Text = dbRead.GetString("poDispatchDate");
                    _dtpPCDATE.Text = dbRead.GetString("plannedCompDate");
                    _dtpACDate.Text = dbRead.GetString("actCompDate");
                    _dtpDODate.Text = dbRead.GetString("dispatchDate");
                    _txtBasicValue.Text = dbRead.GetString("basicValue");
                    //_woCurStatus.Text = dbRead.GetString("woCurStatus");
                    _woGenStatus.Text = dbRead.GetString("woGenStatus");
                }
                adapter.Dispose();
                mysqlCon.Close();
            }
            ClearBottom();
        }

        private void soGrid_DoubleClick(object sender, EventArgs e)
        {
            if (soGrid.ReadOnly == false)
            {
                cbProdGroup.Text = soGrid.CurrentRow.Cells[3].Value.ToString();
                txtProdCode.Text = soGrid.CurrentRow.Cells[2].Value.ToString();
                cbProductName.Text = soGrid.CurrentRow.Cells[4].Value.ToString();
                cbUoM.Text = soGrid.CurrentRow.Cells[5].Value.ToString();
                txtDetails.Text = soGrid.CurrentRow.Cells[6].Value.ToString();
                txtSpecialNotes.Text = soGrid.CurrentRow.Cells[7].Value.ToString();
                cbColor.Text = soGrid.CurrentRow.Cells[8].Value.ToString();
                txtLength.Text = soGrid.CurrentRow.Cells[9].Value.ToString();
                txtWidth.Text = soGrid.CurrentRow.Cells[10].Value.ToString();
                txtHeight.Text = soGrid.CurrentRow.Cells[11].Value.ToString();
                txtSQM.Text = soGrid.CurrentRow.Cells[12].Value.ToString();
                txtQuantity.Text = soGrid.CurrentRow.Cells[13].Value.ToString();
                txtUnitRate.Text = soGrid.CurrentRow.Cells[14].Value.ToString();
                txtTotalAmount.Text = soGrid.CurrentRow.Cells[15].Value.ToString();

                id = Convert.ToInt32(soGrid.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            GridEmpty();
        }

        private void _cmdPrint_Click(object sender, EventArgs e)
        {
            FrmReport FR = new FrmReport();
            FR.Show();
        }

        private void cbProdGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProductName.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand cmd = new MySqlCommand(" SELECT * FROM producttable WHERE prodGroup = '"+ cbProdGroup.Text +"' ", mysqlCon);
                MySqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    cbProductName.Items.Add(dr1.GetString("prodName"));
                }
                mysqlCon.Close();
            }
        }

        private void cbProductName_SelectedIndexChanged(object sender, EventArgs e) => SetTxtVisStuff();

        private void btnClose_Click(object sender, EventArgs e)
        {
            FM.Show();
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
                GridEmpty();
                string sonum = (cbSONum.Items[cbSONum.Items.Count - 1].ToString());
                sonum = sonum.Substring(sonum.Length - 1);
                int x = int.Parse(sonum);
                Console.WriteLine(sonum);
                labelSONum.Text = "SO" + (x + 1);
                cbSONum.Text = labelSONum.Text;
                spwAdded = false;
            }
            catch
            {
                MessageBox.Show("oops");
            }
        }

        void FillSheetwithGrid(Excel.Application xlApp)
        {
            try
            {
                object misValue = System.Reflection.Missing.Value;
                xlApp.Visible = true;
                Workbook workbook = xlApp.Workbooks.Add(misValue);
                Worksheet worksheet1 = workbook.Sheets[1];
                worksheet1 = workbook.Worksheets.get_Item(1);
                worksheet1.Name = cbSONum.Text;
                for (int i = 0; i <= soGrid.ColumnCount - 1; i++)
                {
                    worksheet1.Cells[1, i + 1] = soGrid.Columns[i].Name;
                }
                for (int i = 0; i <= soGrid.RowCount - 1; i++)
                {
                    for (int j = 0; j <= soGrid.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = soGrid[j, i];
                        worksheet1.Cells[i + 2, j + 1] = cell.Value;
                    }
                }
                worksheet1.Columns["A"].Delete();
                worksheet1.Columns.AutoFit();
                worksheet1.Rows.AutoFit();
                workbook.SaveAs(@"C:\ERP\WorkOrder.xls", XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlApp.Workbooks.Close();
                xlApp.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some Excel export error : " + ex.Message);
            }
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            else
            {
                FillSheetwithGrid(xlApp);
            }
        }

        private void btnSOAddProd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbSONum.Text) || String.IsNullOrEmpty(cbCustName.Text) || String.IsNullOrEmpty(_txtProjName.Text) || String.IsNullOrEmpty(_txtPONum.Text) 
                || String.IsNullOrEmpty(cbProdGroup.Text) || String.IsNullOrEmpty(txtLength.Text) || String.IsNullOrEmpty(txtSQM.Text) || String.IsNullOrEmpty(txtQuantity.Text) || String.IsNullOrEmpty(txtUnitRate.Text))
            {
                MessageBox.Show("cbSONum, cbCustName, _txtProjName, _txtPONum, cbProdGroup, txtLength, txtSQM, txtQuantity or txtUnitRate missing?");
            }
            else
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    if (spwAdded == false)
                    {
                        MySqlCommand mysqlCmd1 = new MySqlCommand("PSWOAddorEdit", mysqlCon);
                        mysqlCmd1.CommandType = CommandType.StoredProcedure;
                        mysqlCmd1.Parameters.AddWithValue("_id", id);
                        mysqlCmd1.Parameters.AddWithValue("_soNum", cbSONum.Text);
                        mysqlCmd1.Parameters.AddWithValue("_soDate", _dtpSODate.Text.Trim());
                        mysqlCmd1.Parameters.AddWithValue("_custName", cbCustName.Text.Trim());
                        mysqlCmd1.Parameters.AddWithValue("_projName", _txtProjName.Text.Trim());
                        mysqlCmd1.Parameters.AddWithValue("_poNum", _txtPONum.Text.Trim());
                        mysqlCmd1.Parameters.AddWithValue("_poDate", _dtpPODate.Text.Trim());
                        mysqlCmd1.Parameters.AddWithValue("_poDispatchDate", _dtpPODDate.Text.Trim());
                        mysqlCmd1.Parameters.AddWithValue("_plannedCompDate", _dtpPCDATE.Text.Trim());
                        mysqlCmd1.Parameters.AddWithValue("_actCompDate", _dtpACDate.Text.Trim());
                        mysqlCmd1.Parameters.AddWithValue("_dispatchDate", _dtpDODate.Text.Trim());
                        mysqlCmd1.Parameters.AddWithValue("_pickinglistGenStatus", "NOT GENERATED");
                        mysqlCmd1.Parameters.AddWithValue("_woCurStatus", "NOT GENERATED");
                        mysqlCmd1.Parameters.AddWithValue("_woGenStatus", _woGenStatus.Text.Trim());
                        mysqlCmd1.Parameters.AddWithValue("_poGenStatus", "NOT GENERATED");
                        mysqlCmd1.Parameters.AddWithValue("_woNum", "-");
                        mysqlCmd1.Parameters.AddWithValue("_woDate", "-");
                        mysqlCmd1.Parameters.AddWithValue("_basicValue", float.TryParse(_txtBasicValue.Text.Trim(), out value) ? float.Parse(_txtBasicValue.Text) : 0);
                        mysqlCmd1.ExecuteNonQuery();
                        MessageBox.Show("Added to SPW Table");
                        spwAdded = true;
                    }
                    MySqlCommand mysqlCmd2 = new MySqlCommand("SOAddorEdit", mysqlCon);
                    mysqlCmd2.CommandType = CommandType.StoredProcedure;
                    mysqlCmd2.Parameters.AddWithValue("_id", id);
                    mysqlCmd2.Parameters.AddWithValue("_soNum", cbSONum.Text);
                    mysqlCmd2.Parameters.AddWithValue("_productGroup", cbProdGroup.Text);
                    mysqlCmd2.Parameters.AddWithValue("_productCode", txtProdCode.Text);
                    mysqlCmd2.Parameters.AddWithValue("_productName", cbProductName.Text.Trim());
                    mysqlCmd2.Parameters.AddWithValue("_uom", cbUoM.Text.Trim());
                    mysqlCmd2.Parameters.AddWithValue("_deets", txtDetails.Text.Trim());
                    mysqlCmd2.Parameters.AddWithValue("_specNotes", txtSpecialNotes.Text.Trim());
                    mysqlCmd2.Parameters.AddWithValue("_col", cbColor.Text.Trim());
                    mysqlCmd2.Parameters.AddWithValue("_l", float.TryParse(txtLength.Text.Trim(), out value) ? float.Parse(txtLength.Text) : 0);
                    mysqlCmd2.Parameters.AddWithValue("_h", float.TryParse(txtHeight.Text.Trim(), out value) ? float.Parse(txtHeight.Text) : 0);
                    mysqlCmd2.Parameters.AddWithValue("_w", float.TryParse(txtWidth.Text.Trim(), out value) ? float.Parse(txtWidth.Text) : 0);
                    mysqlCmd2.Parameters.AddWithValue("_totalSQM", float.TryParse(txtSQM.Text.Trim(), out value) ? float.Parse(txtSQM.Text) : 0);
                    mysqlCmd2.Parameters.AddWithValue("_quant", float.TryParse(txtQuantity.Text.Trim(), out value) ? float.Parse(txtQuantity.Text) : 1);
                    mysqlCmd2.Parameters.AddWithValue("_rate", float.TryParse(txtUnitRate.Text.Trim(), out value) ? float.Parse(txtUnitRate.Text) : 0);
                    mysqlCmd2.Parameters.AddWithValue("_totAmt", float.TryParse(txtTotalAmount.Text.Trim(), out value) ? float.Parse(txtTotalAmount.Text) : 0);
                    mysqlCmd2.ExecuteNonQuery();
                    //soGrid.ReadOnly = true;
                    if (btnSOAddProd.Text == "Insert")
                        MessageBox.Show("Products added to SO Table");
                    else
                        MessageBox.Show("Products updated in SO Table");
                    cbSONum.Items.Clear();
                    LoadcbSO();
                    cbCustName.Items.Clear();
                    LoadCustNames();
                    Reload(cbSONum);
                    //ClearBottom();
                    mysqlCon.Close();
                }
            }
        }

        private void txtWidth_TextChanged(object sender, EventArgs e) => DoMathonChange();

        private void txtLength_TextChanged(object sender, EventArgs e) => DoMathonChange();

        private void txtQuantity_TextChanged(object sender, EventArgs e) => DoMathonChange();

        private void txtHeight_TextChanged(object sender, EventArgs e) => DoMathonChange();

        private void txtUnitRate_TextChanged(object sender, EventArgs e) => DoMathonChange();

        private void cbUoM_TextChanged(object sender, EventArgs e)
        {
            if (cbUoM.Text == "Rmt" || cbUoM.Text == "LM" || cbUoM.Text == "Pc" || cbUoM.Text == "Nos")
            {
                lblSQM.Visible = false;
                txtSQM.Visible = false;
                txtSQM.Text = "0";
            }
            else
            {
                lblSQM.Visible = true;
                txtSQM.Visible = true;
            }
        }

        private void btnEditPSWO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update PSWO Table in WO Form.");
        }

        private void chkboxEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (soGrid.ReadOnly == true)
            {
                soGrid.ReadOnly = false;
                btnsotxt = btnSOAddProd.Text;
                btnSOAddProd.Text = "Update Values";
                chkboxEdit.BackColor = Color.IndianRed;
            }
            else if (soGrid.ReadOnly == false)
            {
                soGrid.ReadOnly = true;
                btnSOAddProd.Text = btnsotxt;
                chkboxEdit.BackColor = Color.White;
                id = 0;
            }
        }

        void ResetRight()
        {
            lblLength.Visible = true;
            lblLength.Text = "Length";
            txtLength.Visible = true;

            lblHeight.Visible = true;
            lblHeight.Text = "Height";
            txtHeight.Visible = true;

            lblWidth.Visible = true;
            lblWidth.Text = "Width";
            txtWidth.Visible = true;

            lblSQM.Visible = true;
            lblSQM.Text = "SQM";
            txtSQM.Visible = true;

            lblQuantity.Visible = true;
            lblQuantity.Text = "Quantity";
            txtQuantity.Visible = true;

            lblUnitRate.Visible = true;
            lblUnitRate.Text = "Unit Rate";
            txtUnitRate.Visible = true;

            lblTotalAmount.Visible = true;
            lblTotalAmount.Text = "Tot Amt";
            txtTotalAmount.Visible = true;
        }

        void DoMathonChange()
        {
            //Console.WriteLine("entered DoMathonChange");
            l = float.TryParse(txtLength.Text.Trim(), out value) ? float.Parse(txtLength.Text) : 0;
            h = float.TryParse(txtHeight.Text.Trim(), out value) ? float.Parse(txtHeight.Text) : 0;
            w = float.TryParse(txtWidth.Text.Trim(), out value) ? float.Parse(txtWidth.Text) : 0;
            q = float.TryParse(txtQuantity.Text.Trim(), out value) ? float.Parse(txtQuantity.Text) : 0;
            u = float.TryParse(txtUnitRate.Text.Trim(), out value) ? float.Parse(txtUnitRate.Text) : 0;
            s = float.TryParse(txtSQM.Text.Trim(), out value) ? float.Parse(txtSQM.Text) : 0;
            //ResetRight();
            switch (cbProdGroup.Text)
            {
                case "GRILLE":
                    GDL();
                    break;
                case "DIFFUSER":
                    DR();
                    break;
                case "SLOT DIFFUSER":
                    SDHD();
                    break;
                case "ROUND":
                    DR();
                    break;
                case "DAMPER":
                    GDL();
                    break;
                case "HM DAMPER":
                    SDHD();
                    break;
                case "LOUVER":
                    GDL();
                    break;
                case "SS PLENUM":
                    //idk
                    break;
                case "DS PLENUM":
                    DPSA();
                    break;
                case "SOUND ATTENUATOR":
                    DPSA();
                    break;
                case "AHU":
                    //idk
                    break;
                default:
                    Console.WriteLine("entered default");
                    break;
            }
        }

        void SetTxtVisStuff()
        {
            Console.WriteLine("SetTxtVisStuff");
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand cmd = new MySqlCommand(" SELECT * FROM producttable WHERE prodGroup = '" + cbProdGroup.Text + "' AND prodName = '" + cbProductName.Text + "' ", mysqlCon);
                MySqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    Console.WriteLine("prodID > "+ dr1.GetString("prodID"));
                    txtProdCode.Text = dr1.GetString("prodID");

                    //Console.WriteLine("\n" + dr1.GetString("lblLengthTxt") + " | " + dr1.GetString("txtLengthTxt") + " | " + dr1.GetBoolean("LengthVis"));
                    lblLength.Text = dr1.GetString("lblLengthTxt");
                    lblLength.Visible = dr1.GetBoolean("LengthVis");
                    txtLength.Visible = dr1.GetBoolean("LengthVis");
                    txtLength.Text = dr1.GetString("txtLengthTxt");

                    //Console.WriteLine(dr1.GetString("lblWidthTxt") + " - " + dr1.GetString("txtWidthTxt") + " - " + dr1.GetBoolean("WidthVis"));
                    lblWidth.Text = dr1.GetString("lblWidthTxt");
                    lblWidth.Visible = dr1.GetBoolean("WidthVis");
                    txtWidth.Visible = dr1.GetBoolean("WidthVis");
                    txtWidth.Text = dr1.GetString("txtWidthTxt");

                    //Console.WriteLine(dr1.GetString("lblHeightTxt") + " / " + dr1.GetString("txtHeightTxt") + " / " + dr1.GetBoolean("HeightVis"));
                    lblHeight.Text = dr1.GetString("lblHeightTxt");
                    lblHeight.Visible = dr1.GetBoolean("HeightVis");
                    txtHeight.Visible = dr1.GetBoolean("HeightVis");
                    txtHeight.Text = dr1.GetString("txtHeightTxt");

                    cbUoM.Text = dr1.GetString("prodUOM");
                }
                mysqlCon.Close();
            }
        }

        void GDL()
        {
            Console.WriteLine("GDL");
            if (cbUoM.Text == "Sqm")
            {
                sqm = (l * h) / 1000000;
                if (sqm < 0.1f)
                {
                    sqm = 0.1f;
                }
                txtSQM.Text = sqm.ToString();
                ta = sqm * u * q;
                txtTotalAmount.Text = ta.ToString();
            }
            else if (cbUoM.Text == "LM" || cbUoM.Text == "Rmt")
            {
                ta = (l / 1000) * u * q;
                txtTotalAmount.Text = ta.ToString();
            }
            else if (cbUoM.Text == "Pc" || cbUoM.Text == "Nos")
            {
                ta = u * q;
                txtTotalAmount.Text = ta.ToString();
            }
        }

        void DR()
        {
            Console.WriteLine("DR");
            if (cbUoM.Text == "Sqm")
            {
                if (sqm < 0.1f)
                {
                    sqm = (l * l) / 1000000;
                    sqm = 0.1f;
                }
                txtSQM.Text = sqm.ToString();
                ta = sqm * u * q;
                txtTotalAmount.Text = ta.ToString();
            }
            else if (cbUoM.Text == "LM" || cbUoM.Text == "Rmt")
            {
                ta = (l / 1000) * u * q;
                txtTotalAmount.Text = ta.ToString();
            }
            else if (cbUoM.Text == "Pc" || cbUoM.Text == "Nos")
            {
                ta = u * q;
                txtTotalAmount.Text = ta.ToString();
            }
        }

        void SDHD()
        {
            Console.WriteLine("SDHD");
            if (cbUoM.Text == "Sqm")
            {
                txtTotalAmount.Text = "N/A";
            }
            else if (cbUoM.Text == "LM" || cbUoM.Text == "Rmt")
            {
                //l *= s;
                ta = q * u * (l / 1000);
                txtTotalAmount.Text = ta.ToString();
            }
            else if (cbUoM.Text == "Pc" || cbUoM.Text == "Nos")
            {
                ta = u * q;
                txtTotalAmount.Text = ta.ToString();
            }
        }

        void DPSA()
        {
            Console.WriteLine("DPSA");
            if (cbUoM.Text == "Sqm")
            {
                sqm = ((h + l) * 2 * w + (h * l) * 2) / 1000000;
                if (sqm < 0.1f)
                {
                    sqm = 0.1f;
                }
                txtSQM.Text = sqm.ToString();
                ta = sqm * u * q;
                txtTotalAmount.Text = ta.ToString();
            }
            else if (cbUoM.Text == "LM" || cbUoM.Text == "Rmt")
            {
                txtTotalAmount.Text = "N/A";
            }
            else if (cbUoM.Text == "Pc" || cbUoM.Text == "Nos")
            {
                ta = u * q;
                txtTotalAmount.Text = ta.ToString();
            }
        }
    }
}
