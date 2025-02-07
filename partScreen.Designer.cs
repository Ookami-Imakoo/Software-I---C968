namespace MatthewEvans___BFM1___Software_I___C968
{
    partial class partScreen
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
            this.addPartLabel = new System.Windows.Forms.Label();
            this.inhouseRadioButton = new System.Windows.Forms.RadioButton();
            this.outsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.idLabel = new System.Windows.Forms.Label();
            this.idValue = new System.Windows.Forms.TextBox();
            this.nameValue = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryValue = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceCostValue = new System.Windows.Forms.TextBox();
            this.priceCostLabel = new System.Windows.Forms.Label();
            this.maxValue = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.machineIDValue = new System.Windows.Forms.TextBox();
            this.machineIDLabel = new System.Windows.Forms.Label();
            this.minValue = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.companyNameValue = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabel.Location = new System.Drawing.Point(12, 9);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(100, 30);
            this.addPartLabel.TabIndex = 0;
            this.addPartLabel.Text = "Add Part";
            // 
            // inhouseRadioButton
            // 
            this.inhouseRadioButton.AutoSize = true;
            this.inhouseRadioButton.Location = new System.Drawing.Point(176, 7);
            this.inhouseRadioButton.Name = "inhouseRadioButton";
            this.inhouseRadioButton.Size = new System.Drawing.Size(116, 34);
            this.inhouseRadioButton.TabIndex = 1;
            this.inhouseRadioButton.TabStop = true;
            this.inhouseRadioButton.Text = "In-House";
            this.inhouseRadioButton.UseVisualStyleBackColor = true;
            this.inhouseRadioButton.CheckedChanged += new System.EventHandler(this.inhouseRadioButton_CheckedChanged);
            // 
            // outsourcedRadioButton
            // 
            this.outsourcedRadioButton.AutoSize = true;
            this.outsourcedRadioButton.Location = new System.Drawing.Point(312, 7);
            this.outsourcedRadioButton.Name = "outsourcedRadioButton";
            this.outsourcedRadioButton.Size = new System.Drawing.Size(139, 34);
            this.outsourcedRadioButton.TabIndex = 2;
            this.outsourcedRadioButton.TabStop = true;
            this.outsourcedRadioButton.Text = "Outsourced";
            this.outsourcedRadioButton.UseVisualStyleBackColor = true;
            this.outsourcedRadioButton.CheckedChanged += new System.EventHandler(this.outsourcedRadioButton_CheckedChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(165, 70);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(34, 30);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            // 
            // idValue
            // 
            this.idValue.Enabled = false;
            this.idValue.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.idValue.HideSelection = false;
            this.idValue.Location = new System.Drawing.Point(205, 67);
            this.idValue.Name = "idValue";
            this.idValue.Size = new System.Drawing.Size(180, 35);
            this.idValue.TabIndex = 4;
            // 
            // nameValue
            // 
            this.nameValue.Location = new System.Drawing.Point(205, 132);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(180, 35);
            this.nameValue.TabIndex = 6;
            this.nameValue.Validating += new System.ComponentModel.CancelEventHandler(this.nameValue_Validating);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(130, 135);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(69, 30);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // inventoryValue
            // 
            this.inventoryValue.Location = new System.Drawing.Point(205, 197);
            this.inventoryValue.Name = "inventoryValue";
            this.inventoryValue.Size = new System.Drawing.Size(180, 35);
            this.inventoryValue.TabIndex = 8;
            this.inventoryValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_DigitBackspace);
            this.inventoryValue.Validating += new System.ComponentModel.CancelEventHandler(this.inventoryValue_Validating);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(99, 200);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(100, 30);
            this.inventoryLabel.TabIndex = 7;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceCostValue
            // 
            this.priceCostValue.Location = new System.Drawing.Point(205, 262);
            this.priceCostValue.Name = "priceCostValue";
            this.priceCostValue.Size = new System.Drawing.Size(180, 35);
            this.priceCostValue.TabIndex = 10;
            this.priceCostValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceCostValue_KeyPress);
            this.priceCostValue.Validating += new System.ComponentModel.CancelEventHandler(this.priceCostValue_Validating);
            // 
            // priceCostLabel
            // 
            this.priceCostLabel.AutoSize = true;
            this.priceCostLabel.Location = new System.Drawing.Point(80, 265);
            this.priceCostLabel.Name = "priceCostLabel";
            this.priceCostLabel.Size = new System.Drawing.Size(119, 30);
            this.priceCostLabel.TabIndex = 9;
            this.priceCostLabel.Text = "Price / Cost";
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(205, 327);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(100, 35);
            this.maxValue.TabIndex = 12;
            this.maxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_DigitBackspace);
            this.maxValue.Validating += new System.ComponentModel.CancelEventHandler(this.maxValue_Validating);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(146, 330);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(53, 30);
            this.maxLabel.TabIndex = 11;
            this.maxLabel.Text = "Max";
            // 
            // machineIDValue
            // 
            this.machineIDValue.Location = new System.Drawing.Point(245, 392);
            this.machineIDValue.Name = "machineIDValue";
            this.machineIDValue.Size = new System.Drawing.Size(180, 35);
            this.machineIDValue.TabIndex = 14;
            this.machineIDValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_DigitBackspace);
            this.machineIDValue.Validating += new System.ComponentModel.CancelEventHandler(this.machineIDValue_Validating);
            // 
            // machineIDLabel
            // 
            this.machineIDLabel.AutoSize = true;
            this.machineIDLabel.Location = new System.Drawing.Point(79, 395);
            this.machineIDLabel.Name = "machineIDLabel";
            this.machineIDLabel.Size = new System.Drawing.Size(120, 30);
            this.machineIDLabel.TabIndex = 13;
            this.machineIDLabel.Text = "Machine ID";
            // 
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(420, 325);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(100, 35);
            this.minValue.TabIndex = 16;
            this.minValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_DigitBackspace);
            this.minValue.Validating += new System.ComponentModel.CancelEventHandler(this.minValue_Validating);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(361, 328);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(49, 30);
            this.minLabel.TabIndex = 15;
            this.minLabel.Text = "Min";
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.Location = new System.Drawing.Point(431, 455);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 41);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(336, 455);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 41);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // companyNameValue
            // 
            this.companyNameValue.Location = new System.Drawing.Point(245, 392);
            this.companyNameValue.Name = "companyNameValue";
            this.companyNameValue.Size = new System.Drawing.Size(180, 35);
            this.companyNameValue.TabIndex = 20;
            this.companyNameValue.Validating += new System.ComponentModel.CancelEventHandler(this.companyNameValue_Validating);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(79, 395);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(163, 30);
            this.companyNameLabel.TabIndex = 19;
            this.companyNameLabel.Text = "Company Name";
            // 
            // partScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(558, 544);
            this.Controls.Add(this.companyNameValue);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.machineIDValue);
            this.Controls.Add(this.machineIDLabel);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceCostValue);
            this.Controls.Add(this.priceCostLabel);
            this.Controls.Add(this.inventoryValue);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idValue);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.outsourcedRadioButton);
            this.Controls.Add(this.inhouseRadioButton);
            this.Controls.Add(this.addPartLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "partScreen";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.RadioButton inhouseRadioButton;
        private System.Windows.Forms.RadioButton outsourcedRadioButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idValue;
        private System.Windows.Forms.TextBox nameValue;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox inventoryValue;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox priceCostValue;
        private System.Windows.Forms.Label priceCostLabel;
        private System.Windows.Forms.TextBox maxValue;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox machineIDValue;
        private System.Windows.Forms.Label machineIDLabel;
        private System.Windows.Forms.TextBox minValue;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox companyNameValue;
        private System.Windows.Forms.Label companyNameLabel;
    }
}