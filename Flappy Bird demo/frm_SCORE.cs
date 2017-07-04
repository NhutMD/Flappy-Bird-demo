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
    public partial class frm_SCORE : Form
    {
        private bool replay = false;
        public frm_SCORE()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Thuc hien theo cac phim duoc chon san.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frm_SCORE_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                case Keys.X:
                    {
                        this.Dispose();
                        break;
                    }
                case Keys.L:
                    {
                        replay = true;
                        this.Dispose();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        /// <summary>
        /// Cho phep click chon nut replay de choi lai.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ptb_replay_Click(object sender, EventArgs e)
        {
            replay = true;
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// Thoat khoi chuong trinh.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ptb_turn_off_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Lay diem tu form GAMEPLAY, de hien thi thong bao.
        /// </summary>
        /// <param name="lbl"></param>

        public void text(Label lbl)
        {
            lbl_mark.Text = lbl.Text;
        }

        /// <summary>
        /// Cap nhat khi nhan nut replay.
        /// </summary>

        public bool Replay
        {
            get
            {
                return replay;
            }
        }
    }
}
