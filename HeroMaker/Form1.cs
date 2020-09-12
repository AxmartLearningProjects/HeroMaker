using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {

            bool[] abilities = { false, false, false, false, false, false, false, false, false, false };

            abilities[0] = chk_fly.Checked;
            abilities[1] = chk_fire.Checked;
            abilities[2] = chk_laser.Checked;
            abilities[3] = chk_time.Checked;
            abilities[4] = chk_speed.Checked;
            abilities[5] = chk_strength.Checked;
            abilities[6] = chk_invis.Checked;
            abilities[7] = chk_animals.Checked;
            abilities[8] = chk_teleki.Checked;
            abilities[9] = chk_water.Checked;

            string statis_message = "You have selected the following abilites : ";

            if (abilities[0])
                statis_message += chk_fly.Text;
            if (abilities[1])
                statis_message += chk_fire.Text;
            if (abilities[2])
                statis_message += chk_laser.Text;
            if (abilities[3])
                statis_message += chk_time.Text;
            if (abilities[4])
                statis_message += chk_speed.Text;
            if (abilities[5])
                statis_message += chk_strength.Text;
            if (abilities[6])
                statis_message += chk_invis.Text;
            if (abilities[7])
                statis_message += chk_animals.Text;
            if (abilities[8])
                statis_message += chk_teleki.Text;
            if (abilities[9])
                statis_message += chk_water.Text;

            MessageBox.Show(statis_message);

        }
    }
}
