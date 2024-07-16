namespace Stock_Control_Application
{
    partial class frmAddProduct
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.btn_ımage = new System.Windows.Forms.Button();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_qantity = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.PB_ = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(80, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "EA Logistics";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Stock_Control_Application.Properties.Resources.pngwing_com__11_;
            this.pictureBox1.Image = global::Stock_Control_Application.Properties.Resources.pngwing_com__11_;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cmb_category);
            this.panel1.Controls.Add(this.btn_ımage);
            this.panel1.Controls.Add(this.btn_addproduct);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_qantity);
            this.panel1.Controls.Add(this.txt_price);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.filename);
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Controls.Add(this.txt_supplier);
            this.panel1.Controls.Add(this.txt_product);
            this.panel1.Location = new System.Drawing.Point(422, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 524);
            this.panel1.TabIndex = 4;
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Items.AddRange(new object[] {
            "Electronics",
            "Furniture",
            "Clothing and Apparel",
            "Food and Beverage",
            "Pharmaceuticals",
            "Automotive Parts",
            "Industrial Equipment",
            "Household Goods",
            "Cosmetics and Personal Care",
            "Building Materials",
            "Toys and Games",
            "Office Supplies",
            "Agricultural Products",
            "Textiles and Fabrics",
            "Medical Equipment"});
            this.cmb_category.Location = new System.Drawing.Point(68, 172);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(130, 21);
            this.cmb_category.TabIndex = 5;
            // 
            // btn_ımage
            // 
            this.btn_ımage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ımage.Location = new System.Drawing.Point(264, 285);
            this.btn_ımage.Name = "btn_ımage";
            this.btn_ımage.Size = new System.Drawing.Size(68, 24);
            this.btn_ımage.TabIndex = 4;
            this.btn_ımage.Text = "Add Image";
            this.btn_ımage.UseVisualStyleBackColor = false;
            this.btn_ımage.Click += new System.EventHandler(this.btn_ımage_Click);
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_addproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addproduct.ForeColor = System.Drawing.Color.White;
            this.btn_addproduct.Location = new System.Drawing.Point(128, 371);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(183, 64);
            this.btn_addproduct.TabIndex = 4;
            this.btn_addproduct.Text = "Add Product";
            this.btn_addproduct.UseVisualStyleBackColor = false;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price";
            // 
            // txt_qantity
            // 
            this.txt_qantity.Location = new System.Drawing.Point(68, 224);
            this.txt_qantity.Name = "txt_qantity";
            this.txt_qantity.Size = new System.Drawing.Size(130, 20);
            this.txt_qantity.TabIndex = 2;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(271, 224);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(130, 20);
            this.txt_price.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "ImageUrl";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(128, 287);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(130, 20);
            this.filename.TabIndex = 0;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(271, 172);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(130, 20);
            this.txt_description.TabIndex = 0;
            // 
            // txt_supplier
            // 
            this.txt_supplier.Location = new System.Drawing.Point(271, 119);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.Size = new System.Drawing.Size(130, 20);
            this.txt_supplier.TabIndex = 0;
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(68, 119);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(130, 20);
            this.txt_product.TabIndex = 0;
            // 
            // PB_
            // 
            this.PB_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_.Location = new System.Drawing.Point(60, 116);
            this.PB_.Name = "PB_";
            this.PB_.Size = new System.Drawing.Size(277, 295);
            this.PB_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_.TabIndex = 5;
            this.PB_.TabStop = false;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 522);
            this.Controls.Add(this.PB_);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAddProduct";
            this.Text = "frmAddProduct";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.Button btn_ımage;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.PictureBox PB_;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.TextBox txt_qantity;
    }
}