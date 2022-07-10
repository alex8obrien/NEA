
namespace NEA
{
    partial class Ordering_Page
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
            this.menuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblmenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDBDataSet = new NEA.cafeDBDataSet();
            this.tblordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ordersTableAdapter = new NEA.cafeDBDataSetTableAdapters.tbl_ordersTableAdapter();
            this.tbl_menuTableAdapter = new NEA.cafeDBDataSetTableAdapters.tbl_menuTableAdapter();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_addtoorder = new System.Windows.Forms.Button();
            this.txt_menuName = new System.Windows.Forms.TextBox();
            this.btn_finish = new System.Windows.Forms.Button();
            this.lbl_currentOrder = new System.Windows.Forms.Label();
            this.lbl_menuName = new System.Windows.Forms.Label();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lbl_finishedOrder = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuIDDataGridViewTextBoxColumn,
            this.menuNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblmenuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 426);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // menuIDDataGridViewTextBoxColumn
            // 
            this.menuIDDataGridViewTextBoxColumn.DataPropertyName = "menuID";
            this.menuIDDataGridViewTextBoxColumn.HeaderText = "menuID";
            this.menuIDDataGridViewTextBoxColumn.Name = "menuIDDataGridViewTextBoxColumn";
            this.menuIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuNameDataGridViewTextBoxColumn
            // 
            this.menuNameDataGridViewTextBoxColumn.DataPropertyName = "menuName";
            this.menuNameDataGridViewTextBoxColumn.HeaderText = "menuName";
            this.menuNameDataGridViewTextBoxColumn.Name = "menuNameDataGridViewTextBoxColumn";
            this.menuNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblmenuBindingSource
            // 
            this.tblmenuBindingSource.DataMember = "tbl_menu";
            this.tblmenuBindingSource.DataSource = this.cafeDBDataSet;
            // 
            // cafeDBDataSet
            // 
            this.cafeDBDataSet.DataSetName = "cafeDBDataSet";
            this.cafeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblordersBindingSource
            // 
            this.tblordersBindingSource.DataMember = "tbl_orders";
            this.tblordersBindingSource.DataSource = this.cafeDBDataSet;
            // 
            // tbl_ordersTableAdapter
            // 
            this.tbl_ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_menuTableAdapter
            // 
            this.tbl_menuTableAdapter.ClearBeforeFill = true;
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(659, 387);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(129, 50);
            this.btn_menu.TabIndex = 5;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.Btn_menu_Click);
            // 
            // btn_addtoorder
            // 
            this.btn_addtoorder.Location = new System.Drawing.Point(659, 219);
            this.btn_addtoorder.Name = "btn_addtoorder";
            this.btn_addtoorder.Size = new System.Drawing.Size(129, 50);
            this.btn_addtoorder.TabIndex = 2;
            this.btn_addtoorder.Text = "Add To Order";
            this.btn_addtoorder.UseVisualStyleBackColor = true;
            this.btn_addtoorder.Click += new System.EventHandler(this.Btn_addtoorder_Click);
            // 
            // txt_menuName
            // 
            this.txt_menuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_menuName.Location = new System.Drawing.Point(385, 7);
            this.txt_menuName.Name = "txt_menuName";
            this.txt_menuName.Size = new System.Drawing.Size(159, 29);
            this.txt_menuName.TabIndex = 1;
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(659, 331);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(129, 50);
            this.btn_finish.TabIndex = 4;
            this.btn_finish.Text = "Finish Order";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.Btn_finish_Click);
            // 
            // lbl_currentOrder
            // 
            this.lbl_currentOrder.AutoSize = true;
            this.lbl_currentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentOrder.Location = new System.Drawing.Point(269, 63);
            this.lbl_currentOrder.Name = "lbl_currentOrder";
            this.lbl_currentOrder.Size = new System.Drawing.Size(131, 48);
            this.lbl_currentOrder.TabIndex = 5;
            this.lbl_currentOrder.Text = "Current Order:\r\n\r\n";
            // 
            // lbl_menuName
            // 
            this.lbl_menuName.AutoSize = true;
            this.lbl_menuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menuName.Location = new System.Drawing.Point(262, 7);
            this.lbl_menuName.Name = "lbl_menuName";
            this.lbl_menuName.Size = new System.Drawing.Size(122, 24);
            this.lbl_menuName.TabIndex = 6;
            this.lbl_menuName.Text = "Menu name: ";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(435, 63);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(109, 24);
            this.lbl_totalPrice.TabIndex = 7;
            this.lbl_totalPrice.Text = "Total Price: ";
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(659, 275);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(129, 50);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove Last Item";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.Btn_remove_Click);
            // 
            // lbl_finishedOrder
            // 
            this.lbl_finishedOrder.AutoSize = true;
            this.lbl_finishedOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finishedOrder.Location = new System.Drawing.Point(262, 417);
            this.lbl_finishedOrder.Name = "lbl_finishedOrder";
            this.lbl_finishedOrder.Size = new System.Drawing.Size(145, 24);
            this.lbl_finishedOrder.TabIndex = 9;
            this.lbl_finishedOrder.Text = "Order Complete";
            this.lbl_finishedOrder.Visible = false;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.Location = new System.Drawing.Point(550, 9);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(50, 24);
            this.lbl_error.TabIndex = 11;
            this.lbl_error.Text = "error";
            this.lbl_error.Visible = false;
            // 
            // Ordering_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_finishedOrder);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.lbl_menuName);
            this.Controls.Add(this.lbl_currentOrder);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.txt_menuName);
            this.Controls.Add(this.btn_addtoorder);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ordering_Page";
            this.Text = "Ordering_Page";
            this.Load += new System.EventHandler(this.Ordering_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private cafeDBDataSet cafeDBDataSet;
        private System.Windows.Forms.BindingSource tblordersBindingSource;
        private cafeDBDataSetTableAdapters.tbl_ordersTableAdapter tbl_ordersTableAdapter;
        private System.Windows.Forms.BindingSource tblmenuBindingSource;
        private cafeDBDataSetTableAdapters.tbl_menuTableAdapter tbl_menuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_addtoorder;
        private System.Windows.Forms.TextBox txt_menuName;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.Label lbl_currentOrder;
        private System.Windows.Forms.Label lbl_menuName;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_finishedOrder;
        private System.Windows.Forms.Label lbl_error;
    }
}