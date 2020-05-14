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
    public partial class FrmCustomers : Form
    {
        string connectionString = @"Server=localhost; Database=projectdb; Uid=root; Pwd=abcXYZ@123";
        bool spwAdded = false;
        int id = 0;

        public FrmCustomers()
        {
            InitializeComponent();
            //Pass();
            ClearAll();
            LoadCustNameDeets();
            LoadCustSupp();
            LoadStateCountry();
            Reload(txtCustID);
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

        private void LoadCustNameDeets()
        {
            cbCustName.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM customertable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbCustName.Items.Add(reader.GetString("custName"));
                }
            }
        }

        private void LoadCustSupp()
        {
            cbCustSupp.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT custsupp FROM customertable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbCustSupp.Items.Count; i++)
                    {
                        if (cbCustSupp.Items[i].ToString() == reader.GetString(0))
                        {
                            cond = false;
                            break;
                        }
                        else
                            cond = true;
                    }
                    if (cond == true)
                    {
                        cbCustSupp.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                        continue;
                }
            }
        }

        private void LoadStateCountry()
        {
            cbState.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT state FROM customertable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbState.Items.Count; i++)
                    {
                        if (cbState.Items[i].ToString() == reader.GetString(0))
                        {
                            cond = false;
                            break;
                        }
                        else
                            cond = true;
                    }
                    if (cond == true)
                    {
                        cbState.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                        continue;
                }
                mysqlCon.Close();
            }
            cbCountry.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT country FROM customertable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbCountry.Items.Count; i++)
                    {
                        if (cbCountry.Items[i].ToString() == reader.GetString(0))
                        {
                            cond = false;
                            break;
                        }
                        else
                            cond = true;
                    }
                    if (cond == true)
                    {
                        cbCountry.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                        continue;
                }
                mysqlCon.Close();
            }
        }

        void ClearAll()
        {
            txtCustID.Text = cbCustName.Text = txtGSTNum.Text = cbCustSupp.Text = "";
            txtContactName1.Text = txtContactName2.Text = txtContactName3.Text = "";
            txtContactNum1.Text = txtContactNum2.Text = txtContactNum3.Text = "";
            txtContactDesig1.Text = txtContactDesig2.Text = txtContactDesig3.Text = "";
            txtAddress.Text = cbState.Text = cbCountry.Text = "";
            id = 0;
            btnCustAddCust.Text = "Add";
        }

        void Reload(TextBox cbText)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM customertable WHERE 'custID' like '%" + txtCustID.Text + "%'", mysqlCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                custGrid.DataSource = table;
                custGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                custGrid.Columns[0].Visible = false;
            }
        }        

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            ClearAll();
            //GridEmpty();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            Reload(txtCustID);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            custGrid.ReadOnly = false;
            btnCustAddCust.Text = "Update";
        }

        private void btnCustAddCust_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                if (spwAdded == false)
                {
                    MySqlCommand mysqlCmd1 = new MySqlCommand("CustAddorEdit", mysqlCon);
                    mysqlCmd1.CommandType = CommandType.StoredProcedure;
                    mysqlCmd1.Parameters.AddWithValue("_id", id);
                    mysqlCmd1.Parameters.AddWithValue("_custID", txtCustID.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_custName", cbCustName.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_gstNum", txtGSTNum.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_custsupp", cbCustSupp.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_adresses", txtAddress.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_contactNum1", txtContactNum1.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_contactDesig1", txtContactDesig1.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_contactName1", txtContactName1.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_contactNum2", txtContactNum2.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_contactDesig2", txtContactDesig2.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_contactName2", txtContactName2.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_contactNum3", txtContactNum3.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_contactDesig3", txtContactDesig3.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_contactName3", txtContactName3.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_country", cbCountry.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_state", cbState.Text.Trim());
                    mysqlCmd1.ExecuteNonQuery();
                    MessageBox.Show("Added to Customer/Supplier Table");
                    //spwAdded = true;
                }
                custGrid.ReadOnly = true;
                ClearAll();
                Reload(txtCustID);
                LoadCustNameDeets();
            }
        }

        private void custGrid_DoubleClick(object sender, EventArgs e)
        {
            txtCustID.Text = custGrid.CurrentRow.Cells[1].Value.ToString();
            cbCustName.Text = custGrid.CurrentRow.Cells[2].Value.ToString();
            txtGSTNum.Text = custGrid.CurrentRow.Cells[3].Value.ToString();
            cbCustSupp.Text = custGrid.CurrentRow.Cells[4].Value.ToString();
            txtAddress.Text = custGrid.CurrentRow.Cells[5].Value.ToString();
            txtContactName1.Text = custGrid.CurrentRow.Cells[6].Value.ToString();
            txtContactNum1.Text = custGrid.CurrentRow.Cells[7].Value.ToString();
            txtContactDesig1.Text = custGrid.CurrentRow.Cells[8].Value.ToString();
            txtContactName2.Text = custGrid.CurrentRow.Cells[9].Value.ToString();
            txtContactNum2.Text = custGrid.CurrentRow.Cells[10].Value.ToString();
            txtContactDesig2.Text = custGrid.CurrentRow.Cells[11].Value.ToString();
            txtContactName3.Text = custGrid.CurrentRow.Cells[12].Value.ToString();
            txtContactDesig3.Text = custGrid.CurrentRow.Cells[13].Value.ToString();
            txtContactNum3.Text = custGrid.CurrentRow.Cells[14].Value.ToString();
            cbCountry.Text = custGrid.CurrentRow.Cells[15].Value.ToString();
            cbState.Text = custGrid.CurrentRow.Cells[16].Value.ToString();

            id = Convert.ToInt32(custGrid.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd1 = new MySqlCommand("DELETE FROM customertable WHERE id = '" + id + "' ", mysqlCon);
                mysqlCmd1.ExecuteNonQuery();
                ClearAll();
                LoadCustNameDeets();
                Reload(txtCustID);
            }
        }

        private void cbCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbCustName.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand cmd = new MySqlCommand(" SELECT * FROM customertable WHERE custName like '%" + cbCustName.Text + "%' ", mysqlCon);
                MySqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    txtCustID.Text = dr1.GetString("custID");
                    txtGSTNum.Text = dr1.GetString("gstNum");
                    cbCustSupp.Text = dr1.GetString("custsupp");
                    txtAddress.Text = dr1.GetString("adresses");
                    txtContactName1.Text = dr1.GetString("contactName1");
                    txtContactDesig1.Text = dr1.GetString("contactDesig1");
                    txtContactNum1.Text = dr1.GetString("contactNum1");
                    txtContactName2.Text = dr1.GetString("contactName2");
                    txtContactDesig2.Text = dr1.GetString("contactDesig2");
                    txtContactNum2.Text = dr1.GetString("contactNum2");
                    txtContactName3.Text = dr1.GetString("contactName3");
                    txtContactDesig3.Text = dr1.GetString("contactDesig3");
                    txtContactNum3.Text = dr1.GetString("contactNum3");
                    cbCountry.Text = dr1.GetString("country");
                    cbState.Text = dr1.GetString("state");
                }
                mysqlCon.Close();
            }
        }

        private void btnRefresh_Click_2(object sender, EventArgs e)
        {
            Reload(txtCustID);
            LoadCustNameDeets();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
