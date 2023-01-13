namespace HotelMangementSystem
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.btnCustomerRegistration = new System.Windows.Forms.Button();
            this.btnCustomerDetail = new System.Windows.Forms.Button();
            this.btnChechout = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customerDetails1 = new HotelMangementSystem.AllUserControl.CustomerDetails();
            this.uC_CustomerChechOut1 = new HotelMangementSystem.AllUserControl.UC_CustomerChechOut();
            this.uC_CustomerRegistration1 = new HotelMangementSystem.AllUserControl.UC_CustomerRegistration();
            this.uC_AddRoom1 = new HotelMangementSystem.AllUserControl.UC_AddRoom();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MovingPanel);
            this.panel1.Controls.Add(this.btnCustomerRegistration);
            this.panel1.Controls.Add(this.btnCustomerDetail);
            this.panel1.Controls.Add(this.btnChechout);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 100);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.Color.Salmon;
            this.MovingPanel.Location = new System.Drawing.Point(87, 89);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(173, 5);
            this.MovingPanel.TabIndex = 5;
            this.MovingPanel.UseWaitCursor = true;
            // 
            // btnCustomerRegistration
            // 
            this.btnCustomerRegistration.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnCustomerRegistration.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCustomerRegistration.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCustomerRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnCustomerRegistration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerRegistration.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.Location = new System.Drawing.Point(326, 13);
            this.btnCustomerRegistration.Name = "btnCustomerRegistration";
            this.btnCustomerRegistration.Size = new System.Drawing.Size(173, 70);
            this.btnCustomerRegistration.TabIndex = 4;
            this.btnCustomerRegistration.Text = "Müşteri Kaydı";
            this.btnCustomerRegistration.UseVisualStyleBackColor = false;
            this.btnCustomerRegistration.UseWaitCursor = true;
            this.btnCustomerRegistration.Click += new System.EventHandler(this.btnCustomerRegistration_Click);
            // 
            // btnCustomerDetail
            // 
            this.btnCustomerDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnCustomerDetail.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCustomerDetail.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCustomerDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnCustomerDetail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerDetail.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetail.Location = new System.Drawing.Point(772, 13);
            this.btnCustomerDetail.Name = "btnCustomerDetail";
            this.btnCustomerDetail.Size = new System.Drawing.Size(173, 70);
            this.btnCustomerDetail.TabIndex = 2;
            this.btnCustomerDetail.Text = "Müşteriler";
            this.btnCustomerDetail.UseVisualStyleBackColor = false;
            this.btnCustomerDetail.UseWaitCursor = true;
            this.btnCustomerDetail.Click += new System.EventHandler(this.btnCustomerDetail_Click);
            // 
            // btnChechout
            // 
            this.btnChechout.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnChechout.BackColor = System.Drawing.Color.OrangeRed;
            this.btnChechout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChechout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnChechout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChechout.ForeColor = System.Drawing.Color.White;
            this.btnChechout.Location = new System.Drawing.Point(554, 13);
            this.btnChechout.Name = "btnChechout";
            this.btnChechout.Size = new System.Drawing.Size(173, 70);
            this.btnChechout.TabIndex = 1;
            this.btnChechout.Text = "Rezervasyon";
            this.btnChechout.UseVisualStyleBackColor = false;
            this.btnChechout.UseWaitCursor = true;
            this.btnChechout.Click += new System.EventHandler(this.btnChechout_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnAddRoom.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddRoom.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAddRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(87, 13);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(173, 70);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Oda Ekle";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.UseWaitCursor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customerDetails1);
            this.panel2.Controls.Add(this.uC_CustomerChechOut1);
            this.panel2.Controls.Add(this.uC_CustomerRegistration1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(12, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 495);
            this.panel2.TabIndex = 1;
            this.panel2.UseWaitCursor = true;
            // 
            // customerDetails1
            // 
            this.customerDetails1.BackColor = System.Drawing.Color.White;
            this.customerDetails1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerDetails1.Location = new System.Drawing.Point(0, 0);
            this.customerDetails1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerDetails1.Name = "customerDetails1";
            this.customerDetails1.Size = new System.Drawing.Size(1030, 495);
            this.customerDetails1.TabIndex = 3;
            this.customerDetails1.UseWaitCursor = true;
            // 
            // uC_CustomerChechOut1
            // 
            this.uC_CustomerChechOut1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerChechOut1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uC_CustomerChechOut1.Location = new System.Drawing.Point(0, 0);
            this.uC_CustomerChechOut1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_CustomerChechOut1.Name = "uC_CustomerChechOut1";
            this.uC_CustomerChechOut1.Size = new System.Drawing.Size(1030, 495);
            this.uC_CustomerChechOut1.TabIndex = 2;
            this.uC_CustomerChechOut1.UseWaitCursor = true;
            // 
            // uC_CustomerRegistration1
            // 
            this.uC_CustomerRegistration1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRegistration1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uC_CustomerRegistration1.Location = new System.Drawing.Point(0, 0);
            this.uC_CustomerRegistration1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_CustomerRegistration1.Name = "uC_CustomerRegistration1";
            this.uC_CustomerRegistration1.Size = new System.Drawing.Size(1030, 495);
            this.uC_CustomerRegistration1.TabIndex = 1;
            this.uC_CustomerRegistration1.UseWaitCursor = true;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uC_AddRoom1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddRoom1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1030, 495);
            this.uC_AddRoom1.TabIndex = 0;
            this.uC_AddRoom1.UseWaitCursor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCustomerRegistration;
        private System.Windows.Forms.Button btnCustomerDetail;
        private System.Windows.Forms.Button btnChechout;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel MovingPanel;
        private AllUserControl.UC_AddRoom uC_AddRoom1;
        private AllUserControl.UC_CustomerRegistration uC_CustomerRegistration1;
        private AllUserControl.UC_CustomerChechOut uC_CustomerChechOut1;
        private AllUserControl.CustomerDetails customerDetails1;
    }
}