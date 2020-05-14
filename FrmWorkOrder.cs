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
    public partial class FrmWorkOrder : Form
    {
        public FrmMain FM;
        string connectionString = @"Server=localhost; Database=projectdb; Uid=root; Pwd=abcXYZ@123";
        //bool spwAdded = false;
        //bool spwGrid = false;
        int id = 0;
        float sqm, value = float.NaN;
        float l, h, w, q, u, s, ta;
        string btnwotxt;

        public FrmWorkOrder()
        {
            InitializeComponent();
            //Pass();
            ClearAll();
            LoadcbSO();
            LoadcbWO();
            LoadProdGroups();
            LoadUoM();
            //cbWONum.SelectedIndex = 0;
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
                MySqlCommand command = new MySqlCommand("SELECT DISTINCT prodUOM FROM producttable WHERE prodGroup = '" + cbProdGroup.Text + "' ", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbUoM.Items.Add(reader.GetString(0));
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
                            cond = true;
                    }
                    if (cond == true)
                    {
                        cbProdGroup.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                        continue;
                }
            }
        }

        private void LoadcbSO()
        {
            cbSONum.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(@"SELECT soNum FROM pswotable WHERE soNum <> ''", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    cbSONum.Items.Add(reader.GetString(0));
            }
        }

        private void LoadcbWO()
        {
            cbWONum.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(" SELECT woNum FROM pswotable WHERE woGenStatus like 'YES GENERATED'", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string st = reader.GetString(0);
                    cbWONum.Items.Add(st);
                }
            }
        }

        void ClearAll()
        {
            cbWONum.Text = dtpWODate.Text = dtpWOPlannedCompDate.Text = cbWOCurStatus.Text = cbWOGenStatus.Text = "";
            cbSONum.Text = dtpSODate.Text = txtCustName.Text = txtProjName.Text = cbPLGenStatus.Text = cbPOGenStatus.Text = "";
            txtPONum.Text = dtpPODate.Text = dtpPODispDate.Text = txtProjBasicVal.Text = "";
            ClearBottom();
        }

        void ClearBottom()
        {
            txtProdCode.Text = cbProductName.Text = txtDetails.Text = "";
            txtSpecialNotes.Text = txtSQM.Text = txtQuantity.Text = txtTotalAmount.Text = "";
            txtLength.Text = txtHeight.Text = txtWidth.Text = cbColor.Text = txtUnitRate.Text = "";
            id = 0;
            if (chkboxEdit.Checked == false)
                btnWOAddProd.Text = btnwotxt;
        }

        void GridEmpty()
        {
            woGrid.DataSource = null;
            woGrid.Rows.Clear();
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
                woGrid.DataSource = table;
                woGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (woGrid.CurrentRow.Cells[1].Value.ToString().Substring(0, 1) == "W")
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    MySqlCommand mysqlCmd1 = new MySqlCommand("DELETE FROM workordertable WHERE id = '" + id + "' ", mysqlCon);
                    mysqlCmd1.ExecuteNonQuery();
                    id = 0;
                    Reload(cbWONum.Text);
                }
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            delWO(false);
            cbSONum.Text = "";
            cbWONum.Text = "";
            Reload(cbWONum.Text);
            LoadcbSO();
            LoadcbWO();
            GridEmpty();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Reload(cbWONum);
            LoadcbSO();
            if(lblGridSource.Text == "Looking at SO Table")
                loadWO();
            else if (lblGridSource.Text == "Looking at WO Table")
                loadWO();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd1 = new MySqlCommand("PSWOAddorEdit", mysqlCon);
                mysqlCmd1.CommandType = CommandType.StoredProcedure;
                mysqlCmd1.Parameters.AddWithValue("_id", id);
                mysqlCmd1.Parameters.AddWithValue("_soNum","");
                mysqlCmd1.Parameters.AddWithValue("_soDate", "");
                mysqlCmd1.Parameters.AddWithValue("_custName", "");
                mysqlCmd1.Parameters.AddWithValue("_projName", "");
                mysqlCmd1.Parameters.AddWithValue("_poNum", "");
                mysqlCmd1.Parameters.AddWithValue("_poDate", "");
                mysqlCmd1.Parameters.AddWithValue("_poDispatchDate", "");
                mysqlCmd1.Parameters.AddWithValue("_plannedCompDate", "");
                mysqlCmd1.Parameters.AddWithValue("_actCompDate", "");
                mysqlCmd1.Parameters.AddWithValue("_dispatchDate", "");
                mysqlCmd1.Parameters.AddWithValue("_pickinglistGenStatus", "NOT GENERATED");
                mysqlCmd1.Parameters.AddWithValue("_woCurStatus", cbWOCurStatus.Text);
                mysqlCmd1.Parameters.AddWithValue("_woGenStatus", "YES GENERATED");
                mysqlCmd1.Parameters.AddWithValue("_poGenStatus", "NOT GENERATED");
                mysqlCmd1.Parameters.AddWithValue("_woNum", cbWONum.Text);
                mysqlCmd1.Parameters.AddWithValue("_woDate", dtpWODate.Text);
                mysqlCmd1.Parameters.AddWithValue("_basicValue", float.TryParse(txtTotalAmount.Text.Trim(), out value) ? float.Parse(txtTotalAmount.Text) : 0);
                mysqlCmd1.ExecuteNonQuery();
                MessageBox.Show("Added to SPW Table");
                ClearBottom();
                loadWO();
                mysqlCon.Close();
            }
        }

        private void cbWONum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("cbWONum_SelectedIndexChanged");
            loadWO();
        }

        private void loadWO()
        {
            Console.WriteLine("loadWO");
            string s = ""; 
            if (cbWONum.Text.Length == 0)
            {
                s = cbSONum.Text.ToString().Trim();
                Console.WriteLine("1s :" + s);
            }
            else
            {
                s = cbWONum.Text;
                Console.WriteLine("2s :"+ s);
            }

            if(chkboxEdit.Checked == false)
                btnWOAddProd.Text = "2. Insert Product";
            lblGridSource.Text = "Seeing WO Table";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM workordertable WHERE CONCAT(`woNum`) like '%" + s + "%'", mysqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                woGrid.DataSource = table;
                woGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                woGrid.Columns[0].Visible = false;
                woGrid.Columns[1].Visible = false;
                woGrid.Columns[2].Visible = false;
                lblWONum.Text = s;
                adapter.Dispose();

                MySqlCommand command1 = new MySqlCommand("SELECT * FROM pswotable WHERE CONCAT(`woNum`) like '%" + s + "%'", mysqlCon);
                MySqlDataReader dbRead = command1.ExecuteReader();
                if (dbRead.Read())
                {
                    String str1 = cbWONum.Text.ToString().Trim();
                    String str2 = cbSONum.Text.ToString().Trim();
                    if (str1.Length != 0) {
                        str1 = "W" + str1.Substring(1, str1.Length - 1);
                        cbWONum.Text = str1;
                    }
                    else if (str2.Length != 0)
                    {
                        str2 = "W" + str2.Substring(1, str2.Length - 1);
                        cbWONum.Text = str2;
                    }
                    //cbSONum.Text = dbRead.GetString(1);
                    dtpSODate.Text = dbRead.GetString("soDate");
                    txtCustName.Text = dbRead.GetString("customerName");
                    txtProjName.Text = dbRead.GetString("projectName");
                    txtPONum.Text = dbRead.GetString("poNum");
                    dtpPODate.Text = dbRead.GetString("poDate");
                    dtpPODispDate.Text = dbRead.GetString("poDispatchDate");
                    dtpWOPlannedCompDate.Text = dbRead.GetString("plannedCompDate");
                    txtProjBasicVal.Text = dbRead.GetString("basicValue");
                    cbPLGenStatus.Text = dbRead.GetString("pickinglistGenStatus");  
                    cbWOCurStatus.Text = dbRead.GetString("woCurStatus");
                    cbWOGenStatus.Text = dbRead.GetString("woGenStatus");
                    cbPOGenStatus.Text = dbRead.GetString("poGenStatus");
                }
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
                        //DelPL();
                        MySqlCommand mysqlCmd0 = new MySqlCommand("DELETE FROM purchaseordertable WHERE woNum = '" + cbWONum.Text.ToString() + "' ", mysqlCon);
                        mysqlCmd0.ExecuteNonQuery();
                        MySqlCommand mysqlCmd = new MySqlCommand("DELETE FROM pickinglisttable WHERE woNum = '" + cbWONum.Text.ToString() + "' ", mysqlCon);
                        mysqlCmd.ExecuteNonQuery();
                        MySqlCommand mysqlCmd1 = new MySqlCommand("DELETE FROM workordertable WHERE woNum = '" + cbWONum.Text.ToString() + "' ", mysqlCon);
                        mysqlCmd1.ExecuteNonQuery();
                        MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE pswotable SET woGenStatus = 'NOT GENERATED', pickinglistGenStatus = 'NOT GENERATED' ,  poGenStatus = 'NOT GENERATED', woNum = '" + null + "' , woDate = '" + null + "' WHERE woNum = '" + cbWONum.SelectedItem.ToString() + "'", mysqlCon);
                        mysqlCmd2.ExecuteNonQuery();
                    }
                }
            }
            else if (toOverwrite == true)
                Console.WriteLine("IDK MAN toOverwrite IS TRUE");
            else
                MessageBox.Show("Can't delete an SO");
        }

        private void ExcelExportImport()
        {
            Excel.Application xlApp = new Excel.Application();
            xlApp.DisplayAlerts = false;
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            else
            {
                var missing = System.Reflection.Missing.Value;
                string path = @"C:\ERP\COSTING N-AIR R7 latest_1.xlsm";
                xlApp.Visible = true;
                System.IO.FileInfo objFileInfo = new System.IO.FileInfo(path);
                objFileInfo.IsReadOnly = false;
                Excel.Workbook myExcelWorkbook = (Excel.Workbook)(xlApp.Workbooks._Open(path, System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value));
                //int numberOfWorkbooks = xlApp.Workbooks.Count;
                Excel.Worksheet myExcelWorkSheet = (Excel.Worksheet)myExcelWorkbook.Worksheets[1];
                //int numberOfSheets = myExcelWorkbook.Worksheets.Count;
                myExcelWorkSheet.Cells.ClearContents();
                for (int i = 0; i <= woGrid.ColumnCount - 1; i++)
                {
                    myExcelWorkSheet.Cells[1, i + 1] = woGrid.Columns[i].Name;
                }
                for (int i = 0; i <= woGrid.RowCount - 1; i++)
                {
                    for (int j = 0; j <= woGrid.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = woGrid[j, i];
                        myExcelWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                    }
                }
                myExcelWorkSheet.Columns["A"].Delete();
                myExcelWorkSheet.Columns.AutoFit();
                myExcelWorkSheet.Rows.AutoFit();
                myExcelWorkbook.SaveAs(path, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value, Excel.XlSaveAsAccessMode.xlNoChange,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                Console.WriteLine("Exported");
                xlApp.Run("Calculate");
                Console.WriteLine("Calculate Run");
                //xlApp.Workbooks.Close();
                //xlApp.Quit();
                Console.WriteLine("Importing");
                Workbook xlWorkBook;
                Worksheet xlWorkSheet;
                xlWorkBook = xlApp.Workbooks.Open(path, false, true, missing, missing, missing, true, XlPlatform.xlWindows, '\t', false, false, 0, false, true, 0);
                xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(3);
                Range xlRange = xlWorkSheet.UsedRange;
                Array myValues = (Array)xlRange.Cells.Value2;
                int lastUsedRow = xlWorkSheet.Cells.Find("*", System.Reflection.Missing.Value,
                                   System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                   Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                                   false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;
                int lastUsedColumn = xlWorkSheet.Cells.Find("*", System.Reflection.Missing.Value,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                               Excel.XlSearchOrder.xlByColumns, Excel.XlSearchDirection.xlPrevious,
                                               false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Column;
                System.Data.DataTable dt = new System.Data.DataTable();
                for (int i = 1; i <= lastUsedColumn; i++)
                {
                    if (myValues.GetValue(1, i) != null)
                    {
                        dt.Columns.Add(new DataColumn(myValues.GetValue(1, i).ToString()));
                        //Console.WriteLine(myValues.GetValue(1, i));
                    }
                }
                for (int a = 2; a <= lastUsedRow; a++)
                {
                    object[] poop = new object[lastUsedColumn];
                    for (int b = 1; b <= lastUsedColumn; b++)
                    {
                        poop[b - 1] = myValues.GetValue(a, b);
                        //Console.WriteLine(myValues.GetValue(a, b));
                    }
                    DataRow row = dt.NewRow();
                    row.ItemArray = poop;
                    dt.Rows.Add(row);
                }
                woGrid.DataSource = dt;
                xlWorkBook.SaveAs(path, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value, Excel.XlSaveAsAccessMode.xlNoChange,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                xlWorkBook.Close(true, missing, missing);

                xlApp.Quit();
            }
                
        }

        private void ExcelImport()
        {
            Console.WriteLine("Importing");
            string filename = @"C:\ERP\COSTING N-AIR R7 latest_1.xlsm";
            System.IO.FileInfo objFileInfo = new System.IO.FileInfo(filename);
            objFileInfo.IsReadOnly = false;
            Excel.Application xlApp = new Excel.Application();
            Workbook xlWorkBook;
            Worksheet xlWorkSheet;
            var missing = System.Reflection.Missing.Value;
            xlWorkBook = xlApp.Workbooks.Open(filename, false, true, missing, missing, missing, true, XlPlatform.xlWindows, '\t', false, false, 0, false, true, 0);
            xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(3);
            Range xlRange = xlWorkSheet.UsedRange;
            Array myValues = (Array)xlRange.Cells.Value2;
            int lastUsedRow = xlWorkSheet.Cells.Find("*", System.Reflection.Missing.Value,
                               System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                               Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                               false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;
            int lastUsedColumn = xlWorkSheet.Cells.Find("*", System.Reflection.Missing.Value,
                                           System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                           Excel.XlSearchOrder.xlByColumns, Excel.XlSearchDirection.xlPrevious,
                                           false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Column;
            System.Data.DataTable dt = new System.Data.DataTable();
            for (int i = 1; i <= lastUsedColumn; i++)
            {
                if (myValues.GetValue(1, i) != null)
                {
                    dt.Columns.Add(new DataColumn(myValues.GetValue(1, i).ToString()));
                    //Console.WriteLine(myValues.GetValue(1, i));
                }
            }
            for (int a = 2; a <= lastUsedRow; a++)
            {
                object[] poop = new object[lastUsedColumn];
                for (int b = 1; b <= lastUsedColumn; b++)
                {
                    poop[b - 1] = myValues.GetValue(a, b);
                    //Console.WriteLine(myValues.GetValue(a, b));
                }
                DataRow row = dt.NewRow();
                row.ItemArray = poop;
                dt.Rows.Add(row);
            }
            woGrid.DataSource = dt;
            xlWorkBook.Close(true, missing, missing);
            xlApp.Quit();
        }

        private void cbSONum_SelectedValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("cbSONum_SelectedValueChanged");
        }

        private void cbSONum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("cbSONum_SelectedIndexChanged");
            loadSO();
        }

        private void loadSO()
        {
            string s = "";
            s = cbSONum.Text.ToString().Trim();
            s = "W" + s.Substring(1, s.Length - 1);
            cbWONum.Text = s;

            btnWOAddProd.Text = "2. Gen WO";
            lblGridSource.Text = "Looking at SO Table";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM salesordertable WHERE CONCAT(`soNum`) like '%" + cbSONum.Text + "%'", mysqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                woGrid.DataSource = table;
                woGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                woGrid.Columns[0].Visible = false;
                woGrid.Columns[1].Visible = false;
                woGrid.Columns[2].Visible = false;
                adapter.Dispose();

                MySqlCommand command1 = new MySqlCommand("SELECT * FROM pswotable WHERE CONCAT(`soNum`) like '%" + cbSONum.Text + "%'", mysqlCon);
                MySqlDataReader dbRead = command1.ExecuteReader();
                if (dbRead.Read())
                {
                    dtpSODate.Text = dbRead.GetString("soDate");
                    txtCustName.Text = dbRead.GetString("customerName");
                    txtProjName.Text = dbRead.GetString("projectName");
                    txtPONum.Text = dbRead.GetString("poNum");
                    dtpPODate.Text = dbRead.GetString("poDate");
                    dtpPODispDate.Text = dbRead.GetString("poDispatchDate");
                    dtpWOPlannedCompDate.Text = dbRead.GetString("plannedCompDate");
                    txtProjBasicVal.Text = dbRead.GetString("basicValue");
                    cbWOCurStatus.Text = dbRead.GetString("woCurStatus");
                    cbWOGenStatus.Text = dbRead.GetString("woGenStatus");
                    cbPOGenStatus.Text = dbRead.GetString("poGenStatus");
                    cbPLGenStatus.Text = dbRead.GetString("pickinglistGenStatus");
                }
            }
        }

        private void btnBOQ_Click(object sender, EventArgs e)
        {
            try
            {
                bool toUpdate = false;
                bool toOverwrite = false;
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    MySqlCommand mysqlCmd0 = new MySqlCommand("SELECT * FROM pswotable WHERE CONCAT(`pickinglistGenStatus`) like 'NOT GENERATED' AND `woNum` like '%" + cbWONum.Text.ToString() + "%'", mysqlCon);
                    MySqlDataReader dbRead = mysqlCmd0.ExecuteReader();
                    if (dbRead.Read())
                    {
                        DialogResult dialogResult = MessageBox.Show("No PickingList Generated for this WO\n Generate new PickingList?", "X Title", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            toUpdate = true;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            toUpdate = false;
                        }
                    }
                    dbRead.Close();

                    if (woGrid.Rows[0].Cells[1].Value.ToString().Substring(0, 1) == "W")
                    {
                        if (toUpdate == true)
                        {
                            MySqlCommand MyCommand2 = new MySqlCommand("UPDATE pswotable SET pickinglistGenStatus = 'YES GENERATED' WHERE woNum = '" + cbWONum.SelectedItem.ToString() + "'", mysqlCon);
                            MySqlDataReader MyReader2 = MyCommand2.ExecuteReader();
                            MyReader2.Close();
                            ExcelExportImport();
                            foreach (DataGridViewRow row in woGrid.Rows)
                            {
                                if (row.Cells[1].Value != null)
                                {
                                    MySqlCommand mysqlCmd1 = new MySqlCommand("PickingListAddorEdit", mysqlCon);
                                    mysqlCmd1.CommandType = CommandType.StoredProcedure;
                                    mysqlCmd1.Parameters.AddWithValue("_id", id);
                                    mysqlCmd1.Parameters.AddWithValue("_woNum", row.Cells[1].Value.ToString().Trim());
                                    mysqlCmd1.Parameters.AddWithValue("_pickGroup", row.Cells[2].Value.ToString().Trim());
                                    mysqlCmd1.Parameters.AddWithValue("_partNum", row.Cells[3].Value.ToString().Trim());
                                    mysqlCmd1.Parameters.AddWithValue("_pickDescription", row.Cells[4].Value.ToString().Trim());
                                    mysqlCmd1.Parameters.AddWithValue("_pickUOM", row.Cells[5].Value.ToString().Trim());
                                    mysqlCmd1.Parameters.AddWithValue("_pickDate", row.Cells[6].Value.ToString().Trim());
                                    mysqlCmd1.Parameters.AddWithValue("_issuedBy", row.Cells[7].Value.ToString().Trim());
                                    mysqlCmd1.Parameters.AddWithValue("_issuedTo", row.Cells[8].Value.ToString().Trim());
                                    mysqlCmd1.Parameters.AddWithValue("_issueStatus", row.Cells[9].Value.ToString().Trim());
                                    mysqlCmd1.Parameters.AddWithValue("_pickCurStock", float.TryParse(row.Cells[10].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[10].Value.ToString().Trim()) : 0);
                                    mysqlCmd1.Parameters.AddWithValue("_demandQuant", float.TryParse(row.Cells[11].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[11].Value.ToString().Trim()) : 0);
                                    mysqlCmd1.Parameters.AddWithValue("_issuedQuant", float.TryParse(row.Cells[12].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[12].Value.ToString().Trim()) : 0);
                                    mysqlCmd1.Parameters.AddWithValue("_balanceQuant", float.TryParse(row.Cells[13].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[13].Value.ToString().Trim()) : 0);
                                    mysqlCmd1.Parameters.AddWithValue("_supplier", "X");
                                    mysqlCmd1.ExecuteNonQuery();
                                }
                            }
                            ClearAll();
                            GridEmpty();
                            MessageBox.Show("pickinglist Added");
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("Not Updated since pickinglist exists for this WO.\n\n Overwrite existing pickinglist?", "Y Title", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                toOverwrite = true;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                toOverwrite = false;
                            }

                            if (toOverwrite == true)
                            {
                                MySqlCommand mysqlCmd1 = new MySqlCommand("DELETE FROM pickinglisttable WHERE woNum = '" + cbWONum.Text.ToString() + "' ", mysqlCon);
                                mysqlCmd1.ExecuteNonQuery();
                                ExcelExportImport();
                                foreach (DataGridViewRow row in woGrid.Rows)
                                {
                                    if (row.Cells[1].Value != null)
                                    {
                                        MySqlCommand mysqlCmd = new MySqlCommand("PickingListAddorEdit", mysqlCon);
                                        mysqlCmd.CommandType = CommandType.StoredProcedure;
                                        mysqlCmd.Parameters.AddWithValue("_id", id);
                                        mysqlCmd.Parameters.AddWithValue("_woNum", row.Cells[1].Value.ToString().Trim());
                                        mysqlCmd.Parameters.AddWithValue("_pickGroup", row.Cells[2].Value.ToString().Trim());
                                        mysqlCmd.Parameters.AddWithValue("_partNum", row.Cells[3].Value.ToString().Trim());
                                        mysqlCmd.Parameters.AddWithValue("_pickDescription", row.Cells[4].Value.ToString().Trim());
                                        mysqlCmd.Parameters.AddWithValue("_pickUOM", row.Cells[5].Value.ToString().Trim());
                                        mysqlCmd.Parameters.AddWithValue("_pickDate", row.Cells[6].Value.ToString().Trim());
                                        mysqlCmd.Parameters.AddWithValue("_issuedBy", row.Cells[7].Value.ToString().Trim());
                                        mysqlCmd.Parameters.AddWithValue("_issuedTo", row.Cells[8].Value.ToString().Trim());
                                        mysqlCmd.Parameters.AddWithValue("_issueStatus", row.Cells[9].Value.ToString().Trim());
                                        mysqlCmd.Parameters.AddWithValue("_pickCurStock", float.TryParse(row.Cells[10].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[10].Value.ToString().Trim()) : 0);
                                        mysqlCmd.Parameters.AddWithValue("_demandQuant", float.TryParse(row.Cells[11].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[11].Value.ToString().Trim()) : 0);
                                        mysqlCmd.Parameters.AddWithValue("_issuedQuant", float.TryParse(row.Cells[12].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[12].Value.ToString().Trim()) : 0);
                                        mysqlCmd.Parameters.AddWithValue("_balanceQuant", float.TryParse(row.Cells[13].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[13].Value.ToString().Trim()) : 0);
                                        mysqlCmd.Parameters.AddWithValue("_supplier", "X");
                                        mysqlCmd.ExecuteNonQuery();
                                    }
                                }
                                ClearAll();
                                GridEmpty();
                                MessageBox.Show("pickinglist Overwritten");
                            }
                            else
                            {
                                MessageBox.Show("Not Overwritten.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select a WO.");
                    }
                    mysqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnWOAddProd_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnWOAddProd_Click");
            try
            {
                bool toUpdate = false;
                bool toOverwrite = false;
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    Console.WriteLine(woGrid.Columns[1].HeaderText);
                    if (woGrid.Columns[1].HeaderText == "soNum")
                    {
                        MySqlCommand mysqlCmd0 = new MySqlCommand("SELECT * FROM pswotable WHERE CONCAT(`woGenStatus`) like 'NOT GENERATED' AND `soNum` like '%" + cbSONum.Text.ToString() + "%'", mysqlCon);
                        MySqlDataReader dbRead = mysqlCmd0.ExecuteReader();
                        if (dbRead.Read())
                        {
                            DialogResult dialogResult = MessageBox.Show("No WO Generated for this SO\n Generate new WO?", "X Title", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                toUpdate = true;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                toUpdate = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error?");
                        }
                        dbRead.Close();

                        if (toUpdate == true)
                        {
                            string numStr = woGrid.Rows[0].Cells[1].Value.ToString().Trim();
                            numStr = "W" + numStr.Substring(1, numStr.Length - 1);
                            MySqlCommand MyCommand2 = new MySqlCommand("UPDATE pswotable SET woGenStatus = 'YES GENERATED' ,woCurStatus = '" + cbWOCurStatus.Text + "', woNum = '" + numStr + "' , woDate = '" + dtpWODate.Text.ToString() + "' WHERE soNum = '" + cbSONum.SelectedItem.ToString() + "'", mysqlCon);
                            MySqlDataReader MyReader2 = MyCommand2.ExecuteReader();
                            MyReader2.Close();

                            foreach (DataGridViewRow row in woGrid.Rows)
                            {
                                if (row.Cells[1].Value != null)
                                {
                                    MySqlCommand mysqlCmd1 = new MySqlCommand("WOAddorEdit", mysqlCon);
                                    mysqlCmd1.CommandType = CommandType.StoredProcedure;
                                    mysqlCmd1.Parameters.AddWithValue("_id", id);
                                    string s = row.Cells[1].Value.ToString().Trim();
                                    mysqlCmd1.Parameters.AddWithValue("_woNum", "W" + s.Substring(1, s.Length - 1));
                                    mysqlCmd1.Parameters.AddWithValue("_productCode", row.Cells[2].Value.ToString());
                                    mysqlCmd1.Parameters.AddWithValue("_productGroup", row.Cells[3].Value.ToString());
                                    mysqlCmd1.Parameters.AddWithValue("_productName", row.Cells[4].Value.ToString().Trim());
                                    mysqlCmd1.Parameters.AddWithValue("_productUOM", row.Cells[5].Value.ToString());
                                    mysqlCmd1.Parameters.AddWithValue("_productStatus", "NOT GENERATED");
                                    mysqlCmd1.Parameters.AddWithValue("_details", row.Cells[6].Value.ToString().Trim());
                                    mysqlCmd1.Parameters.AddWithValue("_specialNotes", row.Cells[7].Value.ToString().Trim());
                                    mysqlCmd1.Parameters.AddWithValue("_color", row.Cells[8].Value.ToString().Trim());
                                    mysqlCmd1.Parameters.AddWithValue("_length", float.TryParse(row.Cells[9].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[9].Value.ToString().Trim()) : 0);
                                    mysqlCmd1.Parameters.AddWithValue("_height", float.TryParse(row.Cells[11].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[11].Value.ToString().Trim()) : 0);
                                    mysqlCmd1.Parameters.AddWithValue("_width", float.TryParse(row.Cells[10].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[10].Value.ToString().Trim()) : 0);
                                    mysqlCmd1.Parameters.AddWithValue("_totalSQM", float.TryParse(row.Cells[12].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[12].Value.ToString().Trim()) : 0);
                                    mysqlCmd1.Parameters.AddWithValue("_quantity", float.TryParse(row.Cells[13].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[13].Value.ToString().Trim()) : 0);
                                    mysqlCmd1.Parameters.AddWithValue("_unitRate", float.TryParse(row.Cells[14].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[14].Value.ToString().Trim()) : 0);
                                    mysqlCmd1.Parameters.AddWithValue("_totalAmount", float.TryParse(row.Cells[15].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[15].Value.ToString().Trim()) : 0);
                                    //ClearBottom();
                                    //loadWO();
                                    mysqlCmd1.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show("WO has been generated.");
                        }
                        else if(toUpdate == false)
                        {
                            MessageBox.Show("WO not generated.");
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("Not Updated since WO exists for this SO.\n\n Overwrite existing WO?", "Y Title", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                toOverwrite = true;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                toOverwrite = false;
                            }

                            if (toOverwrite == true)
                            {
                                //MessageBox.Show("Delete teh needed WO and re-add SO");
                                string s = woGrid.Rows[0].Cells[1].Value.ToString().Trim();
                                string wonum = "W" + s.Substring(1, s.Length - 1);
                                MySqlCommand mysqlCmd1 = new MySqlCommand("DELETE FROM workordertable WHERE woNum = '" + wonum + "' ", mysqlCon);
                                mysqlCmd1.ExecuteNonQuery();
                                MySqlCommand mysqlCmd2 = new MySqlCommand("WOOverwrite", mysqlCon);
                                mysqlCmd2.CommandType = CommandType.StoredProcedure;
                                mysqlCmd2.Parameters.AddWithValue("_woNum", wonum);
                                mysqlCmd2.Parameters.AddWithValue("_soNum", s);
                                ClearBottom();
                                loadWO();
                                mysqlCmd2.ExecuteNonQuery();
                                Console.WriteLine(s+ " . " +wonum);
                            }
                            else
                            {
                                MessageBox.Show("Not Overwritten.");
                            }
                        }
                    }
                    else if (woGrid.Columns[1].HeaderText == "woNum")
                    {
                        //if (String.IsNullOrEmpty(cbSONum.Text) || String.IsNullOrEmpty(txtCustName.Text) || String.IsNullOrEmpty(txtProjName.Text) || String.IsNullOrEmpty(txtPONum.Text)
                        //    || String.IsNullOrEmpty(cbProdGroup.Text) || String.IsNullOrEmpty(txtLength.Text) || String.IsNullOrEmpty(txtSQM.Text) || String.IsNullOrEmpty(txtQuantity.Text) || String.IsNullOrEmpty(txtUnitRate.Text))
                        //{
                        //    MessageBox.Show("Something's missing?");
                        //}
                        //else
                        {
                            MySqlCommand mysqlCmd0 = new MySqlCommand("UPDATE pswotable SET woCurStatus = '" + cbWOCurStatus.Text + "' WHERE woNum = '" + cbWONum.Text + "' ", mysqlCon);
                            mysqlCmd0.ExecuteNonQuery();

                            Console.WriteLine(cbProdGroup.Text.ToString());
                            MySqlCommand mysqlCmd1 = new MySqlCommand("WOAddorEdit", mysqlCon);
                            mysqlCmd1.CommandType = CommandType.StoredProcedure;
                            mysqlCmd1.Parameters.AddWithValue("_id", id);
                            string s = cbWONum.Text.ToString();
                            mysqlCmd1.Parameters.AddWithValue("_woNum", "W" + s.Substring(1, s.Length - 1));
                            mysqlCmd1.Parameters.AddWithValue("_productCode", txtProdCode.Text.ToString());
                            mysqlCmd1.Parameters.AddWithValue("_productGroup", cbProdGroup.Text.ToString());
                            mysqlCmd1.Parameters.AddWithValue("_productName", cbProductName.Text.ToString().Trim());
                            mysqlCmd1.Parameters.AddWithValue("_productUOM", cbUoM.Text.ToString());
                            mysqlCmd1.Parameters.AddWithValue("_productStatus", cbProdStatus.Text.ToString());
                            mysqlCmd1.Parameters.AddWithValue("_details", txtDetails.Text.ToString().Trim());
                            mysqlCmd1.Parameters.AddWithValue("_specialNotes", txtSpecialNotes.Text.ToString().Trim());
                            mysqlCmd1.Parameters.AddWithValue("_color", cbColor.Text.ToString().Trim());
                            mysqlCmd1.Parameters.AddWithValue("_length", float.TryParse(txtLength.Text.ToString().Trim(), out value) ? float.Parse(txtLength.Text.ToString().Trim()) : 0);
                            mysqlCmd1.Parameters.AddWithValue("_height", float.TryParse(txtHeight.Text.ToString().Trim(), out value) ? float.Parse(txtHeight.Text.ToString().Trim()) : 0);
                            mysqlCmd1.Parameters.AddWithValue("_width", float.TryParse(txtWidth.Text.ToString().Trim(), out value) ? float.Parse(txtWidth.Text.ToString().Trim()) : 0);
                            mysqlCmd1.Parameters.AddWithValue("_totalSQM", float.TryParse(txtSQM.Text.ToString().Trim(), out value) ? float.Parse(txtSQM.Text.ToString().Trim()) : 0);
                            mysqlCmd1.Parameters.AddWithValue("_quantity", float.TryParse(txtQuantity.Text.ToString().Trim(), out value) ? float.Parse(txtQuantity.Text.ToString().Trim()) : 0);
                            mysqlCmd1.Parameters.AddWithValue("_unitRate", float.TryParse(txtUnitRate.Text.ToString().Trim(), out value) ? float.Parse(txtUnitRate.Text.ToString().Trim()) : 0);
                            mysqlCmd1.Parameters.AddWithValue("_totalAmount", float.TryParse(txtTotalAmount.Text.ToString().Trim(), out value) ? float.Parse(txtTotalAmount.Text.ToString().Trim()) : 0);
                            mysqlCmd1.ExecuteNonQuery();
                            ClearBottom();
                            loadWO();
                            MessageBox.Show("Data Updated");
                        }
                    }
                    //woGrid.ReadOnly = true;
                    LoadcbSO();
                    LoadcbWO();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void woGrid_DoubleClick(object sender, EventArgs e)
        {
            if (woGrid.ReadOnly == false)
            {
                txtProdCode.Text = woGrid.CurrentRow.Cells[2].Value.ToString();
                cbProdGroup.Text = woGrid.CurrentRow.Cells[3].Value.ToString();
                cbProductName.Text = woGrid.CurrentRow.Cells[4].Value.ToString();
                cbProdStatus.Text = woGrid.CurrentRow.Cells[5].Value.ToString();
                txtDetails.Text = woGrid.CurrentRow.Cells[6].Value.ToString();
                txtSpecialNotes.Text = woGrid.CurrentRow.Cells[7].Value.ToString();
                cbColor.Text = woGrid.CurrentRow.Cells[8].Value.ToString();
                cbUoM.Text = woGrid.CurrentRow.Cells[9].Value.ToString();
                txtLength.Text = woGrid.CurrentRow.Cells[10].Value.ToString();
                txtWidth.Text = woGrid.CurrentRow.Cells[11].Value.ToString();
                txtHeight.Text = woGrid.CurrentRow.Cells[12].Value.ToString();
                txtSQM.Text = woGrid.CurrentRow.Cells[13].Value.ToString();
                txtQuantity.Text = woGrid.CurrentRow.Cells[14].Value.ToString();
                txtUnitRate.Text = woGrid.CurrentRow.Cells[15].Value.ToString();
                txtTotalAmount.Text = woGrid.CurrentRow.Cells[16].Value.ToString();

                id = Convert.ToInt32(woGrid.CurrentRow.Cells[0].Value.ToString());
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
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand cmd = new MySqlCommand(" SELECT DISTINCT prodName FROM producttable WHERE prodGroup = '" + cbProdGroup.Text +"' ", mysqlCon);
                MySqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    cbProductName.Items.Add(dr1.GetString(0));
                }
                mysqlCon.Close();
            }
            LoadUoM();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FM.Show();
            this.Close();
        }

        private void cbProductName_SelectedIndexChanged(object sender, EventArgs e) => SetTxtVisStuff();

        private void txtWidth_TextChanged(object sender, EventArgs e) => DoMathonChange();

        private void txtLength_TextChanged(object sender, EventArgs e) => DoMathonChange();

        private void txtQuantity_TextChanged(object sender, EventArgs e) => DoMathonChange();

        private void txtTotalAmount_TextChanged(object sender, EventArgs e) => DoMathonChange();

        private void txtHeight_TextChanged(object sender, EventArgs e) => DoMathonChange();

        private void txtUnitRate_TextChanged(object sender, EventArgs e) => DoMathonChange();

        private void cbUoM_TextChanged(object sender, EventArgs e) => DoMathonChange();

        private void button1_Click(object sender, EventArgs e) => ExcelImport();

        private void btnEditPSWO_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd1 = new MySqlCommand("PSWOUpdate", mysqlCon);
                mysqlCmd1.CommandType = CommandType.StoredProcedure;
                mysqlCmd1.Parameters.AddWithValue("_customerName", txtCustName.Text.Trim());
                mysqlCmd1.Parameters.AddWithValue("_projectName", txtProjName.Text.Trim());
                mysqlCmd1.Parameters.AddWithValue("_soNum", cbSONum.Text);
                mysqlCmd1.Parameters.AddWithValue("_soDate", dtpSODate.Text.Trim());
                mysqlCmd1.Parameters.AddWithValue("_woNum", cbWONum.Text.Trim());
                mysqlCmd1.Parameters.AddWithValue("_woDate", dtpWODate.Text.Trim());
                mysqlCmd1.Parameters.AddWithValue("_woCurStatus", cbWOCurStatus.Text.Trim());
                mysqlCmd1.Parameters.AddWithValue("_poNum", txtPONum.Text.Trim());
                mysqlCmd1.Parameters.AddWithValue("_poDate", dtpPODate.Text.Trim());
                mysqlCmd1.Parameters.AddWithValue("_poDispatchDate", dtpPODispDate.Text.Trim());
                mysqlCmd1.Parameters.AddWithValue("_plannedCompDate", dtpWOPlannedCompDate.Text.Trim());
                mysqlCmd1.Parameters.AddWithValue("_basicValue", float.TryParse(txtProjBasicVal.Text.Trim(), out value) ? float.Parse(txtProjBasicVal.Text) : 0);
                mysqlCmd1.ExecuteNonQuery();
                MessageBox.Show("Updated SPWO Table");
            }
        }

        private void chkboxEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (woGrid.ReadOnly == true)
            {
                woGrid.ReadOnly = false;
                btnwotxt = btnWOAddProd.Text;
                btnWOAddProd.Text = "Update Values";
                chkboxEdit.BackColor = Color.IndianRed;
            }
            else if (woGrid.ReadOnly == false)
            {
                woGrid.ReadOnly = true;
                btnWOAddProd.Text = btnwotxt;
                chkboxEdit.BackColor = Color.White;
                id = 0;
            }
        }

        private void cbUoM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbUoM.Text == "Rmt" || cbUoM.Text == "LM" || cbUoM.Text == "Pc" || cbUoM.Text == "Nos")
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
                    txtProdCode.Text = dr1.GetString("prodID");
                    cbUoM.Text = dr1.GetString("prodUOM");

                    lblLength.Text = dr1.GetString("lblLengthTxt");
                    txtLength.Text = dr1.GetString("txtLengthTxt");
                    lblLength.Visible = dr1.GetBoolean("LengthVis");
                    txtLength.Visible = dr1.GetBoolean("LengthVis");
                    Console.WriteLine("\n" + dr1.GetString("lblLengthTxt") + " | " + dr1.GetString("txtLengthTxt") + " | " + dr1.GetBoolean("LengthVis"));

                    lblWidth.Text = dr1.GetString("lblWidthTxt");
                    txtWidth.Text = dr1.GetString("txtWidthTxt");
                    lblWidth.Visible = dr1.GetBoolean("WidthVis");
                    txtWidth.Visible = dr1.GetBoolean("WidthVis");
                    Console.WriteLine(dr1.GetString("lblWidthTxt") + " | " + dr1.GetString("txtWidthTxt") + " | " + dr1.GetBoolean("WidthVis"));

                    lblHeight.Text = dr1.GetString("lblHeightTxt");
                    txtHeight.Text = dr1.GetString("txtHeightTxt");
                    lblHeight.Visible = dr1.GetBoolean("HeightVis");
                    txtHeight.Visible = dr1.GetBoolean("HeightVis");
                    Console.WriteLine(dr1.GetString("lblHeightTxt") + " | " + dr1.GetString("txtHeightTxt") + " | " + dr1.GetBoolean("HeightVis"));
                }
                mysqlCon.Close();
            }
        }

        void GDL()
        {
            Console.WriteLine("GDL");
            sqm = (l * h) / 1000000;
            if (sqm < 0.1f)
            {
                sqm = 0.1f;
            }
            txtSQM.Text = sqm.ToString();
            if (cbUoM.Text == "Sqm")
            {
                ta = sqm * u * q;
                txtTotalAmount.Text = ta.ToString();
            }
            else if (cbUoM.Text == "LM" || cbUoM.Text == "Rmt")
            {
                ta = l * u * q;
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
            sqm = (l * l) / 1000000;
            if (sqm < 0.1f)
            {
                sqm = 0.1f;
            }
            txtSQM.Text = sqm.ToString();
            if (cbUoM.Text == "Sqm")
            {
                ta = sqm * u * q;
                txtTotalAmount.Text = ta.ToString();
            }
            else if (cbUoM.Text == "LM" || cbUoM.Text == "Rmt")
            {
                ta = l * u * q;
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
                ta = q * u * l;
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
            sqm = ((h + l) * 2 * w + (h * l) * 2) / 1000000;
            if (sqm < 0.1f)
            {
                sqm = 0.1f;
            }
            txtSQM.Text = sqm.ToString();
            if (cbUoM.Text == "Sqm")
            {
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
