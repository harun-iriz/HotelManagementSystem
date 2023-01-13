namespace HotelMangementSystem.AllUserControl
{
    partial class CustomerDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOran = new System.Windows.Forms.Button();
            this.womenMenRate1 = new HotelMangementSystem.AllUserControl.WomenMenRate();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri Bilgileri";
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.FormattingEnabled = true;
            this.txtSearchBy.Items.AddRange(new object[] {
            "Bütün Müşteriler",
            "Şu Anda Otelde Kalan Müşteriler",
            "Şu Anda Otelde Kalmayan Müşteriler"});
            this.txtSearchBy.Location = new System.Drawing.Point(355, 93);
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(313, 28);
            this.txtSearchBy.TabIndex = 13;
            this.txtSearchBy.SelectedIndexChanged += new System.EventHandler(this.txtSearchBy_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(351, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Listele";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 166);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(965, 287);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnOran
            // 
            this.btnOran.BackColor = System.Drawing.Color.OrangeRed;
            this.btnOran.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOran.ForeColor = System.Drawing.Color.White;
            this.btnOran.Location = new System.Drawing.Point(802, 88);
            this.btnOran.Name = "btnOran";
            this.btnOran.Size = new System.Drawing.Size(174, 37);
            this.btnOran.TabIndex = 15;
            this.btnOran.Text = "Erkek Kadın Oranı";
            this.btnOran.UseVisualStyleBackColor = false;
            this.btnOran.Click += new System.EventHandler(this.btnOran_Click);
            // 
            // womenMenRate1
            // 
            this.womenMenRate1.BackColor = System.Drawing.Color.White;
            this.womenMenRate1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.womenMenRate1.Location = new System.Drawing.Point(36, 166);
            this.womenMenRate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.womenMenRate1.Name = "womenMenRate1";
            this.womenMenRate1.Size = new System.Drawing.Size(965, 287);
            this.womenMenRate1.TabIndex = 16;
            this.womenMenRate1.Visible = false;
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.womenMenRate1);
            this.Controls.Add(this.btnOran);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearchBy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerDetails";
            this.Size = new System.Drawing.Size(1030, 495);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtSearchBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOran;
        private WomenMenRate womenMenRate1;
    }
}
