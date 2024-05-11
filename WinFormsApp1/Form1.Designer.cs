namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Image = new DataGridViewImageColumn();
            Brand = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Cpu = new DataGridViewTextBoxColumn();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            checkedListBox2 = new CheckedListBox();
            label3 = new Label();
            checkedListBox3 = new CheckedListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Image, Brand, Price, Cpu });
            dataGridView1.Location = new Point(213, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(614, 487);
            dataGridView1.TabIndex = 0;
            // 
            // Image
            // 
            Image.HeaderText = "image";
            Image.Name = "Image";
            // 
            // Brand
            // 
            Brand.HeaderText = "brand";
            Brand.Name = "Brand";
            // 
            // Price
            // 
            Price.HeaderText = "price";
            Price.Name = "Price";
            // 
            // Cpu
            // 
            Cpu.HeaderText = "CPU";
            Cpu.Name = "Cpu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Brand";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Dell", "HP", "MSI", "Asus", "Lenovo" });
            checkedListBox1.Location = new Point(12, 30);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(133, 94);
            checkedListBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 140);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Price";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "0-10.000", "10.001-20.000", "20.001-30.000", "30.001-40.000", "40.001-50.000" });
            checkedListBox2.Location = new Point(12, 158);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(133, 94);
            checkedListBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 265);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "CPU";
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Items.AddRange(new object[] { "Intel Core i3", "Intel Core i5", "Intel Core i7" });
            checkedListBox3.Location = new Point(12, 283);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(133, 58);
            checkedListBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(71, 367);
            button1.Name = "button1";
            button1.Size = new Size(74, 21);
            button1.TabIndex = 7;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 511);
            Controls.Add(button1);
            Controls.Add(checkedListBox3);
            Controls.Add(label3);
            Controls.Add(checkedListBox2);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Cpu;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private CheckedListBox checkedListBox2;
        private Label label3;
        private CheckedListBox checkedListBox3;
        private Button button1;
    }
}
