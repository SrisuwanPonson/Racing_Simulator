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
        #region Variable
        public string Revision = "23.12.17.03";
        Vector CarVector, PathVector;
        List<LineTracking> points = null;
        Pen bluePen = new Pen(Color.Blue, 2);
        Point P = new Point(0, 0);
        Point CarLocation = new Point(0, 0);
        int offsetX;
        int offsetY;
        int i = 0;
        int VEL = 0;
        private bool _isStarted = false;
        private bool _enableSteering = false;
        private double MaxDegree = 0;
        #endregion

        #region Constructure
        public Form1()
        {
            InitializeComponent();
            CarVector = new Vector();
            PathVector = new Vector(CarVector);
            this.Text = "Racing Simulator Rev." + this.Revision;
            try
            {
                points = File.ReadAllLines("line.csv")
                                                .Skip(0)
                    .Select(v => LineTracking.FromCsv(v))
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            labelStatus.ForeColor = Color.Blue;

        }
        #endregion

        #region Event Handler

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


            float x1 = 20.0F, y1 = 20.0F;
            float x2 = 200.0F, y2 = 20.0F;

            for (int i = 0; i < points.Count - 1; i++)
            {

                x1 = points[i].Xaxis;
                y1 = points[i].Yaxis;
                x2 = points[i + 1].Xaxis;
                y2 = points[i + 1].Yaxis;
                e.Graphics.DrawLine(bluePen, x1, y1, x2, y2);

            }

        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            VEL++;
            labelStatus.Text = "VEL UP";
            labelStatus.ForeColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            belVel.Text = VEL.ToString();//int i = 0;

            if (_enableSteering)
            {

            }
            else
            {
                if (i < points.Count)
                {
                    P.X = offsetX + Convert.ToInt32(points[i].Xaxis);
                    P.Y = offsetY + Convert.ToInt32(points[i].Yaxis);
                    car.Location = P;

                    #region Update Current Location
                    //CarLocation.X = Convert.ToInt32(points[i].Xaxis);
                    //CarLocation.Y = Convert.ToInt32(points[i].Yaxis);
                    labelLocationX.Text = points[i].Xaxis.ToString();
                    labelLocationY.Text = points[i].Yaxis.ToString();
                    try
                    {
                        CarVector.X = points[i].Xaxis - points[i - 1].Xaxis;
                        CarVector.Y = points[i].Yaxis - points[i - 1].Yaxis;
                        CarVector.Uniteze();
                        labelCarVector.Text = CarVector.ToString();
                    }
                    catch (Exception ex)
                    {

                        //labelCarVector.Text = "Error";
                    }
                    try
                    {
                        double AverageX = (points[i + 1].Xaxis/* + points[i + 2].Xaxis + points[i + 3].Xaxis*/) / 1;
                        double AverageY = (points[i + 1].Yaxis /*+ points[i + 2].Yaxis + points[i + 3].Yaxis*/) / 1;
                        PathVector.X = points[i + 1].Xaxis - points[i].Xaxis;
                        PathVector.Y = points[i + 1].Yaxis - points[i].Yaxis;
                        PathVector.Uniteze();
                        labelPathVector.Text = PathVector.ToString();
                    }
                    catch (Exception)
                    {
                        //labelPathVector.Text = "Error";
                    }

                    try
                    {
                        double angle_rads = Vector.GetAngle(PathVector, CarVector);
                        //Vector.ConvertRadiansToDegrees(angle_rads)
                        double Deg = Vector.ConvertRadiansToDegrees(angle_rads);
                        if (Deg < 2.5)
                        {
                            Deg = 0;
                            if (VEL < 60)
                            {
                                VEL = VEL + 9;//modify later
                            }
                        }
                        if (VEL > 20)//big angle
                        {
                            VEL = VEL - 3;
                        }
                        labelAngle.Text = Deg.ToString("F2");
                        if(Deg>MaxDegree)
                        {
                            MaxDegree = Deg;
                        }
                        labelMaxDegree.Text = MaxDegree.ToString();
                    }
                    catch (Exception)
                    {
                        //labelAngle.Text = "Error";
                        //throw;
                    }

                    #endregion
                    i = i + VEL;
                }
                if (i > points.Count)//modify later
                {
                    i = 0;
                    P.X = offsetX + Convert.ToInt32(points[i].Xaxis);
                    P.Y = offsetY + Convert.ToInt32(points[i].Yaxis);
                    car.Location = P;//modify later
                    i = i + VEL;
                }

            }




        }

        private void btnBrk_Click(object sender, EventArgs e)
        {
            if (VEL > 0)
            {
                VEL--;
                labelStatus.Text = "VEL DOWN";
                labelStatus.ForeColor = Color.Blue;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_isStarted)
            {
                return;
            }
            VEL = 1;
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
            labelStatus.Text = "START";
            labelStatus.ForeColor = Color.Green;
            MaxDegree = 0;
        }



        private void btnAcc_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Enabled = true;
        }

        private void btnAcc_MouseUp(object sender, MouseEventArgs e)
        {
            timer2.Enabled = false;
            labelStatus.Text = "----";
            labelStatus.ForeColor = Color.Black;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (VEL < 100)
            {
                VEL++;
                labelStatus.Text = "VEL UP";
                labelStatus.ForeColor = Color.Red;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (VEL > 0)
            {
                labelStatus.Text = "VEL DOWN";
                labelStatus.ForeColor = Color.Blue;
                VEL--;
            }
        }

        private void btnBrk_MouseDown(object sender, MouseEventArgs e)
        {
            timer3.Enabled = true;
        }

        private void btnBrk_MouseUp(object sender, MouseEventArgs e)
        {
            timer3.Enabled = false;
            labelStatus.Text = "----";
            labelStatus.ForeColor = Color.Black;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (VEL > 10)
                return;
            _isStarted = false;
            VEL = 0;
            belVel.Text = 0.ToString();
            timer1.Enabled = false;
            labelStatus.Text = "STOP";
            labelStatus.ForeColor = Color.Red;
        } 
        #endregion
    }
}
