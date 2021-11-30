
namespace FormUI.Forms.PopUps
{
    partial class Delete
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonDeleteByIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(123, 68);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(110, 24);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDeleteItem.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteItem.Location = new System.Drawing.Point(123, 158);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDeleteItem.Size = new System.Drawing.Size(110, 31);
            this.buttonDeleteItem.TabIndex = 4;
            this.buttonDeleteItem.Text = "Item\'leri Sil";
            this.buttonDeleteItem.UseVisualStyleBackColor = false;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // buttonDeleteByIndex
            // 
            this.buttonDeleteByIndex.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDeleteByIndex.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteByIndex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteByIndex.Location = new System.Drawing.Point(66, 120);
            this.buttonDeleteByIndex.Name = "buttonDeleteByIndex";
            this.buttonDeleteByIndex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDeleteByIndex.Size = new System.Drawing.Size(226, 32);
            this.buttonDeleteByIndex.TabIndex = 3;
            this.buttonDeleteByIndex.Text = "İndex Numarasına Göre Veri Sil";
            this.buttonDeleteByIndex.UseVisualStyleBackColor = false;
            this.buttonDeleteByIndex.Click += new System.EventHandler(this.buttonDeleteByIndex_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(361, 253);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonDeleteByIndex);
            this.Controls.Add(this.textBoxInput);
            this.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonDeleteByIndex;
    }
}