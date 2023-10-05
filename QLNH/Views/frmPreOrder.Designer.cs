
namespace QLNH.Views
{
    partial class frmPreOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreOrder));
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.mcDateCheck = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCalendar = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txbSearchTableName = new System.Windows.Forms.TextBox();
            this.btnSearchTable = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTableName = new System.Windows.Forms.Label();
            this.btnViewList = new System.Windows.Forms.Button();
            this.btnUnOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.Color.Moccasin;
            this.flpTable.Location = new System.Drawing.Point(12, 15);
            this.flpTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(1159, 603);
            this.flpTable.TabIndex = 6;
            // 
            // mcDateCheck
            // 
            this.mcDateCheck.Location = new System.Drawing.Point(11, 6);
            this.mcDateCheck.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mcDateCheck.Name = "mcDateCheck";
            this.mcDateCheck.TabIndex = 8;
            this.mcDateCheck.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcDateCheck_DateChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMinute);
            this.panel1.Controls.Add(this.cbHour);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(7, 247);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 46);
            this.panel1.TabIndex = 9;
            // 
            // cbMinute
            // 
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Location = new System.Drawing.Point(189, 9);
            this.cbMinute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(112, 28);
            this.cbMinute.TabIndex = 2;
            // 
            // cbHour
            // 
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Location = new System.Drawing.Point(71, 9);
            this.cbHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(109, 28);
            this.cbHour.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.lbCalendar);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.mcDateCheck);
            this.panel2.Location = new System.Drawing.Point(7, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 297);
            this.panel2.TabIndex = 10;
            // 
            // lbCalendar
            // 
            this.lbCalendar.AutoSize = true;
            this.lbCalendar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lbCalendar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalendar.ForeColor = System.Drawing.Color.Crimson;
            this.lbCalendar.Location = new System.Drawing.Point(9, 217);
            this.lbCalendar.Name = "lbCalendar";
            this.lbCalendar.Size = new System.Drawing.Size(43, 19);
            this.lbCalendar.TabIndex = 10;
            this.lbCalendar.Text = "date";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrder.Location = new System.Drawing.Point(169, 546);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(160, 42);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.YellowGreen;
            this.panel14.Controls.Add(this.txbSearchTableName);
            this.panel14.Controls.Add(this.btnSearchTable);
            this.panel14.Location = new System.Drawing.Point(7, 1);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(325, 54);
            this.panel14.TabIndex = 12;
            // 
            // txbSearchTableName
            // 
            this.txbSearchTableName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbSearchTableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearchTableName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchTableName.Location = new System.Drawing.Point(11, 14);
            this.txbSearchTableName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSearchTableName.Name = "txbSearchTableName";
            this.txbSearchTableName.Size = new System.Drawing.Size(231, 23);
            this.txbSearchTableName.TabIndex = 5;
            // 
            // btnSearchTable
            // 
            this.btnSearchTable.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSearchTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchTable.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSearchTable.FlatAppearance.BorderSize = 0;
            this.btnSearchTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTable.Location = new System.Drawing.Point(247, 5);
            this.btnSearchTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchTable.Name = "btnSearchTable";
            this.btnSearchTable.Size = new System.Drawing.Size(69, 46);
            this.btnSearchTable.TabIndex = 4;
            this.btnSearchTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchTable.UseVisualStyleBackColor = false;
            this.btnSearchTable.Click += new System.EventHandler(this.btnSearchTable_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Ivory;
            this.panel3.Controls.Add(this.btnDeleteAll);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnViewList);
            this.panel3.Controls.Add(this.btnUnOrder);
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Controls.Add(this.btnOrder);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(1177, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 603);
            this.panel3.TabIndex = 13;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteAll.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteAll.Location = new System.Drawing.Point(7, 450);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(327, 42);
            this.btnDeleteAll.TabIndex = 19;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Menu;
            this.panel4.Controls.Add(this.lbDate);
            this.panel4.Controls.Add(this.lbTableName);
            this.panel4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(7, 367);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 76);
            this.panel4.TabIndex = 18;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(11, 43);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(42, 23);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Date";
            // 
            // lbTableName
            // 
            this.lbTableName.AutoSize = true;
            this.lbTableName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableName.Location = new System.Drawing.Point(9, 11);
            this.lbTableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(120, 24);
            this.lbTableName.TabIndex = 0;
            this.lbTableName.Text = "Table Name";
            this.lbTableName.Click += new System.EventHandler(this.lbTableName_Click);
            // 
            // btnViewList
            // 
            this.btnViewList.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewList.Location = new System.Drawing.Point(7, 500);
            this.btnViewList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(327, 42);
            this.btnViewList.TabIndex = 17;
            this.btnViewList.Text = "View list";
            this.btnViewList.UseVisualStyleBackColor = false;
            this.btnViewList.Click += new System.EventHandler(this.btnViewList_Click);
            // 
            // btnUnOrder
            // 
            this.btnUnOrder.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUnOrder.Enabled = false;
            this.btnUnOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUnOrder.Location = new System.Drawing.Point(7, 546);
            this.btnUnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnOrder.Name = "btnUnOrder";
            this.btnUnOrder.Size = new System.Drawing.Size(160, 42);
            this.btnUnOrder.TabIndex = 13;
            this.btnUnOrder.Text = "UnOrder";
            this.btnUnOrder.UseVisualStyleBackColor = false;
            this.btnUnOrder.Click += new System.EventHandler(this.btnUnOrder_Click);
            // 
            // frmPreOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1532, 629);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flpTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPreOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pre Order Table";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.MonthCalendar mcDateCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txbSearchTableName;
        private System.Windows.Forms.Button btnSearchTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUnOrder;
        private System.Windows.Forms.Label lbCalendar;
        private System.Windows.Forms.Button btnViewList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}