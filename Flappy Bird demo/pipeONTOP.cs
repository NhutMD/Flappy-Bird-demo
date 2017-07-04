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
    public class pipeONTOP : Pipe
    {
        /// <summary>
        /// Cap chieu dai cho ong tren.
        /// </summary>
        /// <param name="_height"></param>

        public void create(int _height)
        {
            create(Properties.Resources.pipe_on_top, _height, 0);
        }

        /// <summary>
        /// Di chuyen ong tren.
        /// </summary>

        public void topMOVE()
        {
            move();
        }

        /// <summary>
        /// Thay doi tao do X cua ong tren.
        /// </summary>

        public int X
        {
            set
            {
                Location = new Point(value, Location.Y);
            }
        }

        /// <summary>
        /// Cap nhat trang thai ong tren.(So voi vi tri cua con chim)
        /// </summary>

        public bool Flag
        {
            get
            {
                return _flag;
            }
            set
            {
                _flag = value;
            }
        }
    }
}
