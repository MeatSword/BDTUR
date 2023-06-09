using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionPersonality
{
    public partial class frm_Hotels : Form
    {
        public DBDownload db;
        public frm_Hotels(string status)
        {
            InitializeComponent();

            db= new DBDownload();
            db.Hotel();
            db.Services();

            ShowHotels(); 
        }
        
        private void ChangeColorGr_Click(object sender, EventArgs e)
        {
      
           (sender as PictureBox).BorderStyle= BorderStyle.Fixed3D;
           
        }
        private void ChangeColorBl_Click(object sender, EventArgs e)
        {

            (sender as PictureBox).BorderStyle = BorderStyle.None;

        }
        private void pb_Click(object sender, EventArgs e)
        {
         
            ShowInfo(tbPanel_Hotels.Controls.IndexOf(sender as PictureBox));
        }
        public void ShowHotels()
        {
            for (int i = 0; i < tbPanel_Hotels.RowCount * tbPanel_Hotels.ColumnCount; i++)
            {
                if (i < db.idHotel.Count)
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = Image.FromFile(db.imgHotel[i]);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Dock = DockStyle.Fill;
                    pb.MouseLeave += ChangeColorBl_Click;
                    pb.MouseEnter += ChangeColorGr_Click;
                    pb.Click += pb_Click;

                    tbPanel_Hotels.Controls.Add(pb);
                }
                else
                {

                    PictureBox pb = new PictureBox();
                    pb.Image = Image.FromFile("Cross.png");
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Dock = DockStyle.Fill;


                    tbPanel_Hotels.Controls.Add(pb);
                }
            }
        }
        public void ShowInfo(int id)
        {
            db.GetImgRooms();
            

            pn_Info.Visible = true;
            ClearInfo();

            pb_ImgHotel.Image = Image.FromFile(db.imgHotel[id]);

            string[] services = db.servicesHotel[id].Split(',');
            foreach(CheckBox ch in panel4.Controls)
            {
                char[] c = ch.Tag.ToString().ToCharArray();
                for(int i = 0; i <services.Length; i++)
                {
                    if (c[2].ToString() == services[i])
                    {
                        ch.Checked = true;
                        break;
                    }
                }
            }
            txt_NameHotel.Text = db.nameHotel[id];
            txt_RateHotel.Text = db.rateHotel[id].ToString();
            cmb_Nutr.SelectedIndex = db.nutrHotel[id]-1;

            for(int i=0;i<4;i++)
            {
                for(int j=0;j<db.idRoom.Count;j++)
                {
                    if (db.idHotelRoom[j] == db.idHotel[id])
                    {
                        PictureBox pb = new PictureBox();
                        pb.Image = Image.FromFile(db.imgRoom[j].ToString());
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Dock = DockStyle.Fill;

                        tbpb_Rooms.Controls.Add(pb);

                        Label lb = new Label();
                        lb.Dock= DockStyle.Fill;
                        lb.Text = db.statusRoom[j].ToString();
                        lb.TextAlign = label.TextAlign;
                        lb.Font =label.Font;

                        tbpb_Rooms.Controls.Add(lb);
                    }
                }
            }
        }
        public void ClearInfo()
        {
            foreach (CheckBox ch in panel4.Controls)
            {
                
                        ch.Checked = false;
                        
                    
            }
            pb_ImgHotel.Image = null;
            tbpb_Rooms.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pn_Info.Visible = false;
        }
    }
}
