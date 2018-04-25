using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace annoyingAd
{
    public partial class BestAd : Form
    {

        Rectangle workingArea;
        const int movespeed = 2;


        public BestAd()
        {
            InitializeComponent();

            workingArea = Screen.PrimaryScreen.WorkingArea;
            ChangeAd();

        }

        private void BestAd_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int rx = r.Next(workingArea.Width - this.Width);

            this.Location = new Point(rx, workingArea.Bottom);

        }

        private void Moveup_Tick(object sender, EventArgs e)
        {

            if(this.Location.Y > workingArea.Bottom - this.Height)
            {
                this.Location = new Point(this.Location.X, this.Location.Y - movespeed);
            }
        }

        public void ChangeAd()
        {

            List<genericAds> ads = JsonConvert.DeserializeObject<List<genericAds>>(File.ReadAllText("config.json"));

            Random r = new Random();
            int randomAd = r.Next(ads.Count() - 1);

            genericAds temp = ads[randomAd];

            this.headline.Text = temp.headline;
            this.desclabel.Text = temp.description;
            this.pictureBox1.Load(temp.image);

        }

        private void OK_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hackertyper.net/");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
