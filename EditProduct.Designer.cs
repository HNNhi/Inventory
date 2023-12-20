﻿namespace QuanlyKho1
{
    partial class EditProduct
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
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            btClose = new Button();
            btSave = new Button();
            txtPrice = new TextBox();
            txtOrigin = new TextBox();
            cbCategory = new ComboBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btClose);
            panel2.Controls.Add(btSave);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtOrigin);
            panel2.Controls.Add(cbCategory);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(28, 30);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1045, 424);
            panel2.TabIndex = 18;
            // 
            // btClose
            // 
            btClose.BackColor = Color.FromArgb(128, 128, 255);
            btClose.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = Color.White;
            btClose.Location = new Point(518, 328);
            btClose.Margin = new Padding(2);
            btClose.Name = "btClose";
            btClose.Size = new Size(128, 48);
            btClose.TabIndex = 13;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.BackColor = Color.FromArgb(128, 128, 255);
            btSave.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(356, 328);
            btSave.Margin = new Padding(2);
            btSave.Name = "btSave";
            btSave.Size = new Size(128, 48);
            btSave.TabIndex = 11;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.Lavender;
            txtPrice.Location = new Point(668, 158);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(297, 31);
            txtPrice.TabIndex = 10;
            // 
            // txtOrigin
            // 
            txtOrigin.BackColor = Color.Lavender;
            txtOrigin.Location = new Point(668, 244);
            txtOrigin.Margin = new Padding(2);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(297, 31);
            txtOrigin.TabIndex = 9;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.Lavender;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Wine", "Beer", "Soft Drink", "Mineral Water" });
            cbCategory.Location = new Point(182, 244);
            cbCategory.Margin = new Padding(2);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(270, 33);
            cbCategory.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Lavender;
            txtName.Location = new Point(182, 156);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 31);
            txtName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(128, 128, 255);
            label5.Location = new Point(567, 158);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 29);
            label5.TabIndex = 4;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(128, 128, 255);
            label4.Location = new Point(557, 244);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 29);
            label4.TabIndex = 3;
            label4.Text = "Origin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(43, 243);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 29);
            label3.TabIndex = 3;
            label3.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(80, 156);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 29);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(268, 45);
            label1.TabIndex = 1;
            label1.Text = "EDIT PRODUCT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 83);
            panel1.TabIndex = 14;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1105, 488);
            ControlBox = false;
            Controls.Add(panel2);
            Name = "EditProduct";
            Text = "EditProduct";
            FormClosing += EditProduct_FormClosing;
            Load += EditProduct_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btClose;
        private Button btSave;
        private TextBox txtPrice;
        private ComboBox cbCategory;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtOrigin;
        private ToolTip toolTip1;
        private Panel panel1;
    }
}