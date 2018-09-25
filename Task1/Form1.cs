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
            Game.start();
        }

        private void tmTick_Tick(object sender, EventArgs e)
        {
            lblMap.Text = Game.playGame();
            lblTime.Text = time.ToString();
            time++;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmTick.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmTick.Enabled = false;
        }
    }
}
