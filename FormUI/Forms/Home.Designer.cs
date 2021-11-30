
namespace FormUI.Forms
{
    partial class Home
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonCreateLilah = new System.Windows.Forms.Button();
            this.buttonInteger = new System.Windows.Forms.Button();
            this.buttonDouble = new System.Windows.Forms.Button();
            this.buttonString = new System.Windows.Forms.Button();
            this.labelCreateLilah = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.MenuText;
            this.labelTitle.Font = new System.Drawing.Font("lilahFontBold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Location = new System.Drawing.Point(243, 87);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(336, 21);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Bugünümüzü Yarınlar İçin Yaşıyoruz.. - lilah";
            // 
            // buttonCreateLilah
            // 
            this.buttonCreateLilah.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCreateLilah.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateLilah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreateLilah.Location = new System.Drawing.Point(203, 176);
            this.buttonCreateLilah.Name = "buttonCreateLilah";
            this.buttonCreateLilah.Size = new System.Drawing.Size(181, 56);
            this.buttonCreateLilah.TabIndex = 1;
            this.buttonCreateLilah.Text = "Lilah List Veri Yapısını Oluştur";
            this.buttonCreateLilah.UseVisualStyleBackColor = false;
            this.buttonCreateLilah.Click += new System.EventHandler(this.buttonCreateLilah_Click);
            // 
            // buttonInteger
            // 
            this.buttonInteger.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInteger.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInteger.Location = new System.Drawing.Point(446, 209);
            this.buttonInteger.Name = "buttonInteger";
            this.buttonInteger.Size = new System.Drawing.Size(43, 23);
            this.buttonInteger.TabIndex = 3;
            this.buttonInteger.Text = "int";
            this.buttonInteger.UseVisualStyleBackColor = false;
            this.buttonInteger.Click += new System.EventHandler(this.buttonInteger_Click);
            // 
            // buttonDouble
            // 
            this.buttonDouble.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDouble.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDouble.Location = new System.Drawing.Point(495, 209);
            this.buttonDouble.Name = "buttonDouble";
            this.buttonDouble.Size = new System.Drawing.Size(55, 23);
            this.buttonDouble.TabIndex = 4;
            this.buttonDouble.Text = "double";
            this.buttonDouble.UseVisualStyleBackColor = false;
            this.buttonDouble.Click += new System.EventHandler(this.buttonDouble_Click);
            // 
            // buttonString
            // 
            this.buttonString.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonString.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonString.Location = new System.Drawing.Point(556, 209);
            this.buttonString.Name = "buttonString";
            this.buttonString.Size = new System.Drawing.Size(51, 23);
            this.buttonString.TabIndex = 5;
            this.buttonString.Text = "string";
            this.buttonString.UseVisualStyleBackColor = false;
            this.buttonString.Click += new System.EventHandler(this.buttonString_Click);
            // 
            // labelCreateLilah
            // 
            this.labelCreateLilah.AutoSize = true;
            this.labelCreateLilah.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCreateLilah.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCreateLilah.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCreateLilah.ForeColor = System.Drawing.Color.White;
            this.labelCreateLilah.Location = new System.Drawing.Point(444, 176);
            this.labelCreateLilah.Name = "labelCreateLilah";
            this.labelCreateLilah.Padding = new System.Windows.Forms.Padding(7);
            this.labelCreateLilah.Size = new System.Drawing.Size(163, 31);
            this.labelCreateLilah.TabIndex = 6;
            this.labelCreateLilah.Text = "Lilah Veri Yapısını Oluştur";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCreateLilah);
            this.Controls.Add(this.buttonString);
            this.Controls.Add(this.buttonDouble);
            this.Controls.Add(this.buttonInteger);
            this.Controls.Add(this.buttonCreateLilah);
            this.Controls.Add(this.labelTitle);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonCreateLilah;
        private System.Windows.Forms.Button buttonInteger;
        private System.Windows.Forms.Button buttonDouble;
        private System.Windows.Forms.Button buttonString;
        private System.Windows.Forms.Label labelCreateLilah;
    }
}