
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
            ((System.ComponentModel.ISupportInitialize)(this.frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            this.SuspendLayout();
            // 
            // frame
            // 
            this.frame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frame.Location = new System.Drawing.Point(57, 34);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(356, 208);
            this.frame.TabIndex = 1;
            this.frame.TabStop = false;
            this.frame.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnAcc
            // 
            this.btnAcc.Location = new System.Drawing.Point(233, 378);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(101, 35);
            this.btnAcc.TabIndex = 2;
            this.btnAcc.Text = "ACCELERATOR";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnBrk
            // 
            this.btnBrk.Location = new System.Drawing.Point(109, 378);
            this.btnBrk.Name = "btnBrk";
            this.btnBrk.Size = new System.Drawing.Size(88, 35);
            this.btnBrk.TabIndex = 3;
            this.btnBrk.Text = "BREAK";
            this.btnBrk.UseVisualStyleBackColor = true;
            this.btnBrk.Click += new System.EventHandler(this.btnBrk_Click);
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
            this.belVel.Location = new System.Drawing.Point(239, 329);
            this.belVel.Name = "belVel";
            this.belVel.Size = new System.Drawing.Size(16, 13);
            this.belVel.TabIndex = 13;
            this.belVel.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Point/0.1 sec";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "VELOCITY :";
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
            this.btnStart.Location = new System.Drawing.Point(312, 248);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 35);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(205, 248);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(101, 35);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(509, 446);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.belVel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.car);
            this.Controls.Add(this.btnBrk);
            this.Controls.Add(this.btnAcc);
            this.Controls.Add(this.frame);
            this.Name = "Form1";
            this.Text = "RACHING SIMULATION";
            ((System.ComponentModel.ISupportInitialize)(this.frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
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
    }
}

