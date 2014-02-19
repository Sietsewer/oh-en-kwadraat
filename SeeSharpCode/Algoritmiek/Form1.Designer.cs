namespace WindowsFormsApplication1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.drp_Sort = new System.Windows.Forms.ComboBox();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.btn_Random = new System.Windows.Forms.Button();
            this.txt_Elements = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 40);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(670, 424);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // drp_Sort
            // 
            this.drp_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drp_Sort.FormattingEnabled = true;
            this.drp_Sort.Items.AddRange(new object[] {
            "Bogo Sort (NOT FOR MORTALS)",
            "Bubble Sort",
            "Heap Sort",
            "Quick Sort"});
            this.drp_Sort.Location = new System.Drawing.Point(13, 13);
            this.drp_Sort.Name = "drp_Sort";
            this.drp_Sort.Size = new System.Drawing.Size(184, 21);
            this.drp_Sort.TabIndex = 1;
            this.drp_Sort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(204, 13);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(48, 21);
            this.btn_Sort.TabIndex = 2;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Random
            // 
            this.btn_Random.Location = new System.Drawing.Point(258, 13);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(75, 21);
            this.btn_Random.TabIndex = 3;
            this.btn_Random.Text = "Re-shuffle";
            this.btn_Random.UseVisualStyleBackColor = true;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
            // 
            // txt_Elements
            // 
            this.txt_Elements.Location = new System.Drawing.Point(340, 13);
            this.txt_Elements.Name = "txt_Elements";
            this.txt_Elements.Size = new System.Drawing.Size(100, 20);
            this.txt_Elements.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 476);
            this.Controls.Add(this.txt_Elements);
            this.Controls.Add(this.btn_Random);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.drp_Sort);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox drp_Sort;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.TextBox txt_Elements;
    }
}

