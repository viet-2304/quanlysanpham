
namespace _102190248_PhamSiViet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Show = new System.Windows.Forms.Button();
            this.BTAdd = new System.Windows.Forms.Button();
            this.BTEdit = new System.Windows.Forms.Button();
            this.BTDelete = new System.Windows.Forms.Button();
            this.BTSort = new System.Windows.Forms.Button();
            this.CBSort = new System.Windows.Forms.ComboBox();
            this.CBTinh = new System.Windows.Forms.ComboBox();
            this.CBNhaCC = new System.Windows.Forms.ComboBox();
            this.TBSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(983, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tinh/TP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(44, 386);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(80, 36);
            this.Show.TabIndex = 5;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // BTAdd
            // 
            this.BTAdd.Location = new System.Drawing.Point(163, 386);
            this.BTAdd.Name = "BTAdd";
            this.BTAdd.Size = new System.Drawing.Size(80, 36);
            this.BTAdd.TabIndex = 6;
            this.BTAdd.Text = "Add";
            this.BTAdd.UseVisualStyleBackColor = true;
            this.BTAdd.Click += new System.EventHandler(this.BTAdd_Click);
            // 
            // BTEdit
            // 
            this.BTEdit.Location = new System.Drawing.Point(286, 386);
            this.BTEdit.Name = "BTEdit";
            this.BTEdit.Size = new System.Drawing.Size(80, 36);
            this.BTEdit.TabIndex = 7;
            this.BTEdit.Text = "Edit";
            this.BTEdit.UseVisualStyleBackColor = true;
            this.BTEdit.Click += new System.EventHandler(this.BTEdit_Click);
            // 
            // BTDelete
            // 
            this.BTDelete.Location = new System.Drawing.Point(403, 386);
            this.BTDelete.Name = "BTDelete";
            this.BTDelete.Size = new System.Drawing.Size(80, 36);
            this.BTDelete.TabIndex = 8;
            this.BTDelete.Text = "Del";
            this.BTDelete.UseVisualStyleBackColor = true;
            this.BTDelete.Click += new System.EventHandler(this.BTDelete_Click);
            // 
            // BTSort
            // 
            this.BTSort.Location = new System.Drawing.Point(517, 386);
            this.BTSort.Name = "BTSort";
            this.BTSort.Size = new System.Drawing.Size(80, 36);
            this.BTSort.TabIndex = 9;
            this.BTSort.Text = "Sort";
            this.BTSort.UseVisualStyleBackColor = true;
            this.BTSort.Click += new System.EventHandler(this.BTSort_Click);
            // 
            // CBSort
            // 
            this.CBSort.FormattingEnabled = true;
            this.CBSort.Location = new System.Drawing.Point(616, 391);
            this.CBSort.Name = "CBSort";
            this.CBSort.Size = new System.Drawing.Size(121, 28);
            this.CBSort.TabIndex = 10;
            // 
            // CBTinh
            // 
            this.CBTinh.FormattingEnabled = true;
            this.CBTinh.Location = new System.Drawing.Point(108, 32);
            this.CBTinh.Name = "CBTinh";
            this.CBTinh.Size = new System.Drawing.Size(121, 28);
            this.CBTinh.TabIndex = 11;
            this.CBTinh.SelectedIndexChanged += new System.EventHandler(this.CBTinh_SelectedIndexChanged);
            // 
            // CBNhaCC
            // 
            this.CBNhaCC.FormattingEnabled = true;
            this.CBNhaCC.Location = new System.Drawing.Point(414, 32);
            this.CBNhaCC.Name = "CBNhaCC";
            this.CBNhaCC.Size = new System.Drawing.Size(121, 28);
            this.CBNhaCC.TabIndex = 12;
            // 
            // TBSearch
            // 
            this.TBSearch.Location = new System.Drawing.Point(652, 40);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(100, 26);
            this.TBSearch.TabIndex = 13;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 446);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.CBNhaCC);
            this.Controls.Add(this.CBTinh);
            this.Controls.Add(this.CBSort);
            this.Controls.Add(this.BTSort);
            this.Controls.Add(this.BTDelete);
            this.Controls.Add(this.BTEdit);
            this.Controls.Add(this.BTAdd);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button BTAdd;
        private System.Windows.Forms.Button BTEdit;
        private System.Windows.Forms.Button BTDelete;
        private System.Windows.Forms.Button BTSort;
        private System.Windows.Forms.ComboBox CBSort;
        private System.Windows.Forms.ComboBox CBTinh;
        private System.Windows.Forms.ComboBox CBNhaCC;
        private System.Windows.Forms.TextBox TBSearch;
    }
}

