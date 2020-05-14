using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestX
{
    public partial class FrmIssue : Form
    {
        string connectionString = @"Server=localhost; Database=projectdb; Uid=root; Pwd=abcXYZ@123";
        bool spwAdded = false;
        //bool spwGrid = false;
        int id = 0;
        float value = float.NaN;

        public FrmIssue()
        {
            InitializeComponent();
            //Pass();
            ClearAll();
            LoadcbWO();
            LoadcbPO();
            LoadRecIDDeets();
            LoadIssGroup();
            //LoadIssDescription();
            LoadIssUOM();
            LoadIssIssuedBy();
            LoadIssIssuedTo();
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

        private void LoadcbWO()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(" SELECT * FROM pswotable WHERE woGenStatus like 'YES GENERATED' AND pickinglistGenStatus like 'YES GENERATED'", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string st = reader.GetString("woNum");
                    cbWONum.Items.Add(st);
                }
            }
        }

        private void LoadcbPO()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand(" SELECT DISTINCT poNum FROM purchaseordertable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string st = reader.GetString(0);
                    cbPONum.Items.Add(st);
                }
            }
        }

        private void LoadIssGroup()
        {
            cbProductGroup.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT DISTINCT prodGroup FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbProductGroup.Items.Add(reader.GetString(0));
                }
            }
        }

        private void LoadIssDescription()
        {
            cbDescription.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT DISTINCT exitDescription FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbDescription.Items.Add(reader.GetString(0));
                }
            }
        }

        private void LoadIssUOM()
        {
            cbUOM.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT DISTINCT uom FROM rawmaterialtable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbUOM.Items.Add(reader.GetString(0));
                }
            }
        }

        private void LoadIssIssuedTo()
        {
            cbIssuedTo.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT DISTINCT empName FROM employeetable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbIssuedTo.Items.Add(reader.GetString(0));
                }
            }
        }

        private void LoadIssIssuedBy()
        {
            cbIssuedBy.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT DISTINCT * FROM employeetable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbIssuedBy.Items.Add(reader.GetString("empName"));
                }
            }
        }

        private void LoadRecIDDeets()
        {
            cbRecID.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM issuetable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbRecID.Items.Add(reader.GetString("recID"));
                }
            }
        }

        void ClearAll()
        {
            cbRecID.Text = cbWONum.Text = cbProductGroup.Text = cbDescription.Text = "";
            txtQuantity.Text = cbWONum.Text = cbIssuedBy.Text = cbIssuedTo.Text = dtpDate.Text = "";
            id = 0;
            btnAddIssue.Text = "Add";
        }

        void hideColumns()
        {
            for (int i = 0; i <= 14; i++)
                issueGrid.Columns[i].Visible = false;
            issueGrid.Columns[19].Visible = issueGrid.Columns[20].Visible = false;
        }

        void Reload(ComboBox cbText)
        {
            string refType = "";
            if(cbText.Text != "" && cbText.Text.Substring(0,2) == "WO")
            {
                refType = "WO";
            }
            else if(cbText.Text != "" && cbText.Text.Substring(0, 2) == "SO")
            {
                refType = "SO";
            }
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM issuetable WHERE '"+ refType + "' like '%" + cbText.Text + "%'", mysqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                issueGrid.DataSource = table;
                //hideColumns();
                issueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //labelSONum.Text = cbText.Text;
                adapter.Dispose();
                mysqlCon.Close();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload(cbRecID);
            LoadRecIDDeets();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDescription.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand cmd = new MySqlCommand(" SELECT * FROM rawmaterialtable WHERE prodGroup = '" + cbProductGroup.Text + "' ", mysqlCon);
                MySqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    cbDescription.Items.Add(dr1.GetString("exitDescription"));
                }
                mysqlCon.Close();
            }
            //LoadNPartNum();
            //LoadSPartNum();
            //GridEmpty();
            //Reload(cbProductGroup);
        }

        //Get stock of item selected
        private void cbDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("cbDescription_SelectedIndexChanged");
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand cmd = new MySqlCommand(" SELECT quantity FROM rawmaterialtable WHERE exitDescription = '" + cbDescription.Text + "' ", mysqlCon);
                MySqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    string opStock = dr1.GetString(0);
                    txtStock.Text = opStock;
                    Console.WriteLine("cbDescription_SelectedIndexChanged - " + cbDescription.Text + " | " + opStock + " / " + txtStock.Text);
                }
                mysqlCon.Close();
            }
        }

        private void issueGrid_DoubleClick(object sender, EventArgs e)
        {
            if (issueGrid.ReadOnly == false)
            {
                id = Convert.ToInt32(issueGrid.CurrentRow.Cells[0].Value.ToString());

                cbWONum.Text = issueGrid.CurrentRow.Cells[1].Value.ToString();
                cbIssuedBy.Text = issueGrid.CurrentRow.Cells[9].Value.ToString();
                txtQuantity.Text = issueGrid.CurrentRow.Cells[22].Value.ToString();
                cbProductGroup.Text = issueGrid.CurrentRow.Cells[15].Value.ToString();
                cbDescription.Text = issueGrid.CurrentRow.Cells[16].Value.ToString();
                cbUOM.Text = issueGrid.CurrentRow.Cells[18].Value.ToString();
                

                //cbRecID.Text = issueGrid.CurrentRow.Cells[1].Value.ToString();
                //cbWONum.Text = issueGrid.CurrentRow.Cells[2].Value.ToString();
                //cbProductGroup.Text = issueGrid.CurrentRow.Cells[3].Value.ToString();
                //cbDescription.Text = issueGrid.CurrentRow.Cells[4].Value.ToString();
                //txtQuantity.Text = issueGrid.CurrentRow.Cells[5].Value.ToString();
                //cbUOM.Text = issueGrid.CurrentRow.Cells[6].Value.ToString();
                //cbIssuedBy.Text = issueGrid.CurrentRow.Cells[7].Value.ToString();
                //cbIssuedTo.Text = issueGrid.CurrentRow.Cells[8].Value.ToString();
                //dtpDate.Text = issueGrid.CurrentRow.Cells[9].Value.ToString();

                
            }
        }

        private void cbRecID_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand cmd = new MySqlCommand(" SELECT * FROM issuetable WHERE recID like '%" + cbRecID.Text + "%' ", mysqlCon);
                MySqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    //cbRecID.Items.Add(dr1.GetString("prodName"));
                    cbWONum.Text = dr1.GetString("woNum");
                    cbProductGroup.Text = dr1.GetString("recStockGroup");
                    cbDescription.Text = dr1.GetString("recDescription");
                    txtQuantity.Text = dr1.GetString("recQuantity");
                    cbUOM.Text = dr1.GetString("recUOM");
                    cbIssuedBy.Text = dr1.GetString("recIssuedBy");
                    cbIssuedTo.Text = dr1.GetString("recIssuedTo");
                    dtpDate.Text = dr1.GetString("recDate");
                }
                mysqlCon.Close();
            }
        }

        //Fill details of selected WO
        private void _CBWO_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                //MySqlCommand command = new MySqlCommand("SELECT * FROM pickinglisttable WHERE CONCAT(`woNum`) like '%" + cbWONum.Text + "%'", mysqlCon);
                //MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                //System.Data.DataTable table = new System.Data.DataTable();
                //adapter.Fill(table);
                //issueGrid.DataSource = table;
                //issueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //issueGrid.Columns[0].Visible = false;
                //adapter.Dispose();

                //MySqlCommand command1 = new MySqlCommand("SELECT * FROM pickinglisttable WHERE CONCAT(`woNum`) like '%" + cbWONum.Text + "%'", mysqlCon);
                //MySqlDataReader dbRead = command1.ExecuteReader();
                //if (dbRead.Read())
                //{
                //    //dtpSODate.Text = dbRead.GetString(2);
                //}

                MySqlCommand command = new MySqlCommand("SELECT * FROM pickinglisttable WHERE CONCAT(`woNum`) like '%" + cbWONum.Text + "%'", mysqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                issueGrid.DataSource = table;
                issueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                issueGrid.Columns[0].Visible = false;
                //issueGrid.Columns[1].Visible = false;
                //issueGrid.Columns[2].Visible = false;
                adapter.Dispose();

                MySqlCommand command1 = new MySqlCommand("SELECT * FROM pickinglisttable WHERE CONCAT(`woNum`) like '%" + cbWONum.Text + "%'", mysqlCon);
                MySqlDataReader dbRead = command1.ExecuteReader();
                if (dbRead.Read())
                {
                    cbWONum.Text = cbWONum.Text.ToString().Trim();
                    //cbPONum.Text = dbRead.GetString("poNum");
                }
                dbRead.Close();

                //foreach (DataGridViewRow row in issueGrid.Rows)
                //{
                //    if (row.Cells[1].Value != null)
                //    {
                //        MySqlCommand mysqlCmd1 = new MySqlCommand("UPDATE pickinglisttable, rawmaterialtable SET pickinglisttable.pickCurStock = rawmaterialtable.quantity WHERE pickinglisttable.pickDescription = rawmaterialtable.exitDescription AND pickinglisttable.id = '" + row.Cells[0].Value + "'; ", mysqlCon);
                //        //mysqlCmd1.Parameters.AddWithValue("_id", row.Cells[0].Value);
                //        //float pickCurStock = float.TryParse(row.Cells[9].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[9].Value.ToString().Trim()) : 0;
                //        mysqlCmd1.ExecuteNonQuery();
                //    }
                //}
            }
        }

        private void cbPONum_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM purchaseordertable WHERE CONCAT(`poNum`) like '%" + cbPONum.Text + "%'", mysqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                issueGrid.DataSource = table;
                issueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                hideColumns();
                adapter.Dispose();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            issueGrid.ReadOnly = false;
            btnAddIssue.Text = "IDK";
        }

        private void issueGrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (issueGrid.CurrentRow.Index != -1)
                {
                    try
                    {
                        id = Convert.ToInt32(issueGrid.CurrentRow.Cells[0].Value.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Don't double click there.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Don't click here.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd1 = new MySqlCommand("DELETE FROM issuetable WHERE id = '" + id + "' ", mysqlCon);
                mysqlCmd1.ExecuteNonQuery();
                id = 0;
                ClearAll();
                LoadRecIDDeets();
                Reload(cbRecID);
            }
        }

        //Have this issued material added to either raw mat table
        private void btnAddIssue_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                if (spwAdded == false)
                {
                    MySqlCommand mysqlCmd1 = new MySqlCommand("IssAddorEdit", mysqlCon);
                    mysqlCmd1.CommandType = CommandType.StoredProcedure;
                    mysqlCmd1.Parameters.AddWithValue("_id", id);
                    mysqlCmd1.Parameters.AddWithValue("_recID", cbRecID.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_woNum", cbWONum.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_recStockGroup", cbProductGroup.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_recDescription", cbDescription.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_recQuantity", float.TryParse(txtQuantity.Text.Trim(), out value) ? float.Parse(txtQuantity.Text) : 0);
                    mysqlCmd1.Parameters.AddWithValue("_recUOM", cbUOM.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_recIssuedBy", cbIssuedBy.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_recIssuedTo", cbIssuedTo.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_recDate", dtpDate.Text.Trim());
                    mysqlCmd1.ExecuteNonQuery();

                    MessageBox.Show("Added to Issue Table");
                    //spwAdded = true;
                }
                issueGrid.ReadOnly = true;
                ClearAll();
                //Reload(cbRecID);
                LoadRecIDDeets();
                LoadIssGroup();
                //LoadIssDescription();
                LoadIssUOM();
                LoadIssIssuedBy();
                LoadIssIssuedTo();
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                foreach (DataGridViewRow row in issueGrid.Rows)
                {
                    if (row.Cells[1].Value != null && (row.Cells[8].Value.ToString() != "COMPLETELY ISSUED" || row.Cells[8].Value.ToString() == "") )
                    {
                        MySqlCommand mysqlCmd1 = new MySqlCommand("PickingListAddorEdit", mysqlCon);
                        mysqlCmd1.CommandType = CommandType.StoredProcedure;
                        mysqlCmd1.Parameters.AddWithValue("_id", row.Cells[0].Value);
                        mysqlCmd1.Parameters.AddWithValue("_woNum", row.Cells[1].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_supplier", row.Cells[2].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_pickGroup", row.Cells[3].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_partNum", row.Cells[4].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_pickDescription", row.Cells[5].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_pickUOM", row.Cells[6].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_pickDate", row.Cells[7].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_issuedBy", row.Cells[8].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_issuedTo", row.Cells[9].Value.ToString());

                        String issueStatus = row.Cells[10].Value.ToString().Trim();
                        float pickCurStock = float.TryParse(row.Cells[11].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[11].Value.ToString().Trim()) : 0;
                        float demandQuant = float.TryParse(row.Cells[12].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[12].Value.ToString().Trim()) : 0;
                        float issuedQuant = float.TryParse(row.Cells[13].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[13].Value.ToString().Trim()) : 0;
                        float balanceQuant = float.TryParse(row.Cells[14].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[14].Value.ToString().Trim()) : 0;
                        if (demandQuant < pickCurStock)
                        {
                            Console.WriteLine(row.Cells[0].Value+" - "+issueStatus + " | " + pickCurStock + " | " + demandQuant + " | " + issuedQuant + " | " + balanceQuant);
                            issuedQuant = demandQuant;
                            balanceQuant = demandQuant - issuedQuant;
                            pickCurStock = pickCurStock - issuedQuant;
                            if (balanceQuant == 0)
                            {
                                issueStatus = "COMPLETELY ISSUED";
                            }
                            else if (balanceQuant > 0)
                            {
                                issueStatus = "PARTLY ISSUED";
                            }
                            Console.WriteLine(issueStatus + " | " + pickCurStock + " | " + demandQuant + " | " + issuedQuant + " | " + balanceQuant);
                        }
                        mysqlCmd1.Parameters.AddWithValue("_issueStatus", issueStatus);
                        mysqlCmd1.Parameters.AddWithValue("_pickCurStock", pickCurStock);
                        mysqlCmd1.Parameters.AddWithValue("_demandQuant", demandQuant);
                        mysqlCmd1.Parameters.AddWithValue("_issuedQuant", issuedQuant);
                        mysqlCmd1.Parameters.AddWithValue("_balanceQuant", balanceQuant);

                        mysqlCmd1.ExecuteNonQuery();

                        //float sum = 1;
                        //MySqlCommand mysqlCmd2 = new MySqlCommand("UPDATE pickinglisttable, rawmaterialtable SET pickinglisttable.pickCurStock = rawmaterialtable.quantity WHERE pickinglisttable.pickDescription = rawmaterialtable.exitDescription AND pickinglisttable.id = '" + row.Cells[0].Value + "'; ", mysqlCon);
                        //mysqlCmd1.Parameters.AddWithValue("_id", row.Cells[0].Value);
                        //float pickCurStock = float.TryParse(row.Cells[9].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[9].Value.ToString().Trim()) : 0;
                        //mysqlCmd2.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Updated quantities in PickingList Table");
                issueGrid.ReadOnly = true;
                ClearAll();
                Reload(cbRecID);
                LoadRecIDDeets();
                LoadIssGroup();
                //LoadIssDescription();
                LoadIssUOM();
                LoadIssIssuedBy();
                LoadIssIssuedTo();
            }
        }

        //void QuantCalculation(MySqlCommand mysqlCmd1, DataGridViewRow row)
        //{
        //    String issueStatus = row.Cells[8].Value.ToString().Trim();
        //    float pickCurStock = float.TryParse(row.Cells[9].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[9].Value.ToString().Trim()) : 0;
        //    float demandQuant = float.TryParse(row.Cells[10].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[10].Value.ToString().Trim()) : 0;
        //    float issuedQuant = float.TryParse(row.Cells[11].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[11].Value.ToString().Trim()) : 0;
        //    float balanceQuant = float.TryParse(row.Cells[12].Value.ToString().Trim(), out value) ? float.Parse(row.Cells[12].Value.ToString().Trim()) : 0;
        //    if(demandQuant < pickCurStock)
        //    {
        //        issuedQuant = demandQuant;
        //        balanceQuant = demandQuant - issuedQuant;
        //        pickCurStock = pickCurStock - issuedQuant;
        //        if(balanceQuant == 0)
        //        {
        //            issueStatus = "COMPLETELY ISSUED";
        //        }
        //        else if (balanceQuant > 0)
        //        {
        //            issueStatus = "PARTLY ISSUED";
        //        }
        //    }
        //    mysqlCmd1.Parameters.AddWithValue("_issueStatus", issueStatus);
        //    mysqlCmd1.Parameters.AddWithValue("_pickCurStock", pickCurStock);
        //    mysqlCmd1.Parameters.AddWithValue("_demandQuant", demandQuant);
        //    mysqlCmd1.Parameters.AddWithValue("_issuedQuant", issuedQuant);
        //    mysqlCmd1.Parameters.AddWithValue("_balanceQuant", balanceQuant);
        //}

        void DataGridtoSQL()
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    for (int i=0; i< issueGrid.Rows.Count; i++)
                    {
                        MySqlCommand mysqlCmd1 = new MySqlCommand("IssAddorEdit", mysqlCon);
                        mysqlCmd1.CommandType = CommandType.StoredProcedure;
                        mysqlCmd1.Parameters.AddWithValue("_id", id);
                        mysqlCmd1.Parameters.AddWithValue("_recID", issueGrid.Rows[i].Cells[1].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_woNum", issueGrid.Rows[i].Cells[2].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_recStockGroup", issueGrid.Rows[i].Cells[3].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_recDescription", issueGrid.Rows[i].Cells[4].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_recQuantity", float.TryParse(issueGrid.Rows[i].Cells[5].Value.ToString(), out value) ? float.Parse(issueGrid.CurrentRow.Cells[5].Value.ToString()) : 0);
                        mysqlCmd1.Parameters.AddWithValue("_recUOM", issueGrid.Rows[i].Cells[6].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_recIssuedBy", issueGrid.Rows[i].Cells[7].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_recIssuedTo", issueGrid.Rows[i].Cells[8].Value.ToString());
                        mysqlCmd1.Parameters.AddWithValue("_recDate", issueGrid.Rows[i].Cells[9].Value.ToString());
                        mysqlCmd1.ExecuteNonQuery();
                    }
                    MessageBox.Show("Imported into Issue Table");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.DataSet DtSet;
                System.Data.OleDb.OleDbDataAdapter MyCommand;
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\\ERP\\BOQ.xls';Extended Properties=Excel 8.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [WO$A1:J11]", MyConnection);
                MyCommand.TableMappings.Add("Table", "TestTable");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                issueGrid.DataSource = DtSet.Tables[0];
                DataGridtoSQL();
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbUOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtQuantity.Clear();
            //using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            //{
            //    mysqlCon.Open();
            //    MySqlCommand cmd = new MySqlCommand(" SELECT * FROM rawmaterialtable WHERE prodGroup = '" + cbProductGroup.Text + "' AND uom = '" + cbUOM.Text + "' ", mysqlCon);
            //    MySqlDataReader dr1 = cmd.ExecuteReader();
            //    while (dr1.Read())
            //    {
            //        txtQuantity.Text = dr1.GetString("quantity");
            //    }
            //    mysqlCon.Close();
            //}
            //LoadNPartNum();
            //LoadSPartNum();
            //GridEmpty();
            //Reload(cbProductGroup);
        }

    }
}
