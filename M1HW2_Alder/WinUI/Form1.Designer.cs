
namespace WinUI
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
            this.exitButton = new System.Windows.Forms.Button();
            this.massEntryLabel = new System.Windows.Forms.Label();
            this.velocityEntryLabel = new System.Windows.Forms.Label();
            this.kineticEnergyLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.velocityTextBox = new System.Windows.Forms.TextBox();
            this.kineticEnergyText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(154, 92);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 45);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // massEntryLabel
            // 
            this.massEntryLabel.AutoSize = true;
            this.massEntryLabel.Location = new System.Drawing.Point(19, 9);
            this.massEntryLabel.Name = "massEntryLabel";
            this.massEntryLabel.Size = new System.Drawing.Size(119, 13);
            this.massEntryLabel.TabIndex = 0;
            this.massEntryLabel.Text = "Enter the object\'s mass:";
            // 
            // velocityEntryLabel
            // 
            this.velocityEntryLabel.AutoSize = true;
            this.velocityEntryLabel.Location = new System.Drawing.Point(7, 35);
            this.velocityEntryLabel.Name = "velocityEntryLabel";
            this.velocityEntryLabel.Size = new System.Drawing.Size(131, 13);
            this.velocityEntryLabel.TabIndex = 1;
            this.velocityEntryLabel.Text = "Enter the object\'s velocity:";
            // 
            // kineticEnergyLabel
            // 
            this.kineticEnergyLabel.AutoSize = true;
            this.kineticEnergyLabel.Location = new System.Drawing.Point(61, 62);
            this.kineticEnergyLabel.Name = "kineticEnergyLabel";
            this.kineticEnergyLabel.Size = new System.Drawing.Size(77, 13);
            this.kineticEnergyLabel.TabIndex = 2;
            this.kineticEnergyLabel.Text = "Kinetic energy:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(26, 92);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 45);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Kinetic Energy";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // massTextBox
            // 
            this.massTextBox.Location = new System.Drawing.Point(154, 9);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(100, 20);
            this.massTextBox.TabIndex = 4;
            // 
            // velocityTextBox
            // 
            this.velocityTextBox.Location = new System.Drawing.Point(154, 35);
            this.velocityTextBox.Name = "velocityTextBox";
            this.velocityTextBox.Size = new System.Drawing.Size(100, 20);
            this.velocityTextBox.TabIndex = 5;
            // 
            // kineticEnergyText
            // 
            this.kineticEnergyText.AutoSize = true;
            this.kineticEnergyText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kineticEnergyText.Location = new System.Drawing.Point(154, 62);
            this.kineticEnergyText.MinimumSize = new System.Drawing.Size(100, 20);
            this.kineticEnergyText.Name = "kineticEnergyText";
            this.kineticEnergyText.Size = new System.Drawing.Size(100, 20);
            this.kineticEnergyText.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 149);
            this.Controls.Add(this.kineticEnergyText);
            this.Controls.Add(this.velocityTextBox);
            this.Controls.Add(this.massTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.kineticEnergyLabel);
            this.Controls.Add(this.massEntryLabel);
            this.Controls.Add(this.velocityEntryLabel);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Kinetic Energy Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label massEntryLabel;
        private System.Windows.Forms.Label velocityEntryLabel;
        private System.Windows.Forms.Label kineticEnergyLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.TextBox velocityTextBox;
        private System.Windows.Forms.Label kineticEnergyText;
    }
}

