namespace Flappy_Bird_demo
{
    partial class frm_GAMEPLAY
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GAMEPLAY));
            this.ptb_ground = new System.Windows.Forms.PictureBox();
            this.ptb_pause = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.tmr_fall = new System.Windows.Forms.Timer(this.components);
            this.tmr_ground = new System.Windows.Forms.Timer(this.components);
            this.tmr_fly = new System.Windows.Forms.Timer(this.components);
            this.tmr_create_pipe = new System.Windows.Forms.Timer(this.components);
            this.tmr_move = new System.Windows.Forms.Timer(this.components);
            this.lbl_mark_down = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pause)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_ground
            // 
            this.ptb_ground.BackColor = System.Drawing.Color.Transparent;
            this.ptb_ground.BackgroundImage = global::Flappy_Bird_demo.Properties.Resources.ground;
            this.ptb_ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_ground.Location = new System.Drawing.Point(0, 520);
            this.ptb_ground.Name = "ptb_ground";
            this.ptb_ground.Size = new System.Drawing.Size(400, 80);
            this.ptb_ground.TabIndex = 1;
            this.ptb_ground.TabStop = false;
            // 
            // ptb_pause
            // 
            this.ptb_pause.BackColor = System.Drawing.Color.Transparent;
            this.ptb_pause.BackgroundImage = global::Flappy_Bird_demo.Properties.Resources.land;
            this.ptb_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_pause.Image = global::Flappy_Bird_demo.Properties.Resources.pause;
            this.ptb_pause.Location = new System.Drawing.Point(190, 550);
            this.ptb_pause.Name = "ptb_pause";
            this.ptb_pause.Size = new System.Drawing.Size(32, 32);
            this.ptb_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_pause.TabIndex = 8;
            this.ptb_pause.TabStop = false;
            this.ptb_pause.Click += new System.EventHandler(this.ptb_pause_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Source Code Pro", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_score.Image = global::Flappy_Bird_demo.Properties.Resources.ground;
            this.lbl_score.Location = new System.Drawing.Point(264, 557);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(84, 25);
            this.lbl_score.TabIndex = 7;
            this.lbl_score.Text = "SCORE:";
            // 
            // tmr_fall
            // 
            this.tmr_fall.Enabled = true;
            this.tmr_fall.Interval = 40;
            this.tmr_fall.Tick += new System.EventHandler(this.tmr_fall_Tick);
            // 
            // tmr_ground
            // 
            this.tmr_ground.Enabled = true;
            this.tmr_ground.Interval = 303;
            this.tmr_ground.Tick += new System.EventHandler(this.tmr_ground_Tick);
            // 
            // tmr_fly
            // 
            this.tmr_fly.Enabled = true;
            this.tmr_fly.Tick += new System.EventHandler(this.tmr_fly_Tick);
            // 
            // tmr_create_pipe
            // 
            this.tmr_create_pipe.Enabled = true;
            this.tmr_create_pipe.Interval = 2000;
            this.tmr_create_pipe.Tick += new System.EventHandler(this.tmr_create_pipe_Tick);
            // 
            // tmr_move
            // 
            this.tmr_move.Enabled = true;
            this.tmr_move.Tick += new System.EventHandler(this.tmr_move_Tick);
            // 
            // lbl_mark_down
            // 
            this.lbl_mark_down.AutoSize = true;
            this.lbl_mark_down.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mark_down.Font = new System.Drawing.Font("Source Code Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mark_down.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_mark_down.Image = global::Flappy_Bird_demo.Properties.Resources.ground;
            this.lbl_mark_down.Location = new System.Drawing.Point(340, 552);
            this.lbl_mark_down.Name = "lbl_mark_down";
            this.lbl_mark_down.Size = new System.Drawing.Size(31, 34);
            this.lbl_mark_down.TabIndex = 12;
            this.lbl_mark_down.Text = "0";
            // 
            // frm_GAMEPLAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_Bird_demo.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_mark_down);
            this.Controls.Add(this.ptb_pause);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.ptb_ground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_GAMEPLAY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLAPPY BIRD";
            this.Load += new System.EventHandler(this.frm_GAMEPLAY_Load);
            this.Click += new System.EventHandler(this.frm_GAMEPLAY_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_GAMEPLAY_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_ground;
        private System.Windows.Forms.PictureBox ptb_pause;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Timer tmr_fall;
        private System.Windows.Forms.Timer tmr_ground;
        private System.Windows.Forms.Timer tmr_create_pipe;
        private System.Windows.Forms.Timer tmr_move;
        private System.Windows.Forms.Label lbl_mark_down;
        public System.Windows.Forms.Timer tmr_fly;
    }
}