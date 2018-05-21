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
            this.newProductText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteProductText = new System.Windows.Forms.TextBox();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.changeForm = new System.Windows.Forms.Button();
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
            this.patchButton.Location = new System.Drawing.Point(102, 381);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(75, 30);
            this.patchButton.TabIndex = 2;
            this.patchButton.Text = "Aktualizuj";
            this.patchButton.UseVisualStyleBackColor = true;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // newProductText
            // 
            this.newProductText.Location = new System.Drawing.Point(205, 387);
            this.newProductText.Name = "newProductText";
            this.newProductText.Size = new System.Drawing.Size(189, 20);
            this.newProductText.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(429, 385);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteProductText
            // 
            this.deleteProductText.Location = new System.Drawing.Point(205, 413);
            this.deleteProductText.Name = "deleteProductText";
            this.deleteProductText.Size = new System.Drawing.Size(189, 20);
            this.deleteProductText.TabIndex = 5;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(429, 411);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.deleteProductButton.TabIndex = 6;
            this.deleteProductButton.Text = "Usun";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // changeForm
            // 
            this.changeForm.Location = new System.Drawing.Point(590, 431);
            this.changeForm.Name = "changeForm";
            this.changeForm.Size = new System.Drawing.Size(75, 23);
            this.changeForm.TabIndex = 7;
            this.changeForm.Text = ">";
            this.changeForm.UseVisualStyleBackColor = true;
            this.changeForm.Click += new System.EventHandler(this.changeForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 466);
            this.Controls.Add(this.changeForm);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.deleteProductText);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.newProductText);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.dataView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.Button patchButton;
        private System.Windows.Forms.TextBox newProductText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox deleteProductText;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button changeForm;
    }
}

