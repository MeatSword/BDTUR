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
        public frm_Hotels()
        {
            InitializeComponent();

            db= new DBDownload();
            db.Hotel();
            db.Services();

            for(int i=0;i<db.idHotel.Count;i++)
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
            MessageBox.Show(tbPanel_Hotels.Controls.IndexOf(sender as PictureBox).ToString());
        }
    }
}
