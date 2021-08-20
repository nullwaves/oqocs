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
            this.ButtonGenerateByJob = new System.Windows.Forms.Button();
            this.ButtonGenBySpeciesAndGroup = new System.Windows.Forms.Button();
            this.ButtonGenerateBySpecies = new System.Windows.Forms.Button();
            this.TextCharacterOutput = new System.Windows.Forms.TextBox();
            this.ButtonRandomCharacter = new System.Windows.Forms.Button();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.ComboJob = new System.Windows.Forms.ComboBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.ComboKinship = new System.Windows.Forms.ComboBox();
            this.lblKinship = new System.Windows.Forms.Label();
            this.ComboSpecies = new System.Windows.Forms.ComboBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.PageLangGen = new System.Windows.Forms.TabPage();
            this.TextWordOutput = new System.Windows.Forms.TextBox();
            this.ButtonGenerateWords = new System.Windows.Forms.Button();
            this.lblNumWords = new System.Windows.Forms.Label();
            this.TextNumWords = new System.Windows.Forms.TextBox();
            this.TextNumSyllables = new System.Windows.Forms.TextBox();
            this.lblSyllables = new System.Windows.Forms.Label();
            this.PageItemGen = new System.Windows.Forms.TabPage();
            this.TextItemOutput = new System.Windows.Forms.TextBox();
            this.ButtonGenerateItem = new System.Windows.Forms.Button();
            this.lblItemToBuild = new System.Windows.Forms.Label();
            this.ComboItemRecipes = new System.Windows.Forms.ComboBox();
            this.ButtonGenerateBySpeciesAndJob = new System.Windows.Forms.Button();
            this.Frame.SuspendLayout();
            this.PageCharacterGen.SuspendLayout();
            this.PageLangGen.SuspendLayout();
            this.PageItemGen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frame
            // 
            this.Frame.Controls.Add(this.PageCharacterGen);
            this.Frame.Controls.Add(this.PageLangGen);
            this.Frame.Controls.Add(this.PageItemGen);
            this.Frame.Location = new System.Drawing.Point(12, 12);
            this.Frame.Name = "Frame";
            this.Frame.SelectedIndex = 0;
            this.Frame.Size = new System.Drawing.Size(774, 575);
            this.Frame.TabIndex = 0;
            // 
            // PageCharacterGen
            // 
            this.PageCharacterGen.Controls.Add(this.ButtonGenerateBySpeciesAndJob);
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
            // TextCharacterOutput
            // 
            this.TextCharacterOutput.Location = new System.Drawing.Point(9, 46);
            this.TextCharacterOutput.Multiline = true;
            this.TextCharacterOutput.Name = "TextCharacterOutput";
            this.TextCharacterOutput.Size = new System.Drawing.Size(671, 497);
            this.TextCharacterOutput.TabIndex = 8;
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
            // PageLangGen
            // 
            this.PageLangGen.Controls.Add(this.TextWordOutput);
            this.PageLangGen.Controls.Add(this.ButtonGenerateWords);
            this.PageLangGen.Controls.Add(this.lblNumWords);
            this.PageLangGen.Controls.Add(this.TextNumWords);
            this.PageLangGen.Controls.Add(this.TextNumSyllables);
            this.PageLangGen.Controls.Add(this.lblSyllables);
            this.PageLangGen.Location = new System.Drawing.Point(4, 22);
            this.PageLangGen.Name = "PageLangGen";
            this.PageLangGen.Padding = new System.Windows.Forms.Padding(3);
            this.PageLangGen.Size = new System.Drawing.Size(766, 549);
            this.PageLangGen.TabIndex = 1;
            this.PageLangGen.Text = "Lang Gen.";
            this.PageLangGen.UseVisualStyleBackColor = true;
            // 
            // TextWordOutput
            // 
            this.TextWordOutput.Location = new System.Drawing.Point(11, 46);
            this.TextWordOutput.Multiline = true;
            this.TextWordOutput.Name = "TextWordOutput";
            this.TextWordOutput.Size = new System.Drawing.Size(671, 497);
            this.TextWordOutput.TabIndex = 9;
            // 
            // ButtonGenerateWords
            // 
            this.ButtonGenerateWords.Location = new System.Drawing.Point(257, 4);
            this.ButtonGenerateWords.Name = "ButtonGenerateWords";
            this.ButtonGenerateWords.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerateWords.TabIndex = 7;
            this.ButtonGenerateWords.Text = "Generate";
            this.ButtonGenerateWords.UseVisualStyleBackColor = true;
            this.ButtonGenerateWords.Click += new System.EventHandler(this.GenerateWords);
            // 
            // lblNumWords
            // 
            this.lblNumWords.AutoSize = true;
            this.lblNumWords.Location = new System.Drawing.Point(115, 9);
            this.lblNumWords.Name = "lblNumWords";
            this.lblNumWords.Size = new System.Drawing.Size(63, 13);
            this.lblNumWords.TabIndex = 5;
            this.lblNumWords.Text = "# of Words:";
            // 
            // TextNumWords
            // 
            this.TextNumWords.Location = new System.Drawing.Point(184, 6);
            this.TextNumWords.Name = "TextNumWords";
            this.TextNumWords.Size = new System.Drawing.Size(67, 20);
            this.TextNumWords.TabIndex = 4;
            // 
            // TextNumSyllables
            // 
            this.TextNumSyllables.Location = new System.Drawing.Point(62, 6);
            this.TextNumSyllables.Name = "TextNumSyllables";
            this.TextNumSyllables.Size = new System.Drawing.Size(47, 20);
            this.TextNumSyllables.TabIndex = 3;
            // 
            // lblSyllables
            // 
            this.lblSyllables.AutoSize = true;
            this.lblSyllables.Location = new System.Drawing.Point(8, 9);
            this.lblSyllables.Name = "lblSyllables";
            this.lblSyllables.Size = new System.Drawing.Size(48, 13);
            this.lblSyllables.TabIndex = 2;
            this.lblSyllables.Text = "Syllables";
            // 
            // PageItemGen
            // 
            this.PageItemGen.Controls.Add(this.TextItemOutput);
            this.PageItemGen.Controls.Add(this.ButtonGenerateItem);
            this.PageItemGen.Controls.Add(this.lblItemToBuild);
            this.PageItemGen.Controls.Add(this.ComboItemRecipes);
            this.PageItemGen.Location = new System.Drawing.Point(4, 22);
            this.PageItemGen.Name = "PageItemGen";
            this.PageItemGen.Size = new System.Drawing.Size(766, 549);
            this.PageItemGen.TabIndex = 2;
            this.PageItemGen.Text = "Item Builder";
            this.PageItemGen.UseVisualStyleBackColor = true;
            // 
            // TextItemOutput
            // 
            this.TextItemOutput.Location = new System.Drawing.Point(3, 36);
            this.TextItemOutput.Multiline = true;
            this.TextItemOutput.Name = "TextItemOutput";
            this.TextItemOutput.Size = new System.Drawing.Size(671, 497);
            this.TextItemOutput.TabIndex = 10;
            // 
            // ButtonGenerateItem
            // 
            this.ButtonGenerateItem.Location = new System.Drawing.Point(175, 9);
            this.ButtonGenerateItem.Name = "ButtonGenerateItem";
            this.ButtonGenerateItem.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerateItem.TabIndex = 8;
            this.ButtonGenerateItem.Text = "Generate";
            this.ButtonGenerateItem.UseVisualStyleBackColor = true;
            this.ButtonGenerateItem.Click += new System.EventHandler(this.BuildItem);
            // 
            // lblItemToBuild
            // 
            this.lblItemToBuild.AutoSize = true;
            this.lblItemToBuild.Location = new System.Drawing.Point(12, 12);
            this.lblItemToBuild.Name = "lblItemToBuild";
            this.lblItemToBuild.Size = new System.Drawing.Size(30, 13);
            this.lblItemToBuild.TabIndex = 1;
            this.lblItemToBuild.Text = "Item:";
            // 
            // ComboItemRecipes
            // 
            this.ComboItemRecipes.FormattingEnabled = true;
            this.ComboItemRecipes.Location = new System.Drawing.Point(48, 9);
            this.ComboItemRecipes.Name = "ComboItemRecipes";
            this.ComboItemRecipes.Size = new System.Drawing.Size(121, 21);
            this.ComboItemRecipes.TabIndex = 0;
            // 
            // ButtonGenerateBySpeciesAndJob
            // 
            this.ButtonGenerateBySpeciesAndJob.Location = new System.Drawing.Point(685, 110);
            this.ButtonGenerateBySpeciesAndJob.Name = "ButtonGenerateBySpeciesAndJob";
            this.ButtonGenerateBySpeciesAndJob.Size = new System.Drawing.Size(75, 38);
            this.ButtonGenerateBySpeciesAndJob.TabIndex = 12;
            this.ButtonGenerateBySpeciesAndJob.Text = "By Species And Job";
            this.ButtonGenerateBySpeciesAndJob.UseVisualStyleBackColor = true;
            this.ButtonGenerateBySpeciesAndJob.Click += new System.EventHandler(this.GenerateCharacterBySpeciesAndJob);
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
            this.PageLangGen.ResumeLayout(false);
            this.PageLangGen.PerformLayout();
            this.PageItemGen.ResumeLayout(false);
            this.PageItemGen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Frame;
        private System.Windows.Forms.TabPage PageCharacterGen;
        private System.Windows.Forms.ComboBox ComboSpecies;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.TabPage PageLangGen;
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
        private System.Windows.Forms.TextBox TextNumSyllables;
        private System.Windows.Forms.Label lblSyllables;
        private System.Windows.Forms.Button ButtonGenerateWords;
        private System.Windows.Forms.Label lblNumWords;
        private System.Windows.Forms.TextBox TextNumWords;
        private System.Windows.Forms.TextBox TextWordOutput;
        private System.Windows.Forms.TabPage PageItemGen;
        private System.Windows.Forms.TextBox TextItemOutput;
        private System.Windows.Forms.Button ButtonGenerateItem;
        private System.Windows.Forms.Label lblItemToBuild;
        private System.Windows.Forms.ComboBox ComboItemRecipes;
        private System.Windows.Forms.Button ButtonGenerateBySpeciesAndJob;
    }
}

