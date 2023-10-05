
namespace QLNH.Views
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tlpFoodBill = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tlpPrice = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBill = new System.Windows.Forms.TableLayoutPanel();
            this.lbDetail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbBill = new System.Windows.Forms.Label();
            this.lbTable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 462);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thank you for dining at Bill\'s";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tlpFoodBill);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tlpPrice);
            this.panel3.Controls.Add(this.tlpBill);
            this.panel3.Controls.Add(this.lbDetail);
            this.panel3.Location = new System.Drawing.Point(41, 155);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 263);
            this.panel3.TabIndex = 5;
            // 
            // tlpFoodBill
            // 
            this.tlpFoodBill.ColumnCount = 2;
            this.tlpFoodBill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.79795F));
            this.tlpFoodBill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.20205F));
            this.tlpFoodBill.Location = new System.Drawing.Point(11, 63);
            this.tlpFoodBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpFoodBill.Name = "tlpFoodBill";
            this.tlpFoodBill.RowCount = 1;
            this.tlpFoodBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tlpFoodBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tlpFoodBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpFoodBill.Size = new System.Drawing.Size(391, 27);
            this.tlpFoodBill.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // tlpPrice
            // 
            this.tlpPrice.ColumnCount = 2;
            this.tlpPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.79795F));
            this.tlpPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.20205F));
            this.tlpPrice.Location = new System.Drawing.Point(11, 95);
            this.tlpPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpPrice.Name = "tlpPrice";
            this.tlpPrice.RowCount = 1;
            this.tlpPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tlpPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tlpPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpPrice.Size = new System.Drawing.Size(391, 25);
            this.tlpPrice.TabIndex = 4;
            this.tlpPrice.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpPrice_Paint);
            // 
            // tlpBill
            // 
            this.tlpBill.ColumnCount = 2;
            this.tlpBill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.1974F));
            this.tlpBill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.8026F));
            this.tlpBill.Location = new System.Drawing.Point(11, 158);
            this.tlpBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpBill.Name = "tlpBill";
            this.tlpBill.RowCount = 3;
            this.tlpBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tlpBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tlpBill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBill.Size = new System.Drawing.Size(391, 71);
            this.tlpBill.TabIndex = 2;
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetail.Location = new System.Drawing.Point(3, 4);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(95, 37);
            this.lbDetail.TabIndex = 1;
            this.lbDetail.Text = "detail";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Controls.Add(this.lbBill);
            this.panel2.Controls.Add(this.lbTable);
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(41, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 74);
            this.panel2.TabIndex = 3;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(13, 38);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(37, 22);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "date";
            // 
            // lbBill
            // 
            this.lbBill.AutoSize = true;
            this.lbBill.Location = new System.Drawing.Point(333, 14);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(54, 22);
            this.lbBill.TabIndex = 2;
            this.lbBill.Text = "Bill No.";
            // 
            // lbTable
            // 
            this.lbTable.AutoSize = true;
            this.lbTable.Location = new System.Drawing.Point(13, 14);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(72, 22);
            this.lbTable.TabIndex = 1;
            this.lbTable.Text = "Table No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant bill";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheck.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.LightCyan;
            this.btnCheck.Location = new System.Drawing.Point(428, 514);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(88, 30);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 556);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbBill;
        private System.Windows.Forms.Label lbTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbDetail;
        private System.Windows.Forms.TableLayoutPanel tlpBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tlpPrice;
        private System.Windows.Forms.TableLayoutPanel tlpFoodBill;
    }
}