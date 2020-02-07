namespace Session2RushYeeet
{
    partial class formAPMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAvailAsset = new System.Windows.Forms.DataGridView();
            this.AssetSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastClosedEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendEM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Assets: ";
            // 
            // dgvAvailAsset
            // 
            this.dgvAvailAsset.AllowUserToAddRows = false;
            this.dgvAvailAsset.AllowUserToDeleteRows = false;
            this.dgvAvailAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailAsset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssetSN,
            this.AssetName,
            this.LastClosedEM,
            this.EMCount});
            this.dgvAvailAsset.Location = new System.Drawing.Point(17, 47);
            this.dgvAvailAsset.Name = "dgvAvailAsset";
            this.dgvAvailAsset.ReadOnly = true;
            this.dgvAvailAsset.RowHeadersWidth = 82;
            this.dgvAvailAsset.RowTemplate.Height = 33;
            this.dgvAvailAsset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailAsset.Size = new System.Drawing.Size(1505, 873);
            this.dgvAvailAsset.TabIndex = 1;
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
            // LastClosedEM
            // 
            this.LastClosedEM.HeaderText = "Last Closed EM";
            this.LastClosedEM.MinimumWidth = 10;
            this.LastClosedEM.Name = "LastClosedEM";
            this.LastClosedEM.ReadOnly = true;
            this.LastClosedEM.Width = 200;
            // 
            // EMCount
            // 
            this.EMCount.HeaderText = "Number of EMs";
            this.EMCount.MinimumWidth = 10;
            this.EMCount.Name = "EMCount";
            this.EMCount.ReadOnly = true;
            this.EMCount.Width = 200;
            // 
            // btnSendEM
            // 
            this.btnSendEM.Location = new System.Drawing.Point(17, 926);
            this.btnSendEM.Name = "btnSendEM";
            this.btnSendEM.Size = new System.Drawing.Size(528, 52);
            this.btnSendEM.TabIndex = 2;
            this.btnSendEM.Text = "Send Emergency Maintenance Request";
            this.btnSendEM.UseVisualStyleBackColor = true;
            this.btnSendEM.Click += new System.EventHandler(this.btnSendEM_Click);
            // 
            // formEMReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 990);
            this.Controls.Add(this.btnSendEM);
            this.Controls.Add(this.dgvAvailAsset);
            this.Controls.Add(this.label1);
            this.Name = "formEMReq";
            this.Text = "Emergency Maintenance Management";
            this.Load += new System.EventHandler(this.formEMReq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailAsset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAvailAsset;
        private System.Windows.Forms.Button btnSendEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastClosedEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMCount;
    }
}