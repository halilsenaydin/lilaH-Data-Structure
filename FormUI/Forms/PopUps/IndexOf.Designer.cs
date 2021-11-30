
namespace FormUI.Forms.PopUps
{
    partial class IndexOf
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
            this.labelCaption = new System.Windows.Forms.Label();
            this.buttonIndexOf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.Location = new System.Drawing.Point(87, 73);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 24);
            this.textBoxInput.TabIndex = 0;
            // 
            // labelCaption
            // 
            this.labelCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCaption.AutoSize = true;
            this.labelCaption.Location = new System.Drawing.Point(108, 55);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(63, 15);
            this.labelCaption.TabIndex = 1;
            this.labelCaption.Text = "Item Girin";
            // 
            // buttonIndexOf
            // 
            this.buttonIndexOf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIndexOf.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonIndexOf.ForeColor = System.Drawing.Color.Black;
            this.buttonIndexOf.Location = new System.Drawing.Point(52, 103);
            this.buttonIndexOf.Name = "buttonIndexOf";
            this.buttonIndexOf.Size = new System.Drawing.Size(193, 23);
            this.buttonIndexOf.TabIndex = 2;
            this.buttonIndexOf.Text = "Item\'in Index Numarasını Getir";
            this.buttonIndexOf.UseVisualStyleBackColor = false;
            this.buttonIndexOf.Click += new System.EventHandler(this.buttonIndexOf_Click);
            // 
            // IndexOf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(293, 197);
            this.Controls.Add(this.buttonIndexOf);
            this.Controls.Add(this.labelCaption);
            this.Controls.Add(this.textBoxInput);
            this.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "IndexOf";
            this.Text = "IndexOf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Button buttonIndexOf;
    }
}