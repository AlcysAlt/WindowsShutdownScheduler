namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.hours_txt = new System.Windows.Forms.TextBox();
            this.minutes_txt = new System.Windows.Forms.TextBox();
            this.seconds_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.abortShutdown_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(316, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Timed Shutdown";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // hours_txt
            // 
            this.hours_txt.Location = new System.Drawing.Point(181, 163);
            this.hours_txt.Name = "hours_txt";
            this.hours_txt.Size = new System.Drawing.Size(87, 20);
            this.hours_txt.TabIndex = 5;
            this.hours_txt.Text = "0";
            this.hours_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // minutes_txt
            // 
            this.minutes_txt.Location = new System.Drawing.Point(323, 163);
            this.minutes_txt.Name = "minutes_txt";
            this.minutes_txt.Size = new System.Drawing.Size(106, 20);
            this.minutes_txt.TabIndex = 6;
            this.minutes_txt.Text = "0";
            this.minutes_txt.TextChanged += new System.EventHandler(this.minutes_txt_TextChanged);
            // 
            // seconds_txt
            // 
            this.seconds_txt.Location = new System.Drawing.Point(481, 163);
            this.seconds_txt.Name = "seconds_txt";
            this.seconds_txt.Size = new System.Drawing.Size(106, 20);
            this.seconds_txt.TabIndex = 7;
            this.seconds_txt.Text = "0";
            this.seconds_txt.TextChanged += new System.EventHandler(this.seconds_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(274, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "HR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // abortShutdown_btn
            // 
            this.abortShutdown_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.abortShutdown_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.abortShutdown_btn.FlatAppearance.BorderSize = 2;
            this.abortShutdown_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abortShutdown_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.abortShutdown_btn.Location = new System.Drawing.Point(354, 294);
            this.abortShutdown_btn.Name = "abortShutdown_btn";
            this.abortShutdown_btn.Size = new System.Drawing.Size(75, 28);
            this.abortShutdown_btn.TabIndex = 11;
            this.abortShutdown_btn.Text = "Cancel";
            this.abortShutdown_btn.UseVisualStyleBackColor = false;
            this.abortShutdown_btn.Click += new System.EventHandler(this.abortShutdown_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(435, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "MIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(593, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "SEC";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(303, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Schedule Shutdown";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abortShutdown_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seconds_txt);
            this.Controls.Add(this.minutes_txt);
            this.Controls.Add(this.hours_txt);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Schedule Shutdown ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox hours_txt;
        public System.Windows.Forms.TextBox minutes_txt;
        public System.Windows.Forms.TextBox seconds_txt;
        private System.Windows.Forms.Button abortShutdown_btn;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

