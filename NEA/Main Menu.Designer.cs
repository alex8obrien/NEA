
namespace NEA
{
    partial class Main_Menu
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_inventoryPage = new System.Windows.Forms.Button();
            this.btn_orderingPage = new System.Windows.Forms.Button();
            this.btn_ownersMenu = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_logoff = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(688, 403);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 35);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // btn_inventoryPage
            // 
            this.btn_inventoryPage.Location = new System.Drawing.Point(588, 148);
            this.btn_inventoryPage.Name = "btn_inventoryPage";
            this.btn_inventoryPage.Size = new System.Drawing.Size(200, 100);
            this.btn_inventoryPage.TabIndex = 3;
            this.btn_inventoryPage.Text = "Inventory Page";
            this.btn_inventoryPage.UseVisualStyleBackColor = true;
            this.btn_inventoryPage.Click += new System.EventHandler(this.Btn_inventoryPage_Click);
            // 
            // btn_orderingPage
            // 
            this.btn_orderingPage.Location = new System.Drawing.Point(12, 148);
            this.btn_orderingPage.Name = "btn_orderingPage";
            this.btn_orderingPage.Size = new System.Drawing.Size(200, 100);
            this.btn_orderingPage.TabIndex = 1;
            this.btn_orderingPage.Text = "Ordering Page";
            this.btn_orderingPage.UseVisualStyleBackColor = true;
            this.btn_orderingPage.Click += new System.EventHandler(this.Btn_orderingPage_Click);
            // 
            // btn_ownersMenu
            // 
            this.btn_ownersMenu.Location = new System.Drawing.Point(12, 280);
            this.btn_ownersMenu.Name = "btn_ownersMenu";
            this.btn_ownersMenu.Size = new System.Drawing.Size(200, 100);
            this.btn_ownersMenu.TabIndex = 2;
            this.btn_ownersMenu.Text = "Owner\'s Menu";
            this.btn_ownersMenu.UseVisualStyleBackColor = true;
            this.btn_ownersMenu.Visible = false;
            this.btn_ownersMenu.Click += new System.EventHandler(this.Btn_ownersMenu_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(8, 417);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(129, 24);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Logged in as: ";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(317, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(158, 33);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Main Menu";
            // 
            // btn_logoff
            // 
            this.btn_logoff.Location = new System.Drawing.Point(688, 345);
            this.btn_logoff.Name = "btn_logoff";
            this.btn_logoff.Size = new System.Drawing.Size(100, 35);
            this.btn_logoff.TabIndex = 4;
            this.btn_logoff.Text = "Log Off";
            this.btn_logoff.UseVisualStyleBackColor = true;
            this.btn_logoff.Click += new System.EventHandler(this.Btn_logoff_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(295, 148);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(200, 100);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update Information";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_logoff);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_ownersMenu);
            this.Controls.Add(this.btn_orderingPage);
            this.Controls.Add(this.btn_inventoryPage);
            this.Controls.Add(this.btn_Exit);
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_inventoryPage;
        private System.Windows.Forms.Button btn_orderingPage;
        private System.Windows.Forms.Button btn_ownersMenu;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_logoff;
        private System.Windows.Forms.Button btn_update;
    }
}