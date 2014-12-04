namespace PagerTrigger
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
            this.StopButton = new System.Windows.Forms.Button();
            this.StopLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StartLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pagerInterval = new System.Windows.Forms.TextBox();
            this.ComPortSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pagerCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sysTime = new System.Windows.Forms.Timer(this.components);
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(288, 126);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 11;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StopLabel
            // 
            this.StopLabel.AutoSize = true;
            this.StopLabel.Location = new System.Drawing.Point(243, 131);
            this.StopLabel.Name = "StopLabel";
            this.StopLabel.Size = new System.Drawing.Size(39, 13);
            this.StopLabel.TabIndex = 10;
            this.StopLabel.Text = "STOP:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(288, 81);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(236, 86);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(46, 13);
            this.StartLabel.TabIndex = 8;
            this.StartLabel.Text = "START:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pager Interval (mili):";
            // 
            // pagerInterval
            // 
            this.pagerInterval.Location = new System.Drawing.Point(120, 84);
            this.pagerInterval.Name = "pagerInterval";
            this.pagerInterval.Size = new System.Drawing.Size(100, 20);
            this.pagerInterval.TabIndex = 13;
            this.pagerInterval.Text = "30000";
            // 
            // ComPortSelector
            // 
            this.ComPortSelector.FormattingEnabled = true;
            this.ComPortSelector.Location = new System.Drawing.Point(120, 128);
            this.ComPortSelector.Name = "ComPortSelector";
            this.ComPortSelector.Size = new System.Drawing.Size(100, 21);
            this.ComPortSelector.TabIndex = 14;
            this.ComPortSelector.Text = "(select)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select COM Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Number of Pager Triggers:";
            // 
            // pagerCountLabel
            // 
            this.pagerCountLabel.AutoSize = true;
            this.pagerCountLabel.Location = new System.Drawing.Point(288, 161);
            this.pagerCountLabel.Name = "pagerCountLabel";
            this.pagerCountLabel.Size = new System.Drawing.Size(13, 13);
            this.pagerCountLabel.TabIndex = 18;
            this.pagerCountLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "* This is an application that will send a page on every given interval.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "** Note that the interval must not fall below 10 seconds (or 10000 mili).";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "*** Also, remember to select a COM Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(275, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 9);
            this.label7.TabIndex = 22;
            this.label7.Text = "© Justin Livingston WTI 2012";
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(12, 182);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(130, 13);
            this.pBar.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 207);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pagerCountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComPortSelector);
            this.Controls.Add(this.pagerInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StopLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StartLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pager Trigger Loop Application";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label StopLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pagerInterval;
        private System.Windows.Forms.ComboBox ComPortSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pagerCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer sysTime;
        private System.Windows.Forms.ProgressBar pBar;
    }
}

