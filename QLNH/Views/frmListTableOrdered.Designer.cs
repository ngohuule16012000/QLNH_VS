
namespace QLNH.Views
{
    partial class frmListTableOrdered
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListTableOrdered));
            this.dtgvTableOrder = new System.Windows.Forms.DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txbSearchTableOrderName = new System.Windows.Forms.TextBox();
            this.btnSearchTableOrder = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.mcDateCheck = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmYear = new System.Windows.Forms.NumericUpDown();
            this.nmMonth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTableOrder)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTableOrder
            // 
            this.dtgvTableOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTableOrder.BackgroundColor = System.Drawing.Color.Azure;
            this.dtgvTableOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvTableOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTableOrder.Location = new System.Drawing.Point(11, 11);
            this.dtgvTableOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvTableOrder.Name = "dtgvTableOrder";
            this.dtgvTableOrder.RowHeadersWidth = 51;
            this.dtgvTableOrder.RowTemplate.Height = 24;
            this.dtgvTableOrder.Size = new System.Drawing.Size(527, 428);
            this.dtgvTableOrder.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel14.Controls.Add(this.txbSearchTableOrderName);
            this.panel14.Controls.Add(this.btnSearchTableOrder);
            this.panel14.Location = new System.Drawing.Point(545, 11);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(244, 44);
            this.panel14.TabIndex = 13;
            // 
            // txbSearchTableOrderName
            // 
            this.txbSearchTableOrderName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbSearchTableOrderName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearchTableOrderName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchTableOrderName.Location = new System.Drawing.Point(8, 11);
            this.txbSearchTableOrderName.Margin = new System.Windows.Forms.Padding(2);
            this.txbSearchTableOrderName.Name = "txbSearchTableOrderName";
            this.txbSearchTableOrderName.Size = new System.Drawing.Size(173, 19);
            this.txbSearchTableOrderName.TabIndex = 5;
            // 
            // btnSearchTableOrder
            // 
            this.btnSearchTableOrder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearchTableOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchTableOrder.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSearchTableOrder.FlatAppearance.BorderSize = 0;
            this.btnSearchTableOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTableOrder.Location = new System.Drawing.Point(185, 4);
            this.btnSearchTableOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchTableOrder.Name = "btnSearchTableOrder";
            this.btnSearchTableOrder.Size = new System.Drawing.Size(52, 37);
            this.btnSearchTableOrder.TabIndex = 4;
            this.btnSearchTableOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchTableOrder.UseVisualStyleBackColor = false;
            this.btnSearchTableOrder.Click += new System.EventHandler(this.btnSearchTable_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel11.Controls.Add(this.mcDateCheck);
            this.panel11.Controls.Add(this.panel1);
            this.panel11.Location = new System.Drawing.Point(545, 59);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(244, 380);
            this.panel11.TabIndex = 14;
            // 
            // mcDateCheck
            // 
            this.mcDateCheck.Location = new System.Drawing.Point(9, 6);
            this.mcDateCheck.Name = "mcDateCheck";
            this.mcDateCheck.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nmYear);
            this.panel1.Controls.Add(this.nmMonth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(2, 172);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 92);
            this.panel1.TabIndex = 2;
            // 
            // nmYear
            // 
            this.nmYear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmYear.Location = new System.Drawing.Point(130, 52);
            this.nmYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nmYear.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nmYear.Name = "nmYear";
            this.nmYear.Size = new System.Drawing.Size(102, 26);
            this.nmYear.TabIndex = 3;
            this.nmYear.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nmYear.ValueChanged += new System.EventHandler(this.nmYear_ValueChanged);
            // 
            // nmMonth
            // 
            this.nmMonth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmMonth.Location = new System.Drawing.Point(130, 12);
            this.nmMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMonth.Name = "nmMonth";
            this.nmMonth.Size = new System.Drawing.Size(102, 26);
            this.nmMonth.TabIndex = 7;
            this.nmMonth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmMonth.ValueChanged += new System.EventHandler(this.nmMonth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Month:";
            // 
            // frmListTableOrdered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.dtgvTableOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListTableOrdered";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Ordered Table";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTableOrder)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTableOrder;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txbSearchTableOrderName;
        private System.Windows.Forms.Button btnSearchTableOrder;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmMonth;
        private System.Windows.Forms.NumericUpDown nmYear;
        private System.Windows.Forms.MonthCalendar mcDateCheck;
    }
}