using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SessionPersonality
{
    public partial class frm_ActionBuilderNew : Form
    {
        private  string ConnectionString = ConfigurationManager.ConnectionStrings["TurBase"].ConnectionString;
        SqlConnection connection;
        
        public List<int> idCity= new List<int>();
        public frm_ActionBuilderNew()
        {
            
            InitializeComponent();
            cmb_Type.SelectedItem = cmb_Type.Items[0];


            connection = new SqlConnection(ConnectionString);
            connection.Open();
            Refresh();
            
        }

        public void Refresh()
        {
            idCity.Clear();
            chList_Ways.Items.Clear();
            
            List<string> namesCity = new List<string>();
            List<string> idCityCnt= new List<string>();
            

            List<string> namesCountry = new List<string>();
            List<string> idCountry= new List<string>();
            
            SqlCommand com = new SqlCommand($"SELECT * FROM City", connection);
            SqlDataReader rd = com.ExecuteReader();
            
            while (rd.Read())
            {
                namesCity.Add(rd.GetValue(1).ToString());
                idCityCnt.Add(rd.GetValue(2).ToString());
                idCity.Add(Convert.ToInt32(rd.GetValue(0)));
            }
            rd.Close();
            
            SqlCommand com1 = new SqlCommand($"SELECT * FROM Country", connection);
            rd = com1.ExecuteReader();
            
            while (rd.Read())
            {
                namesCountry.Add(rd.GetValue(1).ToString());
                idCountry.Add(rd.GetValue(0).ToString());
            }
            rd.Close();

            for (int i = 0; i < namesCity.Count; i++)
            {
                for (int j = 0; j < namesCountry.Count; j++)
                {
                    if (idCityCnt[i] == idCountry[j])
                    {
                        chList_Ways.Items.Add($"{namesCity[i]} ({namesCountry[j]})");
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string name, ways=null, typeDiscont,   descript;
            int isDate = 0, isSumm = 0,valueDiscont=0 , category=0;


            if (((cmb_Type.SelectedItem==cmb_Type.Items[1] && Convert.ToInt32(txt_ValueDisc.Text)<100 && Convert.ToInt32(txt_ValueDisc.Text)> 0)||cmb_Type.SelectedItem==cmb_Type.Items[0]) && txt_Desc.Text!=""
                && txt_NameAct.Text!="" && txt_ValueDisc.Text!="" && chList_Ways.SelectedIndices.Count!=0)
            {
                
                for (int i = 0; i < chList_Ways.CheckedIndices.Count; i++)
                {
                    ways += $"{idCity[chList_Ways.CheckedIndices[i]]},";
                }

                ways = ways.Remove(ways.Length - 1);

                if (cb_IsDiscontAct.Checked)
                {
                    isDate = 1;
                }

                if (rb_Plat.Checked)
                {
                    category = 3;
                }

                if (rb_Gold.Checked)
                {
                    category = 2;
                }

                if (rb_Silv.Checked)
                {
                    category = 1;
                }

                typeDiscont = cmb_Type.SelectedItem.ToString();
                valueDiscont = Convert.ToInt32(txt_ValueDisc.Text);

                if (cb_IsSumm.Checked == true)
                {
                    isSumm = 1;
                }

                name = txt_NameAct.Text;
                descript = txt_Desc.Text;

                
                try
                {
                    
                    SqlCommand com =
                        new SqlCommand(
                            $"INSERT INTO Actions VALUES('{name}','{descript}',{category},{valueDiscont},'{typeDiscont}',{isDate},{isSumm},'{ways}' ,'{DateTime.Now.Date}')",
                            connection);
                    com.ExecuteNonQuery();
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter value correct");
            }
            

        }

        private void frm_ActionBuilderNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            frm_ActionBuilder fr = frm_ActionBuilder.getInstance();
            fr.Refresh();
        }
    }
}