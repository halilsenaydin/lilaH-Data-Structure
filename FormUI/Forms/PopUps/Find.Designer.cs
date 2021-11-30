
namespace FormUI.Forms.PopUps
{
    partial class Find
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonFindByIndex = new System.Windows.Forms.Button();
            this.buttonFindByItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = "Veri Girşi Yok";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "Veri Girşi Yok";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Data,
            this.Type});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.NullValue = "Veri Girişi Yok";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGrid.Location = new System.Drawing.Point(12, 285);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(662, 153);
            this.dataGrid.TabIndex = 0;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(253, 68);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(184, 24);
            this.textBoxInput.TabIndex = 1;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("lilahFontBold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearch.Location = new System.Drawing.Point(292, 31);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(112, 21);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Ne Arıyorsun?";
            // 
            // buttonFindByIndex
            // 
            this.buttonFindByIndex.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFindByIndex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFindByIndex.Location = new System.Drawing.Point(119, 98);
            this.buttonFindByIndex.Name = "buttonFindByIndex";
            this.buttonFindByIndex.Size = new System.Drawing.Size(217, 23);
            this.buttonFindByIndex.TabIndex = 3;
            this.buttonFindByIndex.Text = "Index Numarasına Göre Arama Yap";
            this.buttonFindByIndex.UseVisualStyleBackColor = false;
            this.buttonFindByIndex.Click += new System.EventHandler(this.buttonFindByIndex_Click);
            // 
            // buttonFindByItem
            // 
            this.buttonFindByItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFindByItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFindByItem.Location = new System.Drawing.Point(352, 98);
            this.buttonFindByItem.Name = "buttonFindByItem";
            this.buttonFindByItem.Size = new System.Drawing.Size(217, 23);
            this.buttonFindByItem.TabIndex = 4;
            this.buttonFindByItem.Text = "Item Bul";
            this.buttonFindByItem.UseVisualStyleBackColor = false;
            this.buttonFindByItem.Click += new System.EventHandler(this.buttonFindByItem_Click);
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.buttonFindByItem);
            this.Controls.Add(this.buttonFindByIndex);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.dataGrid);
            this.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "Find";
            this.Text = "Find";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonFindByIndex;
        private System.Windows.Forms.Button buttonFindByItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}