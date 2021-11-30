
namespace FormUI.Forms.PopUps
{
    partial class Extend
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
            this.buttonAppendDigit = new System.Windows.Forms.Button();
            this.buttonAppendInteger = new System.Windows.Forms.Button();
            this.buttonAppendString = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonExtend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAppendDigit
            // 
            this.buttonAppendDigit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAppendDigit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonAppendDigit.Location = new System.Drawing.Point(171, 102);
            this.buttonAppendDigit.Name = "buttonAppendDigit";
            this.buttonAppendDigit.Size = new System.Drawing.Size(84, 23);
            this.buttonAppendDigit.TabIndex = 7;
            this.buttonAppendDigit.Text = "Ondalıklı Sayı";
            this.buttonAppendDigit.UseVisualStyleBackColor = false;
            this.buttonAppendDigit.Click += new System.EventHandler(this.buttonAppendDigit_Click);
            // 
            // buttonAppendInteger
            // 
            this.buttonAppendInteger.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAppendInteger.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonAppendInteger.Location = new System.Drawing.Point(97, 102);
            this.buttonAppendInteger.Name = "buttonAppendInteger";
            this.buttonAppendInteger.Size = new System.Drawing.Size(68, 23);
            this.buttonAppendInteger.TabIndex = 6;
            this.buttonAppendInteger.Text = "Tam Sayı";
            this.buttonAppendInteger.UseVisualStyleBackColor = false;
            this.buttonAppendInteger.Click += new System.EventHandler(this.buttonAppendInteger_Click);
            // 
            // buttonAppendString
            // 
            this.buttonAppendString.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAppendString.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonAppendString.Location = new System.Drawing.Point(45, 102);
            this.buttonAppendString.Name = "buttonAppendString";
            this.buttonAppendString.Size = new System.Drawing.Size(46, 23);
            this.buttonAppendString.TabIndex = 5;
            this.buttonAppendString.Text = "Metin";
            this.buttonAppendString.UseVisualStyleBackColor = false;
            this.buttonAppendString.Click += new System.EventHandler(this.buttonAppendString_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(97, 62);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(105, 24);
            this.textBoxInput.TabIndex = 4;
            // 
            // buttonExtend
            // 
            this.buttonExtend.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonExtend.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonExtend.Location = new System.Drawing.Point(97, 150);
            this.buttonExtend.Name = "buttonExtend";
            this.buttonExtend.Size = new System.Drawing.Size(101, 23);
            this.buttonExtend.TabIndex = 8;
            this.buttonExtend.Text = "Verileri Gönder";
            this.buttonExtend.UseVisualStyleBackColor = false;
            this.buttonExtend.Click += new System.EventHandler(this.buttonExtend_Click);
            // 
            // Extend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(293, 197);
            this.Controls.Add(this.buttonExtend);
            this.Controls.Add(this.buttonAppendDigit);
            this.Controls.Add(this.buttonAppendInteger);
            this.Controls.Add(this.buttonAppendString);
            this.Controls.Add(this.textBoxInput);
            this.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "Extend";
            this.Text = "Extend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAppendDigit;
        private System.Windows.Forms.Button buttonAppendInteger;
        private System.Windows.Forms.Button buttonAppendString;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonExtend;
    }
}