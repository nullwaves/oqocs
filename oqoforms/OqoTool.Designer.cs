namespace oqoforms
{
    partial class OqoTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OqoTool));
            this.Frame = new System.Windows.Forms.TabControl();
            this.PageCharacterGen = new System.Windows.Forms.TabPage();
            this.ComboSpecies = new System.Windows.Forms.ComboBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ComboKinship = new System.Windows.Forms.ComboBox();
            this.lblKinship = new System.Windows.Forms.Label();
            this.ComboJob = new System.Windows.Forms.ComboBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.ButtonRandomCharacter = new System.Windows.Forms.Button();
            this.TextCharacterOutput = new System.Windows.Forms.TextBox();
            this.ButtonGenerateBySpecies = new System.Windows.Forms.Button();
            this.ButtonGenBySpeciesAndGroup = new System.Windows.Forms.Button();
            this.ButtonGenerateByJob = new System.Windows.Forms.Button();
            this.Frame.SuspendLayout();
            this.PageCharacterGen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frame
            // 
            this.Frame.Controls.Add(this.PageCharacterGen);
            this.Frame.Controls.Add(this.tabPage2);
            this.Frame.Location = new System.Drawing.Point(12, 12);
            this.Frame.Name = "Frame";
            this.Frame.SelectedIndex = 0;
            this.Frame.Size = new System.Drawing.Size(774, 575);
            this.Frame.TabIndex = 0;
            // 
            // PageCharacterGen
            // 
            this.PageCharacterGen.Controls.Add(this.ButtonGenerateByJob);
            this.PageCharacterGen.Controls.Add(this.ButtonGenBySpeciesAndGroup);
            this.PageCharacterGen.Controls.Add(this.ButtonGenerateBySpecies);
            this.PageCharacterGen.Controls.Add(this.TextCharacterOutput);
            this.PageCharacterGen.Controls.Add(this.ButtonRandomCharacter);
            this.PageCharacterGen.Controls.Add(this.ButtonGenerate);
            this.PageCharacterGen.Controls.Add(this.ComboJob);
            this.PageCharacterGen.Controls.Add(this.lblJob);
            this.PageCharacterGen.Controls.Add(this.ComboKinship);
            this.PageCharacterGen.Controls.Add(this.lblKinship);
            this.PageCharacterGen.Controls.Add(this.ComboSpecies);
            this.PageCharacterGen.Controls.Add(this.lblSpecies);
            this.PageCharacterGen.Location = new System.Drawing.Point(4, 22);
            this.PageCharacterGen.Name = "PageCharacterGen";
            this.PageCharacterGen.Padding = new System.Windows.Forms.Padding(3);
            this.PageCharacterGen.Size = new System.Drawing.Size(766, 549);
            this.PageCharacterGen.TabIndex = 0;
            this.PageCharacterGen.Text = "Char. Gen.";
            this.PageCharacterGen.UseVisualStyleBackColor = true;
            // 
            // ComboSpecies
            // 
            this.ComboSpecies.FormattingEnabled = true;
            this.ComboSpecies.Location = new System.Drawing.Point(60, 10);
            this.ComboSpecies.Name = "ComboSpecies";
            this.ComboSpecies.Size = new System.Drawing.Size(121, 21);
            this.ComboSpecies.TabIndex = 1;
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(6, 13);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(48, 13);
            this.lblSpecies.TabIndex = 0;
            this.lblSpecies.Text = "Species:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ComboKinship
            // 
            this.ComboKinship.FormattingEnabled = true;
            this.ComboKinship.Location = new System.Drawing.Point(237, 10);
            this.ComboKinship.Name = "ComboKinship";
            this.ComboKinship.Size = new System.Drawing.Size(121, 21);
            this.ComboKinship.TabIndex = 3;
            // 
            // lblKinship
            // 
            this.lblKinship.AutoSize = true;
            this.lblKinship.Location = new System.Drawing.Point(187, 13);
            this.lblKinship.Name = "lblKinship";
            this.lblKinship.Size = new System.Drawing.Size(44, 13);
            this.lblKinship.TabIndex = 2;
            this.lblKinship.Text = "Kinship:";
            // 
            // ComboJob
            // 
            this.ComboJob.FormattingEnabled = true;
            this.ComboJob.Location = new System.Drawing.Point(397, 10);
            this.ComboJob.Name = "ComboJob";
            this.ComboJob.Size = new System.Drawing.Size(121, 21);
            this.ComboJob.TabIndex = 5;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(364, 13);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(27, 13);
            this.lblJob.TabIndex = 4;
            this.lblJob.Text = "Job:";
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Location = new System.Drawing.Point(524, 8);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerate.TabIndex = 6;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.GenerateCharacter);
            // 
            // ButtonRandomCharacter
            // 
            this.ButtonRandomCharacter.Location = new System.Drawing.Point(605, 8);
            this.ButtonRandomCharacter.Name = "ButtonRandomCharacter";
            this.ButtonRandomCharacter.Size = new System.Drawing.Size(75, 23);
            this.ButtonRandomCharacter.TabIndex = 7;
            this.ButtonRandomCharacter.Text = "All Random";
            this.ButtonRandomCharacter.UseVisualStyleBackColor = true;
            this.ButtonRandomCharacter.Click += new System.EventHandler(this.GenerateRandomCharacter);
            // 
            // TextCharacterOutput
            // 
            this.TextCharacterOutput.Location = new System.Drawing.Point(9, 46);
            this.TextCharacterOutput.Multiline = true;
            this.TextCharacterOutput.Name = "TextCharacterOutput";
            this.TextCharacterOutput.Size = new System.Drawing.Size(671, 497);
            this.TextCharacterOutput.TabIndex = 8;
            // 
            // ButtonGenerateBySpecies
            // 
            this.ButtonGenerateBySpecies.Location = new System.Drawing.Point(685, 8);
            this.ButtonGenerateBySpecies.Name = "ButtonGenerateBySpecies";
            this.ButtonGenerateBySpecies.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerateBySpecies.TabIndex = 9;
            this.ButtonGenerateBySpecies.Text = "By Species";
            this.ButtonGenerateBySpecies.UseVisualStyleBackColor = true;
            this.ButtonGenerateBySpecies.Click += new System.EventHandler(this.GenerateCharacterBySpecies);
            // 
            // ButtonGenBySpeciesAndGroup
            // 
            this.ButtonGenBySpeciesAndGroup.Location = new System.Drawing.Point(685, 37);
            this.ButtonGenBySpeciesAndGroup.Name = "ButtonGenBySpeciesAndGroup";
            this.ButtonGenBySpeciesAndGroup.Size = new System.Drawing.Size(75, 38);
            this.ButtonGenBySpeciesAndGroup.TabIndex = 10;
            this.ButtonGenBySpeciesAndGroup.Text = "By Species And Kinship";
            this.ButtonGenBySpeciesAndGroup.UseVisualStyleBackColor = true;
            this.ButtonGenBySpeciesAndGroup.Click += new System.EventHandler(this.GenerateCharacterBySpeciesAndGroup);
            // 
            // ButtonGenerateByJob
            // 
            this.ButtonGenerateByJob.Location = new System.Drawing.Point(685, 81);
            this.ButtonGenerateByJob.Name = "ButtonGenerateByJob";
            this.ButtonGenerateByJob.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerateByJob.TabIndex = 11;
            this.ButtonGenerateByJob.Text = "By Job";
            this.ButtonGenerateByJob.UseVisualStyleBackColor = true;
            this.ButtonGenerateByJob.Click += new System.EventHandler(this.GenerateCharacterByJob);
            // 
            // OqoTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 599);
            this.Controls.Add(this.Frame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OqoTool";
            this.Text = "Oqo Tool [ALPHA]";
            this.Frame.ResumeLayout(false);
            this.PageCharacterGen.ResumeLayout(false);
            this.PageCharacterGen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Frame;
        private System.Windows.Forms.TabPage PageCharacterGen;
        private System.Windows.Forms.ComboBox ComboSpecies;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox ComboKinship;
        private System.Windows.Forms.Label lblKinship;
        private System.Windows.Forms.ComboBox ComboJob;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox TextCharacterOutput;
        private System.Windows.Forms.Button ButtonRandomCharacter;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Button ButtonGenerateByJob;
        private System.Windows.Forms.Button ButtonGenBySpeciesAndGroup;
        private System.Windows.Forms.Button ButtonGenerateBySpecies;
    }
}

