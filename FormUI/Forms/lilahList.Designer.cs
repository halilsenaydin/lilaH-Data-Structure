
namespace FormUI.Forms
{
    partial class LilahList
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
            this.buttonAppend = new System.Windows.Forms.Button();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonAppendFromExcel = new System.Windows.Forms.Button();
            this.buttonAppendFromArray = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonUpdateAll = new System.Windows.Forms.Button();
            this.buttonIndexOf = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonGoHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAppend
            // 
            this.buttonAppend.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAppend.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAppend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAppend.Location = new System.Drawing.Point(147, 43);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAppend.Size = new System.Drawing.Size(75, 31);
            this.buttonAppend.TabIndex = 0;
            this.buttonAppend.Text = "Veri Ekle";
            this.buttonAppend.UseVisualStyleBackColor = false;
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDeleteAll.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteAll.Location = new System.Drawing.Point(238, 117);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDeleteAll.Size = new System.Drawing.Size(75, 31);
            this.buttonDeleteAll.TabIndex = 3;
            this.buttonDeleteAll.Text = "Tümünü Sil";
            this.buttonDeleteAll.UseVisualStyleBackColor = false;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonShow.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonShow.Location = new System.Drawing.Point(147, 153);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonShow.Size = new System.Drawing.Size(118, 31);
            this.buttonShow.TabIndex = 4;
            this.buttonShow.Text = "Verileri Listele";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFind.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFind.Location = new System.Drawing.Point(147, 80);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonFind.Size = new System.Drawing.Size(210, 30);
            this.buttonFind.TabIndex = 5;
            this.buttonFind.Text = "Veri(ler) Bul";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonAppendFromExcel
            // 
            this.buttonAppendFromExcel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAppendFromExcel.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAppendFromExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAppendFromExcel.Location = new System.Drawing.Point(228, 43);
            this.buttonAppendFromExcel.Name = "buttonAppendFromExcel";
            this.buttonAppendFromExcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAppendFromExcel.Size = new System.Drawing.Size(177, 31);
            this.buttonAppendFromExcel.TabIndex = 9;
            this.buttonAppendFromExcel.Text = "Excel Dosyasından Veri Ekle";
            this.buttonAppendFromExcel.UseVisualStyleBackColor = false;
            // 
            // buttonAppendFromArray
            // 
            this.buttonAppendFromArray.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAppendFromArray.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAppendFromArray.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAppendFromArray.Location = new System.Drawing.Point(411, 43);
            this.buttonAppendFromArray.Name = "buttonAppendFromArray";
            this.buttonAppendFromArray.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAppendFromArray.Size = new System.Drawing.Size(186, 31);
            this.buttonAppendFromArray.TabIndex = 10;
            this.buttonAppendFromArray.Text = "Toplu Veri Girişi Yaparak Ekle";
            this.buttonAppendFromArray.UseVisualStyleBackColor = false;
            this.buttonAppendFromArray.Click += new System.EventHandler(this.buttonAppendFromArray_Click);
            // 
            // dataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "Veri Girişi Yok";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "Veri Girişi Yok";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Data,
            this.Type});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.NullValue = "Veri Girişi Yok";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGrid.Location = new System.Drawing.Point(12, 311);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGrid.RowTemplate.DefaultCellStyle.NullValue = "Veri Yok";
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(776, 127);
            this.dataGrid.TabIndex = 12;
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
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUpdate.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUpdate.Location = new System.Drawing.Point(147, 190);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonUpdate.Size = new System.Drawing.Size(95, 31);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Veri Güncelle";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonUpdateAll
            // 
            this.buttonUpdateAll.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUpdateAll.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdateAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUpdateAll.Location = new System.Drawing.Point(248, 190);
            this.buttonUpdateAll.Name = "buttonUpdateAll";
            this.buttonUpdateAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonUpdateAll.Size = new System.Drawing.Size(109, 31);
            this.buttonUpdateAll.TabIndex = 14;
            this.buttonUpdateAll.Text = "Bul ve Değiştir";
            this.buttonUpdateAll.UseVisualStyleBackColor = false;
            // 
            // buttonIndexOf
            // 
            this.buttonIndexOf.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonIndexOf.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIndexOf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonIndexOf.Location = new System.Drawing.Point(363, 190);
            this.buttonIndexOf.Name = "buttonIndexOf";
            this.buttonIndexOf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonIndexOf.Size = new System.Drawing.Size(196, 31);
            this.buttonIndexOf.TabIndex = 15;
            this.buttonIndexOf.Text = "Item\'in Index Numarasını Getir";
            this.buttonIndexOf.UseVisualStyleBackColor = false;
            this.buttonIndexOf.Click += new System.EventHandler(this.buttonIndexOf_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDelete.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDelete.Location = new System.Drawing.Point(147, 116);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDelete.Size = new System.Drawing.Size(85, 31);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Veri(ler) Sil";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonGoHome
            // 
            this.buttonGoHome.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGoHome.Font = new System.Drawing.Font("lilahFontBold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGoHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGoHome.Location = new System.Drawing.Point(679, 274);
            this.buttonGoHome.Name = "buttonGoHome";
            this.buttonGoHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGoHome.Size = new System.Drawing.Size(109, 31);
            this.buttonGoHome.TabIndex = 17;
            this.buttonGoHome.Text = "Eve Dön :..(";
            this.buttonGoHome.UseVisualStyleBackColor = false;
            this.buttonGoHome.Click += new System.EventHandler(this.buttonGoHome_Click);
            // 
            // LilahList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGoHome);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonIndexOf);
            this.Controls.Add(this.buttonUpdateAll);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.buttonAppendFromArray);
            this.Controls.Add(this.buttonAppendFromExcel);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.buttonAppend);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "LilahList";
            this.Text = "LilahList Data Structure ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAppend;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonAppendFromExcel;
        private System.Windows.Forms.Button buttonAppendFromArray;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonUpdateAll;
        private System.Windows.Forms.Button buttonIndexOf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonGoHome;
    }
}