namespace Calculator
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
            this.thePanel = new System.Windows.Forms.Panel();
            this.pointsGameOvertxt = new System.Windows.Forms.Label();
            this.gameOvertxt = new System.Windows.Forms.Label();
            this.calcbtn = new System.Windows.Forms.Button();
            this.leftbtn = new System.Windows.Forms.Button();
            this.downbtn = new System.Windows.Forms.Button();
            this.pointstxt = new System.Windows.Forms.Label();
            this.rightbtn = new System.Windows.Forms.Button();
            this.upbtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.itemTimer = new System.Windows.Forms.Timer(this.components);
            this.thePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // thePanel
            // 
            this.thePanel.BackColor = System.Drawing.Color.Gray;
            this.thePanel.Controls.Add(this.pointsGameOvertxt);
            this.thePanel.Controls.Add(this.gameOvertxt);
            this.thePanel.Location = new System.Drawing.Point(12, 12);
            this.thePanel.Name = "thePanel";
            this.thePanel.Size = new System.Drawing.Size(500, 500);
            this.thePanel.TabIndex = 15;
            // 
            // pointsGameOvertxt
            // 
            this.pointsGameOvertxt.AutoSize = true;
            this.pointsGameOvertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsGameOvertxt.Location = new System.Drawing.Point(105, 216);
            this.pointsGameOvertxt.Name = "pointsGameOvertxt";
            this.pointsGameOvertxt.Size = new System.Drawing.Size(210, 55);
            this.pointsGameOvertxt.TabIndex = 12;
            this.pointsGameOvertxt.Text = "Points: 0";
            this.pointsGameOvertxt.Visible = false;
            // 
            // gameOvertxt
            // 
            this.gameOvertxt.AutoSize = true;
            this.gameOvertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOvertxt.Location = new System.Drawing.Point(54, 132);
            this.gameOvertxt.Name = "gameOvertxt";
            this.gameOvertxt.Size = new System.Drawing.Size(372, 73);
            this.gameOvertxt.TabIndex = 11;
            this.gameOvertxt.Text = "Game Over";
            this.gameOvertxt.Visible = false;
            // 
            // calcbtn
            // 
            this.calcbtn.BackColor = System.Drawing.Color.Gray;
            this.calcbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcbtn.Location = new System.Drawing.Point(533, 462);
            this.calcbtn.Name = "calcbtn";
            this.calcbtn.Size = new System.Drawing.Size(135, 50);
            this.calcbtn.TabIndex = 22;
            this.calcbtn.Text = "Close";
            this.calcbtn.UseVisualStyleBackColor = false;
            this.calcbtn.Click += new System.EventHandler(this.calcbtn_Click_1);
            // 
            // leftbtn
            // 
            this.leftbtn.BackColor = System.Drawing.Color.Gray;
            this.leftbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftbtn.Location = new System.Drawing.Point(543, 108);
            this.leftbtn.Name = "leftbtn";
            this.leftbtn.Size = new System.Drawing.Size(38, 33);
            this.leftbtn.TabIndex = 20;
            this.leftbtn.Text = "LT";
            this.leftbtn.UseVisualStyleBackColor = false;
            this.leftbtn.Click += new System.EventHandler(this.leftbtn_Click);
            // 
            // downbtn
            // 
            this.downbtn.BackColor = System.Drawing.Color.Gray;
            this.downbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downbtn.Location = new System.Drawing.Point(579, 138);
            this.downbtn.Name = "downbtn";
            this.downbtn.Size = new System.Drawing.Size(38, 33);
            this.downbtn.TabIndex = 19;
            this.downbtn.Text = "DN";
            this.downbtn.UseVisualStyleBackColor = false;
            this.downbtn.Click += new System.EventHandler(this.downbtn_Click);
            // 
            // pointstxt
            // 
            this.pointstxt.AutoSize = true;
            this.pointstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointstxt.Location = new System.Drawing.Point(538, 249);
            this.pointstxt.Name = "pointstxt";
            this.pointstxt.Size = new System.Drawing.Size(105, 29);
            this.pointstxt.TabIndex = 21;
            this.pointstxt.Text = "Points: 0";
            // 
            // rightbtn
            // 
            this.rightbtn.BackColor = System.Drawing.Color.Gray;
            this.rightbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightbtn.Location = new System.Drawing.Point(614, 108);
            this.rightbtn.Name = "rightbtn";
            this.rightbtn.Size = new System.Drawing.Size(38, 33);
            this.rightbtn.TabIndex = 18;
            this.rightbtn.Text = "RT";
            this.rightbtn.UseVisualStyleBackColor = false;
            this.rightbtn.Click += new System.EventHandler(this.rightbtn_Click);
            // 
            // upbtn
            // 
            this.upbtn.BackColor = System.Drawing.Color.Gray;
            this.upbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upbtn.Location = new System.Drawing.Point(579, 77);
            this.upbtn.Name = "upbtn";
            this.upbtn.Size = new System.Drawing.Size(38, 33);
            this.upbtn.TabIndex = 17;
            this.upbtn.Text = "UP";
            this.upbtn.UseVisualStyleBackColor = false;
            this.upbtn.Click += new System.EventHandler(this.upbtn_Click);
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.Gray;
            this.startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbtn.Location = new System.Drawing.Point(536, 12);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(122, 50);
            this.startbtn.TabIndex = 16;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // itemTimer
            // 
            this.itemTimer.Enabled = true;
            this.itemTimer.Interval = 3000;
            this.itemTimer.Tick += new System.EventHandler(this.itemTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(681, 526);
            this.Controls.Add(this.thePanel);
            this.Controls.Add(this.calcbtn);
            this.Controls.Add(this.leftbtn);
            this.Controls.Add(this.downbtn);
            this.Controls.Add(this.pointstxt);
            this.Controls.Add(this.rightbtn);
            this.Controls.Add(this.upbtn);
            this.Controls.Add(this.startbtn);
            this.Name = "Form1";
            this.Text = "Doms Snake Game :)";
            this.thePanel.ResumeLayout(false);
            this.thePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel thePanel;
        private System.Windows.Forms.Label pointsGameOvertxt;
        private System.Windows.Forms.Label gameOvertxt;
        private System.Windows.Forms.Button calcbtn;
        private System.Windows.Forms.Button leftbtn;
        private System.Windows.Forms.Button downbtn;
        private System.Windows.Forms.Label pointstxt;
        private System.Windows.Forms.Button rightbtn;
        private System.Windows.Forms.Button upbtn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer itemTimer;
    }
}