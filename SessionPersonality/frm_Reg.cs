using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionPersonality
{
    public partial class frm_Reg : Form
    {
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["turbase"].ConnectionString);
        string path;

        public frm_Reg()
        {
            InitializeComponent();

           
            try
            {
                connect.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlCommand com = new SqlCommand($"SELECT * FROM Country", connect);
            SqlDataReader rd = com.ExecuteReader();
            
            while(rd.Read())
            {
                cmb_Cnt.Items.Add(rd.GetString(1));
            }

            cmb_Cnt.SelectedIndex = 0;

            rd.Close();
        }

      

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            if(!File.Exists(Path.GetFileName(openFileDialog1.FileName)))
            {
                File.Copy(openFileDialog1.FileName, Path.GetFileName(openFileDialog1.FileName));
            }
            
            pct_Avatar.Image = Image.FromFile(Path.GetFileName(openFileDialog1.FileName));
            path = Path.GetFileName(openFileDialog1.FileName);
        }
        private void btn_Reg_Click(object sender, EventArgs e)
        {
            string log = txt_LogN.Text, pass = txt_PassN.Text, name = txt_NameN.Text, surname = txt_SurnameN.Text, cnt = "2", numb = txt_PhoneN.Text;

            if (txt_LogN.Text != "" && txt_PassN.Text != "" && txt_NameN.Text != "" && txt_SurnameN.Text != "" && txt_PhoneN.Text != "")
            {
                SqlCommand com = new SqlCommand($"SELECT * FROM Country", connect);
                SqlDataReader rd = com.ExecuteReader();

                while (rd.Read())
                {
                    if (rd.GetValue(1).ToString() == cmb_Cnt.Text.Trim())
                    {
                        cnt = rd.GetValue(0).ToString();
                        break;
                    }
                }
                rd.Close();

                try
                {
                    com.CommandText = $"INSERT INTO Users (login,password,[order],status,name,surname,cntid,phone,img) VALUES('{log}','{pass}',0,'user','{name}','{surname}',{cnt},{numb},'{path}')";
                    com.ExecuteNonQuery();
                    MessageBox.Show("Succes");
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.Message);
                }

            }
            else
            {
                MessageBox.Show("Not all");
            }

        }


    }
}
