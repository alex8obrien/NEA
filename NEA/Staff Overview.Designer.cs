namespace NEA
{
    partial class Staff_Overview
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDBDataSet = new NEA.cafeDBDataSet();
            this.tbl_staffTableAdapter = new NEA.cafeDBDataSetTableAdapters.tbl_staffTableAdapter();
            this.txt_staffName = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_staff = new System.Windows.Forms.Label();
            this.lbl_information = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_ownersMenu = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(201, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // tblstaffBindingSource
            // 
            this.tblstaffBindingSource.DataMember = "tbl_staff";
            this.tblstaffBindingSource.DataSource = this.cafeDBDataSet;
            // 
            // cafeDBDataSet
            // 
            this.cafeDBDataSet.DataSetName = "cafeDBDataSet";
            this.cafeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_staffTableAdapter
            // 
            this.tbl_staffTableAdapter.ClearBeforeFill = true;
            // 
            // txt_staffName
            // 
            this.txt_staffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staffName.Location = new System.Drawing.Point(494, 58);
            this.txt_staffName.Name = "txt_staffName";
            this.txt_staffName.Size = new System.Drawing.Size(178, 29);
            this.txt_staffName.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(220, 403);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 35);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(441, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(128, 24);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Staff Overview";
            // 
            // lbl_staff
            // 
            this.lbl_staff.AutoSize = true;
            this.lbl_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff.Location = new System.Drawing.Point(361, 58);
            this.lbl_staff.Name = "lbl_staff";
            this.lbl_staff.Size = new System.Drawing.Size(102, 24);
            this.lbl_staff.TabIndex = 4;
            this.lbl_staff.Text = "Staff name:";
            // 
            // lbl_information
            // 
            this.lbl_information.AutoSize = true;
            this.lbl_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_information.Location = new System.Drawing.Point(263, 139);
            this.lbl_information.Name = "lbl_information";
            this.lbl_information.Size = new System.Drawing.Size(160, 144);
            this.lbl_information.TabIndex = 5;
            this.lbl_information.Text = "Phone number:\r\nEmail:\r\nAdmin:\r\n\r\nTotal transactions:\r\nTotal earnings:\r\n";
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(688, 403);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(100, 35);
            this.btn_menu.TabIndex = 6;
            this.btn_menu.Text = "Main Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.Btn_menu_Click);
            // 
            // btn_ownersMenu
            // 
            this.btn_ownersMenu.Location = new System.Drawing.Point(572, 403);
            this.btn_ownersMenu.Name = "btn_ownersMenu";
            this.btn_ownersMenu.Size = new System.Drawing.Size(100, 35);
            this.btn_ownersMenu.TabIndex = 7;
            this.btn_ownersMenu.Text = "Owners Menu";
            this.btn_ownersMenu.UseVisualStyleBackColor = true;
            this.btn_ownersMenu.Click += new System.EventHandler(this.Btn_ownersMenu_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.Location = new System.Drawing.Point(490, 104);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(79, 24);
            this.lbl_error.TabIndex = 8;
            this.lbl_error.Text = "lbl_error";
            this.lbl_error.Visible = false;
            // 
            // Staff_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_ownersMenu);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.lbl_information);
            this.Controls.Add(this.lbl_staff);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_staffName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Staff_Overview";
            this.Text = "Staff_Overview";
            this.Load += new System.EventHandler(this.Staff_Overview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private cafeDBDataSet cafeDBDataSet;
        private System.Windows.Forms.BindingSource tblstaffBindingSource;
        private cafeDBDataSetTableAdapters.tbl_staffTableAdapter tbl_staffTableAdapter;
        private System.Windows.Forms.TextBox txt_staffName;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_staff;
        private System.Windows.Forms.Label lbl_information;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_ownersMenu;
        private System.Windows.Forms.Label lbl_error;
    }
}