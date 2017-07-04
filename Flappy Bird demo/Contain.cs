using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flappy_Bird_demo
{

    /// <summary>
    /// Lop chua cac thong so can thiet.
    /// </summary>

    class Contain
    {
        /// <summary>
        /// Toc do.
        /// </summary>
        
        //  Chim bay len.
        public static int speed4bird = 40;
        //  Chim roi xuong.
        public static int speed2fall =5;
        public static int speed4pipe = 5;

        /// <summary>
        /// Ty le khung hinh.
        /// </summary>
        
        //  Chieu dai khung hinh chua chim, chua ong.
        public static int height4bird = 64;
        public static int height4pipe;
        //  Chieu rong khung hinh chua chim, chua ong.
        public static int width4bird = 64;
        public static int width4pipe = 64;

        /// <summary>
        /// Tao do khoi tao ban dau.
        /// </summary>
        
        //  Tao do X.
        public static int X4bird = 100;
        public static int X4pipe = 300;
        //  Tao do Y.
        public static int Y4bird = 300;
        public static int Y4pipe = 0;

        /// <summary>
        /// Phan trong thua trong khung hinh chua chim.
        /// </summary>
        
        //  Khoang trong phia duoi.
        public static int bottom4bird = 17;
        //  Khoang trong phia tren.
        public static int top4bird = 17;
        //  Khoang trong ben trai.
        public static int left4bird = 12;
        //  Khoang trong ben phai.
        public static int right4bird = 10;

        /// <summary>
        /// Khoang cach giua hai ong.
        /// </summary>

        public static int spacepi2pi = 100;

        /// <summary>
        /// Lay gia tri hoac cai dat lai toc do bay len cua chim.
        /// </summary>

        public static int Speed4Bird
        {
            get
            {
                return speed4bird;
            }
            set
            {
                speed4bird = value;
            }
        }

        /// <summary>
        /// Lay gia tri hoac cai dat lai toc do di chuyen cua ong
        /// </summary>

        public int Speed4Pipe
        {
            get
            {
                return speed4pipe;
            }
            set
            {
                speed4pipe = value;
            }
        }
    }
}
