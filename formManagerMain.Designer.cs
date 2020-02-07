namespace Session2RushYeeet
{
    partial class formManagerMain
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
            this.btnSendEM = new System.Windows.Forms.Button();
            this.dgvAvailAsset = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AssetSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendEM
            // 
            this.btnSendEM.Location = new System.Drawing.Point(13, 486);
            this.btnSendEM.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendEM.Name = "btnSendEM";
            this.btnSendEM.Size = new System.Drawing.Size(264, 27);
            this.btnSendEM.TabIndex = 5;
            this.btnSendEM.Text = "Manage Request";
            this.btnSendEM.UseVisualStyleBackColor = true;
            this.btnSendEM.Click += new System.EventHandler(this.btnSendEM_Click);
            // 
            // dgvAvailAsset
            // 
            this.dgvAvailAsset.AllowUserToAddRows = false;
            this.dgvAvailAsset.AllowUserToDeleteRows = false;
            this.dgvAvailAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailAsset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssetSN,
            this.AssetName,
            this.RequestDate,
            this.fullName,
            this.Department});
            this.dgvAvailAsset.Location = new System.Drawing.Point(14, 28);
            this.dgvAvailAsset.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAvailAsset.Name = "dgvAvailAsset";
            this.dgvAvailAsset.ReadOnly = true;
            this.dgvAvailAsset.RowHeadersWidth = 82;
            this.dgvAvailAsset.RowTemplate.Height = 33;
            this.dgvAvailAsset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailAsset.Size = new System.Drawing.Size(752, 454);
            this.dgvAvailAsset.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of Assets requesting EM:";
            // 
            // AssetSN
            // 
            this.AssetSN.HeaderText = "Asset SN";
            this.AssetSN.MinimumWidth = 10;
            this.AssetSN.Name = "AssetSN";
            this.AssetSN.ReadOnly = true;
            this.AssetSN.Width = 200;
            // 
            // AssetName
            // 
            this.AssetName.HeaderText = "Asset Name";
            this.AssetName.MinimumWidth = 10;
            this.AssetName.Name = "AssetName";
            this.AssetName.ReadOnly = true;
            this.AssetName.Width = 200;
            // 
            // RequestDate
            // 
            this.RequestDate.HeaderText = "Request Date";
            this.RequestDate.MinimumWidth = 10;
            this.RequestDate.Name = "RequestDate";
            this.RequestDate.ReadOnly = true;
            this.RequestDate.Width = 200;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Employee Full Name";
            this.fullName.MinimumWidth = 10;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Width = 200;
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // formManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 524);
            this.Controls.Add(this.btnSendEM);
            this.Controls.Add(this.dgvAvailAsset);
            this.Controls.Add(this.label1);
            this.Name = "formManagerMain";
            this.Text = "formManagerMain";
            this.Load += new System.EventHandler(this.formManagerMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailAsset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendEM;
        private System.Windows.Forms.DataGridView dgvAvailAsset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
    }
}