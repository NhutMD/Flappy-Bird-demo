using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flappy_Bird_demo
{
    public partial class frm_MENU : Form
    {
        private bool flag = false;

        public frm_MENU()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Thuc thi khi nhan chon nut help.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ptb_help_Click(object sender, EventArgs e)
        {
            help();
        }

        /// <summary>
        /// Khi chon vao con chim.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ptb_bird_Click(object sender, EventArgs e)
        {
            play();
        }

        /// <summary>
        /// Khi chon nut turn off.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ptb_turn_off_Click(object sender, EventArgs e)
        {
            exit();
        }

        /// <summary>
        /// Khi click nut play.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ptb_play_Click(object sender, EventArgs e)
        {
            play();
        }

        /// <summary>
        /// Khi nhan dung nhung phim duoc chon san.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frm_MENU_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                case Keys.X:
                    {
                        exit();
                        break;
                    }
                case Keys.Enter:
                case Keys.Space:
                    {
                        play();
                        break;
                    }
                case Keys.H:
                    {
                        help();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        /// <summary>
        /// Cho phep thay doi hinh anh chim va nen co.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timer_action_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                ptb_bird.BackgroundImage = Properties.Resources.bird_normal;
                ptb_ground.BackgroundImage = Properties.Resources.ground;
            }
            else
            {
                ptb_bird.BackgroundImage = Properties.Resources.bird_fly;
                ptb_ground.BackgroundImage = Properties.Resources.ground_1;
            }
            flag = !flag;
        }

        /// <summary>
        /// Ham goi form GAMEPLAY.
        /// </summary>

        public void play()
        {
            timer_action.Stop();
            this.Hide();
            frm_GAMEPLAY player = new frm_GAMEPLAY();
            player.ShowDialog();
            player.Dispose();
            timer_action.Start();
            this.Show();
        }

        /// <summary>
        /// Ham goi form HELP.
        /// </summary>

        public void help()
        {
            timer_action.Stop();
            this.Hide();
            frm_HELP help = new frm_HELP();
            help.ShowDialog();
            help.Dispose();
            timer_action.Start();
            this.Show();
        }

        /// <summary>
        /// Ham thoat chuong trinh.
        /// </summary>

        public void exit()
        {
            timer_action.Stop();
            this.Dispose();
        }

        private void frm_MENU_Load(object sender, EventArgs e)
        {

        }
    }
}
