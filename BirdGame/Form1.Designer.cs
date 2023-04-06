
namespace BirdGame
{
    partial class Form1
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
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeDawn = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblscore = new System.Windows.Forms.Label();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.gameOverlbl = new System.Windows.Forms.Label();
            this.exLife = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exLife)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.Image = global::BirdGame.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(62, 34);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(61, 63);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::BirdGame.Properties.Resources.pipedawn;
            this.pipeBottom.Location = new System.Drawing.Point(553, -106);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(102, 216);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 1;
            this.pipeBottom.TabStop = false;
            // 
            // pipeDawn
            // 
            this.pipeDawn.Image = global::BirdGame.Properties.Resources.pipe;
            this.pipeDawn.Location = new System.Drawing.Point(507, 329);
            this.pipeDawn.Name = "pipeDawn";
            this.pipeDawn.Size = new System.Drawing.Size(106, 271);
            this.pipeDawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDawn.TabIndex = 3;
            this.pipeDawn.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::BirdGame.Properties.Resources.ground__2_;
            this.ground.Location = new System.Drawing.Point(-5, 433);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(811, 127);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.life3);
            this.panel1.Controls.Add(this.life2);
            this.panel1.Controls.Add(this.life1);
            this.panel1.Location = new System.Drawing.Point(12, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 84);
            this.panel1.TabIndex = 5;
            // 
            // lblscore
            // 
            this.lblscore.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(439, 478);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(243, 79);
            this.lblscore.TabIndex = 0;
            this.lblscore.Text = "Score :";
            this.lblscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // life1
            // 
            this.life1.Image = global::BirdGame.Properties.Resources.life;
            this.life1.Location = new System.Drawing.Point(5, 13);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(64, 68);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1.TabIndex = 0;
            this.life1.TabStop = false;
            // 
            // life2
            // 
            this.life2.Image = global::BirdGame.Properties.Resources.life;
            this.life2.Location = new System.Drawing.Point(75, 13);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(64, 68);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2.TabIndex = 0;
            this.life2.TabStop = false;
            // 
            // life3
            // 
            this.life3.Image = global::BirdGame.Properties.Resources.life;
            this.life3.Location = new System.Drawing.Point(145, 13);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(64, 68);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3.TabIndex = 0;
            this.life3.TabStop = false;
            // 
            // gameTime
            // 
            this.gameTime.Enabled = true;
            this.gameTime.Interval = 20;
            this.gameTime.Tick += new System.EventHandler(this.gameTimeTickEvent);
            // 
            // gameOverlbl
            // 
            this.gameOverlbl.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverlbl.Location = new System.Drawing.Point(135, 159);
            this.gameOverlbl.Name = "gameOverlbl";
            this.gameOverlbl.Size = new System.Drawing.Size(478, 122);
            this.gameOverlbl.TabIndex = 6;
            this.gameOverlbl.Text = "label1";
            this.gameOverlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOverlbl.Visible = false;
            // 
            // exLife
            // 
            this.exLife.Image = global::BirdGame.Properties.Resources.life;
            this.exLife.Location = new System.Drawing.Point(355, 135);
            this.exLife.Name = "exLife";
            this.exLife.Size = new System.Drawing.Size(55, 51);
            this.exLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exLife.TabIndex = 7;
            this.exLife.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(733, 553);
            this.Controls.Add(this.exLife);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.gameOverlbl);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeDawn);
            this.Controls.Add(this.pipeBottom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDawnEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exLife)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeDawn;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Label gameOverlbl;
        private System.Windows.Forms.PictureBox exLife;
    }
}

