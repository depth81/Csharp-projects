
namespace InventoryManagement
{
    partial class ManageProducts
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProdPriceTb = new System.Windows.Forms.TextBox();
            this.ProdQtyTb = new System.Windows.Forms.TextBox();
            this.ProdNameTb = new System.Windows.Forms.TextBox();
            this.ProdIdTb = new System.Windows.Forms.TextBox();
            this.ProdDescTb = new System.Windows.Forms.TextBox();
            this.CatCombo = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductsGv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 100);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(635, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(236, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(105, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // ProdPriceTb
            // 
            this.ProdPriceTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ProdPriceTb.ForeColor = System.Drawing.Color.Crimson;
            this.ProdPriceTb.Location = new System.Drawing.Point(12, 286);
            this.ProdPriceTb.Name = "ProdPriceTb";
            this.ProdPriceTb.Size = new System.Drawing.Size(269, 27);
            this.ProdPriceTb.TabIndex = 8;
            this.ProdPriceTb.Text = "ProductPrice";
            // 
            // ProdQtyTb
            // 
            this.ProdQtyTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ProdQtyTb.ForeColor = System.Drawing.Color.Crimson;
            this.ProdQtyTb.Location = new System.Drawing.Point(12, 239);
            this.ProdQtyTb.Name = "ProdQtyTb";
            this.ProdQtyTb.Size = new System.Drawing.Size(269, 27);
            this.ProdQtyTb.TabIndex = 7;
            this.ProdQtyTb.Text = "ProductQty";
            // 
            // ProdNameTb
            // 
            this.ProdNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ProdNameTb.ForeColor = System.Drawing.Color.Crimson;
            this.ProdNameTb.Location = new System.Drawing.Point(12, 191);
            this.ProdNameTb.Name = "ProdNameTb";
            this.ProdNameTb.Size = new System.Drawing.Size(269, 27);
            this.ProdNameTb.TabIndex = 6;
            this.ProdNameTb.Text = "FullNameProductName\r\n";
            // 
            // ProdIdTb
            // 
            this.ProdIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ProdIdTb.ForeColor = System.Drawing.Color.Crimson;
            this.ProdIdTb.Location = new System.Drawing.Point(12, 141);
            this.ProdIdTb.Name = "ProdIdTb";
            this.ProdIdTb.Size = new System.Drawing.Size(269, 27);
            this.ProdIdTb.TabIndex = 5;
            this.ProdIdTb.Text = "ProductId";
            // 
            // ProdDescTb
            // 
            this.ProdDescTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ProdDescTb.ForeColor = System.Drawing.Color.Crimson;
            this.ProdDescTb.Location = new System.Drawing.Point(12, 333);
            this.ProdDescTb.Name = "ProdDescTb";
            this.ProdDescTb.Size = new System.Drawing.Size(269, 27);
            this.ProdDescTb.TabIndex = 9;
            this.ProdDescTb.Text = "Description";
            // 
            // CatCombo
            // 
            this.CatCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CatCombo.ForeColor = System.Drawing.Color.Crimson;
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(12, 379);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(269, 27);
            this.CatCombo.TabIndex = 10;
            this.CatCombo.Text = "ProductCategory";
            this.CatCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 479);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 36);
            this.button4.TabIndex = 14;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(107, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 36);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(107, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductsGv
            // 
            this.ProductsGv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProductsGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductsGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGv.Location = new System.Drawing.Point(310, 141);
            this.ProductsGv.Name = "ProductsGv";
            this.ProductsGv.RowTemplate.Height = 25;
            this.ProductsGv.Size = new System.Drawing.Size(339, 374);
            this.ProductsGv.TabIndex = 16;
            this.ProductsGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGv_CellContentClick);
            this.ProductsGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGv_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(399, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "PRODUCTS LIST";
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 541);
            this.Controls.Add(this.ProductsGv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.ProdDescTb);
            this.Controls.Add(this.ProdPriceTb);
            this.Controls.Add(this.ProdQtyTb);
            this.Controls.Add(this.ProdNameTb);
            this.Controls.Add(this.ProdIdTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProdPriceTb;
        private System.Windows.Forms.TextBox ProdQtyTb;
        private System.Windows.Forms.TextBox ProdNameTb;
        private System.Windows.Forms.TextBox ProdIdTb;
        private System.Windows.Forms.TextBox ProdDescTb;
        private System.Windows.Forms.ComboBox CatCombo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ProductsGv;
        private System.Windows.Forms.Label label4;
    }
}