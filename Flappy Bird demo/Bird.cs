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
    class Bird : PictureBox
    {
        private bool _fly;
        private int _speed;

        /// <summary>
        /// Khoi tao ban dau cho chim.
        /// </summary>

        public Bird()
        {
            _fly = true;
            _speed = Contain.speed4bird;
            Location = new Point(Contain.X4bird, Contain.Y4bird);
            Height = Contain.height4bird;
            Width = Contain.width4bird;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Properties.Resources.bird_normal;
        }

        /// <summary>
        /// Hien thi hinh anh roi xuong cua chim.
        /// </summary>

        public void fall()
        {
            BackgroundImage = Properties.Resources.bird_fall;
        }

        /// <summary>
        /// Hien thi hinh anh bay cua chim.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void fly()
        {
            BackgroundImage = Properties.Resources.bird_fly2;
        }

        /// <summary>
        /// Hien thi hinh anh dung yen cua chim.
        /// </summary>

        public void normal()
        {
            BackgroundImage = Properties.Resources.bird_normal;
        }

        /// <summary>
        /// Lay gia tri hoac cai dat lai trang thai bay cua chim.
        /// </summary>

        public bool Fly
        {
            get
            {
                return _fly;
            }
            set
            {
                _fly = value;
            }
        }

        /// <summary>
        /// Lay gia tri toc do bay cua chim.
        /// </summary>

        public int Speed
        {
            get
            {
                return _speed;
            }
        }
    }
}
