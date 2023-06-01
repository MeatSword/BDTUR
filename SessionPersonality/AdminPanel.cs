using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionPersonality
{
    public partial class Form1 : Form
    {
        public string status = "";
        public int id = 1;
        private  string ConnectionString = ConfigurationManager.ConnectionStrings["TurBase"].ConnectionString;
        SqlConnection connection;
        
        static Form1 instance;
        
        public static Form1 getInstance()//синглтон
        {
            if (instance == null)
                instance = new Form1();
            return instance;
        }
        public Form1()
        {
            InitializeComponent();
            instance = this;
            try
            {
                connection = new SqlConnection(ConnectionString);
                // Открываем подключение
                connection.Open();
                MessageBox.Show("Подключение открыто");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Reg_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand($"SELECT id,password,status FROM Users WHERE login ='{txt_Log.Text}'", connection);
            SqlDataReader rd = com.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    if (rd.GetValue(1).ToString() == txt_Pass.Text)
                    {
                        id=Convert.ToInt32(rd.GetValue(0));
                        status = rd.GetValue(2).ToString();
                        frm_MainForm fr = new frm_MainForm();
                        Hide();
                        fr.Show();
                    }
                    else
                    {
                        MessageBox.Show("Not found user");
                    }
                }
                else
                {
                    MessageBox.Show("Not found user");
                }
                rd.Close();
                

        }
    }
}