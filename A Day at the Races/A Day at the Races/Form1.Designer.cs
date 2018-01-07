namespace A_Day_at_the_Races
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.startRaceButton = new System.Windows.Forms.Button();
            this.alsBetLabel = new System.Windows.Forms.Label();
            this.bobsBetLabel = new System.Windows.Forms.Label();
            this.joesBetLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectDog = new System.Windows.Forms.NumericUpDown();
            this.dogLabel = new System.Windows.Forms.Label();
            this.selectAmount = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(13, 13);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1277, 333);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.AutoSize = true;
            this.groupBox.Controls.Add(this.startRaceButton);
            this.groupBox.Controls.Add(this.alsBetLabel);
            this.groupBox.Controls.Add(this.bobsBetLabel);
            this.groupBox.Controls.Add(this.joesBetLabel);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.selectDog);
            this.groupBox.Controls.Add(this.dogLabel);
            this.groupBox.Controls.Add(this.selectAmount);
            this.groupBox.Controls.Add(this.betsButton);
            this.groupBox.Controls.Add(this.nameLabel);
            this.groupBox.Controls.Add(this.alRadioButton);
            this.groupBox.Controls.Add(this.bobRadioButton);
            this.groupBox.Controls.Add(this.joeRadioButton);
            this.groupBox.Controls.Add(this.minimumBetLabel);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(12, 354);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(1277, 343);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Betting Parlor";
            // 
            // startRaceButton
            // 
            this.startRaceButton.Location = new System.Drawing.Point(936, 45);
            this.startRaceButton.Margin = new System.Windows.Forms.Padding(4);
            this.startRaceButton.Name = "startRaceButton";
            this.startRaceButton.Size = new System.Drawing.Size(296, 183);
            this.startRaceButton.TabIndex = 13;
            this.startRaceButton.Text = "Race!";
            this.startRaceButton.UseVisualStyleBackColor = true;
            this.startRaceButton.Click += new System.EventHandler(this.startRaceButton_Click);
            // 
            // alsBetLabel
            // 
            this.alsBetLabel.AutoSize = true;
            this.alsBetLabel.Location = new System.Drawing.Point(410, 178);
            this.alsBetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alsBetLabel.Name = "alsBetLabel";
            this.alsBetLabel.Size = new System.Drawing.Size(113, 36);
            this.alsBetLabel.TabIndex = 12;
            this.alsBetLabel.Text = "Al\'s bet";
            // 
            // bobsBetLabel
            // 
            this.bobsBetLabel.AutoSize = true;
            this.bobsBetLabel.Location = new System.Drawing.Point(410, 130);
            this.bobsBetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bobsBetLabel.Name = "bobsBetLabel";
            this.bobsBetLabel.Size = new System.Drawing.Size(139, 36);
            this.bobsBetLabel.TabIndex = 11;
            this.bobsBetLabel.Text = "Bob\'s bet";
            // 
            // joesBetLabel
            // 
            this.joesBetLabel.AutoSize = true;
            this.joesBetLabel.Location = new System.Drawing.Point(410, 82);
            this.joesBetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.joesBetLabel.Name = "joesBetLabel";
            this.joesBetLabel.Size = new System.Drawing.Size(133, 36);
            this.joesBetLabel.TabIndex = 10;
            this.joesBetLabel.Text = "Joe\'s bet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bets";
            // 
            // selectDog
            // 
            this.selectDog.Location = new System.Drawing.Point(652, 253);
            this.selectDog.Margin = new System.Windows.Forms.Padding(4);
            this.selectDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.selectDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectDog.Name = "selectDog";
            this.selectDog.Size = new System.Drawing.Size(112, 41);
            this.selectDog.TabIndex = 8;
            this.selectDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dogLabel
            // 
            this.dogLabel.Location = new System.Drawing.Point(354, 255);
            this.dogLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dogLabel.Name = "dogLabel";
            this.dogLabel.Size = new System.Drawing.Size(410, 50);
            this.dogLabel.TabIndex = 7;
            this.dogLabel.Text = "bucks on dog number";
            // 
            // selectAmount
            // 
            this.selectAmount.Location = new System.Drawing.Point(233, 253);
            this.selectAmount.Margin = new System.Windows.Forms.Padding(4);
            this.selectAmount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.selectAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.selectAmount.Name = "selectAmount";
            this.selectAmount.Size = new System.Drawing.Size(113, 41);
            this.selectAmount.TabIndex = 6;
            this.selectAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(103, 243);
            this.betsButton.Margin = new System.Windows.Forms.Padding(4);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(122, 57);
            this.betsButton.TabIndex = 5;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 255);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 36);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "name";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(8, 174);
            this.alRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(235, 40);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(8, 126);
            this.bobRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(263, 40);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(8, 78);
            this.joeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(252, 40);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(8, 38);
            this.minimumBetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(249, 36);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // dog2
            // 
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(13, 121);
            this.dog2.Margin = new System.Windows.Forms.Padding(4);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(75, 20);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog2.TabIndex = 3;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(12, 209);
            this.dog3.Margin = new System.Windows.Forms.Padding(4);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(75, 20);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog3.TabIndex = 4;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = ((System.Drawing.Image)(resources.GetObject("dog4.Image")));
            this.dog4.Location = new System.Drawing.Point(13, 305);
            this.dog4.Margin = new System.Windows.Forms.Padding(4);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(75, 20);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog4.TabIndex = 5;
            this.dog4.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(12, 26);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(75, 20);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog1.TabIndex = 6;
            this.dog1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 706);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.Label dogLabel;
        private System.Windows.Forms.NumericUpDown selectAmount;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.NumericUpDown selectDog;
        private System.Windows.Forms.Button startRaceButton;
        private System.Windows.Forms.Label alsBetLabel;
        private System.Windows.Forms.Label bobsBetLabel;
        private System.Windows.Forms.Label joesBetLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.Timer timer1;
    }
}

