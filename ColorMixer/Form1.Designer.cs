namespace Assignment1
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
            this.colorMixerPanel = new System.Windows.Forms.Panel();
            this.workshopSelectorPanel = new System.Windows.Forms.Panel();
            this.colorMixerRB = new System.Windows.Forms.RadioButton();
            this.workshopSelRB = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.firstColorGB = new System.Windows.Forms.GroupBox();
            this.secondColorGB = new System.Windows.Forms.GroupBox();
            this.mixButtonColorPanel = new System.Windows.Forms.Button();
            this.redColor1RB = new System.Windows.Forms.RadioButton();
            this.blueColor1RB = new System.Windows.Forms.RadioButton();
            this.yellowColor1RB = new System.Windows.Forms.RadioButton();
            this.redColor2RB = new System.Windows.Forms.RadioButton();
            this.blueColor2RB = new System.Windows.Forms.RadioButton();
            this.yellowColor2RB = new System.Windows.Forms.RadioButton();
            this.workshopListBox = new System.Windows.Forms.ListBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.colorMixerPanel.SuspendLayout();
            this.workshopSelectorPanel.SuspendLayout();
            this.firstColorGB.SuspendLayout();
            this.secondColorGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorMixerPanel
            // 
            this.colorMixerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorMixerPanel.Controls.Add(this.mixButtonColorPanel);
            this.colorMixerPanel.Controls.Add(this.secondColorGB);
            this.colorMixerPanel.Controls.Add(this.firstColorGB);
            this.colorMixerPanel.Location = new System.Drawing.Point(82, 56);
            this.colorMixerPanel.Name = "colorMixerPanel";
            this.colorMixerPanel.Size = new System.Drawing.Size(700, 577);
            this.colorMixerPanel.TabIndex = 0;
            this.colorMixerPanel.Visible = false;
            // 
            // workshopSelectorPanel
            // 
            this.workshopSelectorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workshopSelectorPanel.Controls.Add(this.clearButton);
            this.workshopSelectorPanel.Controls.Add(this.calculateButton);
            this.workshopSelectorPanel.Controls.Add(this.outputListBox);
            this.workshopSelectorPanel.Controls.Add(this.locationListBox);
            this.workshopSelectorPanel.Controls.Add(this.workshopListBox);
            this.workshopSelectorPanel.Location = new System.Drawing.Point(934, 56);
            this.workshopSelectorPanel.Name = "workshopSelectorPanel";
            this.workshopSelectorPanel.Size = new System.Drawing.Size(825, 577);
            this.workshopSelectorPanel.TabIndex = 1;
            this.workshopSelectorPanel.Visible = false;
            // 
            // colorMixerRB
            // 
            this.colorMixerRB.AutoSize = true;
            this.colorMixerRB.Location = new System.Drawing.Point(330, 692);
            this.colorMixerRB.Name = "colorMixerRB";
            this.colorMixerRB.Size = new System.Drawing.Size(196, 36);
            this.colorMixerRB.TabIndex = 2;
            this.colorMixerRB.Text = "Color Mixer";
            this.colorMixerRB.UseVisualStyleBackColor = true;
            this.colorMixerRB.CheckedChanged += new System.EventHandler(this.colorMixerRB_CheckedChanged);
            // 
            // workshopSelRB
            // 
            this.workshopSelRB.AutoSize = true;
            this.workshopSelRB.Location = new System.Drawing.Point(1206, 692);
            this.workshopSelRB.Name = "workshopSelRB";
            this.workshopSelRB.Size = new System.Drawing.Size(291, 36);
            this.workshopSelRB.TabIndex = 3;
            this.workshopSelRB.Text = "Workshop Selector";
            this.workshopSelRB.UseVisualStyleBackColor = true;
            this.workshopSelRB.CheckedChanged += new System.EventHandler(this.workshopSelRB_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(786, 801);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(149, 86);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // firstColorGB
            // 
            this.firstColorGB.Controls.Add(this.yellowColor1RB);
            this.firstColorGB.Controls.Add(this.blueColor1RB);
            this.firstColorGB.Controls.Add(this.redColor1RB);
            this.firstColorGB.Location = new System.Drawing.Point(35, 76);
            this.firstColorGB.Name = "firstColorGB";
            this.firstColorGB.Size = new System.Drawing.Size(261, 270);
            this.firstColorGB.TabIndex = 0;
            this.firstColorGB.TabStop = false;
            this.firstColorGB.Text = "First Color";
            // 
            // secondColorGB
            // 
            this.secondColorGB.Controls.Add(this.yellowColor2RB);
            this.secondColorGB.Controls.Add(this.blueColor2RB);
            this.secondColorGB.Controls.Add(this.redColor2RB);
            this.secondColorGB.Location = new System.Drawing.Point(373, 76);
            this.secondColorGB.Name = "secondColorGB";
            this.secondColorGB.Size = new System.Drawing.Size(251, 270);
            this.secondColorGB.TabIndex = 1;
            this.secondColorGB.TabStop = false;
            this.secondColorGB.Text = "Second Color";
            // 
            // mixButtonColorPanel
            // 
            this.mixButtonColorPanel.Location = new System.Drawing.Point(257, 403);
            this.mixButtonColorPanel.Name = "mixButtonColorPanel";
            this.mixButtonColorPanel.Size = new System.Drawing.Size(154, 54);
            this.mixButtonColorPanel.TabIndex = 2;
            this.mixButtonColorPanel.Text = " Mix!";
            this.mixButtonColorPanel.UseVisualStyleBackColor = true;
            this.mixButtonColorPanel.Click += new System.EventHandler(this.mixButtonColorPanel_Click);
            // 
            // redColor1RB
            // 
            this.redColor1RB.AutoSize = true;
            this.redColor1RB.Location = new System.Drawing.Point(74, 65);
            this.redColor1RB.Name = "redColor1RB";
            this.redColor1RB.Size = new System.Drawing.Size(104, 36);
            this.redColor1RB.TabIndex = 0;
            this.redColor1RB.TabStop = true;
            this.redColor1RB.Text = "Red";
            this.redColor1RB.UseVisualStyleBackColor = true;
            // 
            // blueColor1RB
            // 
            this.blueColor1RB.AutoSize = true;
            this.blueColor1RB.Location = new System.Drawing.Point(74, 134);
            this.blueColor1RB.Name = "blueColor1RB";
            this.blueColor1RB.Size = new System.Drawing.Size(110, 36);
            this.blueColor1RB.TabIndex = 1;
            this.blueColor1RB.TabStop = true;
            this.blueColor1RB.Text = "Blue";
            this.blueColor1RB.UseVisualStyleBackColor = true;
            // 
            // yellowColor1RB
            // 
            this.yellowColor1RB.AutoSize = true;
            this.yellowColor1RB.Location = new System.Drawing.Point(74, 200);
            this.yellowColor1RB.Name = "yellowColor1RB";
            this.yellowColor1RB.Size = new System.Drawing.Size(137, 36);
            this.yellowColor1RB.TabIndex = 2;
            this.yellowColor1RB.TabStop = true;
            this.yellowColor1RB.Text = "Yellow";
            this.yellowColor1RB.UseVisualStyleBackColor = true;
            // 
            // redColor2RB
            // 
            this.redColor2RB.AutoSize = true;
            this.redColor2RB.Location = new System.Drawing.Point(67, 65);
            this.redColor2RB.Name = "redColor2RB";
            this.redColor2RB.Size = new System.Drawing.Size(104, 36);
            this.redColor2RB.TabIndex = 0;
            this.redColor2RB.TabStop = true;
            this.redColor2RB.Text = "Red";
            this.redColor2RB.UseVisualStyleBackColor = true;
            // 
            // blueColor2RB
            // 
            this.blueColor2RB.AutoSize = true;
            this.blueColor2RB.Location = new System.Drawing.Point(67, 134);
            this.blueColor2RB.Name = "blueColor2RB";
            this.blueColor2RB.Size = new System.Drawing.Size(110, 36);
            this.blueColor2RB.TabIndex = 1;
            this.blueColor2RB.TabStop = true;
            this.blueColor2RB.Text = "Blue";
            this.blueColor2RB.UseVisualStyleBackColor = true;
            // 
            // yellowColor2RB
            // 
            this.yellowColor2RB.AutoSize = true;
            this.yellowColor2RB.Location = new System.Drawing.Point(67, 200);
            this.yellowColor2RB.Name = "yellowColor2RB";
            this.yellowColor2RB.Size = new System.Drawing.Size(137, 36);
            this.yellowColor2RB.TabIndex = 2;
            this.yellowColor2RB.TabStop = true;
            this.yellowColor2RB.Text = "Yellow";
            this.yellowColor2RB.UseVisualStyleBackColor = true;
            // 
            // workshopListBox
            // 
            this.workshopListBox.FormattingEnabled = true;
            this.workshopListBox.ItemHeight = 31;
            this.workshopListBox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.workshopListBox.Location = new System.Drawing.Point(59, 50);
            this.workshopListBox.Name = "workshopListBox";
            this.workshopListBox.Size = new System.Drawing.Size(334, 221);
            this.workshopListBox.TabIndex = 0;
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.ItemHeight = 31;
            this.locationListBox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Pheonix",
            "Raleigh"});
            this.locationListBox.Location = new System.Drawing.Point(455, 50);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(315, 221);
            this.locationListBox.TabIndex = 1;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 31;
            this.outputListBox.Location = new System.Drawing.Point(59, 291);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(711, 159);
            this.outputListBox.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(235, 485);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(158, 45);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(455, 485);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(141, 45);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1853, 998);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.workshopSelRB);
            this.Controls.Add(this.colorMixerRB);
            this.Controls.Add(this.workshopSelectorPanel);
            this.Controls.Add(this.colorMixerPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.colorMixerPanel.ResumeLayout(false);
            this.workshopSelectorPanel.ResumeLayout(false);
            this.firstColorGB.ResumeLayout(false);
            this.firstColorGB.PerformLayout();
            this.secondColorGB.ResumeLayout(false);
            this.secondColorGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel colorMixerPanel;
        private System.Windows.Forms.Button mixButtonColorPanel;
        private System.Windows.Forms.GroupBox secondColorGB;
        private System.Windows.Forms.RadioButton yellowColor2RB;
        private System.Windows.Forms.RadioButton blueColor2RB;
        private System.Windows.Forms.RadioButton redColor2RB;
        private System.Windows.Forms.GroupBox firstColorGB;
        private System.Windows.Forms.RadioButton yellowColor1RB;
        private System.Windows.Forms.RadioButton blueColor1RB;
        private System.Windows.Forms.RadioButton redColor1RB;
        private System.Windows.Forms.Panel workshopSelectorPanel;
        private System.Windows.Forms.RadioButton colorMixerRB;
        private System.Windows.Forms.RadioButton workshopSelRB;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.ListBox workshopListBox;
        private System.Windows.Forms.Button clearButton;
    }
}

