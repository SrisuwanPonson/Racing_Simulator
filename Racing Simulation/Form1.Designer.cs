
namespace Racing_Simulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.frame = new System.Windows.Forms.PictureBox();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnBrk = new System.Windows.Forms.Button();
            this.car = new System.Windows.Forms.PictureBox();
            this.belVel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLocationX = new System.Windows.Forms.Label();
            this.labelLocationY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCarVector = new System.Windows.Forms.Label();
            this.labelPathVector = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAngle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frame
            // 
            this.frame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frame.Location = new System.Drawing.Point(12, 34);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(401, 208);
            this.frame.TabIndex = 1;
            this.frame.TabStop = false;
            this.frame.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnAcc
            // 
            this.btnAcc.Location = new System.Drawing.Point(276, 68);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(101, 35);
            this.btnAcc.TabIndex = 2;
            this.btnAcc.Text = "ACCELERATOR";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            this.btnAcc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAcc_MouseDown);
            this.btnAcc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAcc_MouseUp);
            // 
            // btnBrk
            // 
            this.btnBrk.Location = new System.Drawing.Point(169, 68);
            this.btnBrk.Name = "btnBrk";
            this.btnBrk.Size = new System.Drawing.Size(101, 35);
            this.btnBrk.TabIndex = 3;
            this.btnBrk.Text = "BREAK";
            this.btnBrk.UseVisualStyleBackColor = true;
            this.btnBrk.Click += new System.EventHandler(this.btnBrk_Click);
            this.btnBrk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBrk_MouseDown);
            this.btnBrk.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBrk_MouseUp);
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Red;
            this.car.Location = new System.Drawing.Point(69, 213);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(11, 10);
            this.car.TabIndex = 4;
            this.car.TabStop = false;
            // 
            // belVel
            // 
            this.belVel.AutoSize = true;
            this.belVel.Location = new System.Drawing.Point(141, 52);
            this.belVel.Name = "belVel";
            this.belVel.Size = new System.Drawing.Size(16, 13);
            this.belVel.TabIndex = 13;
            this.belVel.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Point/0.1 sec";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Velocity :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(384, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(307, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "ERROR :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.Location = new System.Drawing.Point(276, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 35);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStop.Location = new System.Drawing.Point(169, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(101, 35);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Location X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Location Y:";
            // 
            // labelLocationX
            // 
            this.labelLocationX.AutoSize = true;
            this.labelLocationX.Location = new System.Drawing.Point(137, 28);
            this.labelLocationX.Name = "labelLocationX";
            this.labelLocationX.Size = new System.Drawing.Size(16, 13);
            this.labelLocationX.TabIndex = 21;
            this.labelLocationX.Text = "---";
            // 
            // labelLocationY
            // 
            this.labelLocationY.AutoSize = true;
            this.labelLocationY.Location = new System.Drawing.Point(273, 28);
            this.labelLocationY.Name = "labelLocationY";
            this.labelLocationY.Size = new System.Drawing.Size(16, 13);
            this.labelLocationY.TabIndex = 22;
            this.labelLocationY.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Car Vector :";
            // 
            // labelCarVector
            // 
            this.labelCarVector.AutoSize = true;
            this.labelCarVector.Location = new System.Drawing.Point(141, 78);
            this.labelCarVector.Name = "labelCarVector";
            this.labelCarVector.Size = new System.Drawing.Size(16, 13);
            this.labelCarVector.TabIndex = 24;
            this.labelCarVector.Text = "---";
            // 
            // labelPathVector
            // 
            this.labelPathVector.AutoSize = true;
            this.labelPathVector.Location = new System.Drawing.Point(141, 102);
            this.labelPathVector.Name = "labelPathVector";
            this.labelPathVector.Size = new System.Drawing.Size(16, 13);
            this.labelPathVector.TabIndex = 26;
            this.labelPathVector.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Path Vector :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelLocationY);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelLocationX);
            this.groupBox1.Controls.Add(this.labelAngle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelPathVector);
            this.groupBox1.Controls.Add(this.labelCarVector);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.belVel);
            this.groupBox1.Location = new System.Drawing.Point(12, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 183);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controller";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "** average 3 points forward";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "*** 2 points backward";
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Location = new System.Drawing.Point(141, 126);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(16, 13);
            this.labelAngle.TabIndex = 28;
            this.labelAngle.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Steering Angle(Degree) :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.btnAcc);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnBrk);
            this.groupBox2.Location = new System.Drawing.Point(12, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 115);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 30;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelStatus.Location = new System.Drawing.Point(284, 213);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(86, 20);
            this.labelStatus.TabIndex = 29;
            this.labelStatus.Text = "READY !!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 585);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.car);
            this.Controls.Add(this.frame);
            this.Name = "Form1";
            this.Text = "RACHING SIMULATION";
            ((System.ComponentModel.ISupportInitialize)(this.frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox frame;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnBrk;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Label belVel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLocationX;
        private System.Windows.Forms.Label labelLocationY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCarVector;
        private System.Windows.Forms.Label labelPathVector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label labelStatus;
    }
}

