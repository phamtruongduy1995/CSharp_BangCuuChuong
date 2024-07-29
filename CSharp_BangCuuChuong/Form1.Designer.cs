namespace CSharp_BangCuuChuong
{
    partial class lblKetQua
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
            label1 = new Label();
            label2 = new Label();
            txtSo = new TextBox();
            btnXem = new Button();
            nudSo = new NumericUpDown();
            lblKQ = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudSo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(150, 24);
            label1.Name = "label1";
            label1.Size = new Size(535, 37);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG HIỂN THỊ BẢNG CUU CHƯƠNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 82);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 1;
            label2.Text = "Chọn bảng cưu chương";
            // 
            // txtSo
            // 
            txtSo.Location = new Point(216, 79);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(100, 23);
            txtSo.TabIndex = 2;
            // 
            // btnXem
            // 
            btnXem.Location = new Point(610, 75);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(75, 23);
            btnXem.TabIndex = 3;
            btnXem.Text = "xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // nudSo
            // 
            nudSo.Location = new Point(410, 77);
            nudSo.Name = "nudSo";
            nudSo.Size = new Size(120, 23);
            nudSo.TabIndex = 4;
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Location = new Point(12, 251);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(46, 15);
            lblKQ.TabIndex = 5;
            lblKQ.Text = "kết quả";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(556, 251);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(244, 169);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblKetQua
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 422);
            Controls.Add(listBox1);
            Controls.Add(lblKQ);
            Controls.Add(nudSo);
            Controls.Add(btnXem);
            Controls.Add(txtSo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "lblKetQua";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudSo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSo;
        private Button btnXem;
        private NumericUpDown nudSo;
        private Label lblKQ;
        private ListBox listBox1;
    }
}
