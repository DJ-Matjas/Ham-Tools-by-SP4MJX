namespace Ham_Tools
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.localDateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.localTimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.utcTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.moveToCorner = new System.Windows.Forms.Button();
            this.alwaysOnTopButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.hamQsl1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.localDateLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.temperatureLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.localTimeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.utcTimeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.closeButton);
            this.splitContainer1.Panel2.Controls.Add(this.moveToCorner);
            this.splitContainer1.Panel2.Controls.Add(this.alwaysOnTopButton);
            this.splitContainer1.Panel2.Controls.Add(this.settingsButton);
            this.splitContainer1.Panel2.Controls.Add(this.hamQsl1);
            this.splitContainer1.Size = new System.Drawing.Size(634, 261);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // localDateLabel
            // 
            this.localDateLabel.AutoSize = true;
            this.localDateLabel.Font = new System.Drawing.Font("Aptos", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localDateLabel.Location = new System.Drawing.Point(9, 148);
            this.localDateLabel.Name = "localDateLabel";
            this.localDateLabel.Size = new System.Drawing.Size(172, 41);
            this.localDateLabel.TabIndex = 7;
            this.localDateLabel.Text = "00.00.0000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aptos", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Local Date";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("Aptos", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureLabel.Location = new System.Drawing.Point(9, 208);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(108, 41);
            this.temperatureLabel.TabIndex = 5;
            this.temperatureLabel.Text = "ERR°C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aptos", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Temperature";
            // 
            // localTimeLabel
            // 
            this.localTimeLabel.AutoSize = true;
            this.localTimeLabel.Font = new System.Drawing.Font("Aptos", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localTimeLabel.Location = new System.Drawing.Point(9, 88);
            this.localTimeLabel.Name = "localTimeLabel";
            this.localTimeLabel.Size = new System.Drawing.Size(138, 41);
            this.localTimeLabel.TabIndex = 3;
            this.localTimeLabel.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aptos", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Local Time";
            // 
            // utcTimeLabel
            // 
            this.utcTimeLabel.AutoSize = true;
            this.utcTimeLabel.Font = new System.Drawing.Font("Aptos SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utcTimeLabel.Location = new System.Drawing.Point(9, 28);
            this.utcTimeLabel.Name = "utcTimeLabel";
            this.utcTimeLabel.Size = new System.Drawing.Size(138, 41);
            this.utcTimeLabel.TabIndex = 1;
            this.utcTimeLabel.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aptos", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "UTC Time";
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Aptos", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(3, 226);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(62, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // moveToCorner
            // 
            this.moveToCorner.Font = new System.Drawing.Font("Aptos", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveToCorner.Location = new System.Drawing.Point(71, 226);
            this.moveToCorner.Name = "moveToCorner";
            this.moveToCorner.Size = new System.Drawing.Size(119, 23);
            this.moveToCorner.TabIndex = 3;
            this.moveToCorner.Text = "Move to Corner";
            this.moveToCorner.UseVisualStyleBackColor = true;
            this.moveToCorner.Click += new System.EventHandler(this.moveToCorner_Click);
            // 
            // alwaysOnTopButton
            // 
            this.alwaysOnTopButton.Font = new System.Drawing.Font("Aptos", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alwaysOnTopButton.Location = new System.Drawing.Point(196, 226);
            this.alwaysOnTopButton.Name = "alwaysOnTopButton";
            this.alwaysOnTopButton.Size = new System.Drawing.Size(121, 23);
            this.alwaysOnTopButton.TabIndex = 2;
            this.alwaysOnTopButton.Text = "Always on Top";
            this.alwaysOnTopButton.UseVisualStyleBackColor = true;
            this.alwaysOnTopButton.Click += new System.EventHandler(this.alwaysOnTopButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Aptos", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(323, 226);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(95, 23);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.comPortButton_Click);
            // 
            // hamQsl1
            // 
            this.hamQsl1.AllowNavigation = false;
            this.hamQsl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hamQsl1.IsWebBrowserContextMenuEnabled = false;
            this.hamQsl1.Location = new System.Drawing.Point(0, 0);
            this.hamQsl1.MinimumSize = new System.Drawing.Size(20, 20);
            this.hamQsl1.Name = "hamQsl1";
            this.hamQsl1.ScrollBarsEnabled = false;
            this.hamQsl1.Size = new System.Drawing.Size(430, 261);
            this.hamQsl1.TabIndex = 0;
            this.hamQsl1.Url = new System.Uri("https://www.hamqsl.com/solarmap.php", System.UriKind.Absolute);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.splitContainer1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 300);
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "mainWindow";
            this.Opacity = 0.85D;
            this.Text = "Ham Tools 1.0 by SP4MJX";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label utcTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label localTimeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label localDateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser hamQsl1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button alwaysOnTopButton;
        private System.Windows.Forms.Button moveToCorner;
        private System.Windows.Forms.Button closeButton;
    }
}

