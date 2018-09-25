using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        GameEngine Game = new GameEngine();
        int time = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMap.Text = "";
            Game.start();
        }

        private void tmTick_Tick(object sender, EventArgs e)
        {
            
            lblMap.Text = Game.playGame();
            lblTime.Text = time.ToString();

            cmbInfo.Items.Clear();

            for (int i = 0; i < Game.numUnit(); i++) //add units to the combo box
            {
                cmbInfo.Items.Add(Game.UnitsString(i));
            }

            time++;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmTick.Enabled = true;
            tmTick.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmTick.Enabled = false;
            tmTick.Stop();
        }

        private void cmbInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
