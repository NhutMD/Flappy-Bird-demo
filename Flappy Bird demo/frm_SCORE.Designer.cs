namespace Flappy_Bird_demo
{
    partial class frm_SCORE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SCORE));
            this.ptb_replay = new System.Windows.Forms.PictureBox();
            this.lbl_text = new System.Windows.Forms.Label();
            this.ptb_turn_off = new System.Windows.Forms.PictureBox();
            this.lbl_game_over = new System.Windows.Forms.Label();
            this.lbl_mark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_replay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_turn_off)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_replay
            // 
            this.ptb_replay.BackColor = System.Drawing.Color.Transparent;
            this.ptb_replay.BackgroundImage = global::Flappy_Bird_demo.Properties.Resources.replay;
            this.ptb_replay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_replay.Location = new System.Drawing.Point(2, 266);
            this.ptb_replay.Name = "ptb_replay";
            this.ptb_replay.Size = new System.Drawing.Size(32, 32);
            this.ptb_replay.TabIndex = 16;
            this.ptb_replay.TabStop = false;
            this.ptb_replay.Click += new System.EventHandler(this.ptb_replay_Click);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.BackColor = System.Drawing.Color.Transparent;
            this.lbl_text.Font = new System.Drawing.Font("Source Code Pro", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_text.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_text.Location = new System.Drawing.Point(14, 140);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(210, 32);
            this.lbl_text.TabIndex = 15;
            this.lbl_text.Text = "Your score is";
            // 
            // ptb_turn_off
            // 
            this.ptb_turn_off.BackColor = System.Drawing.Color.Transparent;
            this.ptb_turn_off.BackgroundImage = global::Flappy_Bird_demo.Properties.Resources.turn_off;
            this.ptb_turn_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_turn_off.Location = new System.Drawing.Point(266, 266);
            this.ptb_turn_off.Name = "ptb_turn_off";
            this.ptb_turn_off.Size = new System.Drawing.Size(32, 32);
            this.ptb_turn_off.TabIndex = 14;
            this.ptb_turn_off.TabStop = false;
            this.ptb_turn_off.Click += new System.EventHandler(this.ptb_turn_off_Click);
            // 
            // lbl_game_over
            // 
            this.lbl_game_over.AutoSize = true;
            this.lbl_game_over.BackColor = System.Drawing.Color.Transparent;
            this.lbl_game_over.Font = new System.Drawing.Font("Source Code Pro", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_game_over.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_game_over.Location = new System.Drawing.Point(2, 33);
            this.lbl_game_over.Name = "lbl_game_over";
            this.lbl_game_over.Size = new System.Drawing.Size(297, 63);
            this.lbl_game_over.TabIndex = 13;
            this.lbl_game_over.Text = "GAME OVER";
            // 
            // lbl_mark
            // 
            this.lbl_mark.AutoSize = true;
            this.lbl_mark.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mark.Font = new System.Drawing.Font("Source Code Pro", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mark.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_mark.Location = new System.Drawing.Point(230, 126);
            this.lbl_mark.Name = "lbl_mark";
            this.lbl_mark.Size = new System.Drawing.Size(46, 50);
            this.lbl_mark.TabIndex = 17;
            this.lbl_mark.Text = "0";
            // 
            // frm_SCORE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Flappy_Bird_demo.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.lbl_mark);
            this.Controls.Add(this.ptb_replay);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.ptb_turn_off);
            this.Controls.Add(this.lbl_game_over);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_SCORE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_SCORE_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_replay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_turn_off)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_replay;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.PictureBox ptb_turn_off;
        private System.Windows.Forms.Label lbl_game_over;
        private System.Windows.Forms.Label lbl_mark;
    }
}