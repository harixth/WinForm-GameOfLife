using System.Drawing;

namespace GameOfLife
{
    partial class GameUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameUI));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MainFrame = new System.Windows.Forms.GroupBox();
            this.gbGameInst = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.picbxHelp = new System.Windows.Forms.PictureBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.picbxGenTxt = new System.Windows.Forms.PictureBox();
            this.lblGenTxt = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gameScreen = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.MainFrame.SuspendLayout();
            this.gbGameInst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxGenTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainFrame
            // 
            this.MainFrame.BackColor = System.Drawing.Color.Transparent;
            this.MainFrame.BackgroundImage = global::GameOfLife.Properties.Resources._73620_OE55YI_193;
            this.MainFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainFrame.Controls.Add(this.gbGameInst);
            this.MainFrame.Controls.Add(this.picbxHelp);
            this.MainFrame.Controls.Add(this.lblCount);
            this.MainFrame.Controls.Add(this.picbxGenTxt);
            this.MainFrame.Controls.Add(this.lblGenTxt);
            this.MainFrame.Controls.Add(this.btnClose);
            this.MainFrame.Controls.Add(this.gameScreen);
            this.MainFrame.Controls.Add(this.btnStop);
            this.MainFrame.Controls.Add(this.btnPlay);
            this.MainFrame.Controls.Add(this.btnReset);
            this.MainFrame.Location = new System.Drawing.Point(0, 0);
            this.MainFrame.Margin = new System.Windows.Forms.Padding(0);
            this.MainFrame.Name = "MainFrame";
            this.MainFrame.Padding = new System.Windows.Forms.Padding(0);
            this.MainFrame.Size = new System.Drawing.Size(1180, 990);
            this.MainFrame.TabIndex = 7;
            this.MainFrame.TabStop = false;
            // 
            // gbGameInst
            // 
            this.gbGameInst.BackgroundImage = global::GameOfLife.Properties.Resources.GameInstruction;
            this.gbGameInst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbGameInst.Controls.Add(this.btnStart);
            this.gbGameInst.Location = new System.Drawing.Point(296, 48);
            this.gbGameInst.Name = "gbGameInst";
            this.gbGameInst.Size = new System.Drawing.Size(523, 369);
            this.gbGameInst.TabIndex = 0;
            this.gbGameInst.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::GameOfLife.Properties.Resources.start;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(208, 287);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 44);
            this.btnStart.TabIndex = 10;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picbxHelp
            // 
            this.picbxHelp.BackColor = System.Drawing.Color.Transparent;
            this.picbxHelp.BackgroundImage = global::GameOfLife.Properties.Resources.help_128x;
            this.picbxHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbxHelp.Location = new System.Drawing.Point(34, 304);
            this.picbxHelp.Name = "picbxHelp";
            this.picbxHelp.Size = new System.Drawing.Size(128, 128);
            this.picbxHelp.TabIndex = 9;
            this.picbxHelp.TabStop = false;
            this.picbxHelp.Click += new System.EventHandler(this.picbxHelp_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(617, 836);
            this.lblCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(49, 59);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "0";
            // 
            // picbxGenTxt
            // 
            this.picbxGenTxt.BackColor = System.Drawing.Color.Transparent;
            this.picbxGenTxt.BackgroundImage = global::GameOfLife.Properties.Resources.bubbles_64x;
            this.picbxGenTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbxGenTxt.Location = new System.Drawing.Point(324, 840);
            this.picbxGenTxt.Name = "picbxGenTxt";
            this.picbxGenTxt.Size = new System.Drawing.Size(48, 48);
            this.picbxGenTxt.TabIndex = 6;
            this.picbxGenTxt.TabStop = false;
            // 
            // lblGenTxt
            // 
            this.lblGenTxt.AutoSize = true;
            this.lblGenTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblGenTxt.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenTxt.Location = new System.Drawing.Point(371, 834);
            this.lblGenTxt.Name = "lblGenTxt";
            this.lblGenTxt.Size = new System.Drawing.Size(244, 59);
            this.lblGenTxt.TabIndex = 8;
            this.lblGenTxt.Text = "Generation";
            this.lblGenTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::GameOfLife.Properties.Resources.deny;
            this.btnClose.Location = new System.Drawing.Point(996, 324);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 145);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gameScreen
            // 
            this.gameScreen.Location = new System.Drawing.Point(296, 48);
            this.gameScreen.Margin = new System.Windows.Forms.Padding(4);
            this.gameScreen.Name = "gameScreen";
            this.gameScreen.Padding = new System.Windows.Forms.Padding(4);
            this.gameScreen.Size = new System.Drawing.Size(522, 371);
            this.gameScreen.TabIndex = 1;
            this.gameScreen.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::GameOfLife.Properties.Resources.stop_button;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(731, 630);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 90);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::GameOfLife.Properties.Resources.play_button;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(602, 679);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(90, 90);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = global::GameOfLife.Properties.Resources.plus_sign;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(296, 659);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 100);
            this.btnReset.TabIndex = 2;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // GameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1190, 1021);
            this.Controls.Add(this.MainFrame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Conway\'s Game of Life";
            this.Load += new System.EventHandler(this.GameUI_Load);
            this.MainFrame.ResumeLayout(false);
            this.MainFrame.PerformLayout();
            this.gbGameInst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbxHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxGenTxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gameScreen;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox MainFrame;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picbxGenTxt;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblGenTxt;
        private System.Windows.Forms.PictureBox picbxHelp;
        private System.Windows.Forms.GroupBox gbGameInst;
        private System.Windows.Forms.Button btnStart;
    }
}

