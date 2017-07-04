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
    public class Pipe : PictureBox
    {
        protected int _speed;
        protected bool _flag;

        /// <summary>
        /// Khoi cac thong so cho ong.
        /// </summary>

        public Pipe()
        {
            _speed = Contain.speed4pipe;
            _flag = false;
            Location = new Point(Contain.X4pipe, Contain.Y4pipe);
            Width = Contain.width4pipe;
        }

        /// <summary>
        /// Tao ong co chieu cao tuy chon.
        /// </summary>
        /// <param name="_image"></param>
        /// <param name="_height"></param>
        /// <param name="_y"></param>

        public void create(Image _image, int _height, int _y)
        {
            this.BackgroundImage = _image;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackColor = Color.Transparent;
            this.Height = _height;
            this.Location = new Point(Contain.X4pipe, _y);
            this.Width = Contain.width4pipe;
        }

        /// <summary>
        /// Di chuyen ong qua trai.
        /// </summary>

        public void move()
        {
            Point newLocation = new Point(this.Location.X - Contain.speed4pipe, this.Location.Y);
            this.Location = newLocation;
        }
    }
}
