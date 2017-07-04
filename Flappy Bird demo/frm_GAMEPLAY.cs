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

    //protected virtual bool DoubleBuffered { get; set; }

    //protected override CreateParams CreateParams
    //{
    //    get
    //    {
    //        CreateParams cp = base.CreateParams;
    //        cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
    //        return cp;
    //    }
    //    set { }
    //}

    public partial class frm_GAMEPLAY : Form
    {
        //public static int high_score = 0;
        private bool[] flag = { false, false, false, false };
        private Random rand = new Random();
        private Bird _bird = new Bird();
        private pipeONTOP[] _top = new pipeONTOP[3];
        private pipeONBOTTOM[] _bottom = new pipeONBOTTOM[3];
        private int score = 0;
        private Point newLocation = new Point(100, 300);

        /// <summary>
        /// Them doi tuong con chim vao form.
        /// </summary>

        public frm_GAMEPLAY()
        {
            InitializeComponent();
            new_create();
        }

        /// <summary>
        /// Ham khoi tao tat ca cac doi tuong va the hie len form gom: con chim, ong tren ong duoi.
        /// </summary>

        public void new_create()
        {
            _bird = new Bird();
            for (int i = 0; i < 3; i++)
            {
                _top[i] = new pipeONTOP();
                _bottom[i] = new pipeONBOTTOM();
            }
            for (int i = 0; i < 3; i++)
            {
                create_pipe(_top[i], _bottom[i]);
                switch (i)
                {
                    case 0:
                        {
                            _top[i].X = 400;
                            _bottom[i].X = 400;
                            break;
                        }
                    case 1:
                        {
                            _top[i].X = 600;
                            _bottom[i].X = 600;
                            break;
                        }
                    case 2:
                        {
                            _top[i].X = 800;
                            _bottom[i].X = 800;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                this.Controls.Add(_top[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                this.Controls.Add(_bottom[i]);
            }
            this.Controls.Add(_bird);
        }
        
        /// <summary>
        /// Chim roi xuong.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tmr_fall_Tick(object sender, EventArgs e)
        {
            fall(_bird, e);
        }

        /// <summary>
        /// Thay doi nen co trong form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tmr_ground_Tick(object sender, EventArgs e)
        {
            if (flag[0])
            {
                ptb_ground.BackgroundImage = Properties.Resources.ground;
                ptb_ground.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                ptb_ground.BackgroundImage = Properties.Resources.ground_1;
                ptb_ground.BackgroundImageLayout = ImageLayout.Stretch;
            }
            flag[0] = !flag[0];
        }

        /// <summary>
        /// Thay doi hinh nen cua chim (chim vo canh).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tmr_fly_Tick(object sender, EventArgs e)
        {
            if (flag[1])
            {
                _bird.BackgroundImage = Properties.Resources.bird_fly;
            }
            else
            {
                _bird.BackgroundImage = Properties.Resources.bird_normal;
            }
            flag[1] = !flag[1];
        }

        /// <summary>
        /// Thuc hien khi click chuot chon nut pause.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ptb_pause_Click(object sender, EventArgs e)
        {
            if (_bird.Fly)
                if (flag[2])
                {
                    start();
                    flag[2] = !flag[2];
                    ptb_pause.Image = Properties.Resources.pause;
                }
                else
                {
                    stop();
                    flag[2] = !flag[2];
                    ptb_pause.Image = Properties.Resources.play;
                }
        }

        /// <summary>
        /// Bat su kien click cho form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frm_GAMEPLAY_Click(object sender, EventArgs e)
        {
            if (!flag[2])
            {
                fly(_bird, e);
            }
        }

        /// <summary>
        /// Khi nhan phim.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frm_GAMEPLAY_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //  Thoat khoi chuong trinh.
                case Keys.Escape:
                    {
                        this.Dispose();
                        break;
                    }

                // Cho phep chim bay len.
                case Keys.Enter:
                case Keys.Space:
                    {
                        if (!flag[2])
                        {
                            fly(_bird, e);
                        }
                        break;
                    }

                //  Tam dung chuong trinh.
                case Keys.P:
                    {
                        if(_bird.Fly)
                            if (flag[2])
                            {
                                start();
                                flag[2] = !flag[2];
                                ptb_pause.Image = Properties.Resources.pause;
                            }
                            else
                            {
                                stop();
                                flag[2] = !flag[2];
                                ptb_pause.Image = Properties.Resources.play;
                            }
                        break;
                    }

                //  Tai lai chuong trinh.
                case Keys.L:
                    {
                        if (!flag[2])
                        {
                            load();
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        /// <summary>
        /// Giam tao do Y cua chim: Chim bay len.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void fly(object sender, EventArgs e)
        {
            newLocation = _bird.Location;
            if (_bird.Location.Y - Contain.top4bird > 0)
            {
                newLocation.Y -= Contain.speed4bird;
                _bird.Location = newLocation;
                //_bird.fly();
            }
        }

        /// <summary>
        /// tang tao do Y cua chim: Chim roi xuong.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void fall(object sender, EventArgs e)
        {
            newLocation = _bird.Location;
            if (!(_bird.Location.Y + _bird.Size.Height >= ptb_ground.Location.Y))
            {
                newLocation.Y += Contain.speed2fall;
                _bird.Location = newLocation;
            }
        }

        /// <summary>
        /// Tu dong sinh ong: Khi ong di chuyen khoi form --> gan cho ong vi tri moi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tmr_create_pipe_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (_top[i].Location.X <= -_top[i].Size.Width)
                {
                    create_pipe(_top[i], _bottom[i]);
                    switch (i)
                    {
                        case 0:
                            {
                                _top[i].X = _top[2].Location.X + 200;
                                _bottom[i].X = _top[2].Location.X + 200;
                                _top[i].Flag = !_top[i].Flag;
                                _bottom[i].Flag = !_bottom[i].Flag;
                                break;
                            }
                        case 1:
                            {
                                _top[i].X = _top[0].Location.X + 200;
                                _bottom[i].X = _top[0].Location.X + 200;
                                _top[i].Flag = !_top[i].Flag;
                                _bottom[i].Flag = !_bottom[i].Flag;
                                break;
                            }
                        case 2:
                            {
                                _top[i].X = _top[1].Location.X + 200;
                                _bottom[i].X = _top[1].Location.X + 200;
                                _top[i].Flag = !_top[i].Flag;
                                _bottom[i].Flag = !_bottom[i].Flag;
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

        /// <summary>
        /// Thiet lap chieu cao ngau nhien cho ong tren  va ong duoi.
        /// </summary>
        /// <param name="_top"></param>
        /// <param name="_bottom"></param>

        public void create_pipe(pipeONTOP _top, pipeONBOTTOM _bottom)
        {
            _top.Height = rand.Next(19, 24)*10;
            _top.create(_top.Height);
            _bottom.Height = ptb_ground.Location.Y - (_top.Size.Height + Contain.spacepi2pi);
            _bottom.create(_bottom.Height, _top.Size.Height + Contain.spacepi2pi);
        }

        /// <summary>
        /// Di chuyen ong tu phai sang trai.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tmr_move_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                _top[i].topMOVE();
            }
            for (int i = 0; i < 3; i++)
            {
                _bottom[i].bottomMOVE();
            }
            for (int i = 0; i < 3; i++)
            {
                game_over(_top[i], _bottom[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                game_over(_top[i], _bottom[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                if(_top[i].Location.X <= _bird.Location.X && !_top[i].Flag)
                {
                    _top[i].Flag = !_top[i].Flag;
                    _bottom[i].Flag = !_bottom[i].Flag;
                    score++;
                    //if (score > highscore)    highscore = score;
                    //lbl_mark.Text = score.ToString();+" / "+ highscore;
                    lbl_mark_down.Text = score.ToString();
                }
            }
        }

        /// <summary>
        /// Ham dung chuong trinh: Tam dung tat ca timer.
        /// </summary>
        
        public void stop()
        {
            tmr_create_pipe.Stop();
            tmr_fall.Stop();
            tmr_fly.Stop();
            tmr_ground.Stop();
            tmr_move.Stop();
        }

        /// <summary>
        /// Cho timer tiep tuc hoat dong.
        /// </summary>

        public void start()
        {
            tmr_create_pipe.Start();
            tmr_fall.Start();
            tmr_fly.Start();
            tmr_ground.Start();
            tmr_move.Start();
        }

        /// <summary>
        /// Ham tai lai chong trinh.
        /// </summary>

        public void load()
        {
            stop();
            for (int i = 0; i < 3; i++)
            {
                _top[i].Dispose();
                _bottom[i].Dispose();
            }
            _bird.Dispose();
            score = 0;
            lbl_mark_down.Text = score.ToString();
            new_create();
            start();
        }

        /// <summary>
        /// Ham ket thuc chuong trinh.
        /// </summary>
        /// <param name="_top"></param>
        /// <param name="_bottom"></param>

        public void game_over(Control _top, Control _bottom)
        {
            if (accident(_top, _bottom) && _bird.Fly)
            {
                _bird.Fly = false;
                flag[2] = true;
                frm_SCORE _score = new frm_SCORE();
                _score.text(lbl_mark_down);
                _score.ShowDialog();
                if (_score.Replay)
                {
                    flag[2] = !flag[2];
                    load();
                }
                else
                {
                    this.Close();
                }
            }
            if (_bird.Location.Y + _bird.Size.Height >= ptb_ground.Location.Y && _bird.Fly)
            {
                stop();
                flag[2] = true;
                newLocation.Y = ptb_ground.Location.Y - _bird.Size.Height + Contain.bottom4bird;
                _bird.Fly = false;
                _bird.fall();
                _bird.Location = newLocation;
                frm_SCORE _score = new frm_SCORE();
                _score.text(lbl_mark_down);
                _score.ShowDialog();
                if (_score.Replay)
                {
                    flag[2] = !flag[2];
                    load();
                }
                else
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Ham kiem tra va cham giua chim va ong(tren - duoi).
        /// </summary>
        /// <param name="_top"></param>
        /// <param name="_bottom"></param>
        /// <returns></returns>

        public bool accident(Control _top, Control _bottom)
        {
            if (!(_bird.Location.Y + Contain.top4bird >= _top.Height && ((_bird.Location.Y - Contain.bottom4bird + _bird.Size.Height) <= _bottom.Location.Y)) && _bird.Fly)
            {
                flag[3] = true;
                if (_bird.Location.X <= _top.Location.X && _top.Location.X - _bird.Location.X < _bird.Size.Width - Contain.right4bird && flag[3])
                {
                    flag[3] = false;
                    stop();
                    newLocation.X = _bottom.Location.X - _bird.Size.Width + 2*Contain.right4bird;
                    newLocation.Y = ptb_ground.Location.Y - _bird.Size.Height + Contain.bottom4bird;
                    _bird.Location = newLocation;
                    _bird.fall();
                    return true;
                }
                if (_bird.Location.X == _top.Location.X && _top.Location.X + _top.Size.Width >= _bird.Location.X + _bird.Size.Width && flag[3])
                {
                    flag[3] = false;
                    stop();
                    newLocation.X = _bottom.Location.X - _bird.Size.Width + Contain.right4bird;
                    newLocation.Y = ptb_ground.Location.Y - _bird.Size.Height + Contain.bottom4bird;
                    _bird.Location = newLocation;
                    _bird.fall();
                    return true;
                }
                if (_bird.Location.X >= _top.Location.X && _bird.Location.X - Contain.left4bird - _top.Location.X < _top.Size.Width && flag[3])
                {
                    flag[3] = false;
                    stop();
                    newLocation.X = _bottom.Location.X + _bottom.Size.Width - Contain.left4bird;
                    newLocation.Y = ptb_ground.Location.Y - _bird.Size.Height + Contain.bottom4bird;
                    _bird.Location = newLocation;
                    _bird.fall();
                    return true;
                }
            }
            return false;
        }

        private void frm_GAMEPLAY_Load(object sender, EventArgs e)
        {

        }
    }
}
