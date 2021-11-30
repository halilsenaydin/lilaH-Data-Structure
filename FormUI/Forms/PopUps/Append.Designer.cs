
namespace FormUI.Forms.PopUps
{
    partial class Append
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
            this.buttonAppendString = new System.Windows.Forms.Button();
            this.buttonAppendInteger = new System.Windows.Forms.Button();
            this.buttonAppendDigit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(97, 60);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(110, 24);
            this.textBoxInput.TabIndex = 0;
            // 
            // buttonAppendString
            // 
            this.buttonAppendString.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAppendString.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonAppendString.Location = new System.Drawing.Point(56, 90);
            this.buttonAppendString.Name = "buttonAppendString";
            this.buttonAppendString.Size = new System.Drawing.Size(45, 23);
            this.buttonAppendString.TabIndex = 1;
            this.buttonAppendString.Text = "Metin";
            this.buttonAppendString.UseVisualStyleBackColor = false;
            this.buttonAppendString.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // buttonAppendInteger
            // 
            this.buttonAppendInteger.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAppendInteger.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonAppendInteger.Location = new System.Drawing.Point(107, 90);
            this.buttonAppendInteger.Name = "buttonAppendInteger";
            this.buttonAppendInteger.Size = new System.Drawing.Size(61, 23);
            this.buttonAppendInteger.TabIndex = 2;
            this.buttonAppendInteger.Text = "Tam Sayı";
            this.buttonAppendInteger.UseVisualStyleBackColor = false;
            this.buttonAppendInteger.Click += new System.EventHandler(this.buttonAppendInteger_Click);
            // 
            // buttonAppendDigit
            // 
            this.buttonAppendDigit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAppendDigit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonAppendDigit.Location = new System.Drawing.Point(174, 90);
            this.buttonAppendDigit.Name = "buttonAppendDigit";
            this.buttonAppendDigit.Size = new System.Drawing.Size(82, 23);
            this.buttonAppendDigit.TabIndex = 3;
            this.buttonAppendDigit.Text = "Ondalıklı Sayı";
            this.buttonAppendDigit.UseVisualStyleBackColor = false;
            this.buttonAppendDigit.Click += new System.EventHandler(this.buttonAppendDigit_Click);
            // 
            // Append
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(293, 197);
            this.Controls.Add(this.buttonAppendDigit);
            this.Controls.Add(this.buttonAppendInteger);
            this.Controls.Add(this.buttonAppendString);
            this.Controls.Add(this.textBoxInput);
            this.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "Append";
            this.Text = "Append";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonAppendString;
        private System.Windows.Forms.Button buttonAppendInteger;
        private System.Windows.Forms.Button buttonAppendDigit;
    }
}