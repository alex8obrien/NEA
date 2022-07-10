
namespace NEA
{
    partial class Inventory
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_title = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_LoadChart = new System.Windows.Forms.Button();
            this.box_MoreOrLess = new System.Windows.Forms.GroupBox();
            this.radio_lessThan = new System.Windows.Forms.RadioButton();
            this.radio_greaterThan = new System.Windows.Forms.RadioButton();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.box_MoreOrLess.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(302, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(135, 24);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Inventory Page";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 125);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ingredients";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(532, 313);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Current Inventory";
            // 
            // btn_LoadChart
            // 
            this.btn_LoadChart.Location = new System.Drawing.Point(219, 67);
            this.btn_LoadChart.Name = "btn_LoadChart";
            this.btn_LoadChart.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadChart.TabIndex = 2;
            this.btn_LoadChart.Text = "Load Chart";
            this.btn_LoadChart.UseVisualStyleBackColor = true;
            this.btn_LoadChart.Click += new System.EventHandler(this.Btn_LoadChart_Click);
            // 
            // box_MoreOrLess
            // 
            this.box_MoreOrLess.Controls.Add(this.radio_lessThan);
            this.box_MoreOrLess.Controls.Add(this.radio_greaterThan);
            this.box_MoreOrLess.Location = new System.Drawing.Point(13, 12);
            this.box_MoreOrLess.Name = "box_MoreOrLess";
            this.box_MoreOrLess.Size = new System.Drawing.Size(200, 100);
            this.box_MoreOrLess.TabIndex = 3;
            this.box_MoreOrLess.TabStop = false;
            this.box_MoreOrLess.Text = "Search Data";
            // 
            // radio_lessThan
            // 
            this.radio_lessThan.AutoSize = true;
            this.radio_lessThan.Location = new System.Drawing.Point(7, 44);
            this.radio_lessThan.Name = "radio_lessThan";
            this.radio_lessThan.Size = new System.Drawing.Size(75, 17);
            this.radio_lessThan.TabIndex = 1;
            this.radio_lessThan.TabStop = true;
            this.radio_lessThan.Text = "Less Than";
            this.radio_lessThan.UseVisualStyleBackColor = true;
            // 
            // radio_greaterThan
            // 
            this.radio_greaterThan.AutoSize = true;
            this.radio_greaterThan.Location = new System.Drawing.Point(7, 20);
            this.radio_greaterThan.Name = "radio_greaterThan";
            this.radio_greaterThan.Size = new System.Drawing.Size(88, 17);
            this.radio_greaterThan.TabIndex = 0;
            this.radio_greaterThan.TabStop = true;
            this.radio_greaterThan.Text = "Greater Than";
            this.radio_greaterThan.UseVisualStyleBackColor = true;
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(219, 41);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(75, 20);
            this.txt_number.TabIndex = 4;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.Location = new System.Drawing.Point(314, 41);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(52, 24);
            this.lbl_error.TabIndex = 5;
            this.lbl_error.Text = "Error";
            this.lbl_error.Visible = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(219, 96);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset Graph";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(713, 415);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.box_MoreOrLess);
            this.Controls.Add(this.btn_LoadChart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbl_title);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.box_MoreOrLess.ResumeLayout(false);
            this.box_MoreOrLess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_LoadChart;
        private System.Windows.Forms.GroupBox box_MoreOrLess;
        private System.Windows.Forms.RadioButton radio_lessThan;
        private System.Windows.Forms.RadioButton radio_greaterThan;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
    }
}