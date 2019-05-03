namespace CarClient
{
    partial class Form1
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
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.carImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblHorsePower = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Horsepower = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxHorsePowerOrder = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFilterHorsePower = new System.Windows.Forms.Button();
            this.Brand = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxModelOrderTab = new System.Windows.Forms.ComboBox();
            this.comboBoxBrands = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBrandFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Horsepower.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Brand.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.Location = new System.Drawing.Point(10, 142);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(285, 316);
            this.listBoxCars.TabIndex = 1;
            this.listBoxCars.SelectedIndexChanged += new System.EventHandler(this.ListBoxCars_SelectedIndexChanged);
            // 
            // carImage
            // 
            this.carImage.ImageLocation = "";
            this.carImage.Location = new System.Drawing.Point(149, 19);
            this.carImage.Name = "carImage";
            this.carImage.Size = new System.Drawing.Size(134, 84);
            this.carImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carImage.TabIndex = 2;
            this.carImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVersion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblFuel);
            this.groupBox1.Controls.Add(this.lblHorsePower);
            this.groupBox1.Controls.Add(this.lblEngine);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblBrand);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.carImage);
            this.groupBox1.Location = new System.Drawing.Point(315, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 316);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Car";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(146, 161);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 13);
            this.lblVersion.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Version";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(146, 251);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 16;
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(146, 229);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(0, 13);
            this.lblFuel.TabIndex = 15;
            // 
            // lblHorsePower
            // 
            this.lblHorsePower.AutoSize = true;
            this.lblHorsePower.Location = new System.Drawing.Point(146, 206);
            this.lblHorsePower.Name = "lblHorsePower";
            this.lblHorsePower.Size = new System.Drawing.Size(0, 13);
            this.lblHorsePower.TabIndex = 14;
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Location = new System.Drawing.Point(146, 183);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(0, 13);
            this.lblEngine.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fuel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Horsepower:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Engine:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(146, 139);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(0, 13);
            this.lblModel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(146, 116);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(0, 13);
            this.lblBrand.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brand:";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetAll.Location = new System.Drawing.Point(519, 11);
            this.btnGetAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(85, 22);
            this.btnGetAll.TabIndex = 5;
            this.btnGetAll.Text = "Get All Cars";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.BtnGetAll_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Horsepower);
            this.tabControl1.Controls.Add(this.Brand);
            this.tabControl1.Location = new System.Drawing.Point(10, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 99);
            this.tabControl1.TabIndex = 6;
            // 
            // Horsepower
            // 
            this.Horsepower.Controls.Add(this.groupBox3);
            this.Horsepower.Location = new System.Drawing.Point(4, 22);
            this.Horsepower.Name = "Horsepower";
            this.Horsepower.Padding = new System.Windows.Forms.Padding(3);
            this.Horsepower.Size = new System.Drawing.Size(586, 73);
            this.Horsepower.TabIndex = 0;
            this.Horsepower.Text = "HorsePower";
            this.Horsepower.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxHorsePowerOrder);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnFilterHorsePower);
            this.groupBox3.Location = new System.Drawing.Point(6, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 67);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filters";
            // 
            // comboBoxHorsePowerOrder
            // 
            this.comboBoxHorsePowerOrder.FormattingEnabled = true;
            this.comboBoxHorsePowerOrder.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.comboBoxHorsePowerOrder.Location = new System.Drawing.Point(80, 19);
            this.comboBoxHorsePowerOrder.Name = "comboBoxHorsePowerOrder";
            this.comboBoxHorsePowerOrder.Size = new System.Drawing.Size(125, 21);
            this.comboBoxHorsePowerOrder.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Horsepower:";
            // 
            // btnFilterHorsePower
            // 
            this.btnFilterHorsePower.Location = new System.Drawing.Point(495, 39);
            this.btnFilterHorsePower.Name = "btnFilterHorsePower";
            this.btnFilterHorsePower.Size = new System.Drawing.Size(79, 22);
            this.btnFilterHorsePower.TabIndex = 0;
            this.btnFilterHorsePower.Text = "Filter";
            this.btnFilterHorsePower.UseVisualStyleBackColor = true;
            this.btnFilterHorsePower.Click += new System.EventHandler(this.BtnFilterHorsePower_Click);
            // 
            // Brand
            // 
            this.Brand.Controls.Add(this.groupBox4);
            this.Brand.Location = new System.Drawing.Point(4, 22);
            this.Brand.Name = "Brand";
            this.Brand.Padding = new System.Windows.Forms.Padding(3);
            this.Brand.Size = new System.Drawing.Size(586, 73);
            this.Brand.TabIndex = 1;
            this.Brand.Text = "Brand";
            this.Brand.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.comboBoxModelOrderTab);
            this.groupBox4.Controls.Add(this.comboBoxBrands);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.btnBrandFilter);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(581, 67);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filters";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Model:";
            // 
            // comboBoxModelOrderTab
            // 
            this.comboBoxModelOrderTab.FormattingEnabled = true;
            this.comboBoxModelOrderTab.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.comboBoxModelOrderTab.Location = new System.Drawing.Point(235, 24);
            this.comboBoxModelOrderTab.Name = "comboBoxModelOrderTab";
            this.comboBoxModelOrderTab.Size = new System.Drawing.Size(125, 21);
            this.comboBoxModelOrderTab.TabIndex = 7;
            // 
            // comboBoxBrands
            // 
            this.comboBoxBrands.FormattingEnabled = true;
            this.comboBoxBrands.Location = new System.Drawing.Point(50, 24);
            this.comboBoxBrands.Name = "comboBoxBrands";
            this.comboBoxBrands.Size = new System.Drawing.Size(125, 21);
            this.comboBoxBrands.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Brand:";
            // 
            // btnBrandFilter
            // 
            this.btnBrandFilter.Location = new System.Drawing.Point(498, 39);
            this.btnBrandFilter.Name = "btnBrandFilter";
            this.btnBrandFilter.Size = new System.Drawing.Size(79, 22);
            this.btnBrandFilter.TabIndex = 0;
            this.btnBrandFilter.Text = "Filter";
            this.btnBrandFilter.UseVisualStyleBackColor = true;
            this.btnBrandFilter.Click += new System.EventHandler(this.BtnBrandFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 463);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxCars);
            this.Name = "Form1";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Horsepower.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Brand.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.PictureBox carImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblHorsePower;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Horsepower;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxHorsePowerOrder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnFilterHorsePower;
        private System.Windows.Forms.TabPage Brand;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxModelOrderTab;
        private System.Windows.Forms.ComboBox comboBoxBrands;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBrandFilter;
    }
}

