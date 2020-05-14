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
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestX
{
    public partial class FrmEmployee : Form
    {
        string connectionString = @"Server=localhost; Database=projectdb; Uid=root; Pwd=abcXYZ@123";
        bool spwAdded = false, spwGrid = false;
        int l, id = 0;
        float value = float.NaN;

        public FrmEmployee()
        {
            InitializeComponent();
            //Pass();
            ClearAll();
            LoadEmpNames();
            LoadEmpDesig();
            LoadEmpWages();
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

        private void LoadEmpNames()
        {
            cbEmpName.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM employeetable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbEmpName.Items.Add(reader.GetString("empName"));
                }
            }
        }

        private void LoadEmpDesig()
        {
            cbEmpDesig.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT empDesig FROM employeetable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbEmpDesig.Items.Count; i++)
                    {
                        if (cbEmpDesig.Items[i].ToString() == reader.GetString(0))
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
                        cbEmpDesig.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void LoadEmpWages()
        {
            cbEmpWages.Items.Clear();
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand command = new MySqlCommand("SELECT empWages FROM employeetable", mysqlCon);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bool cond = true;
                    for (int i = 0; i < cbEmpWages.Items.Count; i++)
                    {
                        if (cbEmpWages.Items[i].ToString() == reader.GetString(0))
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
                        cbEmpWages.Items.Add(reader.GetString(0));
                        cond = false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        void ClearAll()
        {
            cbEmpID.Text = cbEmpDesig.Text = cbEmpName.Text = cbEmpWages.Text = dtpEmpDOB.Text = dtpEmpDOJ.Text = "";
            id = 0;
            btnEmpAddEmp.Text = "Add";
        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();

                MySqlCommand mysqlCmd = new MySqlCommand("SELECT COUNT(*) FROM employeetable", mysqlCon);
                if (spwGrid == false)
                {
                    l = Convert.ToInt32(mysqlCmd.ExecuteScalar());
                }
                MySqlCommand mysqlCmd1 = new MySqlCommand("SELECT * FROM employeetable LIMIT '" + (l-1)+"', 100", mysqlCon);
                mysqlCmd1.ExecuteNonQuery();
                spwGrid = true;
                MySqlDataAdapter mysqlDa = new MySqlDataAdapter("SELECT * FROM employeetable LIMIT '" + (l - 1) + "', 100", mysqlCon);
                mysqlDa.SelectCommand = mysqlCmd1;
                DataTable dtblBook = new DataTable();
                mysqlDa.Fill(dtblBook);
                empGrid.DataSource = dtblBook;
                empGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                empGrid.Columns[0].Visible = false;
            }
        }

        void Reload(ComboBox cbText)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM employeetable WHERE CONCAT(`empID`) like '%" + cbEmpID.Text + "%'", mysqlCon);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    empGrid.DataSource = table;
                    empGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    empGrid.Columns[0].Visible = false;
                }
                catch
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM employeetable WHERE CONCAT(`empID`) like '%" + cbEmpID.Text + "%'", mysqlCon);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    empGrid.DataSource = table;
                    empGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    empGrid.Columns[0].Visible = false;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GridFill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmpAddEmp_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                if (spwAdded == false)
                {
                    MySqlCommand mysqlCmd1 = new MySqlCommand("EmpAddorEdit", mysqlCon);
                    mysqlCmd1.CommandType = CommandType.StoredProcedure;
                    mysqlCmd1.Parameters.AddWithValue("_id", id);
                    mysqlCmd1.Parameters.AddWithValue("_empID", cbEmpID.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_empName", cbEmpName.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_empDesig", cbEmpDesig.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_birthDate", dtpEmpDOB.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_joiningDate", dtpEmpDOJ.Text.Trim());
                    mysqlCmd1.Parameters.AddWithValue("_empWages", float.TryParse(cbEmpWages.Text.Trim(), out value) ? float.Parse(cbEmpWages.Text) : 0);
                    mysqlCmd1.Parameters.AddWithValue("_empStatus", cbEmpStatus.Text.Trim());
                    mysqlCmd1.ExecuteNonQuery();
                    MessageBox.Show("Added to Employee Table");
                    //spwAdded = true;
                }
                empGrid.ReadOnly = true;
                ClearAll();
                Reload(cbEmpID);
                LoadEmpNames();
            }
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            Reload(cbEmpID);
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            Reload(cbEmpID);
            LoadEmpNames();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void empGrid_DoubleClick(object sender, EventArgs e)
        {
            cbEmpID.Text = empGrid.CurrentRow.Cells[1].Value.ToString();
            cbEmpName.Text = empGrid.CurrentRow.Cells[2].Value.ToString();
            cbEmpDesig.Text = empGrid.CurrentRow.Cells[3].Value.ToString();
            dtpEmpDOB.Text = empGrid.CurrentRow.Cells[4].Value.ToString();
            dtpEmpDOJ.Text = empGrid.CurrentRow.Cells[5].Value.ToString();
            cbEmpWages.Text = empGrid.CurrentRow.Cells[6].Value.ToString();
            cbEmpStatus.Text = empGrid.CurrentRow.Cells[7].Value.ToString();

            id = Convert.ToInt32(empGrid.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd1 = new MySqlCommand("DELETE FROM employeetable WHERE id = '" + id + "' ", mysqlCon);
                mysqlCmd1.ExecuteNonQuery();
                ClearAll();
                LoadEmpNames();
                Reload(cbEmpID);
            }
        }

        private void cbEmpName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand cmd = new MySqlCommand(" SELECT * FROM employeetable WHERE empName like '%" + cbEmpName.Text + "%' ", mysqlCon);
                MySqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    cbEmpID.Text = dr1.GetString("empID");
                    cbEmpDesig.Text = dr1.GetString("empDesig");
                    dtpEmpDOB.Text = dr1.GetString("birthDate");
                    dtpEmpDOJ.Text = dr1.GetString("joiningDate");
                    cbEmpWages.Text = dr1.GetString("empWages");
                    cbEmpStatus.Text = dr1.GetString("empStatus");
                }
                mysqlCon.Close();
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            empGrid.ReadOnly = false;
            btnEmpAddEmp.Text = "Update";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
