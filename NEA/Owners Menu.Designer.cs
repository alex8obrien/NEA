
namespace NEA
{
    partial class Owners_Menu
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
            this.btn_staffOverview = new System.Windows.Forms.Button();
            this.btn_restaurantOverview = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_staffOverview
            // 
            this.btn_staffOverview.Location = new System.Drawing.Point(176, 74);
            this.btn_staffOverview.Name = "btn_staffOverview";
            this.btn_staffOverview.Size = new System.Drawing.Size(150, 60);
            this.btn_staffOverview.TabIndex = 1;
            this.btn_staffOverview.Text = "Staff Overview";
            this.btn_staffOverview.UseVisualStyleBackColor = true;
            this.btn_staffOverview.Click += new System.EventHandler(this.Btn_staffOverview_Click);
            // 
            // btn_restaurantOverview
            // 
            this.btn_restaurantOverview.Location = new System.Drawing.Point(416, 74);
            this.btn_restaurantOverview.Name = "btn_restaurantOverview";
            this.btn_restaurantOverview.Size = new System.Drawing.Size(150, 60);
            this.btn_restaurantOverview.TabIndex = 2;
            this.btn_restaurantOverview.Text = "Restaurant Overview";
            this.btn_restaurantOverview.UseVisualStyleBackColor = true;
            this.btn_restaurantOverview.Click += new System.EventHandler(this.Btn_restaurantOverview_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(274, 163);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(202, 39);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.Text = "Main Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.Btn_menu_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(312, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(134, 24);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Owner\'s Menu";
            // 
            // Owners_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_restaurantOverview);
            this.Controls.Add(this.btn_staffOverview);
            this.Name = "Owners_Menu";
            this.Text = "Owners_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_staffOverview;
        private System.Windows.Forms.Button btn_restaurantOverview;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Label lbl_title;
    }
}