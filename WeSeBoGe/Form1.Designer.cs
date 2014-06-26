namespace WeSeBoGe
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
            this.selectBook = new System.Windows.Forms.ListBox();
            this.newItem = new System.Windows.Forms.Button();
            this.selectItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectBook
            // 
            this.selectBook.FormattingEnabled = true;
            this.selectBook.HorizontalScrollbar = true;
            this.selectBook.Location = new System.Drawing.Point(78, 12);
            this.selectBook.Name = "selectBook";
            this.selectBook.Size = new System.Drawing.Size(120, 95);
            this.selectBook.TabIndex = 0;
            // 
            // newItem
            // 
            this.newItem.Location = new System.Drawing.Point(78, 142);
            this.newItem.Name = "newItem";
            this.newItem.Size = new System.Drawing.Size(120, 23);
            this.newItem.TabIndex = 1;
            this.newItem.Text = "New";
            this.newItem.UseVisualStyleBackColor = true;
            this.newItem.Click += new System.EventHandler(this.newItem_Click);
            // 
            // selectItem
            // 
            this.selectItem.Location = new System.Drawing.Point(78, 113);
            this.selectItem.Name = "selectItem";
            this.selectItem.Size = new System.Drawing.Size(120, 23);
            this.selectItem.TabIndex = 2;
            this.selectItem.Text = "Select";
            this.selectItem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.selectItem);
            this.Controls.Add(this.newItem);
            this.Controls.Add(this.selectBook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox selectBook;
        private System.Windows.Forms.Button newItem;
        private System.Windows.Forms.Button selectItem;
    }
}