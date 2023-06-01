using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SessionPersonality
{
    public partial class frm_Bron : Form
    {
        private int id = 0,temp=0;
        private List<Point> last = new List<Point>();
         
        private List<Control> lastCtrl = new List<Control>();
        
        public frm_Bron()
        {//423; 75
            last.Add(new Point(52, 206+34));
            InitializeComponent();
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                Label lb = new Label();
                lb.Location = new Point(last[last.Count-1].X, last[last.Count-1].Y + 15);
                lb.ForeColor=Color.White;
                lb.Text = "FIO";
                lb.BackColor = Color.Black;
                lb.TextAlign = ContentAlignment.MiddleCenter;
                Controls.Add(lb);
                
                TextBox txt = new TextBox();
                txt.Location = new Point(156, last[last.Count-1].Y + 15);
                txt.Size = new Size(252, 20);
                Controls.Add(txt);
                
                Label lb1 = new Label();
                lb1.Location = new Point(last[last.Count-1].X, last[last.Count-1].Y + 45);
                lb1.ForeColor=Color.White;
                lb1.Text = "BirthDay";
                lb1.BackColor = Color.Black;
                lb1.TextAlign = ContentAlignment.MiddleCenter;
                Controls.Add(lb1);
                
                TextBox txt1 = new TextBox();
                txt1.Location = new Point(156, last[last.Count-1].Y + 45);
                txt1.Size = new Size(252, 20);
                Controls.Add(txt1);

                Panel pn = new Panel();
                pn.BackColor=Color.Black;
                pn.Location = last[last.Count-1];
                pn.Size = new Size(423, 75);
                Controls.Add(pn);
                
                CheckBox ch = new CheckBox();
                ch.Text = "Добавить путешествующего";
                ch.Location = new Point(last[last.Count-1].X, last[last.Count-1].Y + 75 + 15);
                ch.Size = new Size(191, 22);
                ch.CheckedChanged += checkBox1_CheckedChanged;
                Controls.Add(ch);
                
                btn_Cab.Location = new Point(ch.Location.X, ch.Location.Y + 25);
                last.Add(new Point(ch.Location.X,ch.Location.Y+25));

                Size = new Size(this.Size.Width, Size.Height + 250);
                
                lastCtrl.Add(lb);
                lastCtrl.Add(lb1);
                lastCtrl.Add(txt);
                lastCtrl.Add(txt1);
                lastCtrl.Add(pn);
                lastCtrl.Add(ch);
                if (temp == 0)
                {
                    Controls.Remove(lastCtrl[lastCtrl.Count-1]);
                    lastCtrl.RemoveAt(lastCtrl.Count-1);
                    Controls.Remove(lastCtrl[lastCtrl.Count-1]);
                    lastCtrl.RemoveAt(lastCtrl.Count-1);
                    Controls.Remove(lastCtrl[lastCtrl.Count-1]);
                    lastCtrl.RemoveAt(lastCtrl.Count-1);
                    Controls.Remove(lastCtrl[lastCtrl.Count-1]);
                    lastCtrl.RemoveAt(lastCtrl.Count-1);
                    Controls.Remove(lastCtrl[lastCtrl.Count-1]);
                    lastCtrl.RemoveAt(lastCtrl.Count-1);
                    Controls.Remove(lastCtrl[lastCtrl.Count-1]);
                    lastCtrl.RemoveAt(lastCtrl.Count-1);
                    last.RemoveAt(last.Count-1);
                    temp++;
                }
            }
            else
            {
                Controls.Remove(lastCtrl[lastCtrl.Count-1]);
                lastCtrl.RemoveAt(lastCtrl.Count-1);
                Controls.Remove(lastCtrl[lastCtrl.Count-1]);
                lastCtrl.RemoveAt(lastCtrl.Count-1);
                Controls.Remove(lastCtrl[lastCtrl.Count-1]);
                lastCtrl.RemoveAt(lastCtrl.Count-1);
                Controls.Remove(lastCtrl[lastCtrl.Count-1]);
                lastCtrl.RemoveAt(lastCtrl.Count-1);
                Controls.Remove(lastCtrl[lastCtrl.Count-1]);
                lastCtrl.RemoveAt(lastCtrl.Count-1);
                Controls.Remove(lastCtrl[lastCtrl.Count-1]);
                lastCtrl.RemoveAt(lastCtrl.Count-1);
                last.RemoveAt(last.Count-1);
                
                btn_Cab.Location = new Point(lastCtrl[lastCtrl.Count-1].Location.X, lastCtrl[lastCtrl.Count-1].Location.Y + 25);
                Size = new Size(this.Size.Width, Size.Height - 250);
            }
           
            

        }
    }
}