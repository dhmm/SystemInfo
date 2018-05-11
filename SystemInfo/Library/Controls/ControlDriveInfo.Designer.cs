namespace SystemWatcher.Library.Controls
{
    partial class ControlDriveInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTotalSize = new System.Windows.Forms.Panel();
            this.pnlUsedSpace = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExpand = new System.Windows.Forms.Button();
            this.lblAvailableSpace = new SystemWatcher.Library.Controls.ExtendedLabel();
            this.lblDriveName = new SystemWatcher.Library.Controls.ExtendedLabel();
            this.lblTotalSize = new SystemWatcher.Library.Controls.ExtendedLabel();
            this.lblTotalFreeSpace = new SystemWatcher.Library.Controls.ExtendedLabel();
            this.lblFormat = new SystemWatcher.Library.Controls.ExtendedLabel();
            this.lblDriveLabel = new SystemWatcher.Library.Controls.ExtendedLabel();
            this.lblType = new SystemWatcher.Library.Controls.ExtendedLabel();
            this.pnlTotalSize.SuspendLayout();
            this.pnlUsedSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drive Name :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(18, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(18, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Format :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(18, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type :";
            // 
            // pnlTotalSize
            // 
            this.pnlTotalSize.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTotalSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalSize.Controls.Add(this.pnlUsedSpace);
            this.pnlTotalSize.Location = new System.Drawing.Point(17, 52);
            this.pnlTotalSize.Name = "pnlTotalSize";
            this.pnlTotalSize.Size = new System.Drawing.Size(436, 30);
            this.pnlTotalSize.TabIndex = 9;
            // 
            // pnlUsedSpace
            // 
            this.pnlUsedSpace.BackColor = System.Drawing.Color.Green;
            this.pnlUsedSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsedSpace.Controls.Add(this.label5);
            this.pnlUsedSpace.Location = new System.Drawing.Point(-1, -1);
            this.pnlUsedSpace.Name = "pnlUsedSpace";
            this.pnlUsedSpace.Size = new System.Drawing.Size(135, 30);
            this.pnlUsedSpace.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Used Space";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(18, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Available Free Space :";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(18, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total Free Space :";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.Location = new System.Drawing.Point(18, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Total Size :";
            // 
            // btnExpand
            // 
            this.btnExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnExpand.Location = new System.Drawing.Point(452, 3);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(30, 27);
            this.btnExpand.TabIndex = 18;
            this.btnExpand.Text = "+";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // lblAvailableSpace
            // 
            this.lblAvailableSpace.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableSpace.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAvailableSpace.Location = new System.Drawing.Point(236, 271);
            this.lblAvailableSpace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAvailableSpace.Name = "lblAvailableSpace";
            this.lblAvailableSpace.Size = new System.Drawing.Size(217, 21);
            this.lblAvailableSpace.TabIndex = 17;
            // 
            // lblDriveName
            // 
            this.lblDriveName.BackColor = System.Drawing.Color.Transparent;
            this.lblDriveName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblDriveName.Location = new System.Drawing.Point(134, 24);
            this.lblDriveName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDriveName.Name = "lblDriveName";
            this.lblDriveName.Size = new System.Drawing.Size(319, 21);
            this.lblDriveName.TabIndex = 16;
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSize.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTotalSize.Location = new System.Drawing.Point(236, 203);
            this.lblTotalSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(217, 21);
            this.lblTotalSize.TabIndex = 17;
            // 
            // lblTotalFreeSpace
            // 
            this.lblTotalFreeSpace.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFreeSpace.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTotalFreeSpace.Location = new System.Drawing.Point(236, 237);
            this.lblTotalFreeSpace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotalFreeSpace.Name = "lblTotalFreeSpace";
            this.lblTotalFreeSpace.Size = new System.Drawing.Size(217, 21);
            this.lblTotalFreeSpace.TabIndex = 17;
            // 
            // lblFormat
            // 
            this.lblFormat.BackColor = System.Drawing.Color.Transparent;
            this.lblFormat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblFormat.Location = new System.Drawing.Point(236, 134);
            this.lblFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(217, 21);
            this.lblFormat.TabIndex = 17;
            // 
            // lblDriveLabel
            // 
            this.lblDriveLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblDriveLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblDriveLabel.Location = new System.Drawing.Point(236, 102);
            this.lblDriveLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDriveLabel.Name = "lblDriveLabel";
            this.lblDriveLabel.Size = new System.Drawing.Size(217, 21);
            this.lblDriveLabel.TabIndex = 17;
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblType.Location = new System.Drawing.Point(236, 168);
            this.lblType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(217, 21);
            this.lblType.TabIndex = 17;
            // 
            // ControlDriveInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlTotalSize);
            this.Controls.Add(this.lblAvailableSpace);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblDriveName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalSize);
            this.Controls.Add(this.lblTotalFreeSpace);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.lblDriveLabel);
            this.Controls.Add(this.lblType);
            this.DoubleBuffered = true;
            this.Name = "ControlDriveInfo";
            this.Size = new System.Drawing.Size(492, 100);
            this.pnlTotalSize.ResumeLayout(false);
            this.pnlUsedSpace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlTotalSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlUsedSpace;
        private System.Windows.Forms.Label label5;
        private ExtendedLabel lblDriveName;
        private ExtendedLabel lblDriveLabel;
        private ExtendedLabel lblFormat;
        private ExtendedLabel lblType;
        private ExtendedLabel lblTotalSize;
        private ExtendedLabel lblTotalFreeSpace;
        private ExtendedLabel lblAvailableSpace;
        private System.Windows.Forms.Button btnExpand;
    }
}
