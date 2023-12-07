namespace Minecraft_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            start_game = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            zombie_health = new Label();
            skeleton_health = new Label();
            label5 = new Label();
            creeper_health = new Label();
            label7 = new Label();
            steve_health = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // start_game
            // 
            start_game.BackColor = Color.ForestGreen;
            start_game.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            start_game.Location = new Point(619, 621);
            start_game.Name = "start_game";
            start_game.Size = new Size(285, 125);
            start_game.TabIndex = 0;
            start_game.Text = "Start Game";
            start_game.UseVisualStyleBackColor = false;
            start_game.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(525, 9);
            label1.Name = "label1";
            label1.Size = new Size(863, 89);
            label1.TabIndex = 2;
            label1.Text = "Minecraft Turn-Based Game";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Steve_29_JE6;
            pictureBox1.Location = new Point(1161, 262);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 473);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(73, 538);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 229);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.zombie;
            pictureBox3.Location = new Point(73, 28);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(122, 207);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(73, 286);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(122, 193);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1161, 230);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 8;
            label2.Text = "Health:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(201, 114);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 9;
            label3.Text = "Health:";
            // 
            // zombie_health
            // 
            zombie_health.AutoSize = true;
            zombie_health.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zombie_health.Location = new Point(280, 114);
            zombie_health.Name = "zombie_health";
            zombie_health.Size = new Size(0, 28);
            zombie_health.TabIndex = 12;
            // 
            // skeleton_health
            // 
            skeleton_health.AutoSize = true;
            skeleton_health.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            skeleton_health.Location = new Point(280, 368);
            skeleton_health.Name = "skeleton_health";
            skeleton_health.Size = new Size(0, 28);
            skeleton_health.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(201, 368);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 13;
            label5.Text = "Health:";
            // 
            // creeper_health
            // 
            creeper_health.AutoSize = true;
            creeper_health.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            creeper_health.Location = new Point(280, 635);
            creeper_health.Name = "creeper_health";
            creeper_health.Size = new Size(0, 28);
            creeper_health.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(201, 635);
            label7.Name = "label7";
            label7.Size = new Size(73, 28);
            label7.TabIndex = 15;
            label7.Text = "Health:";
            // 
            // steve_health
            // 
            steve_health.AutoSize = true;
            steve_health.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            steve_health.Location = new Point(1240, 230);
            steve_health.Name = "steve_health";
            steve_health.Size = new Size(0, 28);
            steve_health.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1429, 859);
            Controls.Add(steve_health);
            Controls.Add(creeper_health);
            Controls.Add(label7);
            Controls.Add(skeleton_health);
            Controls.Add(label5);
            Controls.Add(zombie_health);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(start_game);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start_game;
        private Label label1;
        private PictureBox pictureBox1;

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label2;
        private Label label3;
        private Label zombie_health;
        private Label skeleton_health;
        private Label label5;
        private Label creeper_health;
        private Label label7;
        private Label steve_health;
    }
}