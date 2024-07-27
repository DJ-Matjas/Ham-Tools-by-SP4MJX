using System;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Xml;
using System.Diagnostics;

namespace Ham_Tools
{
    public partial class mainWindow : Form
    {
        private SerialPort serialPort;

        public mainWindow()
        {

            // Stamdard initialzation
            InitializeComponent();

            // Chceck if config file exists
            if (File.Exists("ham.xml") == false)
            {
                MessageBox.Show("Config file not found. Please create it via Settings tool.", "Ham Tools Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start("settings.exe");
                Environment.Exit(1);
            }

            // XML initialization
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ham.xml");

            // Serial port initialization
            XmlNode comPortNode = xmlDoc.SelectSingleNode("/Settings/comPort");
            if (comPortNode != null)
            {
                serialPort = new SerialPort(comPortNode.InnerText, 9600);
            }

            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serial Port Unavailable: " + ex.Message, "Ham Tools Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Timer initialization
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(OnTimerTick);
            timer1.Start();

            this.Load += new EventHandler(mainWindow_Load);
        }

        // Refreshing the window every second
        private void OnTimerTick(object sender, EventArgs e)
        {
            // Date and time refreshing
            DateTime ldt = DateTime.Now;
            DateTime udt = DateTime.UtcNow;
            utcTimeLabel.Text = udt.ToString("HH:mm:ss");
            localTimeLabel.Text = ldt.ToString("HH:mm:ss");
            localDateLabel.Text = ldt.ToString("dd.MM.yyyy");

            // Temperature refreshing
            try
            {
                string data = serialPort.ReadLine().Trim();
                temperatureLabel.Text = data + "°C";
            }
            catch
            {

            }
            // Browsers refreshing
            hamQsl1.Refresh();
        }

        // Closing COM port after closing the program
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            base.OnFormClosing(e);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Move to Cornet Button Action
        private void moveToCorner_Click(object sender, EventArgs e)
        {
            var screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            var screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int x = screenWidth - this.Width;
            int y = screenHeight - this.Height;

            this.Location = new System.Drawing.Point(x, y);
        }

        // Always on Top Button Action
        private void alwaysOnTopButton_Click(object sender, EventArgs e)
        {
            if (this.TopMost == true)
            {
                this.TopMost = false;
                this.Text = "Ham Tools 1.4 by SP4MJX";
            }
            else
            {
                this.TopMost = true;
                this.Text = "Ham Tools 1.4 by SP4MJX [Always on Top]";
            }
        }

        // Setting button Action
        private void comPortButton_Click(object sender, EventArgs e)
        {
            Process.Start("settings.exe");
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            // XML initialization
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ham.xml");

            // Always on Top on Startup
            XmlNode aotOnStartupNode = xmlDoc.SelectSingleNode("/Settings/aotOnStartup");
            if (aotOnStartupNode.InnerText == "true")
            {
                this.TopMost = true;
                this.Text = "Ham Tools 1.4 by SP4MJX [Always on Top]";
            }

            // Move to Corner on Startup
            XmlNode mtcOnStartupNode = xmlDoc.SelectSingleNode("/Settings/mtcOnStartup");
            if (mtcOnStartupNode.InnerText == "true")
            {
                var screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                var screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

                int x = screenWidth - this.Width;
                int y = screenHeight - this.Height;

                this.Location = new System.Drawing.Point(x, y);
            }
        }
    }
}
