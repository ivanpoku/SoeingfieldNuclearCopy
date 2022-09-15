namespace SoeingfieldNuclear
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactor1Label = new System.Windows.Forms.Label();
            this.reactor2Label = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2StateLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.radioactiveImage2 = new System.Windows.Forms.PictureBox();
            this.radioactiveImage1 = new System.Windows.Forms.PictureBox();
            this.temperatureControlButton = new System.Windows.Forms.Button();
            this.temperatureControlLabel = new System.Windows.Forms.Label();
            this.temperatureControlExitButton = new System.Windows.Forms.Button();
            this.raiseTemperature = new System.Windows.Forms.Button();
            this.temperatureDisplay = new System.Windows.Forms.Label();
            this.lowerTemperature = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radioactiveImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioactiveImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(139, 41);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(352, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor Control";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titleLabel.Click += new System.EventHandler(this.startButton_Click);
            // 
            // reactor1Label
            // 
            this.reactor1Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Label.Location = new System.Drawing.Point(139, 106);
            this.reactor1Label.Name = "reactor1Label";
            this.reactor1Label.Size = new System.Drawing.Size(100, 23);
            this.reactor1Label.TabIndex = 1;
            this.reactor1Label.Text = "Reactor 1";
            this.reactor1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reactor1Label.Click += new System.EventHandler(this.reactor1Label_Click);
            // 
            // reactor2Label
            // 
            this.reactor2Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2Label.Location = new System.Drawing.Point(391, 106);
            this.reactor2Label.Name = "reactor2Label";
            this.reactor2Label.Size = new System.Drawing.Size(100, 23);
            this.reactor2Label.TabIndex = 2;
            this.reactor2Label.Text = "Reactor 2";
            this.reactor2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.Green;
            this.reactor1StateLabel.Location = new System.Drawing.Point(139, 166);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(100, 93);
            this.reactor1StateLabel.TabIndex = 3;
            // 
            // reactor2StateLabel
            // 
            this.reactor2StateLabel.BackColor = System.Drawing.Color.Green;
            this.reactor2StateLabel.Location = new System.Drawing.Point(391, 166);
            this.reactor2StateLabel.Name = "reactor2StateLabel";
            this.reactor2StateLabel.Size = new System.Drawing.Size(100, 93);
            this.reactor2StateLabel.TabIndex = 4;
            this.reactor2StateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(139, 366);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(352, 46);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Reactors Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(200, 289);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(231, 47);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start Reactors";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioactiveImage2
            // 
            this.radioactiveImage2.BackColor = System.Drawing.Color.Red;
            this.radioactiveImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioactiveImage2.ImageLocation = "https://icons.iconarchive.com/icons/icons8/windows-8/512/Industry-Radioactive-ico" +
    "n.png";
            this.radioactiveImage2.Location = new System.Drawing.Point(139, 166);
            this.radioactiveImage2.Name = "radioactiveImage2";
            this.radioactiveImage2.Size = new System.Drawing.Size(100, 93);
            this.radioactiveImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.radioactiveImage2.TabIndex = 7;
            this.radioactiveImage2.TabStop = false;
            this.radioactiveImage2.Visible = false;
            this.radioactiveImage2.Click += new System.EventHandler(this.radioactiveImage2_Click);
            // 
            // radioactiveImage1
            // 
            this.radioactiveImage1.BackColor = System.Drawing.Color.Red;
            this.radioactiveImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioactiveImage1.ImageLocation = "https://icons.iconarchive.com/icons/icons8/windows-8/512/Industry-Radioactive-ico" +
    "n.png";
            this.radioactiveImage1.Location = new System.Drawing.Point(391, 166);
            this.radioactiveImage1.Name = "radioactiveImage1";
            this.radioactiveImage1.Size = new System.Drawing.Size(100, 93);
            this.radioactiveImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.radioactiveImage1.TabIndex = 8;
            this.radioactiveImage1.TabStop = false;
            this.radioactiveImage1.Visible = false;
            // 
            // temperatureControlButton
            // 
            this.temperatureControlButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureControlButton.Location = new System.Drawing.Point(561, 57);
            this.temperatureControlButton.Name = "temperatureControlButton";
            this.temperatureControlButton.Size = new System.Drawing.Size(250, 50);
            this.temperatureControlButton.TabIndex = 9;
            this.temperatureControlButton.Text = "Temperature Control";
            this.temperatureControlButton.UseVisualStyleBackColor = true;
            this.temperatureControlButton.Click += new System.EventHandler(this.temperatureControlButton_Click);
            // 
            // temperatureControlLabel
            // 
            this.temperatureControlLabel.BackColor = System.Drawing.Color.White;
            this.temperatureControlLabel.Location = new System.Drawing.Point(561, 129);
            this.temperatureControlLabel.Name = "temperatureControlLabel";
            this.temperatureControlLabel.Size = new System.Drawing.Size(250, 283);
            this.temperatureControlLabel.TabIndex = 11;
            this.temperatureControlLabel.Visible = false;
            this.temperatureControlLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // temperatureControlExitButton
            // 
            this.temperatureControlExitButton.BackColor = System.Drawing.Color.Red;
            this.temperatureControlExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureControlExitButton.Location = new System.Drawing.Point(781, 129);
            this.temperatureControlExitButton.Name = "temperatureControlExitButton";
            this.temperatureControlExitButton.Size = new System.Drawing.Size(30, 30);
            this.temperatureControlExitButton.TabIndex = 12;
            this.temperatureControlExitButton.Text = "X";
            this.temperatureControlExitButton.UseVisualStyleBackColor = false;
            this.temperatureControlExitButton.Visible = false;
            this.temperatureControlExitButton.Click += new System.EventHandler(this.temperatureControlExitButton_Click);
            // 
            // raiseTemperature
            // 
            this.raiseTemperature.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiseTemperature.Location = new System.Drawing.Point(576, 166);
            this.raiseTemperature.Name = "raiseTemperature";
            this.raiseTemperature.Size = new System.Drawing.Size(75, 30);
            this.raiseTemperature.TabIndex = 13;
            this.raiseTemperature.Text = "^";
            this.raiseTemperature.UseVisualStyleBackColor = true;
            this.raiseTemperature.Visible = false;
            this.raiseTemperature.Click += new System.EventHandler(this.raiseTemperature_Click);
            // 
            // temperatureDisplay
            // 
            this.temperatureDisplay.BackColor = System.Drawing.Color.Silver;
            this.temperatureDisplay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureDisplay.Location = new System.Drawing.Point(657, 184);
            this.temperatureDisplay.Name = "temperatureDisplay";
            this.temperatureDisplay.Size = new System.Drawing.Size(50, 50);
            this.temperatureDisplay.TabIndex = 14;
            this.temperatureDisplay.Text = "900";
            this.temperatureDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.temperatureDisplay.Visible = false;
            this.temperatureDisplay.Click += new System.EventHandler(this.temperatureDisplay_Click);
            // 
            // lowerTemperature
            // 
            this.lowerTemperature.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerTemperature.Location = new System.Drawing.Point(576, 236);
            this.lowerTemperature.Name = "lowerTemperature";
            this.lowerTemperature.Size = new System.Drawing.Size(75, 34);
            this.lowerTemperature.TabIndex = 15;
            this.lowerTemperature.Text = "v";
            this.lowerTemperature.UseVisualStyleBackColor = true;
            this.lowerTemperature.Visible = false;
            this.lowerTemperature.Click += new System.EventHandler(this.lowerTemperature_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(838, 448);
            this.Controls.Add(this.lowerTemperature);
            this.Controls.Add(this.temperatureDisplay);
            this.Controls.Add(this.raiseTemperature);
            this.Controls.Add(this.temperatureControlExitButton);
            this.Controls.Add(this.temperatureControlButton);
            this.Controls.Add(this.radioactiveImage1);
            this.Controls.Add(this.radioactiveImage2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reactor2StateLabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.reactor2Label);
            this.Controls.Add(this.reactor1Label);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.temperatureControlLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Window";
            this.Text = "Springfield Nuclear Power Plant";
            ((System.ComponentModel.ISupportInitialize)(this.radioactiveImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioactiveImage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactor1Label;
        private System.Windows.Forms.Label reactor2Label;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2StateLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox radioactiveImage2;
        private System.Windows.Forms.PictureBox radioactiveImage1;
        private System.Windows.Forms.Button temperatureControlButton;
        private System.Windows.Forms.Label temperatureControlLabel;
        private System.Windows.Forms.Button temperatureControlExitButton;
        private System.Windows.Forms.Button raiseTemperature;
        private System.Windows.Forms.Label temperatureDisplay;
        private System.Windows.Forms.Button lowerTemperature;
    }
}

