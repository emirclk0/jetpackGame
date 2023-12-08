namespace jetpackGame
{
    partial class baslangic
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baslangic));
            button1 = new Button();
            label1 = new Label();
            gametextTimer = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Showcard Gothic", 45.8000031F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(235, 236);
            button1.Name = "button1";
            button1.Size = new Size(791, 184);
            button1.TabIndex = 0;
            button1.Text = "OYNA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 70.2000046F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(197, 39);
            label1.Name = "label1";
            label1.Size = new Size(850, 155);
            label1.TabIndex = 1;
            label1.Text = "Jetpack Game";
            // 
            // gametextTimer
            // 
            gametextTimer.Enabled = true;
            gametextTimer.Interval = 500;
            gametextTimer.Tick += gametextTimer_Tick;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Showcard Gothic", 45.8000031F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Maroon;
            button2.Location = new Point(235, 502);
            button2.Name = "button2";
            button2.Size = new Size(791, 184);
            button2.TabIndex = 2;
            button2.Text = "NASIL OYNANIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Maroon;
            button3.Location = new Point(1100, 716);
            button3.Name = "button3";
            button3.Size = new Size(170, 125);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(1133, 670);
            label2.Name = "label2";
            label2.Size = new Size(102, 43);
            label2.TabIndex = 4;
            label2.Text = "QUIT";
            // 
            // baslangic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1282, 853);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "baslangic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jetpack Game";
            FormClosing += baslangic_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private System.Windows.Forms.Timer gametextTimer;
        private Button button2;
        private Button button3;
        private Label label2;
    }
}