using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SessionPersonality
{
    public partial class frm_ActionBuilder : Form
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["TurBase"].ConnectionString;


        SqlConnection connection;
        
        private List<int> id = new List<int>();
        public int idEnter = 0;
        
        static frm_ActionBuilder instance;
        
        public static frm_ActionBuilder getInstance()
        {
            if (instance == null)
                instance = new frm_ActionBuilder();
            return instance;
        }
        public frm_ActionBuilder()
        {
            InitializeComponent();

            connection = new SqlConnection(ConnectionString);
            connection.Open();
            
            cb_User.SelectedItem = cb_User.Items[0];
            
            instance = this;
            NewUser();
            Refresh();
        }

        public void NewUser()
        {
            SqlCommand com = new SqlCommand("SELECT login FROM Users WHERE status='user'",connection);
            SqlDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                cb_User.Items.Add(rd.GetValue(0).ToString());
            }
            rd.Close();
        }

        public void RefreshSearch()
        {
            dtGr_Search.Rows.Clear();

            List<int> idUser = new List<int>();
            List<int> category = new List<int>();

            List<string> nameAct = new List<string>();
            List<double> CategoryAct = new List<double>();
            List<int> ValueDisc= new List<int>();
            List<string> Ways = new List<string>();
            List<bool> IsSumm = new List<bool>();
            List<string> Type = new List<string>();

            List<int> CityId = new List<int>();
            List<string> NameCity = new List<string>();

            SqlCommand com = new SqlCommand("SELECT * FROM Users WHERE status ='user'", connection);
            SqlDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                int order = Convert.ToInt32(rd.GetValue(3));
                idUser.Add(Convert.ToInt32(rd.GetValue(0)));
                if (order<500000)
                {
                    category.Add(0);
                }
                if (order>=500000 && order<1500000)
                {
                    category.Add(1);
                }
                if (order>=1500000 && order<5000000)
                {
                    category.Add(2);
                }
                if (order>=5000000)
                {
                    category.Add(3);
                }
               
               
            }
            rd.Close();

            com.CommandText = "SELECT cityid,cityname FROM City";
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                CityId.Add(Convert.ToInt32(rd.GetValue(0)));
                NameCity.Add(rd.GetValue(1).ToString());
            }
            rd.Close();

            com.CommandText = "SELECT * FROM Actions";
            rd = com.ExecuteReader();   
            while (rd.Read())
            {
                nameAct.Add(rd.GetValue(1).ToString());
                CategoryAct.Add(Convert.ToInt32(rd.GetValue(3)));
                ValueDisc.Add(Convert.ToInt32(rd.GetValue(4)));
                Ways.Add(rd.GetValue(8).ToString());
                IsSumm.Add(Convert.ToBoolean(rd.GetValue(7)));
                Type.Add(rd.GetValue(5).ToString());
            }
            rd.Close();
            
            com.CommandText = "SELECT tourid,idCity,tourcost,dateofarrival,dateofdeparture FROM Tour";
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                double cost = Convert.ToDouble(rd.GetValue(2));
                string names = "";
                bool add = false;
                
                for (int i = 0; i < Ways.Count; i++)
                {
                    
                    if (cb_User.SelectedIndex != 0 &&
                    category[cb_User.SelectedIndex - 1] >= CategoryAct[i]) 
                    {
                        if (IsSumm[i])
                        {

                            
                            bool flag = false;
                            string[] ways = Ways[i].Split(',');

                            for (int j = 0; j < ways.Length; j++)
                            {
                                if (ways[j] == rd.GetValue(1).ToString())
                                {
                                    flag = true;
                                }
                            }

                            if (flag)
                            {

                                if (Type[i] == "Procented")
                                {
                                    cost -= Convert.ToDouble(rd.GetValue(2)) * ValueDisc[i] / 100;
                                }
                                else
                                {
                                    cost -= ValueDisc[i];

                                }
                                add = true;
                                names += nameAct[i] + ", ";
                            }
                        }
                    }
                }
                if (add)
                {
                    names = names.Remove(names.Length - 2);
                    int k = 0;
                    for (int j = 0; j < CityId.Count; j++)
                    {
                        if (CityId[j] == Convert.ToInt32(rd.GetValue(1)))
                        {
                            k = j;
                        }
                    }

                    string date =
                        $"{Convert.ToDateTime(rd.GetValue(3)).ToShortDateString()}-{Convert.ToDateTime(rd.GetValue(4)).ToShortDateString()}";

                    dtGr_Search.Rows.Add(NameCity[k], date, rd.GetValue(2), cost, names);
                }
            }
            
            rd.Close();
        }

        public void Refresh()
        {
            id.Clear();
            dtGr_Act.Rows.Clear();

            SqlCommand com = new SqlCommand("SELECT * FROM Actions",connection);
            SqlDataReader rd = com.ExecuteReader();
            
            while(rd.Read())
            {
                if (rd.GetValue(5).ToString()=="Procented")
                {
                    dtGr_Act.Rows.Add(rd.GetValue(1), $"{rd.GetValue(4)}%", Convert.ToDateTime(rd.GetValue(9)).ToShortDateString());
                    
                }
                else
                {
                    dtGr_Act.Rows.Add(rd.GetValue(1), rd.GetValue(4), Convert.ToDateTime(rd.GetValue(9)).ToShortDateString());
                }
                id.Add(Convert.ToInt32(rd.GetValue(0)));
            }
            rd.Close();
        }

        private void frm_ActionBuilder_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ActionBuilderNew fr = new frm_ActionBuilderNew();
            fr.ShowDialog();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            idEnter = id[dtGr_Act.CurrentCell.RowIndex];
            
            frm_ViewAct fr = new frm_ViewAct();
            fr.Show();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand($"DELETE FROM Actions WHERE idAct = {id[dtGr_Act.CurrentCell.RowIndex]}",connection);
            com.ExecuteNonQuery();
            Refresh();
        }

        private int temp = 0;
        private void cb_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (temp != 0)
            {
                RefreshSearch();
            }

            temp++;
        }
    }
}