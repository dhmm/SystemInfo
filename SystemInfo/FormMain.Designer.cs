namespace SystemWatcher
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlDrivesInfo = new System.Windows.Forms.Panel();
            this.pnlNetworkInterfacesInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPhysicalMemory = new SystemWatcher.Library.Controls.ExtendedLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalVirtualMemory = new SystemWatcher.Library.Controls.ExtendedLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAvailablePhysicalMemory = new SystemWatcher.Library.Controls.ExtendedLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAvailableVirtualMemory = new SystemWatcher.Library.Controls.ExtendedLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOSFullName = new SystemWatcher.Library.Controls.ExtendedLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOSPlatform = new SystemWatcher.Library.Controls.ExtendedLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblOSVersion = new SystemWatcher.Library.Controls.ExtendedLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlDrivesInfo
            // 
            this.pnlDrivesInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDrivesInfo.AutoScroll = true;
            this.pnlDrivesInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrivesInfo.Location = new System.Drawing.Point(12, 418);
            this.pnlDrivesInfo.Name = "pnlDrivesInfo";
            this.pnlDrivesInfo.Size = new System.Drawing.Size(580, 287);
            this.pnlDrivesInfo.TabIndex = 0;
            // 
            // pnlNetworkInterfacesInfo
            // 
            this.pnlNetworkInterfacesInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNetworkInterfacesInfo.AutoScroll = true;
            this.pnlNetworkInterfacesInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNetworkInterfacesInfo.Location = new System.Drawing.Point(605, 107);
            this.pnlNetworkInterfacesInfo.Name = "pnlNetworkInterfacesInfo";
            this.pnlNetworkInterfacesInfo.Size = new System.Drawing.Size(575, 598);
            this.pnlNetworkInterfacesInfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "System Drives Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(604, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(576, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Network Interface Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPhysicalMemory
            // 
            this.lblTotalPhysicalMemory.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPhysicalMemory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTotalPhysicalMemory.Location = new System.Drawing.Point(307, 132);
            this.lblTotalPhysicalMemory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotalPhysicalMemory.Name = "lblTotalPhysicalMemory";
            this.lblTotalPhysicalMemory.Size = new System.Drawing.Size(281, 23);
            this.lblTotalPhysicalMemory.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(25, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Total physical memory :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(580, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "System Information";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(25, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total virtual memory :";
            // 
            // lblTotalVirtualMemory
            // 
            this.lblTotalVirtualMemory.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalVirtualMemory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTotalVirtualMemory.Location = new System.Drawing.Point(307, 163);
            this.lblTotalVirtualMemory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotalVirtualMemory.Name = "lblTotalVirtualMemory";
            this.lblTotalVirtualMemory.Size = new System.Drawing.Size(281, 21);
            this.lblTotalVirtualMemory.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(25, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Available physical memory :";
            // 
            // lblAvailablePhysicalMemory
            // 
            this.lblAvailablePhysicalMemory.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailablePhysicalMemory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAvailablePhysicalMemory.Location = new System.Drawing.Point(307, 192);
            this.lblAvailablePhysicalMemory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAvailablePhysicalMemory.Name = "lblAvailablePhysicalMemory";
            this.lblAvailablePhysicalMemory.Size = new System.Drawing.Size(281, 21);
            this.lblAvailablePhysicalMemory.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(25, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Available virtual memory :";
            // 
            // lblAvailableVirtualMemory
            // 
            this.lblAvailableVirtualMemory.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableVirtualMemory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAvailableVirtualMemory.Location = new System.Drawing.Point(307, 221);
            this.lblAvailableVirtualMemory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAvailableVirtualMemory.Name = "lblAvailableVirtualMemory";
            this.lblAvailableVirtualMemory.Size = new System.Drawing.Size(281, 21);
            this.lblAvailableVirtualMemory.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(25, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "OS full name :";
            // 
            // lblOSFullName
            // 
            this.lblOSFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblOSFullName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblOSFullName.Location = new System.Drawing.Point(307, 250);
            this.lblOSFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblOSFullName.Name = "lblOSFullName";
            this.lblOSFullName.Size = new System.Drawing.Size(281, 21);
            this.lblOSFullName.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(25, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "OS Platform :";
            // 
            // lblOSPlatform
            // 
            this.lblOSPlatform.BackColor = System.Drawing.Color.Transparent;
            this.lblOSPlatform.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblOSPlatform.Location = new System.Drawing.Point(307, 279);
            this.lblOSPlatform.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblOSPlatform.Name = "lblOSPlatform";
            this.lblOSPlatform.Size = new System.Drawing.Size(281, 21);
            this.lblOSPlatform.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.Location = new System.Drawing.Point(25, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "OS Version :";
            // 
            // lblOSVersion
            // 
            this.lblOSVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblOSVersion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblOSVersion.Location = new System.Drawing.Point(307, 308);
            this.lblOSVersion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblOSVersion.Name = "lblOSVersion";
            this.lblOSVersion.Size = new System.Drawing.Size(281, 21);
            this.lblOSVersion.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LawnGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(1135, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(38, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "System Info v 0.1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 717);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDrivesInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalPhysicalMemory);
            this.Controls.Add(this.pnlNetworkInterfacesInfo);
            this.Controls.Add(this.lblOSVersion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAvailableVirtualMemory);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalVirtualMemory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblOSPlatform);
            this.Controls.Add(this.lblOSFullName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAvailablePhysicalMemory);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Watcher";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrivesInfo;
        private System.Windows.Forms.Panel pnlNetworkInterfacesInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Library.Controls.ExtendedLabel lblTotalPhysicalMemory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Library.Controls.ExtendedLabel lblTotalVirtualMemory;
        private System.Windows.Forms.Label label6;
        private Library.Controls.ExtendedLabel lblAvailablePhysicalMemory;
        private System.Windows.Forms.Label label7;
        private Library.Controls.ExtendedLabel lblAvailableVirtualMemory;
        private System.Windows.Forms.Label label8;
        private Library.Controls.ExtendedLabel lblOSFullName;
        private System.Windows.Forms.Label label9;
        private Library.Controls.ExtendedLabel lblOSPlatform;
        private System.Windows.Forms.Label label10;
        private Library.Controls.ExtendedLabel lblOSVersion;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label11;












    }
}

