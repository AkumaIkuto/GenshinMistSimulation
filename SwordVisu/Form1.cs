using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwordVisu
{
    public partial class Form1 : Form
    {
        int energy = 0;
        double attacktime = 5.0;
        double bursttime = 10.0;
        int tokens = 0;
        int dmgbonus = 0;

        // okay
        bool granttoken1 = false;
        bool granttoken2 = false;
        bool granttoken3 = false;

        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            textBoxAttackTimer.Text = Math.Round(attacktime, 2).ToString();
            textBoxBurstTimer.Text = Math.Round(bursttime, 2).ToString();
            textBoxEnergy.Text = energy.ToString();

            if (energy == 100)
            {
                button2.Enabled = true;
            }

            switch (tokens)
            {
                case 0:
                    dmgbonus = 0;
                    break;
                case 1:
                    dmgbonus = 8;
                    break;
                case 2:
                    dmgbonus = 16;
                    break;
                case 3:
                    dmgbonus = 28;
                    break;
            }

            richTextBox1.Text = "Attacktoken: " + granttoken1.ToString() + "\n\r" + "Bursttoken: " + granttoken2.ToString() + "\n\r" + "Energytoken: " + granttoken3.ToString();

            textBoxDMGbon.Text = dmgbonus.ToString() + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (energy < 100)
            {
                energy += 10;
            }

            attacktime = 5.0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            energy = 0;
            button2.Enabled = false;
            bursttime = 10.0;
        }

        private void Attacktimer_Tick(object sender, EventArgs e)
        {
            if (attacktime > 0.1)
            {
                attacktime -= 0.1;
            }
            else
            {
                attacktime = 0;
            }

            if (attacktime != 0 && granttoken1 == false)
            {
                tokens += 1;
                granttoken1 = true;
            }

            if (attacktime == 0 && granttoken1 == true)
            {
                tokens -= 1;
                granttoken1 = false;
            }
        }

        private void Bursttimer_Tick(object sender, EventArgs e)
        {
            if (bursttime > 0.1)
            {
                bursttime -= 0.1;
            }
            else
            {
                bursttime = 0;
            }

            if (bursttime != 0 && granttoken2 == false)
            {
                tokens += 1;
                granttoken2 = true;
            }

            if (bursttime == 0 && granttoken2 == true)
            {
                tokens -= 1;
                granttoken2 = false;
            }
        }

        private void Energytimer_Tick(object sender, EventArgs e)
        {
            if (energy < 100 && granttoken3 == false)
            {
                tokens += 1;
                granttoken3 = true;
            }

            if (energy == 100 && granttoken3 == true)
            {
                tokens -= 1;
                granttoken3 = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                richTextBox1.Visible = true;
            }
            else
            {
                richTextBox1.Visible = false;
            }
        }
    }
}