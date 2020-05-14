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

namespace TestX
{
    public partial class FrmManHours : Form
    {
        string connectionString = @"Server=localhost; Database=projectdb; Uid=root; Pwd=abcXYZ@123";

        public FrmManHours()
        {
            InitializeComponent();
            //Pass();
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

        private void btnAddProd_Click(object sender, EventArgs e)
        {

        }
    }
}
