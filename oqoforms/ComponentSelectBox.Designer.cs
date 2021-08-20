namespace oqoforms
{
    partial class ComponentSelectBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentSelectBox));
            this.lblStack = new System.Windows.Forms.Label();
            this.TextItemStack = new System.Windows.Forms.Label();
            this.ComboComponent = new System.Windows.Forms.ComboBox();
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStack
            // 
            this.lblStack.AutoSize = true;
            this.lblStack.Location = new System.Drawing.Point(12, 9);
            this.lblStack.Name = "lblStack";
            this.lblStack.Size = new System.Drawing.Size(64, 13);
            this.lblStack.TabIndex = 0;
            this.lblStack.Text = "Build Stack:";
            // 
            // TextItemStack
            // 
            this.TextItemStack.AutoSize = true;
            this.TextItemStack.Location = new System.Drawing.Point(82, 9);
            this.TextItemStack.Name = "TextItemStack";
            this.TextItemStack.Size = new System.Drawing.Size(101, 13);
            this.TextItemStack.TabIndex = 1;
            this.TextItemStack.Text = "Stack > Component";
            // 
            // ComboComponent
            // 
            this.ComboComponent.FormattingEnabled = true;
            this.ComboComponent.Location = new System.Drawing.Point(20, 41);
            this.ComboComponent.Name = "ComboComponent";
            this.ComboComponent.Size = new System.Drawing.Size(299, 21);
            this.ComboComponent.TabIndex = 2;
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.Location = new System.Drawing.Point(325, 41);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(75, 23);
            this.ButtonSelect.TabIndex = 3;
            this.ButtonSelect.Text = "Go";
            this.ButtonSelect.UseVisualStyleBackColor = true;
            this.ButtonSelect.Click += new System.EventHandler(this.SelectComponent);
            // 
            // ComponentSelectBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 91);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonSelect);
            this.Controls.Add(this.ComboComponent);
            this.Controls.Add(this.TextItemStack);
            this.Controls.Add(this.lblStack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComponentSelectBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Component Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStack;
        private System.Windows.Forms.Label TextItemStack;
        private System.Windows.Forms.ComboBox ComboComponent;
        private System.Windows.Forms.Button ButtonSelect;
    }
}