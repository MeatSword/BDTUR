using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SessionPersonality
{
    public partial class frm_MainForm : Form
    {
        private int idUser;
        public DBDownload db = new DBDownload();
       static class Search
        {
            public static List<Control> search;
            
            public static DateTime dtStart = new DateTime();
            public static DateTime dtEnd = new DateTime();
             
            public static int days, humans,rate=1,food;
            public static int[] cost = new int[2];
            public static List<int> services= new List<int>();

            public static List<string> categorys = new List<string>();

            public static void Refresh()
            {
                search.Clear();
                days = 0;
                humans = 0;
                rate = 0;
                
            }
        }
        
        public frm_MainForm()
        {
            
            InitializeComponent();
            Form1 fr = Form1.getInstance();
            idUser = fr.id;
            if (fr.status == "admin")
            {
                btn_Admin.Visible = true;
            }
            
            Drag1.BringToFront();
            Drag2.BringToFront();
            Drag3.BringToFront();
            Drag4.BringToFront();
            Drag5.BringToFront();
            Drag6.BringToFront();

            Drags.Add(txt_Drag1);
            Drags.Add(txt_Drag2);
            Drags.Add(txt_Drag3);
            Drags.Add(txt_Drag4);
            Drags.Add(txt_Drag5);
            Drags.Add(txt_Drag6);
        }

        public void Visible_False(List<Control> cnt)
        {
            foreach (var cn in cnt)
            {
                cn.Visible = false;
            }
        }

        private void lb_Tours_Click(object sender, EventArgs e)
        {
            /*Search1.Visible = false;
            Search2.Visible = false;
            Search3.Visible = false;
            Search4.Visible = false;
            Search.Refresh();*/
            
            Search1.Visible = true;
            cnt_Search.Visible = true;
            dtp_Start.Text = "2018-02-02";
            dtp_End.Text = "2022-04-15";
        }
        private void btn_Cont1_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txt_Days.Text);
                Convert.ToInt32(txt_Humans.Text);
                if (Convert.ToDateTime(dtp_Start.Text) < Convert.ToDateTime(dtp_End.Text)
                    && txt_Days.Text != "" && txt_Humans.Text != "")
                {
                    Search.dtStart = Convert.ToDateTime(dtp_Start.Text);
                    Search.dtEnd = Convert.ToDateTime(dtp_End.Text);
                    Search.days = Convert.ToInt32(txt_Days.Text);
                    Search.humans = Convert.ToInt32(txt_Humans.Text);

                    lb_1.BackColor = Color.Gray;
                    lb_2.BackColor = Color.PaleGreen;
                    Search2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Enter correct");
                }
            }
            catch
            {
                MessageBox.Show("Enter correct");
            }

        }

        private void btn_Skip1_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_Cont2_Click(object sender, EventArgs e)
        {
            if (txt_Drag1.Text != "" && txt_Drag2.Text != "" && txt_Drag3.Text != ""&&
                txt_Drag4.Text != "" && txt_Drag5.Text != "" && txt_Drag6.Text != "")
            {
                Search.categorys.Add(txt_Drag1.Text);
                Search.categorys.Add(txt_Drag2.Text);
                Search.categorys.Add(txt_Drag3.Text);
                Search.categorys.Add(txt_Drag4.Text);
                Search.categorys.Add(txt_Drag5.Text);
                Search.categorys.Add(txt_Drag6.Text);

                Drag1.Visible = false;
                Drag2.Visible = false;
                Drag3.Visible = false;
                Drag4.Visible = false;
                Drag5.Visible = false;
                Drag6.Visible = false;
                
                Search3.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Поставьте все предпочтения");
            }
        }

        private void btn_Skip2_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_Cont3_Click(object sender, EventArgs e)
        {
            Search.food = cmb_Nutr.SelectedIndex+1;
            Search.cost[0] = trb_Ot.Value;
            Search.cost[1] = trb_Do.Value;
            Search4.Visible = true;
            ResultSr();
        }

        private void btn_Skip3_Click(object sender, EventArgs e)
        {
            
        }

        void ResultSr()
        {
            
            DBDownload db = new DBDownload();
            db.Hotel();
            db.Tour();

            for (int i = 0; i < db.idTour.Count; i++)
            {
                
                if (Search.dtEnd >= db.departTour[i] && Search.dtStart <= db.ariveTour[i] && Search.days>= (db.departTour[i].Day-db.ariveTour[i].Day)
                    && db.costTour[i]>Search.cost[0] &&db.costTour[i]<Search.cost[1])
                {
                    int idhotel = 0;
                    for (int j = 0; j < db.idHotel.Count;j++)
                    {
                        if (db.idHotelT[i] == db.idHotel[j])
                        {
                            idhotel = j;
                        }
                    }
                    
                    if (Search.rate == db.rateHotel[idhotel] && Search.food == db.nutrHotel[idhotel])
                    {
                        bool serv = true;
                        string[] servHotel = db.servicesHotel[idhotel].Split(',');
                        bool[] hasServ = new bool[servHotel.Length];

                        foreach (var servv in Search.services)
                        {

                            for (int j = 0; j < servHotel.Length; j++)
                            {
                                    if (servHotel[j] == servv.ToString())
                                    {
                                        hasServ[j] = true;
                                    }
                            }
                        }

                        for (int j = 0; j < hasServ.Length; j++)
                        {
                            if (!hasServ[j])
                            {
                                serv = false;
                                break;
                            }
                                
                        }

                        if (serv)
                        {
                            db.City();
                            db.Country();
                            
                            int idcnt = 0,idcity=0;
                            for (int j = 0; j < db.CityId.Count;j++)
                            {
                                if (db.idCityT[i] == db.CityId[j])
                                {
                                    idcity = j;
                                }
                            }
                            
                            for (int j = 0; j < db.CountryId.Count;j++)
                            {
                                if (db.CntIdC[idcity] == db.CountryId[j])
                                {
                                    idcnt = j;
                                }
                            }
                            
                            dtGr_ResSr.Rows.Add(db.NameCnt[idcnt],db.NameCity[idcity],db.nameHotel[idhotel],Convert.ToString($"{db.ariveTour[i]}-{db.departTour[i]}")
                            ,db.costTour[i]);
                        }
                        
                    }
                    
                }
            }
            
            
        }
        private void btn_Admin_Click(object sender, EventArgs e)
        {
            frm_ActionBuilder fr = new frm_ActionBuilder();
            fr.Show();
        }
        private void frm_MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ChangeColorGr_Click(object sender, EventArgs e)
        {
            if ((sender as Label).Tag == "Main")
            {
                (sender as Label).BackColor = Color.Green;
            }
        }
        private void ChangeColorBl_Click(object sender, EventArgs e)
        {
            if ((sender as Label).Tag == "Main")
            {
                (sender as Label).BackColor = Color.Black;
            }
        }

        private void ChangeRate_Click(object sender, EventArgs e)
        {
            if ((sender as Label).Name == "Star1")
            {
                Search.rate = 1;
                Star1.BackColor = Color.Gold;
                Star2.BackColor = Color.White;
                Star3.BackColor = Color.White;
                Star4.BackColor = Color.White;
                Star5.BackColor = Color.White;
            }
            if ((sender as Label).Name == "Star2")
            {
                Search.rate = 2;
                Star1.BackColor = Color.Gold;
                Star2.BackColor = Color.Gold;
                Star3.BackColor = Color.White;
                Star4.BackColor = Color.White;
                Star5.BackColor = Color.White;
            }
            if ((sender as Label).Name == "Star3")
            {
                Search.rate = 3;
                Star1.BackColor = Color.Gold;
                Star2.BackColor = Color.Gold;
                Star3.BackColor = Color.Gold;
                Star4.BackColor = Color.White;
                Star5.BackColor = Color.White;
            }
            if ((sender as Label).Name == "Star4")
            {
                Search.rate = 4;
                Star1.BackColor = Color.Gold;
                Star2.BackColor = Color.Gold;
                Star3.BackColor = Color.Gold;
                Star4.BackColor = Color.Gold;
                Star5.BackColor = Color.White;
            }
            if ((sender as Label).Name == "Star5")
            {
                Search.rate = 5;
                Star1.BackColor = Color.Gold;
                Star2.BackColor = Color.Gold;
                Star3.BackColor = Color.Gold;
                Star4.BackColor = Color.Gold;
                Star5.BackColor = Color.Gold;
            }
        }
        
        private bool drag = false;
        private Point MP = new Point();
        private Point p = new Point();
        private Point pos = new Point();
        private List<TextBox> Drags = new List<TextBox>();
       
        
        
        private void DragClick(object sender, MouseEventArgs e)
        {
            MP = PointToClient(MousePosition);
            p = new Point(MP.X - (sender as Label).Location.X, MP.Y - (sender as Label).Location.Y);
            drag = true;
            pos = (sender as Label).Location;
        }
        private void DragHover(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                MP = PointToClient(MousePosition);
                (sender as Label).Location =  new Point(MP.X - p.X, MP.Y - p.Y);;
            }
            
        }
        private void DragDown(object sender, MouseEventArgs e)
        {
            drag = false;
            
            
            foreach (var txt in Drags)
            {
                Point centerLb = new Point((sender as Label).Location.X+(sender as Label).Width/2,(sender as Label).Location.Y+(sender as Label).Height/2);
                Point center = new Point(txt.Location.X+txt.Width/2,txt.Location.Y+txt.Height/2);

                if (centerLb.X> center.X-txt.Width+10 && centerLb.X< center.X+txt.Width-20
                         && centerLb.Y> center.Y-txt.Height+10 && centerLb.Y< center.Y+txt.Height-10 )
                {
                    (sender as Label).BackColor = Color.Red;
                    txt.Text = (sender as Label).Text;
                    Drags.Remove(txt);
                    (sender as Label).Enabled = false;
                    break;
                }
            }
            (sender as Label).Location = pos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void Reset()
        {
            Drags.Clear();
            Drags.Add(txt_Drag1);
            Drags.Add(txt_Drag2);
            Drags.Add(txt_Drag3);
            Drags.Add(txt_Drag4);
            Drags.Add(txt_Drag5);
            Drags.Add(txt_Drag6);
            txt_Drag1.Text = "";
            txt_Drag2.Text = "";
            txt_Drag3.Text = "";
            txt_Drag4.Text = "";
            txt_Drag5.Text = "";
            txt_Drag6.Text = "";
            
            Drag1.BackColor = Color.Green;
            Drag2.BackColor = Color.Green;
            Drag3.BackColor = Color.Green;
            Drag4.BackColor = Color.Green;
            Drag5.BackColor = Color.Green;
            Drag6.BackColor = Color.Green;

            Drag1.Enabled = true;
            Drag2.Enabled = true;
            Drag3.Enabled = true;
            Drag4.Enabled = true;
            Drag5.Enabled = true;
            Drag6.Enabled = true;
        }


        private void trb_Ot_Scroll(object sender, EventArgs e)
        {
           
            if (trb_Do.Value <= trb_Ot.Value)
            {
                trb_Do.Value = trb_Ot.Value;
                lb_Do.Text= $"До : {trb_Do.Value}Р";
            }
            lb_Ot.Text = $"От : {trb_Ot.Value}Р";
        }

        private void trb_Do_Scroll(object sender, EventArgs e)
        {
            if (trb_Do.Value <= trb_Ot.Value)
            {
                trb_Ot.Value = trb_Do.Value;
                lb_Ot.Text = $"От : {trb_Do.Value}Р";
            }
            lb_Do.Text= $"До : {trb_Do.Value}Р";
        }

        private void Services_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                char[] c = (sender as CheckBox).Tag.ToString().ToCharArray();
                Search.services.Add(Convert.ToInt32(c[2].ToString()));
            }
            else
            {
                char[] c = (sender as CheckBox).Tag.ToString().ToCharArray();
                Search.services.Remove(Convert.ToInt32(c[2].ToString()));
            }
        }


        private void dtGr_ResSr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                frm_Bron frm = new frm_Bron();
                frm.Show();
                if (e.RowIndex == 2)
                {
                    
                }
            }
        }

        private void lb_HotelsView_Click(object sender, EventArgs e)
        {
            frm_Hotels frm = new frm_Hotels();
            frm.Show();
        }
    }
}