
namespace QLNH.Views
{
    partial class frmMergeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMergeTable));
            this.clbTable = new System.Windows.Forms.CheckedListBox();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.pbMerge = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMerge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMerge)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbTable
            // 
            this.clbTable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clbTable.FormattingEnabled = true;
            this.clbTable.Location = new System.Drawing.Point(8, 30);
            this.clbTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbTable.Name = "clbTable";
            this.clbTable.Size = new System.Drawing.Size(204, 298);
            this.clbTable.TabIndex = 0;
            // 
            // cbTable
            // 
            this.cbTable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(8, 30);
            this.cbTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(201, 28);
            this.cbTable.TabIndex = 1;
            // 
            // pbMerge
            // 
            this.pbMerge.Location = new System.Drawing.Point(297, 186);
            this.pbMerge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbMerge.Name = "pbMerge";
            this.pbMerge.Size = new System.Drawing.Size(69, 62);
            this.pbMerge.TabIndex = 2;
            this.pbMerge.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnMerge);
            this.panel1.Controls.Add(this.pbMerge);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 485);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.clbTable);
            this.panel3.Location = new System.Drawing.Point(35, 42);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 361);
            this.panel3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Merge table from:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbTable);
            this.panel2.Location = new System.Drawing.Point(395, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 362);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Merge table to:";
            // 
            // btnMerge
            // 
            this.btnMerge.BackColor = System.Drawing.Color.PeachPuff;
            this.btnMerge.Location = new System.Drawing.Point(513, 432);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(112, 38);
            this.btnMerge.TabIndex = 6;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = false;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // frmMergeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(695, 511);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMergeTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMergeTable";
            ((System.ComponentModel.ISupportInitialize)(this.pbMerge)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbTable;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.PictureBox pbMerge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMerge;
    }
}