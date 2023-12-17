using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Racing_Simulation
{
    public partial class Form1 : Form
    {
        List<LineTracking> points = null;
        Pen bluePen = new Pen(Color.Blue, 2);
        Point P = new Point(0, 0);
        int offsetX;
        int offsetY;
        int i = 0;
        int VEL = 0;
        
        public Form1()
        {
            InitializeComponent();
            try
            {
                points = File.ReadAllLines("line.csv")
                                                .Skip(0)
                    .Select(v => LineTracking.FromCsv(v))
                    .ToList();
                //MessageBox.Show(points.Count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

   
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
            
            float x1 = 20.0F, y1 = 20.0F;
            float x2 = 200.0F, y2 = 20.0F;

            for(int i=0;i<points.Count-1;i++)
            {
               
                x1=points[i].Xaxis;
                y1 = points[i].Yaxis;
                x2 = points[i+1].Xaxis;
                y2 = points[i+1].Yaxis;
                e.Graphics.DrawLine(bluePen, x1, y1, x2, y2);

            }
            //e.Graphics.DrawLine(bluePen, x1, y1, x2, y2);
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {

          
            VEL++;
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            belVel.Text = VEL.ToString();//int i = 0;
            if (i<points.Count)
            {
                P.X = offsetX + Convert.ToInt32(points[i].Xaxis);
                P.Y = offsetY + Convert.ToInt32(points[i].Yaxis);
                car.Location = P;
                i = i + VEL;
            }
            if(i>points.Count)
            {
                i = 0;
                P.X = offsetX + Convert.ToInt32(points[i].Xaxis);
                P.Y = offsetY + Convert.ToInt32(points[i].Yaxis);
                car.Location = P;
                i = i + VEL;
            }

           
            
        }

        private void btnBrk_Click(object sender, EventArgs e)
        {
            if (VEL > 0)
            {
                VEL--;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Point P = new Point(0, 0);
            P.X = 30;
            P.Y = 20;
            //P = frame.Location;
            offsetX = Convert.ToInt32(frame.Location.X - car.Width / 2);
            offsetY = Convert.ToInt32(frame.Location.Y - car.Height / 2);
            P.X = offsetX + Convert.ToInt32(points[0].Xaxis);
            P.Y = offsetY + Convert.ToInt32(points[0].Yaxis);
            car.Location = P;
            i = 0;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            VEL = 0;
            belVel.Text = 0.ToString();
            timer1.Enabled = false;
        }
    }
}
