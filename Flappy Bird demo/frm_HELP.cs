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
    public partial class frm_HELP : Form
    {
        public frm_HELP()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Khi click nut help se quay ve form Menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ptb_help_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Khi phim chon san duoc nhan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frm_HELP_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.H:
                case Keys.Escape:
                case Keys.X:
                    {
                        this.Dispose();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
