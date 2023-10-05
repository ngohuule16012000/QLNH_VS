
namespace QLNH.Views
{
    partial class frmKitchenArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitchenArea));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAllOrder = new System.Windows.Forms.Button();
            this.lbTableName = new System.Windows.Forms.Label();
            this.flpKitchenFood = new System.Windows.Forms.FlowLayoutPanel();
            this.flpKitchenTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txbSearchTableName = new System.Windows.Forms.TextBox();
            this.btnSearchTable = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btnAllOrder);
            this.panel1.Controls.Add(this.lbTableName);
            this.panel1.Controls.Add(this.flpKitchenFood);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(722, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 436);
            this.panel1.TabIndex = 1;
            // 
            // btnAllOrder
            // 
            this.btnAllOrder.BackColor = System.Drawing.Color.DeepPink;
            this.btnAllOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllOrder.ForeColor = System.Drawing.Color.Yellow;
            this.btnAllOrder.Location = new System.Drawing.Point(223, 8);
            this.btnAllOrder.Name = "btnAllOrder";
            this.btnAllOrder.Size = new System.Drawing.Size(89, 30);
            this.btnAllOrder.TabIndex = 1;
            this.btnAllOrder.Text = "All Order";
            this.btnAllOrder.UseVisualStyleBackColor = false;
            this.btnAllOrder.Click += new System.EventHandler(this.btnAllOrder_Click);
            // 
            // lbTableName
            // 
            this.lbTableName.AutoSize = true;
            this.lbTableName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableName.Location = new System.Drawing.Point(9, 12);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(51, 21);
            this.lbTableName.TabIndex = 0;
            this.lbTableName.Text = "Table";
            // 
            // flpKitchenFood
            // 
            this.flpKitchenFood.AutoScroll = true;
            this.flpKitchenFood.BackColor = System.Drawing.SystemColors.Control;
            this.flpKitchenFood.Location = new System.Drawing.Point(13, 55);
            this.flpKitchenFood.Name = "flpKitchenFood";
            this.flpKitchenFood.Size = new System.Drawing.Size(299, 365);
            this.flpKitchenFood.TabIndex = 0;
            // 
            // flpKitchenTable
            // 
            this.flpKitchenTable.AutoScroll = true;
            this.flpKitchenTable.BackColor = System.Drawing.Color.Crimson;
            this.flpKitchenTable.Location = new System.Drawing.Point(11, 12);
            this.flpKitchenTable.Name = "flpKitchenTable";
            this.flpKitchenTable.Size = new System.Drawing.Size(695, 493);
            this.flpKitchenTable.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Pink;
            this.panel14.Controls.Add(this.txbSearchTableName);
            this.panel14.Controls.Add(this.btnSearchTable);
            this.panel14.Location = new System.Drawing.Point(722, 12);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(327, 44);
            this.panel14.TabIndex = 14;
            // 
            // txbSearchTableName
            // 
            this.txbSearchTableName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbSearchTableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearchTableName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchTableName.Location = new System.Drawing.Point(8, 11);
            this.txbSearchTableName.Margin = new System.Windows.Forms.Padding(2);
            this.txbSearchTableName.Name = "txbSearchTableName";
            this.txbSearchTableName.Size = new System.Drawing.Size(259, 19);
            this.txbSearchTableName.TabIndex = 5;
            // 
            // btnSearchTable
            // 
            this.btnSearchTable.BackColor = System.Drawing.Color.Pink;
            this.btnSearchTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchTable.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSearchTable.FlatAppearance.BorderSize = 0;
            this.btnSearchTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTable.Location = new System.Drawing.Point(271, 4);
            this.btnSearchTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchTable.Name = "btnSearchTable";
            this.btnSearchTable.Size = new System.Drawing.Size(52, 37);
            this.btnSearchTable.TabIndex = 4;
            this.btnSearchTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchTable.UseVisualStyleBackColor = false;
            this.btnSearchTable.Click += new System.EventHandler(this.btnSearchTable_Click);
            // 
            // frmKitchenArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1061, 517);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.flpKitchenTable);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKitchenArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitchen Area Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpKitchenFood;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.Button btnAllOrder;
        private System.Windows.Forms.FlowLayoutPanel flpKitchenTable;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txbSearchTableName;
        private System.Windows.Forms.Button btnSearchTable;
    }
}