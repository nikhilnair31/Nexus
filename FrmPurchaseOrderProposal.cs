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
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Configuration;

namespace TestX
{
    public partial class FrmPurchaseOrderProposal : Form
    {
        public FrmMain FM;
        string connectionString = @"Server=localhost; Database=projectdb; Uid=root; Pwd=abcXYZ@123";
        int id = 0, num, vali;
        string btnpoptxt;

        public FrmPurchaseOrderProposal()
        {
            InitializeComponent();
            //Pass();
            ClearAll();
            LoadcbWO();
            LoadcbPO();
            LoadProdGroups();
            LoadUoM();
            updateAllSuppliers();
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
                    connectionString += decSt;
            }
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
                reader.Close();
                mysqlCon.Close();
            }
        }

        private void LoadProdGroups()
        {
            cbProdGroup.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT DISTINCT prodGroup FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbProdGroup.Items.Add(reader.GetString(0));
                }
                reader.Close();
                mysqlCon.Close();
            }
        }

        private void LoadcbPO()
        {
            int l = cbWONum.Items.Count - 1;
            Console.WriteLine("l : " + l);
            if(l < 0 )
            {
                string s = "WO1";
                s = s.Substring(2);
                num = int.TryParse(s, out num) ? int.Parse(s) : 0;
                //poNum = "PO" + (num);
            }
            else
            {
                if (cbWONum.Items[l].ToString() == "")
                {
                    string s = cbWONum.Items[l].ToString();
                    Console.WriteLine("s : " + s);
                    s = s.Substring(2);
                    num = int.TryParse(s, out num) ? int.Parse(s) : 0;
                    //poNum = "PO" + (num);
                }
            }
            Console.WriteLine("poNum : " + "PO" + num);
        }

        private void LoadcbWO()
        {
            cbWONum.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(@" SELECT * FROM pswotable 
                                                        WHERE poGenStatus like 'NOT GENERATED' AND pickinglistGenStatus like 'YES GENERATED'", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    cbWONum.Items.Add(reader.GetString("woNum"));
                reader.Close();
            }
        }

        private void updateAllSuppliers()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(@" UPDATE pickinglisttable SET 
                                                        supplier = (SELECT `supplier1name` FROM suppliergroupstable WHERE prodName = pickDescription LIMIT 1) WHERE supplier = 'X' ", mysqlCon);
                command.ExecuteNonQuery();
                MySqlCommand command1 = new MySqlCommand(@"UPDATE pickinglisttable 
                                                        SET balanceQuant = (SELECT `moq` FROM projectdb.rawmaterialtable WHERE exitDescription = pickDescription LIMIT 1) 
                                                        WHERE balanceQuant < (SELECT `moq` FROM projectdb.rawmaterialtable WHERE exitDescription = pickDescription LIMIT 1) ", mysqlCon);
                command1.ExecuteNonQuery();
                MySqlCommand command2 = new MySqlCommand("UPDATE pickinglisttable SET supplier = '' WHERE supplier IS NULL ", mysqlCon);
                command2.ExecuteNonQuery();
                mysqlCon.Close();
            }
        }

        void ClearAll()
        {
            cbWONum.Text = dtpWODate.Text = dtpWOPlannedCompDate.Text = "";
            txtCustName.Text = txtProjName.Text = cbPickingListGenStatus.Text = "";
            cbPONum.Text = dtpPODate.Text = dtpPODispDate.Text = "";
            ClearBottom();
        }

        void ClearBottom()
        {
            //txtProdCode.Text = cbProductName.Text = txtDetails.Text = "";
            //txtSpecialNotes.Text = txtbalanceQuant.Text = txtQuantity.Text = txtTotalAmount.Text = "";
            //txtpickCurrStock.Text = txtdemandQuant.Text = txtissuedQuant.Text = cbColor.Text = txtUnitRate.Text = "";
            id = 0;
            if(chkboxEdit.Checked == false)
                btnPOAddProd.Text = "Update POP";
        }

        void GridEmpty()
        {
            popGrid.DataSource = null;
            popGrid.Rows.Clear();
        }

        void Reload(string cbText)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM workordertable WHERE CONCAT(`woNum`) like '%" + cbText + "%'", mysqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                popGrid.DataSource = table;
                popGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                lblWONum.Text = cbText;
                adapter.Dispose();
            }
            id = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            GridEmpty();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            popGrid.ReadOnly = false;
            btnPOAddProd.Text = "Update POP";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd1 = new MySqlCommand("DELETE FROM pickinglisttable WHERE id = '" + id + "' ", mysqlCon);
                mysqlCmd1.ExecuteNonQuery();
                Reload(cbWONum.Text);
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            delWO(false);
            cbWONum.Text = "";
            Reload(cbWONum.Text);
            LoadcbPO();
            LoadcbWO();
            GridEmpty();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Reload(cbWONum);
            LoadcbPO();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void cbWONum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("cbWONum_SelectedIndexChanged");
            loadWOPL();
        }

        private void loadWOPL()
        {
            Console.WriteLine("loadWOPL");
            lblGridSource.Text = "Looking at Picking List Table";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM pickinglisttable WHERE CONCAT(`woNum`) like '%" + cbWONum.Text + "%'", mysqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                popGrid.DataSource = table;
                popGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                popGrid.Columns[0].Visible = false;
                lblWONum.Text = cbWONum.Text;
                adapter.Dispose();

                MySqlCommand command1 = new MySqlCommand("SELECT * FROM pswotable WHERE CONCAT(`woNum`) like '%" + cbWONum.Text + "%'", mysqlCon);
                MySqlDataReader dbRead = command1.ExecuteReader();
                if (dbRead.Read())
                {
                    dtpWODate.Text = dbRead.GetString("woDate");
                    dtpWOPlannedCompDate.Text = dbRead.GetString("plannedCompDate");
                    cbPickingListGenStatus.Text = dbRead.GetString("pickinglistGenStatus");
                    txtCustName.Text = dbRead.GetString("customerName");
                    txtProjName.Text = dbRead.GetString("projectName");
                    cbPONum.Text = dbRead.GetString("poNum");
                    dtpPODate.Text = dbRead.GetString("poDate");
                    dtpPODispDate.Text = dbRead.GetString("poDispatchDate");
                }
                dbRead.Close();
            }
        }

        private void delWO(bool toOverwrite)
        {
            if (cbWONum.Text.Length != 0)
            {
                if (cbWONum.Text.ElementAt(0) == 'W')
                {
                    using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                    {
                        mysqlCon.Open();
                        MySqlCommand mysqlCmd = new MySqlCommand("DELETE FROM pickinglisttable WHERE woNum = '" + cbWONum.Text.ToString() + "' ", mysqlCon);
                        mysqlCmd.ExecuteNonQuery();
                        MySqlCommand mysqlCmd2 = new MySqlCommand(@"UPDATE pswotable SET pickinglistGenStatus = 'NOT GENERATED', poGenStatus = 'NOT GENERATED' 
                                                                    WHERE woNum = '" + cbWONum.SelectedItem.ToString() + "'", mysqlCon);
                        mysqlCmd2.ExecuteNonQuery();
                    }
                }
            }
            else if (toOverwrite == true)
                Console.WriteLine("IDK MAN toOverwrite IS TRUE");
            else
                MessageBox.Show("Can't delete an SO");
        }

        private void btnPOAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    foreach (DataGridViewRow row in popGrid.Rows)
                    {
                        if (row.Cells[1].Value != null)
                        {
                            MySqlCommand mysqlCmd1 = new MySqlCommand("POPUpdate", mysqlCon);
                            mysqlCmd1.CommandType = CommandType.StoredProcedure;
                            mysqlCmd1.Parameters.AddWithValue("_id", id);
                            mysqlCmd1.Parameters.AddWithValue("_woNum", cbWONum.Text);
                            mysqlCmd1.Parameters.AddWithValue("_projectName", txtProjName.Text);
                            mysqlCmd1.Parameters.AddWithValue("_customerName", txtCustName.Text);
                            mysqlCmd1.Parameters.AddWithValue("_woDate", dtpWODate.Text);
                            mysqlCmd1.Parameters.AddWithValue("_plannedCompDate", dtpWOPlannedCompDate.Text);
                            mysqlCmd1.Parameters.AddWithValue("_pickDate", dtpPDate.Text);
                            mysqlCmd1.Parameters.AddWithValue("_pickGroup", cbProdGroup.Text);
                            mysqlCmd1.Parameters.AddWithValue("_partNum", cbProdGroup.Text);
                            mysqlCmd1.Parameters.AddWithValue("_pickDescription", cbProductName.Text);
                            mysqlCmd1.Parameters.AddWithValue("_pickUOM", cbUoM.Text);
                            mysqlCmd1.Parameters.AddWithValue("_lastPurchPrice", txtstandardPrice.Text);
                            mysqlCmd1.Parameters.AddWithValue("_pickCurStock", txtpickCurrStock.Text);
                            mysqlCmd1.Parameters.AddWithValue("_demandQuant", txttoOrderQuant.Text);
                            mysqlCmd1.Parameters.AddWithValue("_issuedQuant", txtOrderedQuant.Text);
                            mysqlCmd1.Parameters.AddWithValue("_balanceQuant", txtbalanceQuant.Text);
                            mysqlCmd1.Parameters.AddWithValue("_unitRate", txtunitPrice.Text);
                            mysqlCmd1.Parameters.AddWithValue("_supplier", cbSupplier.Text);
                            ClearBottom();
                            //loadWOPL();
                            mysqlCmd1.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("POP Data Updated");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void popGrid_DoubleClick(object sender, EventArgs e)
        {
            cbProdGroup.Text = popGrid.CurrentRow.Cells[3].Value.ToString();
            txtProdCode.Text = popGrid.CurrentRow.Cells[4].Value.ToString();
            cbProductName.Text = popGrid.CurrentRow.Cells[5].Value.ToString();
            cbUoM.Text = popGrid.CurrentRow.Cells[6].Value.ToString();
            
            txttoOrderQuant.Text = popGrid.CurrentRow.Cells[12].Value.ToString();
            txtOrderedQuant.Text = popGrid.CurrentRow.Cells[13].Value.ToString();
            txtbalanceQuant.Text = popGrid.CurrentRow.Cells[14].Value.ToString();
            txtunitPrice.Text = popGrid.CurrentRow.Cells[15].Value.ToString();

            id = Convert.ToInt32(popGrid.CurrentRow.Cells[0].Value.ToString());

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM rawmaterialtable WHERE exitDescription = '" + cbProductName.Text + "'", mysqlCon);
                MySqlDataReader dbRead = command1.ExecuteReader();
                if (dbRead.Read())
                {
                    txtpickCurrStock.Text = dbRead.GetString("quantity");
                    txtstandardPrice.Text = dbRead.GetString("standardCost");
                    txtlastPurchPrice.Text = dbRead.GetString("lastPurchPrice");
                    txtavgPurchPrice.Text = dbRead.GetString("avgPurchPrice");
                }
                dbRead.Close();
                mysqlCon.Close();
            }
        }

        private void _cmdPrint_Click(object sender, EventArgs e)
        {
            FrmReport FR = new FrmReport();
            FR.Show();
        }

        private void cbProdGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProductName.Items.Clear();
            cbSupplier.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand cmd0 = new MySqlCommand(" SELECT DISTINCT * FROM suppliergroupstable WHERE prodGroup = '" + cbProdGroup.Text + "' ", mysqlCon);
                MySqlDataReader dr0 = cmd0.ExecuteReader();
                while (dr0.Read())
                {
                    cbSupplier.Text = dr0.GetString("supplier1name");
                }
                dr0.Close();
                MySqlCommand cmd1 = new MySqlCommand(" SELECT * FROM rawmaterialtable WHERE prodGroup = '" + cbProdGroup.Text + "' ", mysqlCon);
                MySqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    cbProductName.Items.Add(dr1.GetString("exitDescription"));
                }
                dr1.Close();
                MySqlCommand cmd2 = new MySqlCommand(@" SELECT DISTINCT supplier1name,supplier2name,supplier3name,supplier4name,supplier5name,supplier6name,supplier7name 
                                                        FROM suppliergroupstable WHERE prodGroup = '" + cbProdGroup.Text + "' ", mysqlCon);
                MySqlDataReader dr2 = cmd2.ExecuteReader();
                List<string> list = new List<string>();
                while (dr2.Read())
                {
                    for(int i=0; i<7; i++)
                    {
                        list.Add(dr2.GetString(i));
                    }
                }
                dr2.Close();
                List<string> uniqueList = list.Distinct().ToList();
                uniqueList.ForEach(i => cbSupplier.Items.Add(i));
                MySqlCommand cmd3 = new MySqlCommand(" SELECT * FROM rawmaterialtable WHERE prodGroup = '" + cbProdGroup.Text + "' ", mysqlCon);
                MySqlDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    cbProductName.Items.Add(dr3.GetString("exitDescription"));
                }
                dr3.Close();
                mysqlCon.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FM.Show();
            this.Close();
        }

        private void ExcelExport()
        {
            try
            {
                Excel.Application xlApp = new Excel.Application();
                string path = @"C:\ERP\fullexport.xlsm";
                xlApp.DisplayAlerts = false;
                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }
                else if(check(path))
                {
                    var missing = System.Reflection.Missing.Value;
                    xlApp.Visible = true;
                    System.IO.FileInfo objFileInfo = new System.IO.FileInfo(path);
                    objFileInfo.IsReadOnly = false;
                    Excel.Workbook myExcelWorkbook = (Excel.Workbook)(xlApp.Workbooks._Open(path, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, System.Reflection.Missing.Value));
                    Excel.Worksheet myExcelWorkSheet = (Excel.Worksheet)myExcelWorkbook.Worksheets[1];
                    using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                    {
                        int i = 0;
                        mysqlCon.Open();

                        myExcelWorkSheet.Cells.ClearContents();
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM rawmaterialtable", mysqlCon);
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        myExcelWorkSheet.Cells[1, 1] = rdr.GetName(0);
                        myExcelWorkSheet.Cells[1, 2] = rdr.GetName(1);
                        myExcelWorkSheet.Cells[1, 3] = rdr.GetName(2);
                        myExcelWorkSheet.Cells[1, 4] = rdr.GetName(4);
                        myExcelWorkSheet.Cells[1, 5] = rdr.GetName(5);
                        myExcelWorkSheet.Cells[1, 6] = rdr.GetName(14);
                        myExcelWorkSheet.Cells[1, 7] = rdr.GetName(15);
                        while (rdr.Read())
                        {
                            myExcelWorkSheet.Cells[i + 2, 1] = rdr.GetString(0);
                            myExcelWorkSheet.Cells[i + 2, 2] = rdr.GetString(1);
                            myExcelWorkSheet.Cells[i + 2, 3] = rdr.GetString(2);
                            myExcelWorkSheet.Cells[i + 2, 4] = rdr.GetString(4);
                            myExcelWorkSheet.Cells[i + 2, 5] = rdr.GetString(5);
                            myExcelWorkSheet.Cells[i + 2, 6] = rdr.GetString(14);
                            myExcelWorkSheet.Cells[i + 2, 7] = rdr.GetString(15);
                            i++;
                        }
                        myExcelWorkSheet.Columns.AutoFit();
                        myExcelWorkSheet.Rows.AutoFit();
                        rdr.Close();

                        Excel.Worksheet myExcelWorkSheet1 = (Excel.Worksheet)myExcelWorkbook.Worksheets[2];
                        myExcelWorkSheet1.Activate();
                        myExcelWorkSheet1.Columns["A"].Delete();
                        MySqlCommand cmd1 = new MySqlCommand(@" SELECT DISTINCT woNum FROM pswotable WHERE woCurStatus = 'ACTIVE' AND woGenStatus = 'YES GENERATED' ", mysqlCon);
                        MySqlDataReader dr1 = cmd1.ExecuteReader();
                        int j = 1;
                        while (dr1.Read())
                        {
                            myExcelWorkSheet1.Cells[j, 1] = dr1.GetString(0);
                            j++;
                        }
                        myExcelWorkSheet1.Columns.AutoFit();
                        myExcelWorkSheet1.Rows.AutoFit();
                        dr1.Close();

                        Excel.Worksheet myExcelWorkSheet2 = (Excel.Worksheet)myExcelWorkbook.Worksheets[3];
                        myExcelWorkSheet2.Activate();
                        myExcelWorkSheet2.Cells.ClearContents();
                        using (MySqlCommand command = new MySqlCommand("SELECT * FROM pickinglisttable", mysqlCon))
                        {
                            MySqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                for (i = 0; i < reader.FieldCount; i++)
                                    myExcelWorkSheet2.Cells[1, i+1] = reader.GetName(i);
                            }
                            reader.Close();
                        }
                        MySqlCommand cmd2 = new MySqlCommand(" SELECT DISTINCT * FROM pickinglisttable ", mysqlCon);
                        MySqlDataReader dr2 = cmd2.ExecuteReader();
                        int l = 2;
                        while (dr2.Read())
                        {
                            for (int k = 0; k < 15; k++)
                            {
                                myExcelWorkSheet2.Cells[l, k+1] = dr2.GetString(k);
                            }
                            l++;
                        }
                        myExcelWorkSheet2.Columns.AutoFit();
                        myExcelWorkSheet2.Rows.AutoFit();
                        dr2.Close();

                        myExcelWorkbook.SaveAs(path, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, System.Reflection.Missing.Value, Excel.XlSaveAsAccessMode.xlNoChange,
                        System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                        xlApp.Workbooks.Close();
                        xlApp.Quit();
                    }
                    Console.WriteLine("Exported FULL");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some Excel export error : " + ex.Message);
            }
        }

        private void btnDelPOsofWO_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                bool doesPOExist = false;
                MySqlCommand mysqlCmd0 = new MySqlCommand(" SELECT woNum FROM purchaseordertable ", mysqlCon);
                MySqlDataReader dr0 = mysqlCmd0.ExecuteReader();
                while (dr0.Read())
                {
                    if (dr0.GetString(0) == cbWONum.Text)
                        doesPOExist = true;
                }
                dr0.Close();
                if (doesPOExist == true)
                {
                    MySqlCommand mysqlCmd1 = new MySqlCommand(" DELETE FROM purchaseordertable WHERE woNum = '" + cbWONum.Text + "' ", mysqlCon);
                    mysqlCmd1.ExecuteNonQuery();
                    MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE pswotable SET poGenStatus = 'NOT GENERATED' WHERE woNum = '" + cbWONum.Text + "'", mysqlCon);
                    mysqlCmd2.ExecuteNonQuery();
                    MessageBox.Show("Deleted all POs of that WO");
                }
                else
                {
                    MessageBox.Show("No POs of that WO");
                }
                mysqlCon.Close();
            }
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelExport();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnPOGen_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();

                popGrid.Sort(popGrid.Columns["supplier"], ListSortDirection.Ascending);
                num = 1;
                string prevsup = popGrid.Rows[0].Cells[2].Value.ToString().Trim();
                foreach (DataGridViewRow row in popGrid.Rows)
                {
                    Console.WriteLine("num : " + num);
                    string cid = "", cadd = "", cgstnum = "", pcol = "", pspec = "", pdeets = "";

                    MySqlCommand cmd0 = new MySqlCommand(" SELECT DISTINCT custID,adresses,gstNum FROM customertable WHERE custName = '" + row.Cells[2].Value + "' ", mysqlCon);
                    MySqlDataReader dr0 = cmd0.ExecuteReader();
                    while (dr0.Read())
                    {
                        cid = dr0.GetString(0);
                        cadd = dr0.GetString(1);
                        cgstnum = dr0.GetString(2);
                    }
                    dr0.Close();
                    MySqlCommand cmd1 = new MySqlCommand(" SELECT DISTINCT color,details,specialNotes FROM workordertable WHERE woNum = '" + cbWONum.Text + "' ", mysqlCon);
                    MySqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        pcol = dr1.GetString(0);
                        pspec = dr1.GetString(1);
                        pdeets = dr1.GetString(2);
                    }
                    dr1.Close();

                    if (row.Cells[1].Value != null)
                    {
                        Console.WriteLine(row.Cells[2].Value.ToString().Trim()+ "/ " + prevsup);
                        if (row.Cells[2].Value.ToString().Trim() == prevsup)//use old po num
                        {
                            Console.WriteLine("using old : " + "PO" + num + "-" + cbWONum.Text);
                        }
                        else//new po num generated
                        {
                            //s = "PO" + num + "-" + cbWONum.Text;
                            //s = s.Substring(2);
                            //num = int.TryParse(s, out num) ? int.Parse(s) : 0;
                            //poNum = "PO" + (++num);
                            num++;
                            prevsup = row.Cells[2].Value.ToString().Trim();
                            Console.WriteLine("using new : " + "PO" + num + "-" + cbWONum.Text);
                        }
                        MySqlCommand mysqlCmd1 = new MySqlCommand("POAddorEdit", mysqlCon);
                        mysqlCmd1.CommandType = CommandType.StoredProcedure;
                        mysqlCmd1.Parameters.AddWithValue("_id", id);
                        mysqlCmd1.Parameters.AddWithValue("_woNum", row.Cells[1].Value.ToString().Trim());
                        mysqlCmd1.Parameters.AddWithValue("_poStatus", "YES GENERATED");
                        mysqlCmd1.Parameters.AddWithValue("_poNum", "PO" + num + "-" + cbWONum.Text);
                        mysqlCmd1.Parameters.AddWithValue("_poDate", row.Cells[7].Value.ToString().Trim());
                        mysqlCmd1.Parameters.AddWithValue("_gstin", "NotSure123");
                        mysqlCmd1.Parameters.AddWithValue("_reqDate", row.Cells[7].Value.ToString().Trim());
                        mysqlCmd1.Parameters.AddWithValue("_billToAdd", "-");
                        mysqlCmd1.Parameters.AddWithValue("_shipToAdd", "# 59/3D2, CHEEMASANDRA VILLAGE, VIRGONAGAR POST, BETWEEN MUNESHWARA SCHOOL AND POORNA PRAGYA SCHOOL, BENGALURU, KARNATAKA 560049");
                        mysqlCmd1.Parameters.AddWithValue("_prepBy", "-");
                        mysqlCmd1.Parameters.AddWithValue("_contactNum", "-");
                        mysqlCmd1.Parameters.AddWithValue("_supplierCode", cid);//gET CODE
                        mysqlCmd1.Parameters.AddWithValue("_supplierName", row.Cells[2].Value.ToString().Trim());
                        mysqlCmd1.Parameters.AddWithValue("_supplierAdd", cadd);
                        mysqlCmd1.Parameters.AddWithValue("_supplierGST", cgstnum);
                        mysqlCmd1.Parameters.AddWithValue("_productGroup", row.Cells[3].Value.ToString().Trim());
                        mysqlCmd1.Parameters.AddWithValue("_productCode", row.Cells[4].Value.ToString().Trim());
                        mysqlCmd1.Parameters.AddWithValue("_productName", row.Cells[5].Value.ToString().Trim());
                        mysqlCmd1.Parameters.AddWithValue("_uom", row.Cells[6].Value.ToString().Trim());
                        mysqlCmd1.Parameters.AddWithValue("_deets", pdeets);//get color
                        mysqlCmd1.Parameters.AddWithValue("_specNotes", pspec);
                        mysqlCmd1.Parameters.AddWithValue("_col", pcol);
                        mysqlCmd1.Parameters.AddWithValue("_quant", int.TryParse(row.Cells[12].Value.ToString().Trim(), out vali) ? int.Parse(row.Cells[12].Value.ToString().Trim()) : 0);
                        mysqlCmd1.Parameters.AddWithValue("_rate", int.TryParse(row.Cells[15].Value.ToString().Trim(), out vali) ? int.Parse(row.Cells[15].Value.ToString().Trim()) : 0);
                        mysqlCmd1.Parameters.AddWithValue("_totAmt", int.TryParse(txttotalAmount.Text, out vali) ? int.Parse(txttotalAmount.Text) : 0);
                        mysqlCmd1.Parameters.AddWithValue("_gstAmt", 0);
                        mysqlCmd1.ExecuteNonQuery();
                    }
                }
                MySqlCommand MyCommand2 = new MySqlCommand("UPDATE pswotable SET poGenStatus = 'YES GENERATED' WHERE woNum = '" + cbWONum.SelectedItem.ToString() + "'", mysqlCon);
                MyCommand2.ExecuteNonQuery();

                ClearAll();
                GridEmpty();
                MessageBox.Show("PO Generated.");
            }
        }

        private void chkboxEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (popGrid.ReadOnly == true)
            {
                popGrid.ReadOnly = false;
                btnpoptxt = btnPOAddProd.Text;
                btnPOAddProd.Text = "Update POP";
                chkboxEdit.BackColor = Color.IndianRed;
            }
            else if (popGrid.ReadOnly == false)
            {
                popGrid.ReadOnly = true;
                btnPOAddProd.Text = btnpoptxt;
                chkboxEdit.BackColor = Color.White;
                id = 0;
            }
        }

        private bool check(String FileName)
        {
            try
            {
                Stream s = File.Open(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                s.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void cbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand cmd0 = new MySqlCommand(" SELECT DISTINCT * FROM rawmaterialtable WHERE exitDescription = '" + cbProductName.Text + "' ", mysqlCon);
                MySqlDataReader dr0 = cmd0.ExecuteReader();
                while (dr0.Read())
                {
                    txtProdCode.Text = dr0.GetString("nairPartNum");
                }
                dr0.Close();
                mysqlCon.Close();
            }
        }
    }
}
