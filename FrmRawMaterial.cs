using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestX
{
    public partial class FrmRawMaterial : Form
    {
        string connectionString = @"Server=localhost; Database=projectdb; Uid=root; Pwd=abcXYZ@123";
        bool spwAdded = false;
        int id = 0;
        float value = float.NaN;

        public FrmRawMaterial()
        {
            InitializeComponent();
            //Pass();
            ClearAll();
            LoadNPartNum();
            LoadSPartNum();
            LoadProdGroup();
            //LoadExitDescription();
            LoadUOM();
            LoadRawMatSupplier();
            LoadFGManuf();
            LoadAT();
            LoadMOQ();
            LoadCurr();
            //Reload(cbProductGroup);
        }

        void Pass()
        {
            var lines = File.ReadLines(@"C:\ERP\test.txt");
            foreach (var line in lines)
            {
                string decSt = Decrypt(line);
                Console.WriteLine("decSt IS : " + decSt + "\n");
                Console.WriteLine("connectionString + decSt IS : " + (connectionString + decSt) + "\n");
                if (checkConnection(connectionString + decSt) == true)
                {
                    connectionString += decSt;
                }
            }
            //Console.WriteLine("DECRYPTED IS : " + Encrypt("projects123") + "\n");
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

        private void LoadCurr()
        {
            cbCurr.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT currency FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbCurr.Items.Count; i++)
                    {
                        if (cbCurr.Items[i].ToString() == reader.GetString(0))
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
                        cbCurr.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void LoadMOQ()
        {
            cbMOQ.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT MOQ FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbMOQ.Items.Count; i++)
                    {
                        if (cbMOQ.Items[i].ToString() == reader.GetString(0))
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
                        cbMOQ.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void LoadFGManuf()
        {
            cbFGManuf.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT FGManuf FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbFGManuf.Items.Count; i++)
                    {
                        if (cbFGManuf.Items[i].ToString() == reader.GetString(0))
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
                        cbFGManuf.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void LoadProdGroup()
        {
            cbProductGroup.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT prodGroup FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbProductGroup.Items.Count; i++)
                    {
                        if (cbProductGroup.Items[i].ToString() == reader.GetString(0))
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
                        cbProductGroup.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void LoadRawMatSupplier()
        {
            cbSupplier.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT supplier FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbSupplier.Items.Count; i++)
                    {
                        if (cbSupplier.Items[i].ToString() == reader.GetString(0))
                        {
                            cond = false;
                            break;
                        }
                        else
                            cond = true;
                    }
                    if (cond == true)
                    {
                        cbSupplier.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                        continue;
                }
            }
        }

        private void LoadExitDescription()
        {
            cbExitDescription.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT exitDescription FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbExitDescription.Items.Count; i++)
                    {
                        if (cbExitDescription.Items[i].ToString() == reader.GetString(0))
                        {
                            cond = false;
                            break;
                        }
                        else
                            cond = true;
                    }
                    if (cond == true)
                    {
                        cbExitDescription.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                        continue;
                }
            }
        }

        private void LoadUOM()
        {
            cbUOM.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT uom FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbUOM.Items.Count; i++)
                    {
                        if (cbUOM.Items[i].ToString() == reader.GetString(0))
                        {
                            cond = false;
                            break;
                        }
                        else
                            cond = true;
                    }
                    if (cond == true)
                    {
                        cbUOM.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                        continue;
                }
            }
        }

        private void LoadAT()
        {
            cbAT.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT rawmatAT FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbAT.Items.Count; i++)
                    {
                        if (cbAT.Items[i].ToString() == reader.GetString(0))
                        {
                            cond = false;
                            break;
                        }
                        else
                            cond = true;
                    }
                    if (cond == true)
                    {
                        cbAT.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                        continue;
                }
            }
        }

        private void LoadNPartNum()
        {
            cbNPartNum.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT nairPartNum FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbNPartNum.Items.Count; i++)
                    {
                        if (cbNPartNum.Items[i].ToString() == reader.GetString(0))
                        {
                            cond = false;
                            break;
                        }
                        else
                            cond = true;
                    }
                    if (cond == true)
                    {
                        cbNPartNum.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                        continue;
                }
            }
        }

        private void LoadSPartNum()
        {
            cbSPartNum.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT supplierPartNum FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbSPartNum.Items.Count; i++)
                    {
                        if (cbSPartNum.Items[i].ToString() == reader.GetString(0))
                        {
                            cond = false;
                            break;
                        }
                        else
                            cond = true;
                    }
                    if (cond == true)
                    {
                        cbSPartNum.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                        continue;
                }
            }
        }

        void ClearAll()
        {
            cbNPartNum.Text = cbSPartNum.Text = cbProductGroup.Text = cbExitDescription.Text = cbUOM.Text = cbSupplier.Text = "";
            cbAT.Text = txtWeightperLM.Text = txtAvgPurchPrice.Text = txtQuantity.Text = txtGST.Text = txtLandedCost.Text = txtFreightCost.Text = "";
            id = 0;
            btnAddRawMat.Text = "Add";
        }

        void GridEmpty()
        {
            rawmatGrid.DataSource = null;
            rawmatGrid.Rows.Clear();
        }

        void Reload(ComboBox cbText)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                //(" SELECT * FROM producttable WHERE prodGroup like '%" + cbProdGroup.Text + "%' AND prodName like '%" + cbProductName.Text + "%' ", mysqlCon);
                MySqlCommand command = new MySqlCommand("SELECT * FROM rawmaterialtable WHERE prodGroup = '" + cbProductGroup.Text + "' ", mysqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                rawmatGrid.DataSource = table;
                rawmatGrid.Columns[0].Visible = false;
                rawmatGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //labelSONum.Text = cbText.Text;
                adapter.Dispose();
                mysqlCon.Close();
            }
        }

        private void cbProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbExitDescription.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand cmd = new MySqlCommand(" SELECT * FROM rawmaterialtable WHERE prodGroup = '" + cbProductGroup.Text + "' ", mysqlCon);
                MySqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    cbExitDescription.Items.Add(dr1.GetString("exitDescription"));
                }
                mysqlCon.Close();
            }
            //LoadNPartNum();
            //LoadSPartNum();
            GridEmpty();
            Reload(cbProductGroup);
        }

        private void btnAddRawMat_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                if (spwAdded == false)
                {
                    MySqlCommand mysqlCmd1 = new MySqlCommand("RawMatAddorEdit", mysqlCon);
                    mysqlCmd1.CommandType = CommandType.StoredProcedure;
                    mysqlCmd1.Parameters.AddWithValue("_id", id);
                    mysqlCmd1.Parameters.AddWithValue("_nairPartNum", cbNPartNum.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_supplierPartNum", cbSPartNum.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_prodGroup", cbProductGroup.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_exitDescription", cbExitDescription.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_uom", cbUOM.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_supplier", cbSupplier.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_FGManuf", cbFGManuf.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_rawmatAT", cbAT.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_moq", cbMOQ.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_currency", cbCurr.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_leadTime", txtLeadTime.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_safetyStock", txtSafetyStock.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_lotSize", txtLotSize.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_quantity", float.TryParse(txtQuantity.Text.Trim(), out value) ? float.Parse(txtQuantity.Text) : 1);
                    mysqlCmd1.Parameters.AddWithValue("_weightPerLM", float.TryParse(txtWeightperLM.Text.Trim(), out value) ? float.Parse(txtWeightperLM.Text) : 0);
                    mysqlCmd1.Parameters.AddWithValue("_standardCost", float.TryParse(txtStandCost.Text.Trim(), out value) ? float.Parse(txtStandCost.Text) : 0);
                    mysqlCmd1.Parameters.AddWithValue("_lastPurchPrice", float.TryParse(txtLastPurchPrice.Text.Trim(), out value) ? float.Parse(txtLastPurchPrice.Text) : 0);
                    mysqlCmd1.Parameters.AddWithValue("_avgPurchPrice", float.TryParse(txtAvgPurchPrice.Text.Trim(), out value) ? float.Parse(txtAvgPurchPrice.Text) : 0);
                    mysqlCmd1.Parameters.AddWithValue("_gst", float.TryParse(txtGST.Text.Trim(), out value) ? float.Parse(txtGST.Text) : 0);
                    mysqlCmd1.Parameters.AddWithValue("_freightCost", float.TryParse(txtFreightCost.Text.Trim(), out value) ? float.Parse(txtFreightCost.Text) : 0);
                    mysqlCmd1.Parameters.AddWithValue("_landedCost", float.TryParse(txtLandedCost.Text.Trim(), out value) ? float.Parse(txtLandedCost.Text) : 0);
                    mysqlCmd1.ExecuteNonQuery();
                    MessageBox.Show("Added to RawMat Table");
                    //spwAdded = true;
                }
                rawmatGrid.ReadOnly = true;
                ClearAll();
                Reload(cbProductGroup);
                LoadProdGroup();
                LoadFGManuf();
                LoadNPartNum();
                LoadSPartNum();
                LoadRawMatSupplier();
                LoadExitDescription();
                LoadUOM();
                LoadMOQ();
                LoadCurr();
            }
        }

        private void rawmatGrid_DoubleClick(object sender, EventArgs e)
        {
            if (rawmatGrid.ReadOnly == false)
            {
                for(int i =0; i<22; i++)
                {
                    Console.WriteLine(rawmatGrid.CurrentRow.Cells[i].Value.ToString());
                }
                cbNPartNum.Text = rawmatGrid.CurrentRow.Cells[1].Value.ToString();
                cbSPartNum.Text = rawmatGrid.CurrentRow.Cells[2].Value.ToString();
                cbProductGroup.Text = rawmatGrid.CurrentRow.Cells[3].Value.ToString();
                cbExitDescription.Text = rawmatGrid.CurrentRow.Cells[4].Value.ToString();
                cbUOM.Text = rawmatGrid.CurrentRow.Cells[5].Value.ToString();
                cbSupplier.Text = rawmatGrid.CurrentRow.Cells[6].Value.ToString();
                cbFGManuf.Text = rawmatGrid.CurrentRow.Cells[7].Value.ToString();
                cbAT.Text = rawmatGrid.CurrentRow.Cells[8].Value.ToString();
                cbMOQ.Text = rawmatGrid.CurrentRow.Cells[9].Value.ToString();
                cbCurr.Text = rawmatGrid.CurrentRow.Cells[10].Value.ToString();
                txtLeadTime.Text = rawmatGrid.CurrentRow.Cells[11].Value.ToString();
                txtSafetyStock.Text = rawmatGrid.CurrentRow.Cells[12].Value.ToString();
                txtLotSize.Text = rawmatGrid.CurrentRow.Cells[13].Value.ToString();
                txtQuantity.Text = rawmatGrid.CurrentRow.Cells[14].Value.ToString();
                txtWeightperLM.Text = rawmatGrid.CurrentRow.Cells[15].Value.ToString();
                txtStandCost.Text = rawmatGrid.CurrentRow.Cells[16].Value.ToString();
                txtLastPurchPrice.Text = rawmatGrid.CurrentRow.Cells[17].Value.ToString();
                txtAvgPurchPrice.Text = rawmatGrid.CurrentRow.Cells[18].Value.ToString();
                txtGST.Text = rawmatGrid.CurrentRow.Cells[19].Value.ToString();
                txtFreightCost.Text = rawmatGrid.CurrentRow.Cells[20].Value.ToString();
                txtLandedCost.Text = rawmatGrid.CurrentRow.Cells[21].Value.ToString();

                id = Convert.ToInt32(rawmatGrid.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            rawmatGrid.ReadOnly = false;
            btnAddRawMat.Text = "Update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd1 = new MySqlCommand("DELETE FROM rawmaterialtable WHERE id = '" + id + "' ", mysqlCon);
                mysqlCmd1.ExecuteNonQuery();
                ClearAll();
                LoadNPartNum();
                LoadSPartNum();
                Reload(cbProductGroup);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload(cbProductGroup);
            LoadNPartNum();
            LoadSPartNum();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbExitDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridEmpty();
            Reload(cbExitDescription);
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
                worksheet1.Name = cbProductGroup.Text;
                for (int i = 0; i <= rawmatGrid.ColumnCount - 1; i++)
                {
                    worksheet1.Cells[1, i + 1] = rawmatGrid.Columns[i].Name;
                }
                for (int i = 0; i <= rawmatGrid.RowCount - 1; i++)
                {
                    for (int j = 0; j <= rawmatGrid.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = rawmatGrid[j, i];
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

        private void btnExportExcel_Click(object sender, EventArgs e)
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

    }
}
