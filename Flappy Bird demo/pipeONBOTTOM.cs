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
    public class pipeONBOTTOM : Pipe
    {
        /// <summary>
        /// Cap chieu dai cho ong duoi.
        /// </summary>
        /// <param name="_height"></param>
        /// <param name="_y"></param>

        public void create(int _height, int _y)
        {
            create(Properties.Resources.pipe_on_bottom, _height, _y);
        }

        /// <summary>
        /// Di chuyen ong duoi.
        /// </summary>

        public void bottomMOVE()
        {
            move();
        }

        /// <summary>
        /// Thay doi tao do X cua ong duoi.
        /// </summary>

        public int X
        {
            set
            {
                Location = new Point(value, Location.Y);
            }
        }

        /// <summary>
        /// Cap nhat trang thai ong duoi.(So voi vi tri cua con chim)
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
