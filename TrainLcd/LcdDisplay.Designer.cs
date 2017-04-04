namespace TrainLcd
{
    partial class LcdDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LcdDisplay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labStation = new System.Windows.Forms.Label();
            this.labDestinationEn = new System.Windows.Forms.Label();
            this.labDestinationJa = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.labState = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMainDisplay = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labTrainType = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.labTrainType);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labStation);
            this.panel1.Controls.Add(this.labDestinationEn);
            this.panel1.Controls.Add(this.labDestinationJa);
            this.panel1.Controls.Add(this.labTime);
            this.panel1.Controls.Add(this.labState);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 190);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 72);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "for";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(196, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "ゆき";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(826, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Car No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(928, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "号車";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(584, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labStation
            // 
            this.labStation.Font = new System.Drawing.Font("MS UI Gothic", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labStation.ForeColor = System.Drawing.SystemColors.Control;
            this.labStation.Location = new System.Drawing.Point(286, 57);
            this.labStation.Name = "labStation";
            this.labStation.Size = new System.Drawing.Size(636, 133);
            this.labStation.TabIndex = 0;
            this.labStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labStation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.labStation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // labDestinationEn
            // 
            this.labDestinationEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labDestinationEn.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labDestinationEn.ForeColor = System.Drawing.SystemColors.Control;
            this.labDestinationEn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labDestinationEn.Location = new System.Drawing.Point(65, 113);
            this.labDestinationEn.Name = "labDestinationEn";
            this.labDestinationEn.Size = new System.Drawing.Size(196, 35);
            this.labDestinationEn.TabIndex = 0;
            // 
            // labDestinationJa
            // 
            this.labDestinationJa.AutoSize = true;
            this.labDestinationJa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labDestinationJa.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labDestinationJa.ForeColor = System.Drawing.SystemColors.Control;
            this.labDestinationJa.Location = new System.Drawing.Point(26, 90);
            this.labDestinationJa.Name = "labDestinationJa";
            this.labDestinationJa.Size = new System.Drawing.Size(0, 48);
            this.labDestinationJa.TabIndex = 0;
            // 
            // labTime
            // 
            this.labTime.BackColor = System.Drawing.SystemColors.Control;
            this.labTime.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labTime.Location = new System.Drawing.Point(716, 7);
            this.labTime.Margin = new System.Windows.Forms.Padding(0);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(95, 35);
            this.labTime.TabIndex = 0;
            this.labTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labState
            // 
            this.labState.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labState.ForeColor = System.Drawing.SystemColors.Control;
            this.labState.Location = new System.Drawing.Point(286, 9);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(292, 35);
            this.labState.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 190);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlMainDisplay
            // 
            this.pnlMainDisplay.Location = new System.Drawing.Point(0, 190);
            this.pnlMainDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMainDisplay.Name = "pnlMainDisplay";
            this.pnlMainDisplay.Size = new System.Drawing.Size(1000, 410);
            this.pnlMainDisplay.TabIndex = 1;
            this.pnlMainDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pnlMainDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labTrainType
            // 
            this.labTrainType.BackColor = System.Drawing.SystemColors.Control;
            this.labTrainType.Font = new System.Drawing.Font("Meiryo UI", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labTrainType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.labTrainType.Location = new System.Drawing.Point(17, 17);
            this.labTrainType.Margin = new System.Windows.Forms.Padding(0);
            this.labTrainType.Name = "labTrainType";
            this.labTrainType.Size = new System.Drawing.Size(210, 57);
            this.labTrainType.TabIndex = 0;
            this.labTrainType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LcdDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 598);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMainDisplay);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(38)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LcdDisplay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "0,0,0,0";
            this.Load += new System.EventHandler(this.LcdDisplay_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labState;
        private System.Windows.Forms.Label labStation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labDestinationJa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labDestinationEn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlMainDisplay;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labTrainType;
    }
}