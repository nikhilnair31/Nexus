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

namespace TestX
{
    public partial class FrmProducts : Form
    {
        string connectionString = @"Server=localhost; Database=projectdb; Uid=root; Pwd=abcXYZ@123";
        bool spwAdded = false;
        //bool spwGrid = false;
        int id = 0;
        float value = float.NaN;

        public FrmProducts()
        {
            InitializeComponent();
            //Pass();
            ClearAll();
            LoadUOM();
            LoadProdGroups();
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

        private void LoadUOM()
        {
            cbUoM.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT prodUOM FROM producttable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbUoM.Items.Count; i++)
                    {
                        if (cbUoM.Items[i].ToString() == reader.GetString(0))
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
                        cbUoM.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                    {
                        continue;
                    }
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
                    for(int i=0; i<cbProdGroup.Items.Count; i++)
                    {
                        if(cbProdGroup.Items[i].ToString() == reader.GetString(0))
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
                        cbProdGroup.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void LoadEmpDeets()
        {
            cbProdID.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM producttable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbProdID.Items.Add(reader.GetString("prodID"));
                }
            }
        }

        void ClearAll()
        {
            cbProdID.Text = cbProdName.Text = cbProdGroup.Text = cbManufTrad.Text = "";
            cbUoM.Text = txtMinSP.Text = txtMaxSP.Text = txtAvgSP.Text = "";
            id = 0;
            btnAddProd.Text = "Add";
        }

        void Reload(ComboBox cbText)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM producttable WHERE CONCAT(`prodID`) like '%" + cbProdID.Text + "%'", mysqlCon);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    prodGrid.DataSource = table;
                    prodGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    prodGrid.Columns[0].Visible = false;
                    for(int i=9; i<=20; i++)
                    {
                        prodGrid.Columns[i].Visible = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Reload");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            prodGrid.ReadOnly = false;
            btnAddProd.Text = "Update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd1 = new MySqlCommand("DELETE FROM producttable WHERE id = '" + id + "' ", mysqlCon);
                mysqlCmd1.ExecuteNonQuery();
                ClearAll();
                LoadEmpDeets();
                Reload(cbProdID);
            }
        }

        private void cbProdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            //{
            //    mysqlCon.Open();
            //    MySqlCommand command = new MySqlCommand("SELECT * FROM producttable WHERE CONCAT(`prodID`) like '%" + cbProdID.SelectedItem.ToString() + "%'", mysqlCon);
            //    MySqlDataReader dbRead = command.ExecuteReader();
            //    if (dbRead.Read())
            //    {
            //        cbProdID.Text = dbRead.GetString("prodID");
            //        cbProdName.Text = dbRead.GetString(2);
            //        cbProdGroup.Text = dbRead.GetString(3);
            //        cbManufTrad.Text = dbRead.GetString(4);
            //        cbUoM.Text = dbRead.GetString(5);
            //        txtMinSP.Text = dbRead.GetString(6);
            //        txtMaxSP.Text = dbRead.GetString(7);
            //        txtAvgSP.Text = dbRead.GetString(8);
            //    }
            //}
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            Reload(cbProdID);
        }

        private void prodGrid_DoubleClick(object sender, EventArgs e)
        {
            cbProdID.Text = prodGrid.CurrentRow.Cells[1].Value.ToString();
            cbProdName.Text = prodGrid.CurrentRow.Cells[2].Value.ToString();
            cbProdGroup.Text = prodGrid.CurrentRow.Cells[3].Value.ToString();
            cbManufTrad.Text = prodGrid.CurrentRow.Cells[4].Value.ToString();
            cbUoM.Text = prodGrid.CurrentRow.Cells[5].Value.ToString();
            txtMinSP.Text = prodGrid.CurrentRow.Cells[6].Value.ToString();
            txtMaxSP.Text = prodGrid.CurrentRow.Cells[7].Value.ToString();
            txtAvgSP.Text = prodGrid.CurrentRow.Cells[8].Value.ToString();

            id = Convert.ToInt32(prodGrid.CurrentRow.Cells[0].Value.ToString());
        }

        private void _cmdPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload(cbProdID);
            LoadEmpDeets();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                if (spwAdded == false)
                {
                    MySqlCommand mysqlCmd1 = new MySqlCommand("ProdAddorEdit", mysqlCon);
                    mysqlCmd1.CommandType = CommandType.StoredProcedure;
                    mysqlCmd1.Parameters.AddWithValue("_id", id);
                    mysqlCmd1.Parameters.AddWithValue("_prodID", cbProdID.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_prodName", cbProdName.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_prodGroup", cbProdGroup.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_prodManufTrad", cbManufTrad.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_prodUOM", cbUoM.Text.Trim());
                    if (float.TryParse(txtMinSP.Text.Trim(), out value))
                    {
                        mysqlCmd1.Parameters.AddWithValue("_prodMinSP", float.Parse(txtMinSP.Text.Trim()));
                        mysqlCmd1.Parameters.AddWithValue("_prodMaxSP", float.Parse(txtMaxSP.Text.Trim()));
                        mysqlCmd1.Parameters.AddWithValue("_prodAvgSP", float.Parse(txtAvgSP.Text.Trim()));
                    }
                    else
                    {
                        mysqlCmd1.Parameters.AddWithValue("_prodMinSP", null);
                        mysqlCmd1.Parameters.AddWithValue("_prodMaxSP", null);
                        mysqlCmd1.Parameters.AddWithValue("_prodAvgSP", null);
                    }
                    mysqlCmd1.ExecuteNonQuery();
                    MessageBox.Show("Added to Product Table");
                    //spwAdded = true;
                }
                prodGrid.ReadOnly = true;
                ClearAll();
                Reload(cbProdID);
                LoadUOM();
                LoadProdGroups();
            }
        }

        private void cbProdGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProdName.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand cmd = new MySqlCommand(" SELECT * FROM producttable WHERE prodGroup like '%" + cbProdGroup.Text + "%' ", mysqlCon);
                MySqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    cbProdName.Items.Add(dr1.GetString("prodName"));
                }
                mysqlCon.Close();
            }
        }

        private void cbProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand cmd = new MySqlCommand(" SELECT * FROM producttable WHERE prodGroup like '%" + cbProdGroup.Text + "%' AND prodName like '%" + cbProdName.Text + "%' ", mysqlCon);
                MySqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    cbProdID.Text = dr1.GetString("prodID");
                }
                dr1.Dispose();

                MySqlCommand command = new MySqlCommand("SELECT * FROM producttable WHERE CONCAT(`prodName`) like '%" + cbProdName.Text + "%'", mysqlCon);
                MySqlDataReader dbRead = command.ExecuteReader();
                if (dbRead.Read())
                {
                    cbManufTrad.Text = dbRead.GetString("prodManufTrad");
                    cbUoM.Text = dbRead.GetString("prodUOM");
                    txtMinSP.Text = dbRead.GetString("prodMinSP");
                    txtMaxSP.Text = dbRead.GetString("prodMaxSP");
                    txtAvgSP.Text = dbRead.GetString("prodAvgSP");
                }
                mysqlCon.Close();
            }
        }
    }
}
