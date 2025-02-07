namespace MatthewEvans___BFM1___Software_I___C968
{
    partial class productScreen
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
            this.addProductLabel = new System.Windows.Forms.Label();
            this.allCandidateAddButton = new System.Windows.Forms.Button();
            this.allCandidatePartsLabel = new System.Windows.Forms.Label();
            this.allCandidateSearchValue = new System.Windows.Forms.TextBox();
            this.allCandidateSearchButton = new System.Windows.Forms.Button();
            this.allCandidateDataGridView = new System.Windows.Forms.DataGridView();
            this.partsAssociatedDeleteButton = new System.Windows.Forms.Button();
            this.partsAssociatedLabel = new System.Windows.Forms.Label();
            this.partsAssociatedDataGridView = new System.Windows.Forms.DataGridView();
            this.productCancelButton = new System.Windows.Forms.Button();
            this.productSaveButton = new System.Windows.Forms.Button();
            this.minValue = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxValue = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceCostValue = new System.Windows.Forms.TextBox();
            this.priceCostLabel = new System.Windows.Forms.Label();
            this.inventoryValue = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.allCandidateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsAssociatedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabel.Location = new System.Drawing.Point(12, 9);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(138, 30);
            this.addProductLabel.TabIndex = 0;
            this.addProductLabel.Text = "Add Product";
            // 
            // allCandidateAddButton
            // 
            this.allCandidateAddButton.Location = new System.Drawing.Point(1314, 381);
            this.allCandidateAddButton.Name = "allCandidateAddButton";
            this.allCandidateAddButton.Size = new System.Drawing.Size(89, 41);
            this.allCandidateAddButton.TabIndex = 12;
            this.allCandidateAddButton.Text = "Add";
            this.allCandidateAddButton.UseVisualStyleBackColor = true;
            this.allCandidateAddButton.Click += new System.EventHandler(this.allCandidateAddButton_Click);
            // 
            // allCandidatePartsLabel
            // 
            this.allCandidatePartsLabel.AutoSize = true;
            this.allCandidatePartsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.allCandidatePartsLabel.Location = new System.Drawing.Point(706, 90);
            this.allCandidatePartsLabel.Name = "allCandidatePartsLabel";
            this.allCandidatePartsLabel.Size = new System.Drawing.Size(147, 21);
            this.allCandidatePartsLabel.TabIndex = 11;
            this.allCandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // allCandidateSearchValue
            // 
            this.allCandidateSearchValue.Location = new System.Drawing.Point(1171, 80);
            this.allCandidateSearchValue.Name = "allCandidateSearchValue";
            this.allCandidateSearchValue.Size = new System.Drawing.Size(259, 35);
            this.allCandidateSearchValue.TabIndex = 10;
            this.allCandidateSearchValue.TextChanged += new System.EventHandler(this.allCandidateSearchValue_TextChanged);
            // 
            // allCandidateSearchButton
            // 
            this.allCandidateSearchButton.Location = new System.Drawing.Point(1075, 78);
            this.allCandidateSearchButton.Name = "allCandidateSearchButton";
            this.allCandidateSearchButton.Size = new System.Drawing.Size(90, 40);
            this.allCandidateSearchButton.TabIndex = 9;
            this.allCandidateSearchButton.Text = "Search";
            this.allCandidateSearchButton.UseVisualStyleBackColor = true;
            this.allCandidateSearchButton.Click += new System.EventHandler(this.allCandidateSearchButton_Click);
            // 
            // allCandidateDataGridView
            // 
            this.allCandidateDataGridView.AllowUserToAddRows = false;
            this.allCandidateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allCandidateDataGridView.Location = new System.Drawing.Point(710, 124);
            this.allCandidateDataGridView.MultiSelect = false;
            this.allCandidateDataGridView.Name = "allCandidateDataGridView";
            this.allCandidateDataGridView.ReadOnly = true;
            this.allCandidateDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allCandidateDataGridView.Size = new System.Drawing.Size(720, 251);
            this.allCandidateDataGridView.TabIndex = 8;
            this.allCandidateDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.allCandidateDataGridView_DataBindingComplete);
            // 
            // partsAssociatedDeleteButton
            // 
            this.partsAssociatedDeleteButton.Location = new System.Drawing.Point(1314, 769);
            this.partsAssociatedDeleteButton.Name = "partsAssociatedDeleteButton";
            this.partsAssociatedDeleteButton.Size = new System.Drawing.Size(89, 41);
            this.partsAssociatedDeleteButton.TabIndex = 17;
            this.partsAssociatedDeleteButton.Text = "Delete";
            this.partsAssociatedDeleteButton.UseVisualStyleBackColor = true;
            this.partsAssociatedDeleteButton.Click += new System.EventHandler(this.partsAssociatedDeleteButton_Click);
            // 
            // partsAssociatedLabel
            // 
            this.partsAssociatedLabel.AutoSize = true;
            this.partsAssociatedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.partsAssociatedLabel.Location = new System.Drawing.Point(706, 478);
            this.partsAssociatedLabel.Name = "partsAssociatedLabel";
            this.partsAssociatedLabel.Size = new System.Drawing.Size(257, 21);
            this.partsAssociatedLabel.TabIndex = 16;
            this.partsAssociatedLabel.Text = "Parts Associated with this Product";
            // 
            // partsAssociatedDataGridView
            // 
            this.partsAssociatedDataGridView.AllowUserToAddRows = false;
            this.partsAssociatedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsAssociatedDataGridView.Location = new System.Drawing.Point(710, 512);
            this.partsAssociatedDataGridView.Name = "partsAssociatedDataGridView";
            this.partsAssociatedDataGridView.ReadOnly = true;
            this.partsAssociatedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsAssociatedDataGridView.Size = new System.Drawing.Size(720, 251);
            this.partsAssociatedDataGridView.TabIndex = 13;
            this.partsAssociatedDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.partsAssociatedDataGridView_DataBindingComplete);
            // 
            // productCancelButton
            // 
            this.productCancelButton.Location = new System.Drawing.Point(1314, 853);
            this.productCancelButton.Name = "productCancelButton";
            this.productCancelButton.Size = new System.Drawing.Size(89, 41);
            this.productCancelButton.TabIndex = 19;
            this.productCancelButton.Text = "Cancel";
            this.productCancelButton.UseVisualStyleBackColor = true;
            this.productCancelButton.Click += new System.EventHandler(this.productCancelButton_Click);
            // 
            // productSaveButton
            // 
            this.productSaveButton.Location = new System.Drawing.Point(1219, 853);
            this.productSaveButton.Name = "productSaveButton";
            this.productSaveButton.Size = new System.Drawing.Size(89, 41);
            this.productSaveButton.TabIndex = 18;
            this.productSaveButton.Text = "Save";
            this.productSaveButton.UseVisualStyleBackColor = true;
            this.productSaveButton.Click += new System.EventHandler(this.productSaveButton_Click);
            // 
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(412, 514);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(100, 35);
            this.minValue.TabIndex = 47;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(353, 517);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(49, 30);
            this.minLabel.TabIndex = 46;
            this.minLabel.Text = "Min";
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(197, 516);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(100, 35);
            this.maxValue.TabIndex = 45;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(138, 519);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(53, 30);
            this.maxLabel.TabIndex = 44;
            this.maxLabel.Text = "Max";
            // 
            // priceCostValue
            // 
            this.priceCostValue.Location = new System.Drawing.Point(197, 451);
            this.priceCostValue.Name = "priceCostValue";
            this.priceCostValue.Size = new System.Drawing.Size(180, 35);
            this.priceCostValue.TabIndex = 43;
            // 
            // priceCostLabel
            // 
            this.priceCostLabel.AutoSize = true;
            this.priceCostLabel.Location = new System.Drawing.Point(72, 454);
            this.priceCostLabel.Name = "priceCostLabel";
            this.priceCostLabel.Size = new System.Drawing.Size(119, 30);
            this.priceCostLabel.TabIndex = 42;
            this.priceCostLabel.Text = "Price / Cost";
            // 
            // inventoryValue
            // 
            this.inventoryValue.Location = new System.Drawing.Point(197, 386);
            this.inventoryValue.Name = "inventoryValue";
            this.inventoryValue.Size = new System.Drawing.Size(180, 35);
            this.inventoryValue.TabIndex = 41;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(91, 389);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(100, 30);
            this.inventoryLabel.TabIndex = 40;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameValue
            // 
            this.nameValue.Location = new System.Drawing.Point(197, 321);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(180, 35);
            this.nameValue.TabIndex = 39;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(122, 324);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(69, 30);
            this.nameLabel.TabIndex = 38;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(157, 259);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(34, 30);
            this.idLabel.TabIndex = 36;
            this.idLabel.Text = "ID";
            // 
            // idValue
            // 
            this.idValue.Enabled = false;
            this.idValue.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.idValue.HideSelection = false;
            this.idValue.Location = new System.Drawing.Point(197, 256);
            this.idValue.Name = "idValue";
            this.idValue.Size = new System.Drawing.Size(180, 35);
            this.idValue.TabIndex = 48;
            // 
            // productScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1515, 928);
            this.Controls.Add(this.idValue);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceCostValue);
            this.Controls.Add(this.priceCostLabel);
            this.Controls.Add(this.inventoryValue);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.productCancelButton);
            this.Controls.Add(this.productSaveButton);
            this.Controls.Add(this.partsAssociatedDeleteButton);
            this.Controls.Add(this.partsAssociatedLabel);
            this.Controls.Add(this.partsAssociatedDataGridView);
            this.Controls.Add(this.allCandidateAddButton);
            this.Controls.Add(this.allCandidatePartsLabel);
            this.Controls.Add(this.allCandidateSearchValue);
            this.Controls.Add(this.allCandidateSearchButton);
            this.Controls.Add(this.allCandidateDataGridView);
            this.Controls.Add(this.addProductLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "productScreen";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.allCandidateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsAssociatedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Button allCandidateAddButton;
        private System.Windows.Forms.Label allCandidatePartsLabel;
        private System.Windows.Forms.TextBox allCandidateSearchValue;
        private System.Windows.Forms.Button allCandidateSearchButton;
        private System.Windows.Forms.DataGridView allCandidateDataGridView;
        private System.Windows.Forms.Button partsAssociatedDeleteButton;
        private System.Windows.Forms.Label partsAssociatedLabel;
        private System.Windows.Forms.DataGridView partsAssociatedDataGridView;
        private System.Windows.Forms.Button productCancelButton;
        private System.Windows.Forms.Button productSaveButton;
        private System.Windows.Forms.TextBox minValue;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox maxValue;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox priceCostValue;
        private System.Windows.Forms.Label priceCostLabel;
        private System.Windows.Forms.TextBox inventoryValue;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox nameValue;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idValue;
    }
}