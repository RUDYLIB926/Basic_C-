namespace Chapter4___Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displayAmountOwed = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.setStartingMileage = new System.Windows.Forms.NumericUpDown();
            this.setEndingMileage = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.setStartingMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setEndingMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Mileage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ending Mileage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Owed";
            // 
            // displayAmountOwed
            // 
            this.displayAmountOwed.AutoSize = true;
            this.displayAmountOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.displayAmountOwed.Location = new System.Drawing.Point(313, 151);
            this.displayAmountOwed.Name = "displayAmountOwed";
            this.displayAmountOwed.Size = new System.Drawing.Size(132, 46);
            this.displayAmountOwed.TabIndex = 3;
            this.displayAmountOwed.Text = "label4";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(321, 210);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(214, 58);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // setStartingMileage
            // 
            this.setStartingMileage.Location = new System.Drawing.Point(321, 28);
            this.setStartingMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.setStartingMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setStartingMileage.Name = "setStartingMileage";
            this.setStartingMileage.Size = new System.Drawing.Size(255, 41);
            this.setStartingMileage.TabIndex = 5;
            this.setStartingMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // setEndingMileage
            // 
            this.setEndingMileage.Location = new System.Drawing.Point(321, 93);
            this.setEndingMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.setEndingMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setEndingMileage.Name = "setEndingMileage";
            this.setEndingMileage.Size = new System.Drawing.Size(255, 41);
            this.setEndingMileage.TabIndex = 6;
            this.setEndingMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(604, 295);
            this.Controls.Add(this.setEndingMileage);
            this.Controls.Add(this.setStartingMileage);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.displayAmountOwed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mileage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.setStartingMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setEndingMileage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label displayAmountOwed;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.NumericUpDown setStartingMileage;
        private System.Windows.Forms.NumericUpDown setEndingMileage;
    }
}

