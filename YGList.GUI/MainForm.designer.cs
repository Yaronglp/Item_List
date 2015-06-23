namespace YGList.GUI
{
    partial class MainForm
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
            this.LabelForListItem = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.changeFontBtn = new System.Windows.Forms.Button();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.emailDataBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.removeItemBtn = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // LabelForListItem
            // 
            this.LabelForListItem.AutoSize = true;
            this.LabelForListItem.Location = new System.Drawing.Point(13, 28);
            this.LabelForListItem.Name = "LabelForListItem";
            this.LabelForListItem.Size = new System.Drawing.Size(87, 16);
            this.LabelForListItem.TabIndex = 0;
            this.LabelForListItem.Text = "List of items:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(16, 61);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(190, 228);
            this.listBox.TabIndex = 7;
            // 
            // changeFontBtn
            // 
            this.changeFontBtn.BackColor = System.Drawing.SystemColors.Control;
            this.changeFontBtn.Location = new System.Drawing.Point(235, 220);
            this.changeFontBtn.Name = "changeFontBtn";
            this.changeFontBtn.Size = new System.Drawing.Size(115, 23);
            this.changeFontBtn.TabIndex = 5;
            this.changeFontBtn.Text = "Change Font";
            this.changeFontBtn.UseVisualStyleBackColor = true;
            this.changeFontBtn.Click += new System.EventHandler(this.changeFontBtn_Click);
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Location = new System.Drawing.Point(235, 191);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(115, 23);
            this.loadFileBtn.TabIndex = 4;
            this.loadFileBtn.Text = "Load File";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            this.loadFileBtn.Click += new System.EventHandler(this.loadFileBtn_Click);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(235, 162);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(115, 23);
            this.saveFileBtn.TabIndex = 3;
            this.saveFileBtn.Text = "Save File";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // emailDataBtn
            // 
            this.emailDataBtn.Location = new System.Drawing.Point(235, 266);
            this.emailDataBtn.Name = "emailDataBtn";
            this.emailDataBtn.Size = new System.Drawing.Size(115, 23);
            this.emailDataBtn.TabIndex = 6;
            this.emailDataBtn.Text = "Email it";
            this.emailDataBtn.UseVisualStyleBackColor = true;
            this.emailDataBtn.Click += new System.EventHandler(this.emailDataBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(235, 61);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(115, 23);
            this.addItemBtn.TabIndex = 1;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.Location = new System.Drawing.Point(235, 91);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.Size = new System.Drawing.Size(115, 23);
            this.removeItemBtn.TabIndex = 2;
            this.removeItemBtn.Text = "Remove Item";
            this.removeItemBtn.UseVisualStyleBackColor = true;
            this.removeItemBtn.Click += new System.EventHandler(this.removeItemBtn_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Arial", 10F);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 319);
            this.Controls.Add(this.removeItemBtn);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.emailDataBtn);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.loadFileBtn);
            this.Controls.Add(this.changeFontBtn);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.LabelForListItem);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YGList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelForListItem;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button changeFontBtn;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.Button emailDataBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button removeItemBtn;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

