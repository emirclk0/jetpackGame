namespace jetpackGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            scoreLabel = new Label();
            endLabel = new Label();
            fuelbar = new ProgressBar();
            movementTimer = new System.Windows.Forms.Timer(components);
            fuelbarTimer = new System.Windows.Forms.Timer(components);
            bulletTimer = new System.Windows.Forms.Timer(components);
            scoreTimer = new System.Windows.Forms.Timer(components);
            invincibleTimer = new System.Windows.Forms.Timer(components);
            drawStarTimer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            dieTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(9, 10);
            label1.Name = "label1";
            label1.Size = new Size(24, 23);
            label1.TabIndex = 0;
            label1.Text = "X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(92, 9);
            label2.Name = "label2";
            label2.Size = new Size(23, 23);
            label2.TabIndex = 1;
            label2.Text = "Y:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLabel.ForeColor = Color.Yellow;
            scoreLabel.Location = new Point(1141, 8);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(100, 31);
            scoreLabel.TabIndex = 2;
            scoreLabel.Text = "SCORE:";
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.BackColor = Color.Transparent;
            endLabel.Font = new Font("Viner Hand ITC", 60F, FontStyle.Regular, GraphicsUnit.Point);
            endLabel.ForeColor = Color.Maroon;
            endLabel.Location = new Point(307, 349);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(686, 162);
            endLabel.TabIndex = 3;
            endLabel.Text = "ÖLDÜNÜZ....";
            endLabel.Visible = false;
            // 
            // fuelbar
            // 
            fuelbar.Location = new Point(19, 812);
            fuelbar.Name = "fuelbar";
            fuelbar.Size = new Size(1251, 29);
            fuelbar.TabIndex = 4;
            // 
            // movementTimer
            // 
            movementTimer.Enabled = true;
            movementTimer.Interval = 1;
            movementTimer.Tick += TimerEvent;
            // 
            // fuelbarTimer
            // 
            fuelbarTimer.Enabled = true;
            fuelbarTimer.Interval = 1000;
            fuelbarTimer.Tick += fuelbarTimer_Tick;
            // 
            // bulletTimer
            // 
            bulletTimer.Enabled = true;
            bulletTimer.Interval = 20;
            bulletTimer.Tick += bulletTimer_Tick;
            // 
            // scoreTimer
            // 
            scoreTimer.Enabled = true;
            scoreTimer.Interval = 2000;
            scoreTimer.Tick += scoreTimer_Tick;
            // 
            // invincibleTimer
            // 
            invincibleTimer.Interval = 5000;
            invincibleTimer.Tick += invincibleTimer_Tick;
            // 
            // drawStarTimer
            // 
            drawStarTimer.Interval = 15000;
            drawStarTimer.Tick += drawStarTimer_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Viner Hand ITC", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(513, 8);
            label3.Name = "label3";
            label3.Size = new Size(234, 55);
            label3.TabIndex = 5;
            label3.Text = "ÖLÜMSÜZ!!!";
            label3.Visible = false;
            // 
            // dieTimer
            // 
            dieTimer.Interval = 200;
            dieTimer.Tick += dieTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 853);
            Controls.Add(label3);
            Controls.Add(fuelbar);
            Controls.Add(endLabel);
            Controls.Add(scoreLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jetpack Game";
            FormClosing += Form1_FormClosing;
            Paint += FormPaintEvent;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label scoreLabel;
        private Label endLabel;
        private ProgressBar fuelbar;
        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.Timer fuelbarTimer;
        private System.Windows.Forms.Timer bulletTimer;
        private System.Windows.Forms.Timer scoreTimer;
        private System.Windows.Forms.Timer invincibleTimer;
        private System.Windows.Forms.Timer drawStarTimer;
        private Label label3;
        private System.Windows.Forms.Timer dieTimer;
    }
}