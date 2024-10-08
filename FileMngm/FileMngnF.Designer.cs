namespace FileMngm
{
    partial class frmFileMngm
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
            this.btnConv = new System.Windows.Forms.Button();
            this.dgCars = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnDSearch = new System.Windows.Forms.Button();
            this.lblDS = new System.Windows.Forms.Label();
            this.btnHash = new System.Windows.Forms.Button();
            this.lblHash = new System.Windows.Forms.Label();
            this.dgErr = new System.Windows.Forms.DataGridView();
            this.CErr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExtSort = new System.Windows.Forms.Button();
            this.odCars = new System.Windows.Forms.OpenFileDialog();
            this.CMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.binarySearchInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgErr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConv
            // 
            this.btnConv.Location = new System.Drawing.Point(0, 0);
            this.btnConv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConv.Name = "btnConv";
            this.btnConv.Size = new System.Drawing.Size(226, 50);
            this.btnConv.TabIndex = 0;
            this.btnConv.Text = "Преобразовать";
            this.btnConv.UseVisualStyleBackColor = true;
            this.btnConv.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgCars
            // 
            this.dgCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CMark,
            this.CV,
            this.CS});
            this.dgCars.Location = new System.Drawing.Point(24, 81);
            this.dgCars.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgCars.Name = "dgCars";
            this.dgCars.RowHeadersWidth = 82;
            this.dgCars.Size = new System.Drawing.Size(1122, 548);
            this.dgCars.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(279, 0);
            this.btnShow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(226, 50);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Показать";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(538, 4);
            this.btnSort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(246, 44);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnDSearch
            // 
            this.btnDSearch.Location = new System.Drawing.Point(1173, 79);
            this.btnDSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDSearch.Name = "btnDSearch";
            this.btnDSearch.Size = new System.Drawing.Size(208, 42);
            this.btnDSearch.TabIndex = 4;
            this.btnDSearch.Text = "Найти";
            this.btnDSearch.UseVisualStyleBackColor = true;
            this.btnDSearch.Click += new System.EventHandler(this.btnDSearch_Click);
            // 
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.Location = new System.Drawing.Point(1180, 194);
            this.lblDS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(0, 25);
            this.lblDS.TabIndex = 5;
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(1383, 81);
            this.btnHash.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(206, 40);
            this.btnHash.TabIndex = 6;
            this.btnHash.Text = "Хэш";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(1408, 13);
            this.lblHash.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(0, 25);
            this.lblHash.TabIndex = 7;
            // 
            // dgErr
            // 
            this.dgErr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgErr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CErr});
            this.dgErr.Location = new System.Drawing.Point(1601, 81);
            this.dgErr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgErr.Name = "dgErr";
            this.dgErr.RowHeadersWidth = 82;
            this.dgErr.Size = new System.Drawing.Size(676, 542);
            this.dgErr.TabIndex = 8;
            // 
            // CErr
            // 
            this.CErr.HeaderText = "Ошибка";
            this.CErr.MinimumWidth = 10;
            this.CErr.Name = "CErr";
            this.CErr.Width = 500;
            // 
            // btnExtSort
            // 
            this.btnExtSort.Location = new System.Drawing.Point(996, 6);
            this.btnExtSort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExtSort.Name = "btnExtSort";
            this.btnExtSort.Size = new System.Drawing.Size(150, 44);
            this.btnExtSort.TabIndex = 9;
            this.btnExtSort.Text = "ExtSort";
            this.btnExtSort.UseVisualStyleBackColor = true;
            this.btnExtSort.Click += new System.EventHandler(this.btnExtSort_Click);
            // 
            // odCars
            // 
            this.odCars.FileName = "openFileDialog1";
            // 
            // CMark
            // 
            this.CMark.HeaderText = "Модель";
            this.CMark.MinimumWidth = 10;
            this.CMark.Name = "CMark";
            this.CMark.Width = 200;
            // 
            // CV
            // 
            this.CV.HeaderText = "Скорость";
            this.CV.MinimumWidth = 10;
            this.CV.Name = "CV";
            this.CV.Width = 200;
            // 
            // CS
            // 
            this.CS.HeaderText = "Мощность двигателя";
            this.CS.MinimumWidth = 10;
            this.CS.Name = "CS";
            this.CS.Width = 200;
            // 
            // binarySearchInput
            // 
            this.binarySearchInput.Location = new System.Drawing.Point(1174, 17);
            this.binarySearchInput.Name = "binarySearchInput";
            this.binarySearchInput.Size = new System.Drawing.Size(415, 31);
            this.binarySearchInput.TabIndex = 10;
            this.binarySearchInput.Text = "404Jaguar XF                     196,0";
            this.binarySearchInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1173, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Результат поиска";
            // 
            // frmFileMngm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3038, 1808);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.binarySearchInput);
            this.Controls.Add(this.btnExtSort);
            this.Controls.Add(this.dgErr);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.lblDS);
            this.Controls.Add(this.btnDSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgCars);
            this.Controls.Add(this.btnConv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFileMngm";
            this.Text = "Управление файлами";
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgErr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConv;
        private System.Windows.Forms.DataGridView dgCars;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnDSearch;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.DataGridView dgErr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CErr;
        private System.Windows.Forms.Button btnExtSort;
        private System.Windows.Forms.OpenFileDialog odCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CS;
        private System.Windows.Forms.TextBox binarySearchInput;
        private System.Windows.Forms.Label label1;
    }
}

