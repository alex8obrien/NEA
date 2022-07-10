
namespace NEA
{
    partial class Owner
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.lbl_staffCount = new System.Windows.Forms.Label();
            this.lbl_moneyMade = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.lbl_mostSold = new System.Windows.Forms.Label();
            this.btn_ownersMenu = new System.Windows.Forms.Button();
            this.lbl_leastSold = new System.Windows.Forms.Label();
            this.lbl_mostMonth = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_leastMonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_staffCount
            // 
            this.lbl_staffCount.AutoSize = true;
            this.lbl_staffCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffCount.Location = new System.Drawing.Point(32, 88);
            this.lbl_staffCount.Name = "lbl_staffCount";
            this.lbl_staffCount.Size = new System.Drawing.Size(148, 24);
            this.lbl_staffCount.TabIndex = 0;
            this.lbl_staffCount.Text = "Number of Staff: ";
            // 
            // lbl_moneyMade
            // 
            this.lbl_moneyMade.AutoSize = true;
            this.lbl_moneyMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moneyMade.Location = new System.Drawing.Point(32, 125);
            this.lbl_moneyMade.Name = "lbl_moneyMade";
            this.lbl_moneyMade.Size = new System.Drawing.Size(129, 24);
            this.lbl_moneyMade.TabIndex = 1;
            this.lbl_moneyMade.Text = "Total income: ";
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(691, 400);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(97, 38);
            this.btn_menu.TabIndex = 2;
            this.btn_menu.Text = "Main Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // lbl_mostSold
            // 
            this.lbl_mostSold.AutoSize = true;
            this.lbl_mostSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mostSold.Location = new System.Drawing.Point(32, 202);
            this.lbl_mostSold.Name = "lbl_mostSold";
            this.lbl_mostSold.Size = new System.Drawing.Size(142, 24);
            this.lbl_mostSold.TabIndex = 5;
            this.lbl_mostSold.Text = "Dish most sold: ";
            // 
            // btn_ownersMenu
            // 
            this.btn_ownersMenu.Location = new System.Drawing.Point(691, 356);
            this.btn_ownersMenu.Name = "btn_ownersMenu";
            this.btn_ownersMenu.Size = new System.Drawing.Size(97, 38);
            this.btn_ownersMenu.TabIndex = 6;
            this.btn_ownersMenu.Text = "Owners Menu";
            this.btn_ownersMenu.UseVisualStyleBackColor = true;
            this.btn_ownersMenu.Click += new System.EventHandler(this.Btn_ownersMenu_Click);
            // 
            // lbl_leastSold
            // 
            this.lbl_leastSold.AutoSize = true;
            this.lbl_leastSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leastSold.Location = new System.Drawing.Point(32, 243);
            this.lbl_leastSold.Name = "lbl_leastSold";
            this.lbl_leastSold.Size = new System.Drawing.Size(140, 24);
            this.lbl_leastSold.TabIndex = 7;
            this.lbl_leastSold.Text = "Dish least sold: ";
            // 
            // lbl_mostMonth
            // 
            this.lbl_mostMonth.AutoSize = true;
            this.lbl_mostMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mostMonth.Location = new System.Drawing.Point(32, 307);
            this.lbl_mostMonth.Name = "lbl_mostMonth";
            this.lbl_mostMonth.Size = new System.Drawing.Size(277, 24);
            this.lbl_mostMonth.TabIndex = 8;
            this.lbl_mostMonth.Text = "This months most popular dish: ";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(299, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(183, 24);
            this.lbl_title.TabIndex = 9;
            this.lbl_title.Text = "Restaurant Overview";
            // 
            // lbl_leastMonth
            // 
            this.lbl_leastMonth.AutoSize = true;
            this.lbl_leastMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leastMonth.Location = new System.Drawing.Point(32, 347);
            this.lbl_leastMonth.Name = "lbl_leastMonth";
            this.lbl_leastMonth.Size = new System.Drawing.Size(275, 24);
            this.lbl_leastMonth.TabIndex = 10;
            this.lbl_leastMonth.Text = "This months least popular dish: ";
            // 
            // owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_leastMonth);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_mostMonth);
            this.Controls.Add(this.lbl_leastSold);
            this.Controls.Add(this.btn_ownersMenu);
            this.Controls.Add(this.lbl_mostSold);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.lbl_moneyMade);
            this.Controls.Add(this.lbl_staffCount);
            this.Name = "owner";
            this.Load += new System.EventHandler(this.Owner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label lbl_staffCount;
        private System.Windows.Forms.Label lbl_moneyMade;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Label lbl_mostSold;
        private System.Windows.Forms.Button btn_ownersMenu;
        private System.Windows.Forms.Label lbl_leastSold;
        private System.Windows.Forms.Label lbl_mostMonth;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_leastMonth;
    }
}