namespace Flappy_Bird_demo
{
    partial class frm_HELP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HELP));
            this.lbl_detail = new System.Windows.Forms.Label();
            this.lbl_help = new System.Windows.Forms.Label();
            this.ptb_help = new System.Windows.Forms.PictureBox();
            this.ptb_ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ground)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_detail
            // 
            this.lbl_detail.AutoSize = true;
            this.lbl_detail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_detail.Font = new System.Drawing.Font("Source Code Pro", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_detail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_detail.Location = new System.Drawing.Point(60, 200);
            this.lbl_detail.Name = "lbl_detail";
            this.lbl_detail.Size = new System.Drawing.Size(285, 160);
            this.lbl_detail.TabIndex = 12;
            this.lbl_detail.Text = "Press Enter 2 play\r\nPress H 2 be help\r\nPress P 2 pause\r\nPress L 2 reload\r\nPress E" +
    "sc 2 exit";
            // 
            // lbl_help
            // 
            this.lbl_help.AutoSize = true;
            this.lbl_help.BackColor = System.Drawing.Color.Transparent;
            this.lbl_help.Font = new System.Drawing.Font("Source Code Pro", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_help.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_help.Location = new System.Drawing.Point(136, 90);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(147, 63);
            this.lbl_help.TabIndex = 11;
            this.lbl_help.Text = "HELP";
            // 
            // ptb_help
            // 
            this.ptb_help.BackColor = System.Drawing.Color.Transparent;
            this.ptb_help.BackgroundImage = global::Flappy_Bird_demo.Properties.Resources.help_info;
            this.ptb_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_help.Location = new System.Drawing.Point(0, 2);
            this.ptb_help.Name = "ptb_help";
            this.ptb_help.Size = new System.Drawing.Size(32, 32);
            this.ptb_help.TabIndex = 10;
            this.ptb_help.TabStop = false;
            this.ptb_help.Click += new System.EventHandler(this.ptb_help_Click);
            // 
            // ptb_ground
            // 
            this.ptb_ground.BackColor = System.Drawing.Color.Transparent;
            this.ptb_ground.BackgroundImage = global::Flappy_Bird_demo.Properties.Resources.ground;
            this.ptb_ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_ground.Location = new System.Drawing.Point(0, 520);
            this.ptb_ground.Name = "ptb_ground";
            this.ptb_ground.Size = new System.Drawing.Size(400, 80);
            this.ptb_ground.TabIndex = 13;
            this.ptb_ground.TabStop = false;
            // 
            // frm_HELP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappy_Bird_demo.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.ControlBox = false;
            this.Controls.Add(this.ptb_ground);
            this.Controls.Add(this.lbl_detail);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.ptb_help);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_HELP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HELP";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_HELP_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_detail;
        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.PictureBox ptb_help;
        private System.Windows.Forms.PictureBox ptb_ground;
    }
}