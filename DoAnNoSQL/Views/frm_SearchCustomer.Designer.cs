namespace DoAnNoSQL.Views
{
    partial class frm_SearchCustomer
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
            label1 = new Label();
            dgv_customer = new DataGridView();
            txt_search = new TextBox();
            label2 = new Label();
            btn_search = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_customer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(394, 26);
            label1.Name = "label1";
            label1.Size = new Size(295, 32);
            label1.TabIndex = 0;
            label1.Text = "TÌM KIẾM KHÁCH HÀNG";
            // 
            // dgv_customer
            // 
            dgv_customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_customer.Location = new Point(40, 166);
            dgv_customer.Name = "dgv_customer";
            dgv_customer.RowHeadersWidth = 62;
            dgv_customer.Size = new Size(1035, 269);
            dgv_customer.TabIndex = 1;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(545, 92);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(293, 31);
            txt_search.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 92);
            label2.Name = "label2";
            label2.Size = new Size(499, 25);
            label2.TabIndex = 3;
            label2.Text = "Nhập thông tin tìm kiếm (Tên khách hàng hoặc số điện thoại):";
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.Image = Properties.Resources.find;
            btn_search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_search.Location = new Point(873, 78);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(92, 52);
            btn_search.TabIndex = 4;
            btn_search.Text = "Tìm";
            btn_search.TextAlign = ContentAlignment.MiddleRight;
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // frm_SearchCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 446);
            Controls.Add(btn_search);
            Controls.Add(label2);
            Controls.Add(txt_search);
            Controls.Add(dgv_customer);
            Controls.Add(label1);
            Name = "frm_SearchCustomer";
            Text = "frm_SearchCustomer";
            ((System.ComponentModel.ISupportInitialize)dgv_customer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_customer;
        private TextBox txt_search;
        private Label label2;
        private Button btn_search;
    }
}