namespace Flappy_Bird_demo
{
    partial class frm_MENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MENU));
            this.ptb_ground = new System.Windows.Forms.PictureBox();
            this.ptb_help = new System.Windows.Forms.PictureBox();
            this.lbl_flappy_bird = new System.Windows.Forms.Label();
            this.ptb_turn_off = new System.Windows.Forms.PictureBox();
            this.ptb_play = new System.Windows.Forms.PictureBox();
            this.ptb_bird = new System.Windows.Forms.PictureBox();
            this.timer_action = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_turn_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_bird)).BeginInit();
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
            this.ptb_ground.TabIndex = 0;
            this.ptb_ground.TabStop = false;
            // 
            // ptb_help
            // 
            this.ptb_help.BackColor = System.Drawing.Color.Transparent;
            this.ptb_help.BackgroundImage = global::Flappy_Bird_demo.Properties.Resources.help_info;
            this.ptb_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_help.Location = new System.Drawing.Point(0, 2);
            this.ptb_help.Name = "ptb_help";
            this.ptb_help.Size = new System.Drawing.Size(32, 32);
            this.ptb_help.TabIndex = 11;
            this.ptb_help.TabStop = false;
            this.ptb_help.Click += new System.EventHandler(this.ptb_help_Click);
            // 
            // lbl_flappy_bird
            // 
            this.lbl_flappy_bird.AutoSize = true;
            this.lbl_flappy_bird.BackColor = System.Drawing.Color.Transparent;
            this.lbl_flappy_bird.Font = new System.Drawing.Font("Source Code Pro", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_flappy_bird.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_flappy_bird.Location = new System.Drawing.Point(22, 90);
            this.lbl_flappy_bird.Name = "lbl_flappy_bird";
            this.lbl_flappy_bird.Size = new System.Drawing.Size(357, 63);
            this.lbl_flappy_bird.TabIndex = 10;
            this.lbl_flappy_bird.Text = "Flappy Bird";
            // 
            // ptb_turn_off
            // 
            this.ptb_turn_off.BackColor = System.Drawing.Color.Transparent;
            this.ptb_turn_off.BackgroundImage = global::Flappy_Bird_demo.Properties.Resources.turn_off;
            this.ptb_turn_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_turn_off.Location = new System.Drawing.Point(368, 2);
            this.ptb_turn_off.Name = "ptb_turn_off";
            this.ptb_turn_off.Size = new System.Drawing.Size(32, 32);
            this.ptb_turn_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_turn_off.TabIndex = 9;
            this.ptb_turn_off.TabStop = false;
            this.ptb_turn_off.Click += new System.EventHandler(this.ptb_turn_off_Click);
            // 
            // ptb_play
            // 
            this.ptb_play.BackColor = System.Drawing.Color.Transparent;
            this.ptb_play.BackgroundImage = global::Flappy_Bird_demo.Properties.Resources.land;
            this.ptb_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_play.Image = global::Flappy_Bird_demo.Properties.Resources.play;
            this.ptb_play.Location = new System.Drawing.Point(190, 550);
            this.ptb_play.Name = "ptb_play";
            this.ptb_play.Size = new System.Drawing.Size(32, 32);
            this.ptb_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_play.TabIndex = 8;
            this.ptb_play.TabStop = false;
            this.ptb_play.Click += new System.EventHandler(this.ptb_play_Click);
            // 
            // ptb_bird
            // 
            this.ptb_bird.BackColor = System.Drawing.Color.Transparent;
            this.ptb_bird.BackgroundImage = global::Flappy_Bird_demo.Properties.Resources.bird_normal;
            this.ptb_bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_bird.Location = new System.Drawing.Point(142, 235);
            this.ptb_bird.Name = "ptb_bird";
            this.ptb_bird.Size = new System.Drawing.Size(128, 128);
            this.ptb_bird.TabIndex = 7;
            this.ptb_bird.TabStop = false;
            this.ptb_bird.Click += new System.EventHandler(this.ptb_bird_Click);
            // 
            // timer_action
            // 
            this.timer_action.Enabled = true;
            this.timer_action.Interval = 200;
            this.timer_action.Tick += new System.EventHandler(this.timer_action_Tick);
            // 
            // frm_MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_Bird_demo.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.ControlBox = false;
            this.Controls.Add(this.ptb_help);
            this.Controls.Add(this.lbl_flappy_bird);
            this.Controls.Add(this.ptb_turn_off);
            this.Controls.Add(this.ptb_play);
            this.Controls.Add(this.ptb_bird);
            this.Controls.Add(this.ptb_ground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLAPPY BIRD";
            this.Load += new System.EventHandler(this.frm_MENU_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_MENU_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_turn_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_ground;
        private System.Windows.Forms.PictureBox ptb_help;
        private System.Windows.Forms.Label lbl_flappy_bird;
        private System.Windows.Forms.PictureBox ptb_turn_off;
        private System.Windows.Forms.PictureBox ptb_play;
        private System.Windows.Forms.PictureBox ptb_bird;
        private System.Windows.Forms.Timer timer_action;
    }
}