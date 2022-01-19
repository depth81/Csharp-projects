
namespace InventoryManagement
{
    partial class ManageCategories
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
            this.CatNameTb = new System.Windows.Forms.TextBox();
            this.CatIdTb = new System.Windows.Forms.TextBox();
            this.CategoriesGv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGv)).BeginInit();
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
            this.panel1.TabIndex = 2;
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
            this.label2.Location = new System.Drawing.Point(236, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage categories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(102, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // CatNameTb
            // 
            this.CatNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.CatNameTb.ForeColor = System.Drawing.Color.Crimson;
            this.CatNameTb.Location = new System.Drawing.Point(12, 190);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(269, 27);
            this.CatNameTb.TabIndex = 8;
            this.CatNameTb.Text = "CategorieName";
            // 
            // CatIdTb
            // 
            this.CatIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.CatIdTb.ForeColor = System.Drawing.Color.Crimson;
            this.CatIdTb.Location = new System.Drawing.Point(12, 140);
            this.CatIdTb.Name = "CatIdTb";
            this.CatIdTb.Size = new System.Drawing.Size(269, 27);
            this.CatIdTb.TabIndex = 7;
            this.CatIdTb.Text = "CategoriesId";
            // 
            // CategoriesGv
            // 
            this.CategoriesGv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CategoriesGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CategoriesGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesGv.Location = new System.Drawing.Point(305, 140);
            this.CategoriesGv.Name = "CategoriesGv";
            this.CategoriesGv.RowTemplate.Height = 25;
            this.CategoriesGv.Size = new System.Drawing.Size(334, 347);
            this.CategoriesGv.TabIndex = 15;
            this.CategoriesGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesGv_CellContentClick);
            this.CategoriesGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesGv_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(383, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "CATEGORIES LIST";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(25, 448);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 36);
            this.button4.TabIndex = 21;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(120, 448);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 36);
            this.button3.TabIndex = 20;
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
            this.button2.Location = new System.Drawing.Point(120, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 36);
            this.button2.TabIndex = 19;
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
            this.button1.Location = new System.Drawing.Point(25, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 21);
            this.panel2.TabIndex = 22;
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CategoriesGv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CatNameTb);
            this.Controls.Add(this.CatIdTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCategories";
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CatNameTb;
        private System.Windows.Forms.TextBox CatIdTb;
        private System.Windows.Forms.DataGridView CategoriesGv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}