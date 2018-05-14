namespace WindowsFormsApplication2
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
            this.dataView = new System.Windows.Forms.DataGridView();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.patchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(12, 12);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(653, 363);
            this.dataView.TabIndex = 0;
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(12, 381);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(84, 30);
            this.loadDataButton.TabIndex = 1;
            this.loadDataButton.Text = "Wczytaj Dane";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // patchButton
            // 
            this.patchButton.Location = new System.Drawing.Point(590, 381);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(75, 30);
            this.patchButton.TabIndex = 2;
            this.patchButton.Text = "Aktualizuj";
            this.patchButton.UseVisualStyleBackColor = true;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 423);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.dataView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.Button patchButton;
    }
}

