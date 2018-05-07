namespace WindowsFormsApplication1
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
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.runQueryButton = new System.Windows.Forms.Button();
            this.clearResultsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commandTextBox
            // 
            this.commandTextBox.Location = new System.Drawing.Point(12, 12);
            this.commandTextBox.Multiline = true;
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(899, 144);
            this.commandTextBox.TabIndex = 0;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.resultTextBox.Location = new System.Drawing.Point(12, 191);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTextBox.Size = new System.Drawing.Size(899, 294);
            this.resultTextBox.TabIndex = 1;
            this.resultTextBox.WordWrap = false;
            // 
            // runQueryButton
            // 
            this.runQueryButton.Location = new System.Drawing.Point(12, 162);
            this.runQueryButton.Name = "runQueryButton";
            this.runQueryButton.Size = new System.Drawing.Size(75, 23);
            this.runQueryButton.TabIndex = 2;
            this.runQueryButton.Text = "Run Querry";
            this.runQueryButton.UseVisualStyleBackColor = true;
            this.runQueryButton.Click += new System.EventHandler(this.runQueryButton_Click);
            // 
            // clearResultsButton
            // 
            this.clearResultsButton.Location = new System.Drawing.Point(163, 162);
            this.clearResultsButton.Name = "clearResultsButton";
            this.clearResultsButton.Size = new System.Drawing.Size(91, 23);
            this.clearResultsButton.TabIndex = 3;
            this.clearResultsButton.Text = "Clear Results";
            this.clearResultsButton.UseVisualStyleBackColor = true;
            this.clearResultsButton.Click += new System.EventHandler(this.clearResultsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 497);
            this.Controls.Add(this.clearResultsButton);
            this.Controls.Add(this.runQueryButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.commandTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button runQueryButton;
        private System.Windows.Forms.Button clearResultsButton;
    }
}

