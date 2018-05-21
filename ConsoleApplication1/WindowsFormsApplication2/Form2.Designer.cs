namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.changeForm = new System.Windows.Forms.Button();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.dataView2 = new System.Windows.Forms.DataGridView();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView2)).BeginInit();
            this.SuspendLayout();
            // 
            // changeForm
            // 
            this.changeForm.Location = new System.Drawing.Point(6, 440);
            this.changeForm.Name = "changeForm";
            this.changeForm.Size = new System.Drawing.Size(75, 23);
            this.changeForm.TabIndex = 15;
            this.changeForm.Text = "<";
            this.changeForm.UseVisualStyleBackColor = true;
            this.changeForm.Click += new System.EventHandler(this.changeForm_Click);
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(6, 386);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(84, 30);
            this.loadDataButton.TabIndex = 9;
            this.loadDataButton.Text = "Wczytaj Dane";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(6, 17);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(223, 363);
            this.dataView.TabIndex = 8;
            // 
            // dataView2
            // 
            this.dataView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView2.Location = new System.Drawing.Point(270, 17);
            this.dataView2.Name = "dataView2";
            this.dataView2.Size = new System.Drawing.Size(223, 363);
            this.dataView2.TabIndex = 16;
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(270, 386);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoriesComboBox.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 475);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.dataView2);
            this.Controls.Add(this.changeForm);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.dataView);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeForm;
        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.DataGridView dataView2;
        private System.Windows.Forms.ComboBox categoriesComboBox;
    }
}