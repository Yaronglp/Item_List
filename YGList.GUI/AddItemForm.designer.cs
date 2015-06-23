namespace YGList.GUI
{
    partial class AddItemForm
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
            this.newItemTextBox = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.Label();
            this.addNewItemBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newItemTextBox
            // 
            this.newItemTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newItemTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.newItemTextBox.Location = new System.Drawing.Point(99, 27);
            this.newItemTextBox.Name = "newItemTextBox";
            this.newItemTextBox.Size = new System.Drawing.Size(313, 26);
            this.newItemTextBox.TabIndex = 0;
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(12, 32);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(81, 16);
            this.itemName.TabIndex = 1;
            this.itemName.Text = "Item Name:";
            // 
            // addNewItemBtn
            // 
            this.addNewItemBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.addNewItemBtn.Location = new System.Drawing.Point(180, 82);
            this.addNewItemBtn.Name = "addNewItemBtn";
            this.addNewItemBtn.Size = new System.Drawing.Size(75, 25);
            this.addNewItemBtn.TabIndex = 2;
            this.addNewItemBtn.Text = "Add";
            this.addNewItemBtn.UseVisualStyleBackColor = true;
            this.addNewItemBtn.Click += new System.EventHandler(this.addNewItemBtn_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 119);
            this.Controls.Add(this.addNewItemBtn);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.newItemTextBox);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newItemTextBox;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Button addNewItemBtn;
    }
}