namespace Hairsalon
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
            this.JaneRB = new System.Windows.Forms.RadioButton();
            this.PatRB = new System.Windows.Forms.RadioButton();
            this.RonRB = new System.Windows.Forms.RadioButton();
            this.SueRB = new System.Windows.Forms.RadioButton();
            this.LauraRB = new System.Windows.Forms.RadioButton();
            this.HairDresserGB = new System.Windows.Forms.GroupBox();
            this.ClientTypeGB = new System.Windows.Forms.GroupBox();
            this.SeniorCitizenRB = new System.Windows.Forms.RadioButton();
            this.StudentRB = new System.Windows.Forms.RadioButton();
            this.ChildRB = new System.Windows.Forms.RadioButton();
            this.AdultRB = new System.Windows.Forms.RadioButton();
            this.HairCutCB = new System.Windows.Forms.CheckBox();
            this.ColourCB = new System.Windows.Forms.CheckBox();
            this.HighlightsCB = new System.Windows.Forms.CheckBox();
            this.ExtensionCB = new System.Windows.Forms.CheckBox();
            this.ServicesGB = new System.Windows.Forms.GroupBox();
            this.NumberOfClientsVisitsTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfClientsVisitsLabel = new System.Windows.Forms.Label();
            this.ClientVisitsGB = new System.Windows.Forms.GroupBox();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.PriceDisplayLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HairDresserGB.SuspendLayout();
            this.ClientTypeGB.SuspendLayout();
            this.ServicesGB.SuspendLayout();
            this.ClientVisitsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // JaneRB
            // 
            this.JaneRB.AutoSize = true;
            this.JaneRB.Checked = true;
            this.JaneRB.Location = new System.Drawing.Point(13, 30);
            this.JaneRB.Name = "JaneRB";
            this.JaneRB.Size = new System.Drawing.Size(85, 17);
            this.JaneRB.TabIndex = 0;
            this.JaneRB.TabStop = true;
            this.JaneRB.Text = "Jane Samley";
            this.JaneRB.UseVisualStyleBackColor = true;
            // 
            // PatRB
            // 
            this.PatRB.AutoSize = true;
            this.PatRB.Location = new System.Drawing.Point(13, 53);
            this.PatRB.Name = "PatRB";
            this.PatRB.Size = new System.Drawing.Size(84, 17);
            this.PatRB.TabIndex = 1;
            this.PatRB.TabStop = true;
            this.PatRB.Text = "Pat Johnson";
            this.PatRB.UseVisualStyleBackColor = true;
            // 
            // RonRB
            // 
            this.RonRB.AutoSize = true;
            this.RonRB.Location = new System.Drawing.Point(13, 76);
            this.RonRB.Name = "RonRB";
            this.RonRB.Size = new System.Drawing.Size(95, 17);
            this.RonRB.TabIndex = 2;
            this.RonRB.TabStop = true;
            this.RonRB.Text = "Ron Chambers";
            this.RonRB.UseVisualStyleBackColor = true;
            // 
            // SueRB
            // 
            this.SueRB.AutoSize = true;
            this.SueRB.Location = new System.Drawing.Point(13, 99);
            this.SueRB.Name = "SueRB";
            this.SueRB.Size = new System.Drawing.Size(76, 17);
            this.SueRB.TabIndex = 3;
            this.SueRB.TabStop = true;
            this.SueRB.Text = "Sue Pallon";
            this.SueRB.UseVisualStyleBackColor = true;
            // 
            // LauraRB
            // 
            this.LauraRB.AutoSize = true;
            this.LauraRB.Location = new System.Drawing.Point(13, 122);
            this.LauraRB.Name = "LauraRB";
            this.LauraRB.Size = new System.Drawing.Size(93, 17);
            this.LauraRB.TabIndex = 4;
            this.LauraRB.TabStop = true;
            this.LauraRB.Text = "Laura Penkins";
            this.LauraRB.UseVisualStyleBackColor = true;
            // 
            // HairDresserGB
            // 
            this.HairDresserGB.Controls.Add(this.LauraRB);
            this.HairDresserGB.Controls.Add(this.SueRB);
            this.HairDresserGB.Controls.Add(this.RonRB);
            this.HairDresserGB.Controls.Add(this.PatRB);
            this.HairDresserGB.Controls.Add(this.JaneRB);
            this.HairDresserGB.Location = new System.Drawing.Point(26, 24);
            this.HairDresserGB.Name = "HairDresserGB";
            this.HairDresserGB.Size = new System.Drawing.Size(141, 158);
            this.HairDresserGB.TabIndex = 5;
            this.HairDresserGB.TabStop = false;
            this.HairDresserGB.Text = "Hair Dresser";
            // 
            // ClientTypeGB
            // 
            this.ClientTypeGB.Controls.Add(this.SeniorCitizenRB);
            this.ClientTypeGB.Controls.Add(this.StudentRB);
            this.ClientTypeGB.Controls.Add(this.ChildRB);
            this.ClientTypeGB.Controls.Add(this.AdultRB);
            this.ClientTypeGB.Location = new System.Drawing.Point(26, 201);
            this.ClientTypeGB.Name = "ClientTypeGB";
            this.ClientTypeGB.Size = new System.Drawing.Size(141, 158);
            this.ClientTypeGB.TabIndex = 6;
            this.ClientTypeGB.TabStop = false;
            this.ClientTypeGB.Text = "Client Type";
            // 
            // SeniorCitizenRB
            // 
            this.SeniorCitizenRB.AutoSize = true;
            this.SeniorCitizenRB.Location = new System.Drawing.Point(13, 99);
            this.SeniorCitizenRB.Name = "SeniorCitizenRB";
            this.SeniorCitizenRB.Size = new System.Drawing.Size(100, 17);
            this.SeniorCitizenRB.TabIndex = 3;
            this.SeniorCitizenRB.TabStop = true;
            this.SeniorCitizenRB.Text = "Senior (over 65)";
            this.SeniorCitizenRB.UseVisualStyleBackColor = true;
            // 
            // StudentRB
            // 
            this.StudentRB.AutoSize = true;
            this.StudentRB.Location = new System.Drawing.Point(13, 76);
            this.StudentRB.Name = "StudentRB";
            this.StudentRB.Size = new System.Drawing.Size(62, 17);
            this.StudentRB.TabIndex = 2;
            this.StudentRB.TabStop = true;
            this.StudentRB.Text = "Student";
            this.StudentRB.UseVisualStyleBackColor = true;
            // 
            // ChildRB
            // 
            this.ChildRB.AutoSize = true;
            this.ChildRB.Location = new System.Drawing.Point(13, 53);
            this.ChildRB.Name = "ChildRB";
            this.ChildRB.Size = new System.Drawing.Size(122, 17);
            this.ChildRB.TabIndex = 1;
            this.ChildRB.TabStop = true;
            this.ChildRB.Text = "Child (12 and Under)";
            this.ChildRB.UseVisualStyleBackColor = true;
            // 
            // AdultRB
            // 
            this.AdultRB.AutoSize = true;
            this.AdultRB.Checked = true;
            this.AdultRB.Location = new System.Drawing.Point(13, 30);
            this.AdultRB.Name = "AdultRB";
            this.AdultRB.Size = new System.Drawing.Size(95, 17);
            this.AdultRB.TabIndex = 0;
            this.AdultRB.TabStop = true;
            this.AdultRB.Text = "Standard Adult";
            this.AdultRB.UseVisualStyleBackColor = true;
            // 
            // HairCutCB
            // 
            this.HairCutCB.AutoSize = true;
            this.HairCutCB.Cursor = System.Windows.Forms.Cursors.Default;
            this.HairCutCB.Location = new System.Drawing.Point(13, 23);
            this.HairCutCB.Name = "HairCutCB";
            this.HairCutCB.Size = new System.Drawing.Size(64, 17);
            this.HairCutCB.TabIndex = 7;
            this.HairCutCB.Text = "Hair Cut";
            this.HairCutCB.UseVisualStyleBackColor = true;
            // 
            // ColourCB
            // 
            this.ColourCB.AutoSize = true;
            this.ColourCB.Location = new System.Drawing.Point(13, 45);
            this.ColourCB.Name = "ColourCB";
            this.ColourCB.Size = new System.Drawing.Size(56, 17);
            this.ColourCB.TabIndex = 8;
            this.ColourCB.Text = "Colour";
            this.ColourCB.UseVisualStyleBackColor = true;
            // 
            // HighlightsCB
            // 
            this.HighlightsCB.AutoSize = true;
            this.HighlightsCB.Location = new System.Drawing.Point(13, 69);
            this.HighlightsCB.Name = "HighlightsCB";
            this.HighlightsCB.Size = new System.Drawing.Size(71, 17);
            this.HighlightsCB.TabIndex = 9;
            this.HighlightsCB.Text = "HighLight";
            this.HighlightsCB.UseVisualStyleBackColor = true;
            // 
            // ExtensionCB
            // 
            this.ExtensionCB.AutoSize = true;
            this.ExtensionCB.Location = new System.Drawing.Point(13, 92);
            this.ExtensionCB.Name = "ExtensionCB";
            this.ExtensionCB.Size = new System.Drawing.Size(77, 17);
            this.ExtensionCB.TabIndex = 10;
            this.ExtensionCB.Text = "Extensions";
            this.ExtensionCB.UseVisualStyleBackColor = true;
            // 
            // ServicesGB
            // 
            this.ServicesGB.Controls.Add(this.ExtensionCB);
            this.ServicesGB.Controls.Add(this.HighlightsCB);
            this.ServicesGB.Controls.Add(this.ColourCB);
            this.ServicesGB.Controls.Add(this.HairCutCB);
            this.ServicesGB.Location = new System.Drawing.Point(207, 24);
            this.ServicesGB.Name = "ServicesGB";
            this.ServicesGB.Size = new System.Drawing.Size(125, 139);
            this.ServicesGB.TabIndex = 11;
            this.ServicesGB.TabStop = false;
            this.ServicesGB.Text = "Services";
            // 
            // NumberOfClientsVisitsTextBox
            // 
            this.NumberOfClientsVisitsTextBox.Location = new System.Drawing.Point(5, 47);
            this.NumberOfClientsVisitsTextBox.Name = "NumberOfClientsVisitsTextBox";
            this.NumberOfClientsVisitsTextBox.Size = new System.Drawing.Size(143, 20);
            this.NumberOfClientsVisitsTextBox.TabIndex = 12;
            // 
            // NumberOfClientsVisitsLabel
            // 
            this.NumberOfClientsVisitsLabel.AutoSize = true;
            this.NumberOfClientsVisitsLabel.Location = new System.Drawing.Point(2, 27);
            this.NumberOfClientsVisitsLabel.Name = "NumberOfClientsVisitsLabel";
            this.NumberOfClientsVisitsLabel.Size = new System.Drawing.Size(130, 13);
            this.NumberOfClientsVisitsLabel.TabIndex = 13;
            this.NumberOfClientsVisitsLabel.Text = "Numbers Of Clients Visits: ";
            // 
            // ClientVisitsGB
            // 
            this.ClientVisitsGB.Controls.Add(this.NumberOfClientsVisitsLabel);
            this.ClientVisitsGB.Controls.Add(this.NumberOfClientsVisitsTextBox);
            this.ClientVisitsGB.Location = new System.Drawing.Point(207, 201);
            this.ClientVisitsGB.Name = "ClientVisitsGB";
            this.ClientVisitsGB.Size = new System.Drawing.Size(160, 122);
            this.ClientVisitsGB.TabIndex = 14;
            this.ClientVisitsGB.TabStop = false;
            this.ClientVisitsGB.Text = "Clients Visits";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(204, 346);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(58, 13);
            this.TotalPriceLabel.TabIndex = 15;
            this.TotalPriceLabel.Text = "Total Price";
            // 
            // PriceDisplayLabel
            // 
            this.PriceDisplayLabel.AutoSize = true;
            this.PriceDisplayLabel.Location = new System.Drawing.Point(296, 346);
            this.PriceDisplayLabel.Name = "PriceDisplayLabel";
            this.PriceDisplayLabel.Size = new System.Drawing.Size(43, 13);
            this.PriceDisplayLabel.TabIndex = 16;
            this.PriceDisplayLabel.Text = "$ 00.00";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(39, 398);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(111, 26);
            this.CalculateButton.TabIndex = 17;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(156, 398);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(111, 26);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(273, 398);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(111, 26);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 436);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.PriceDisplayLabel);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.ClientVisitsGB);
            this.Controls.Add(this.ServicesGB);
            this.Controls.Add(this.ClientTypeGB);
            this.Controls.Add(this.HairDresserGB);
            this.Name = "Form1";
            this.Text = "Hair Salon";
            this.HairDresserGB.ResumeLayout(false);
            this.HairDresserGB.PerformLayout();
            this.ClientTypeGB.ResumeLayout(false);
            this.ClientTypeGB.PerformLayout();
            this.ServicesGB.ResumeLayout(false);
            this.ServicesGB.PerformLayout();
            this.ClientVisitsGB.ResumeLayout(false);
            this.ClientVisitsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton JaneRB;
        private System.Windows.Forms.RadioButton PatRB;
        private System.Windows.Forms.RadioButton RonRB;
        private System.Windows.Forms.RadioButton SueRB;
        private System.Windows.Forms.RadioButton LauraRB;
        private System.Windows.Forms.GroupBox HairDresserGB;
        private System.Windows.Forms.GroupBox ClientTypeGB;
        private System.Windows.Forms.RadioButton SeniorCitizenRB;
        private System.Windows.Forms.RadioButton StudentRB;
        private System.Windows.Forms.RadioButton ChildRB;
        private System.Windows.Forms.RadioButton AdultRB;
        private System.Windows.Forms.CheckBox HairCutCB;
        private System.Windows.Forms.CheckBox ColourCB;
        private System.Windows.Forms.CheckBox HighlightsCB;
        private System.Windows.Forms.CheckBox ExtensionCB;
        private System.Windows.Forms.GroupBox ServicesGB;
        private System.Windows.Forms.TextBox NumberOfClientsVisitsTextBox;
        private System.Windows.Forms.Label NumberOfClientsVisitsLabel;
        private System.Windows.Forms.GroupBox ClientVisitsGB;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label PriceDisplayLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

