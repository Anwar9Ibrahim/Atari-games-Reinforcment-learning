namespace New_Atari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.B_showPlayedGame = new System.Windows.Forms.Button();
            this.b_Play = new System.Windows.Forms.Button();
            this.b_Train = new System.Windows.Forms.Button();
            this.cB_AlgoPick = new System.Windows.Forms.ComboBox();
            this.pB_TrainigCurve = new System.Windows.Forms.PictureBox();
            this.L_Plot = new System.Windows.Forms.Label();
            this.L_AlgoPick = new System.Windows.Forms.Label();
            this.vid_Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.L_welcome = new System.Windows.Forms.Label();
            this.b_frozenLake = new System.Windows.Forms.Button();
            this.b_cartPole = new System.Windows.Forms.Button();
            this.b_MountCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_TrainigCurve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vid_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(781, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(781, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(781, 352);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(123, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // B_showPlayedGame
            // 
            this.B_showPlayedGame.BackColor = System.Drawing.Color.Transparent;
            this.B_showPlayedGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_showPlayedGame.FlatAppearance.BorderSize = 0;
            this.B_showPlayedGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_showPlayedGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_showPlayedGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_showPlayedGame.ForeColor = System.Drawing.Color.Transparent;
            this.B_showPlayedGame.Location = new System.Drawing.Point(628, 385);
            this.B_showPlayedGame.Name = "B_showPlayedGame";
            this.B_showPlayedGame.Size = new System.Drawing.Size(100, 100);
            this.B_showPlayedGame.TabIndex = 9;
            this.B_showPlayedGame.UseVisualStyleBackColor = false;
            this.B_showPlayedGame.Click += new System.EventHandler(this.B_showPlayedGame_Click);
            // 
            // b_Play
            // 
            this.b_Play.BackColor = System.Drawing.Color.Transparent;
            this.b_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Play.FlatAppearance.BorderSize = 0;
            this.b_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Play.ForeColor = System.Drawing.Color.Transparent;
            this.b_Play.Location = new System.Drawing.Point(538, 350);
            this.b_Play.Name = "b_Play";
            this.b_Play.Size = new System.Drawing.Size(79, 72);
            this.b_Play.TabIndex = 10;
            this.b_Play.UseVisualStyleBackColor = false;
            this.b_Play.Click += new System.EventHandler(this.b_Play_Click);
            // 
            // b_Train
            // 
            this.b_Train.BackColor = System.Drawing.Color.Transparent;
            this.b_Train.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Train.FlatAppearance.BorderSize = 0;
            this.b_Train.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_Train.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_Train.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Train.ForeColor = System.Drawing.Color.Transparent;
            this.b_Train.Location = new System.Drawing.Point(587, 283);
            this.b_Train.Name = "b_Train";
            this.b_Train.Size = new System.Drawing.Size(79, 67);
            this.b_Train.TabIndex = 11;
            this.b_Train.UseVisualStyleBackColor = false;
            this.b_Train.Click += new System.EventHandler(this.b_Train_Click);
            // 
            // cB_AlgoPick
            // 
            this.cB_AlgoPick.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic);
            this.cB_AlgoPick.FormattingEnabled = true;
            this.cB_AlgoPick.Location = new System.Drawing.Point(498, 36);
            this.cB_AlgoPick.Name = "cB_AlgoPick";
            this.cB_AlgoPick.Size = new System.Drawing.Size(121, 29);
            this.cB_AlgoPick.TabIndex = 12;
            this.cB_AlgoPick.Visible = false;
            this.cB_AlgoPick.SelectedValueChanged += new System.EventHandler(this.cB_AlgoPick_SelectedValueChanged);
            // 
            // pB_TrainigCurve
            // 
            this.pB_TrainigCurve.Location = new System.Drawing.Point(12, 30);
            this.pB_TrainigCurve.Name = "pB_TrainigCurve";
            this.pB_TrainigCurve.Size = new System.Drawing.Size(353, 200);
            this.pB_TrainigCurve.TabIndex = 13;
            this.pB_TrainigCurve.TabStop = false;
            this.pB_TrainigCurve.Visible = false;
            // 
            // L_Plot
            // 
            this.L_Plot.AutoSize = true;
            this.L_Plot.BackColor = System.Drawing.Color.Transparent;
            this.L_Plot.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Plot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.L_Plot.Location = new System.Drawing.Point(13, 6);
            this.L_Plot.Name = "L_Plot";
            this.L_Plot.Size = new System.Drawing.Size(152, 21);
            this.L_Plot.TabIndex = 14;
            this.L_Plot.Text = "the Training Curve";
            this.L_Plot.Visible = false;
            // 
            // L_AlgoPick
            // 
            this.L_AlgoPick.AutoSize = true;
            this.L_AlgoPick.BackColor = System.Drawing.Color.Transparent;
            this.L_AlgoPick.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_AlgoPick.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.L_AlgoPick.Location = new System.Drawing.Point(500, 12);
            this.L_AlgoPick.Name = "L_AlgoPick";
            this.L_AlgoPick.Size = new System.Drawing.Size(219, 21);
            this.L_AlgoPick.TabIndex = 15;
            this.L_AlgoPick.Text = "Please Chosse an Algorithm";
            this.L_AlgoPick.Visible = false;
            // 
            // vid_Player
            // 
            this.vid_Player.Enabled = true;
            this.vid_Player.Location = new System.Drawing.Point(12, 236);
            this.vid_Player.Name = "vid_Player";
            this.vid_Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vid_Player.OcxState")));
            this.vid_Player.Size = new System.Drawing.Size(353, 266);
            this.vid_Player.TabIndex = 16;
            this.vid_Player.Visible = false;
            // 
            // L_welcome
            // 
            this.L_welcome.AutoSize = true;
            this.L_welcome.BackColor = System.Drawing.Color.Transparent;
            this.L_welcome.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic);
            this.L_welcome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.L_welcome.Location = new System.Drawing.Point(8, 27);
            this.L_welcome.Name = "L_welcome";
            this.L_welcome.Size = new System.Drawing.Size(462, 21);
            this.L_welcome.TabIndex = 17;
            this.L_welcome.Text = "Welcome To Our Atari Solver, Please Chosse A Game First";
            // 
            // b_frozenLake
            // 
            this.b_frozenLake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_frozenLake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_frozenLake.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_frozenLake.Location = new System.Drawing.Point(777, 129);
            this.b_frozenLake.Name = "b_frozenLake";
            this.b_frozenLake.Size = new System.Drawing.Size(127, 34);
            this.b_frozenLake.TabIndex = 18;
            this.b_frozenLake.Text = "Frozen Lake";
            this.b_frozenLake.UseVisualStyleBackColor = true;
            this.b_frozenLake.Click += new System.EventHandler(this.b_frozenLake_Click);
            // 
            // b_cartPole
            // 
            this.b_cartPole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_cartPole.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cartPole.Location = new System.Drawing.Point(777, 297);
            this.b_cartPole.Name = "b_cartPole";
            this.b_cartPole.Size = new System.Drawing.Size(127, 34);
            this.b_cartPole.TabIndex = 19;
            this.b_cartPole.Text = "Cart Pole";
            this.b_cartPole.UseVisualStyleBackColor = true;
            this.b_cartPole.Click += new System.EventHandler(this.b_cartPole_Click);
            // 
            // b_MountCar
            // 
            this.b_MountCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_MountCar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_MountCar.Location = new System.Drawing.Point(777, 468);
            this.b_MountCar.Name = "b_MountCar";
            this.b_MountCar.Size = new System.Drawing.Size(127, 34);
            this.b_MountCar.TabIndex = 20;
            this.b_MountCar.Text = "Mountain Car";
            this.b_MountCar.UseVisualStyleBackColor = true;
            this.b_MountCar.Click += new System.EventHandler(this.b_MountCar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(916, 514);
            this.Controls.Add(this.b_MountCar);
            this.Controls.Add(this.b_cartPole);
            this.Controls.Add(this.b_frozenLake);
            this.Controls.Add(this.L_welcome);
            this.Controls.Add(this.vid_Player);
            this.Controls.Add(this.L_AlgoPick);
            this.Controls.Add(this.L_Plot);
            this.Controls.Add(this.pB_TrainigCurve);
            this.Controls.Add(this.cB_AlgoPick);
            this.Controls.Add(this.b_Train);
            this.Controls.Add(this.b_Play);
            this.Controls.Add(this.B_showPlayedGame);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_TrainigCurve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vid_Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button B_showPlayedGame;
        private System.Windows.Forms.Button b_Play;
        private System.Windows.Forms.Button b_Train;
        private System.Windows.Forms.ComboBox cB_AlgoPick;
        private System.Windows.Forms.PictureBox pB_TrainigCurve;
        private System.Windows.Forms.Label L_Plot;
        private System.Windows.Forms.Label L_AlgoPick;
        private AxWMPLib.AxWindowsMediaPlayer vid_Player;
        private System.Windows.Forms.Label L_welcome;
        private System.Windows.Forms.Button b_frozenLake;
        private System.Windows.Forms.Button b_cartPole;
        private System.Windows.Forms.Button b_MountCar;
    }
}

