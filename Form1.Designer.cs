
namespace flappyBird
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeup = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.pipedown = new System.Windows.Forms.PictureBox();
            this.scoretxt = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = global::flappyBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-13, 605);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(668, 112);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeup
            // 
            this.pipeup.Image = global::flappyBird.Properties.Resources.pipedown;
            this.pipeup.Location = new System.Drawing.Point(486, -12);
            this.pipeup.Name = "pipeup";
            this.pipeup.Size = new System.Drawing.Size(124, 216);
            this.pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeup.TabIndex = 2;
            this.pipeup.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = global::flappyBird.Properties.Resources.bird;
            this.FlappyBird.Location = new System.Drawing.Point(105, 273);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(75, 79);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird.TabIndex = 1;
            this.FlappyBird.TabStop = false;
            // 
            // pipedown
            // 
            this.pipedown.Image = global::flappyBird.Properties.Resources.pipe;
            this.pipedown.Location = new System.Drawing.Point(389, 386);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(125, 299);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown.TabIndex = 0;
            this.pipedown.TabStop = false;
            // 
            // scoretxt
            // 
            this.scoretxt.AutoSize = true;
            this.scoretxt.BackColor = System.Drawing.Color.Pink;
            this.scoretxt.Font = new System.Drawing.Font("mokoto glitch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretxt.Location = new System.Drawing.Point(23, 645);
            this.scoretxt.Name = "scoretxt";
            this.scoretxt.Size = new System.Drawing.Size(155, 33);
            this.scoretxt.TabIndex = 4;
            this.scoretxt.Text = "Score:0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(622, 707);
            this.Controls.Add(this.scoretxt);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeup);
            this.Controls.Add(this.pipedown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipedown;
        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox pipeup;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoretxt;
        private System.Windows.Forms.Timer gameTimer;
    }
}

