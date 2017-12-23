
namespace Chapter3___Program2
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
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.giveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeToBob = new System.Windows.Forms.Button();
            this.bobToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joesCashLabel.Location = new System.Drawing.Point(28, 37);
            this.joesCashLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(319, 63);
            this.joesCashLabel.TabIndex = 0;
            this.joesCashLabel.Text = "Joe has $50";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobsCashLabel.Location = new System.Drawing.Point(28, 119);
            this.bobsCashLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(358, 63);
            this.bobsCashLabel.TabIndex = 1;
            this.bobsCashLabel.Text = "Bob has $100";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankCashLabel.Location = new System.Drawing.Point(28, 194);
            this.bankCashLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(486, 63);
            this.bankCashLabel.TabIndex = 2;
            this.bankCashLabel.Text = "The bank has $100";
            // 
            // giveButton
            // 
            this.giveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giveButton.Location = new System.Drawing.Point(39, 290);
            this.giveButton.Margin = new System.Windows.Forms.Padding(6);
            this.giveButton.Name = "giveButton";
            this.giveButton.Size = new System.Drawing.Size(225, 110);
            this.giveButton.TabIndex = 3;
            this.giveButton.Text = "Give $10 to Joe";
            this.giveButton.UseVisualStyleBackColor = true;
            this.giveButton.Click += new System.EventHandler(this.giveButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(322, 290);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 110);
            this.button2.TabIndex = 4;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joeToBob
            // 
            this.joeToBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeToBob.Location = new System.Drawing.Point(39, 432);
            this.joeToBob.Name = "joeToBob";
            this.joeToBob.Size = new System.Drawing.Size(225, 110);
            this.joeToBob.TabIndex = 5;
            this.joeToBob.Text = "Joe gives $10 to Bob";
            this.joeToBob.UseVisualStyleBackColor = true;
            this.joeToBob.Click += new System.EventHandler(this.joeToBob_Click);
            // 
            // bobToJoe
            // 
            this.bobToJoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobToJoe.Location = new System.Drawing.Point(322, 432);
            this.bobToJoe.Name = "bobToJoe";
            this.bobToJoe.Size = new System.Drawing.Size(225, 110);
            this.bobToJoe.TabIndex = 6;
            this.bobToJoe.Text = "Bob gives $5 to Joe";
            this.bobToJoe.UseVisualStyleBackColor = true;
            this.bobToJoe.Click += new System.EventHandler(this.bobToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 622);
            this.Controls.Add(this.bobToJoe);
            this.Controls.Add(this.joeToBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.giveButton);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button giveButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button joeToBob;
        private System.Windows.Forms.Button bobToJoe;
    }
}

