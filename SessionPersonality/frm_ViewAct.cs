using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SessionPersonality
{
    public partial class frm_ViewAct : Form
    {
        private  string ConnectionString = ConfigurationManager.ConnectionStrings["TurBase"].ConnectionString;
        SqlConnection connection;
        public frm_ViewAct()// Можно было получить в конструкторе
        {
            InitializeComponent();

            connection = new SqlConnection(ConnectionString);
            connection.Open();
            SetInfo();

        }

        public void SetInfo()
        {
            frm_ActionBuilder fr = frm_ActionBuilder.getInstance();

            SqlCommand com = new SqlCommand($"SELECT * FROM Actions WHERE idAct='{fr.idEnter}'", connection);
            SqlDataReader rd = com.ExecuteReader();
            rd.Read();

            txt_Name.Text = rd.GetValue(1).ToString();
            
            if (Convert.ToInt32(rd.GetValue(3)) == 3)
            {
                txt_Category.Text = "Platinum";
            }
            if (Convert.ToInt32(rd.GetValue(3)) == 2)
            {
                txt_Category.Text = "Gold";
            }
            if (Convert.ToInt32(rd.GetValue(3)) == 1)
            {
                txt_Category.Text = "Silver";
            }

            txt_Desc.Text = rd.GetValue(2).ToString();
            txt_Type.Text = rd.GetValue(5).ToString();

            if (txt_Type.Text == "Procented")
            {
                txt_Value.Text = rd.GetValue(4) + "%";
            }
            else
            {
                txt_Value.Text = rd.GetValue(4) + "";
            }

            if (Convert.ToBoolean(rd.GetValue(6)) == false)
            {
                lb_Date.BackColor = Color.Red;
            }
            if (Convert.ToBoolean(rd.GetValue(7)) == false)
            {
                lb_Summ.BackColor = Color.Red;
            }
            
            

            string[] ways = rd.GetValue(8).ToString().Split(',');
            rd.Close();
            
            com.CommandText = "SELECT * FROM City";
            rd = com.ExecuteReader();

            while (rd.Read())
            {
                for (int i = 0; i < ways.Length; i++)
                {
                    if (rd.GetValue(0).ToString() == ways[i])
                    {
                        txt_Ways.Text += $"{rd.GetValue(1)}, ";
                    }
                }
            }

            txt_Ways.Text=txt_Ways.Text.Remove(txt_Ways.Text.Length-2);
            
            rd.Close();
        }

        private void frm_ViewAct_Load(object sender, EventArgs e)
        {
            
        }
    }
}