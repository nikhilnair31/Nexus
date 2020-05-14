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
    public partial class FrmPurchaseOrder : Form
    {
        public FrmMain FM;
        string connectionString = @"Server=localhost; Database=projectdb; Uid=root; Pwd=abcXYZ@123";
        int l, id = 0, vali;
        long previd = 0;
        float value = float.NaN;
        string btnpotxt;

        public FrmPurchaseOrder()
        {
            InitializeComponent();
            //Pass();
            ClearAll();
            LoadcbPO();
            loadSupName();
            LoadprepBy();
            AssignPONum();
            LoadProdGroups();
            txtGSTIN.Text = "NotSure123";
            txtShiptoAdd.Text = "# 59/3D2, CHEEMASANDRA VILLAGE, VIRGONAGAR POST, BETWEEN MUNESHWARA SCHOOL AND POORNA PRAGYA SCHOOL, BENGALURU, KARNATAKA 560049";
        }

        void Pass()
        {
            var lines = File.ReadLines(@"C:\ERP\test.txt");
            foreach (var line in lines)
            {
                Console.WriteLine("line IS : " + line + "\n");
                string decSt = Decrypt(line);
                Console.WriteLine("decSt IS : " + decSt + "\n");
                Console.WriteLine("connectionString + decSt IS : " + (connectionString + decSt) + "\n");
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

        void AssignPONum()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    //Auto assigns PO Number by previous SO Number
                    int l = cbPONum.Items.Count - 1;
                    string s = cbPONum.Items[l].ToString();
                    s = s.Substring(2);
                    if (float.TryParse(s, out value))
                    {
                        float num = float.TryParse(s, out value) ? float.Parse(s) : 0;
                        labelPONum.Text = "PO" + (++num);
                        cbPONum.Text = labelPONum.Text;
                    }
                    else
                    {
                        //Auto assigns PO Number by table count
                        mysqlCon.Open();
                        MySqlCommand mysqlCmd = new MySqlCommand("SELECT COUNT(*) FROM pswotable", mysqlCon);
                        l = Convert.ToInt32(mysqlCmd.ExecuteScalar());
                        labelPONum.Text = "PO" + (++l);
                        cbPONum.Text = labelPONum.Text;
                        mysqlCon.Close();
                    }
                }
                catch
                {
                    //Auto assigns PO Number by table count
                    mysqlCon.Open();
                    MySqlCommand mysqlCmd = new MySqlCommand("SELECT COUNT(*) FROM pswotable", mysqlCon);
                    l = Convert.ToInt32(mysqlCmd.ExecuteScalar());
                    labelPONum.Text = "PO" + (++l);
                    cbPONum.Text = labelPONum.Text;
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
                MySqlCommand command = new MySqlCommand("SELECT DISTINCT prodGroup FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbProdGroup.Items.Add(reader.GetString(0));
                }
            }
        }

        private void LoadcbPO()
        {
            cbPONum.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT DISTINCT poNum FROM purchaseordertable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbPONum.Items.Add(reader.GetString(0));
                }
                mysqlCon.Close();
            }
        }

        private void LoadprepBy()
        {
            cbPrepBy.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT DISTINCT empName FROM employeetable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbPrepBy.Items.Add(reader.GetString(0));
                }
                mysqlCon.Close();
            }
        }

        void ClearAll()
        {
            labelPONum.Text = cbPONum.Text = dtpPODate.Text = txtGSTIN.Text = dtpRBDate.Text = "";
            txtBilltoAdd.Text = txtShiptoAdd.Text = cbPrepBy.Text = txtContactNum.Text = txtSupAdd.Text = txtSupCode.Text = "";
            txtSupGST.Text = cbSupName.Text = "";
            ClearBottom();
        }

        void ClearBottom()
        {
            cbProdGroup.Text = cbProductName.Text = txtProdCode.Text = cbUoM.Text = txtDetails.Text = txtSpecialNotes.Text = "";
            cbColor.Text = txtQuantity.Text = txtUnitRate.Text = txtTotalAmount.Text = txtGSTAmount.Text = "";
            id = 0;
            if(chkboxEdit.Checked == false)
                btnPOAddProd.Text = "Add PO";
        }

        void GridEmpty()
        {
            hideColumns();
            poGrid.DataSource = null;
            poGrid.Rows.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            GridEmpty();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            poGrid.ReadOnly = false;
            btnPOAddProd.Text = "Update PO";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd1 = new MySqlCommand(" DELETE FROM purchaseordertable WHERE id = '" + id + "' ", mysqlCon);
                mysqlCmd1.ExecuteNonQuery();
                id = 0;
                Reload(cbPONum);
                mysqlCon.Close();
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                foreach (DataGridViewRow row in poGrid.Rows)
                {
                    MySqlCommand MyCommand2 = new MySqlCommand("UPDATE rawmaterialtable SET lastPurchPrice = lastb1PurchPrice, buyCount = buyCount - 1, priceSum = priceSum - '" + row.Cells[23].Value + "' WHERE exitDescription = '" + row.Cells[16].Value + "'", mysqlCon);
                    MyCommand2.ExecuteNonQuery();
                }
                MySqlCommand mysqlCmd1 = new MySqlCommand(" DELETE FROM purchaseordertable WHERE poNum like '%" + cbPONum.Text + "%'", mysqlCon);
                mysqlCmd1.ExecuteNonQuery();
                cbPONum.Text = "";
                cbPONum.Items.Clear();
                LoadcbPO();
                GridEmpty();
                mysqlCon.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //GridFill();
            cbPONum.Items.Clear();
            Reload(cbPONum);
            LoadcbPO();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FM.Show();
            this.Close();
        }

        private void btnEditPO_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd1 = new MySqlCommand(@"UPDATE purchaseordertable 
                                                            SET billToAdd = '" + txtBilltoAdd.Text + "', shipToAdd = '" + txtShiptoAdd.Text + "', prepBy = '" + cbPrepBy.Text + "', contactNum = '" + txtContactNum.Text + "'" +
                                                            " WHERE poNum = '" + cbPONum.Text +"' ", mysqlCon);
                mysqlCmd1.ExecuteNonQuery();
                mysqlCon.Close();
            }
            MessageBox.Show("PO Details have been updated.");
        }

        private void btnSOAddProd_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnSOAddProd_Click");
            if (String.IsNullOrEmpty(cbPONum.Text))
            {
                MessageBox.Show("Fill cbPONum.");
            }
            else
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    MySqlCommand mysqlCmd1 = new MySqlCommand("POAddorEdit", mysqlCon);
                    mysqlCmd1.CommandType = CommandType.StoredProcedure;
                    mysqlCmd1.Parameters.AddWithValue("_id", id);
                    mysqlCmd1.Parameters.AddWithValue("_woNum", txtWONum.Text);
                    mysqlCmd1.Parameters.AddWithValue("_poStatus", cbPOStatus.Text);
                    mysqlCmd1.Parameters.AddWithValue("_poNum", cbPONum.Text);
                    mysqlCmd1.Parameters.AddWithValue("_poDate", dtpPODate.Text);
                    mysqlCmd1.Parameters.AddWithValue("_gstin", txtGSTIN.Text);
                    mysqlCmd1.Parameters.AddWithValue("_reqDate", dtpRBDate.Text);
                    mysqlCmd1.Parameters.AddWithValue("_billToAdd", txtBilltoAdd.Text);
                    mysqlCmd1.Parameters.AddWithValue("_shipToAdd", txtShiptoAdd.Text);
                    mysqlCmd1.Parameters.AddWithValue("_prepBy", cbPrepBy.Text);
                    mysqlCmd1.Parameters.AddWithValue("_contactNum", txtContactNum.Text);
                    mysqlCmd1.Parameters.AddWithValue("_supplierCode", txtSupCode.Text);
                    mysqlCmd1.Parameters.AddWithValue("_supplierName", cbSupName.Text);
                    mysqlCmd1.Parameters.AddWithValue("_supplierAdd", txtSupAdd.Text);
                    mysqlCmd1.Parameters.AddWithValue("_supplierGST", txtSupGST.Text);
                    mysqlCmd1.Parameters.AddWithValue("_productGroup", cbProdGroup.Text);
                    mysqlCmd1.Parameters.AddWithValue("_productCode", txtProdCode.Text);
                    mysqlCmd1.Parameters.AddWithValue("_productName", cbProductName.Text);
                    mysqlCmd1.Parameters.AddWithValue("_uom", cbUoM.Text);
                    mysqlCmd1.Parameters.AddWithValue("_deets", txtDetails.Text);
                    mysqlCmd1.Parameters.AddWithValue("_specNotes", txtSpecialNotes.Text);
                    mysqlCmd1.Parameters.AddWithValue("_col", cbColor.Text);

                    string q = txtQuantity.Text;
                    string r = txtUnitRate.Text;
                    string t = txtTotalAmount.Text;
                    string g = txtGSTAmount.Text;
                    Console.WriteLine("btnSOAddProd_Click ---\t" + q + "\t" + r + "\t" + t + "\t" + g);
                    int q1 = int.TryParse(txtQuantity.Text, out vali) ? int.Parse(txtQuantity.Text) : 0;
                    float r1 = float.TryParse(txtUnitRate.Text, out value) ? float.Parse(txtUnitRate.Text) : 0;
                    float t1 = float.TryParse(txtTotalAmount.Text, out value) ? float.Parse(txtTotalAmount.Text) : 0;
                    float g1 = float.TryParse(txtGSTAmount.Text, out value) ? float.Parse(txtGSTAmount.Text) : 0;
                    Console.WriteLine("btnSOAddProd_Click ---\t" + q1 + "\t" + r1 + "\t" + t1 + "\t" + g1);

                    mysqlCmd1.Parameters.AddWithValue("_quant", q1);
                    mysqlCmd1.Parameters.AddWithValue("_rate", r1);
                    mysqlCmd1.Parameters.AddWithValue("_totAmt", t1);
                    mysqlCmd1.Parameters.AddWithValue("_gstAmt", g1);
                    mysqlCmd1.ExecuteNonQuery();
                    previd = mysqlCmd1.LastInsertedId;
                    mysqlCon.Close();
                }
                ClearBottom();
                LoadcbPO();
                Reload(cbPONum);
                MessageBox.Show("Added Products to PO.");
            }
        }

        void hideColumns()
        {
            for (int i = 0; i <= 14; i++)
                poGrid.Columns[i].Visible = false;
            poGrid.Columns[19].Visible = poGrid.Columns[20].Visible = false;
        }

        void Reload(ComboBox cbText)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM purchaseordertable WHERE CONCAT(`poNum`) like '%" + cbText.Text + "%'", mysqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                poGrid.DataSource = table;
                poGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                hideColumns();
                labelPONum.Text = cbText.Text;
                adapter.Dispose();
                mysqlCon.Close();
            }
        }

        private void cbPONum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("cbPONum_SelectedIndexChanged");
            loadPO();
        }

        private void loadPO()
        {
            Console.WriteLine("loadPO");
            btnPOAddProd.Text = "Insert Product";
            lblGridSource.Text = "Looking at Purchase Order Table";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM purchaseordertable WHERE poNum = '" + cbPONum.Text + "'", mysqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                poGrid.DataSource = table;
                poGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                hideColumns();
                adapter.Dispose();

                MySqlCommand command1 = new MySqlCommand("SELECT DISTINCT * FROM purchaseordertable WHERE poNum = '" + cbPONum.Text + "'", mysqlCon);
                MySqlDataReader dbRead = command1.ExecuteReader();
                if (dbRead.Read())
                {
                    Console.WriteLine("prepBy : "+dbRead.GetString("productCode"));
                    dtpPODate.Text = dbRead.GetString("poDate");
                    txtGSTIN.Text = dbRead.GetString("gstin");
                    dtpRBDate.Text = dbRead.GetString("reqDate");
                    cbPOStatus.Text = dbRead.GetString("poStatus");
                    txtBilltoAdd.Text = dbRead.GetString("billToAdd");
                    txtShiptoAdd.Text = dbRead.GetString("shipToAdd");
                    cbPrepBy.Text = dbRead.GetString("prepBy");
                    txtContactNum.Text = dbRead.GetString("contactNum");
                    txtSupAdd.Text = dbRead.GetString("supplierAdd");
                    txtSupCode.Text = dbRead.GetString("productCode");
                    txtSupGST.Text = dbRead.GetString("supplierGST");
                    cbSupName.Text = dbRead.GetString("supplierName");
                    txtWONum.Text = dbRead.GetString("woNum");
                }
                dbRead.Close();
                mysqlCon.Close();
            }
        }

        private void btnDelPOWO_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd1 = new MySqlCommand(" DELETE FROM purchaseordertable WHERE woNum = '" + txtWONum.Text + "' ", mysqlCon);
                mysqlCmd1.ExecuteNonQuery();
                MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE pswotable SET poGenStatus = 'NOT GENERATED' WHERE woNum = '" + txtWONum.Text + "'", mysqlCon);
                mysqlCmd2.ExecuteNonQuery();
                mysqlCon.Close();
            }
            MessageBox.Show("All POs of that WO have been deleted.");
        }

        void loadSupName()
        {
            cbSupName.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(" SELECT DISTINCT supplier1name,supplier2name,supplier3name FROM suppliergroupstable ", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbSupName.Items.Add(reader.GetString(0));
                }
            }
        }

        private void cbSupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSupCode.Clear();
            txtSupAdd.Clear();
            txtSupGST.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(" SELECT * FROM customertable WHERE custName = '"+ cbSupName.Text+ "' ", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtSupCode.Text = reader.GetString("custID");
                    txtSupAdd.Text = reader.GetString("adresses");
                    txtSupGST.Text = reader.GetString("gstNum");
                }
            }
        }

        private void _cmdPrint_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(@" UPDATE projectdb.rawmaterialtable 
                                                        SET quantity = quantity + (SELECT `quantity` FROM projectdb.purchaseordertable 
                                                        WHERE productName = exitDescription LIMIT 1)", mysqlCon);
                command.ExecuteNonQuery();
                mysqlCon.Close();
            }
            MessageBox.Show("Added quantity values to rawmaterialtable.");
        }

        private void poGrid_DoubleClick(object sender, EventArgs e)
        {
            if (poGrid.ReadOnly == false)
            {
                txtProdCode.Text = poGrid.CurrentRow.Cells[17].Value.ToString();
                cbProdGroup.Text = poGrid.CurrentRow.Cells[15].Value.ToString();
                cbProductName.Text = poGrid.CurrentRow.Cells[16].Value.ToString();
                txtDetails.Text = poGrid.CurrentRow.Cells[19].Value.ToString();
                txtSpecialNotes.Text = poGrid.CurrentRow.Cells[20].Value.ToString();
                cbColor.Text = poGrid.CurrentRow.Cells[21].Value.ToString();
                cbUoM.Text = poGrid.CurrentRow.Cells[18].Value.ToString();
                txtQuantity.Text = poGrid.CurrentRow.Cells[22].Value.ToString();
                txtUnitRate.Text = poGrid.CurrentRow.Cells[23].Value.ToString();
                txtTotalAmount.Text = poGrid.CurrentRow.Cells[24].Value.ToString();
                txtGSTAmount.Text = poGrid.CurrentRow.Cells[25].Value.ToString();

                id = Convert.ToInt32(poGrid.CurrentRow.Cells[0].Value.ToString());
                Console.WriteLine("ID : "+id);
            }
        }

        private void cbProdGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProductName.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand cmd1 = new MySqlCommand(" SELECT * FROM rawmaterialtable WHERE prodGroup = '" + cbProdGroup.Text + "' ", mysqlCon);
                MySqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    cbProductName.Items.Add(dr1.GetString("exitDescription"));
                }
                dr1.Close();
                mysqlCon.Close();
            }
        }

        private void chkboxEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (poGrid.ReadOnly == true)
            {
                poGrid.ReadOnly = false;
                btnpotxt = btnPOAddProd.Text;
                btnPOAddProd.Text = "Update Values";
                chkboxEdit.BackColor = Color.IndianRed;
            }
            else if (poGrid.ReadOnly == false)
            {
                poGrid.ReadOnly = true;
                btnPOAddProd.Text = btnpotxt;
                chkboxEdit.BackColor = Color.White;
                id = 0;
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
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
                GridEmpty();
                string sonum = (cbPONum.Items[cbPONum.Items.Count - 1].ToString());
                sonum = sonum.Substring(sonum.Length - 1);
                int x = int.Parse(sonum);
                Console.WriteLine(sonum);
                labelPONum.Text = "PO" + (x + 1);
                cbPONum.Text = labelPONum.Text;
            }
            catch
            {
                MessageBox.Show("oops");
            }
        }
    }
}
