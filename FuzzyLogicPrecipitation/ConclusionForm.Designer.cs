namespace FuzzyLogicPrecipitation
{
    partial class ConclusionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConclusionForm));
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cloudy_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calc_btn = new System.Windows.Forms.Button();
            this.pressure_scrollbar = new System.Windows.Forms.HScrollBar();
            this.cloudy_scrollbar = new System.Windows.Forms.HScrollBar();
            this.pressure_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.result_name_row4_label = new System.Windows.Forms.Label();
            this.result_name_row2_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.result_name_row1_label = new System.Windows.Forms.Label();
            this.result_value_row1_label = new System.Windows.Forms.Label();
            this.result_value_row2_label = new System.Windows.Forms.Label();
            this.result_name_row3_label = new System.Windows.Forms.Label();
            this.result_value_row3_label = new System.Windows.Forms.Label();
            this.result_value_row4_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.min_row4_label = new System.Windows.Forms.Label();
            this.precipitation_row4_label = new System.Windows.Forms.Label();
            this.pressure_row4_label = new System.Windows.Forms.Label();
            this.cloudy_row4_label = new System.Windows.Forms.Label();
            this.min_row3_label = new System.Windows.Forms.Label();
            this.precipitation_row3_label = new System.Windows.Forms.Label();
            this.pressure_row3_label = new System.Windows.Forms.Label();
            this.cloudy_row3_label = new System.Windows.Forms.Label();
            this.min_row2_label = new System.Windows.Forms.Label();
            this.precipitation_row2_label = new System.Windows.Forms.Label();
            this.pressure_row2_label = new System.Windows.Forms.Label();
            this.cloudy_row2_label = new System.Windows.Forms.Label();
            this.min_row1_label = new System.Windows.Forms.Label();
            this.precipitation_row1_label = new System.Windows.Forms.Label();
            this.pressure_row1_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cloudy_row1_label = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.mom_method_label = new System.Windows.Forms.Label();
            this.cog_method_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.LightBlue;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_btn.Location = new System.Drawing.Point(351, 607);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(126, 43);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "Zamknij";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zachmurzenie [%]";
            // 
            // cloudy_textbox
            // 
            this.cloudy_textbox.Location = new System.Drawing.Point(111, 24);
            this.cloudy_textbox.Name = "cloudy_textbox";
            this.cloudy_textbox.Size = new System.Drawing.Size(140, 20);
            this.cloudy_textbox.TabIndex = 0;
            this.cloudy_textbox.TextChanged += new System.EventHandler(this.cloudy_textbox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calc_btn);
            this.groupBox1.Controls.Add(this.pressure_scrollbar);
            this.groupBox1.Controls.Add(this.cloudy_scrollbar);
            this.groupBox1.Controls.Add(this.pressure_textbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cloudy_textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane wejściowe";
            // 
            // calc_btn
            // 
            this.calc_btn.BackColor = System.Drawing.Color.LightBlue;
            this.calc_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calc_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calc_btn.Location = new System.Drawing.Point(538, 52);
            this.calc_btn.Name = "calc_btn";
            this.calc_btn.Size = new System.Drawing.Size(126, 43);
            this.calc_btn.TabIndex = 4;
            this.calc_btn.Text = "Oblicz";
            this.calc_btn.UseVisualStyleBackColor = false;
            this.calc_btn.Click += new System.EventHandler(this.calc_btn_Click);
            // 
            // pressure_scrollbar
            // 
            this.pressure_scrollbar.Location = new System.Drawing.Point(302, 72);
            this.pressure_scrollbar.Maximum = 1109;
            this.pressure_scrollbar.Minimum = 950;
            this.pressure_scrollbar.Name = "pressure_scrollbar";
            this.pressure_scrollbar.Size = new System.Drawing.Size(185, 17);
            this.pressure_scrollbar.TabIndex = 3;
            this.pressure_scrollbar.Value = 950;
            this.pressure_scrollbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pressure_scrollbar_Scroll);
            // 
            // cloudy_scrollbar
            // 
            this.cloudy_scrollbar.Location = new System.Drawing.Point(302, 27);
            this.cloudy_scrollbar.Maximum = 109;
            this.cloudy_scrollbar.Name = "cloudy_scrollbar";
            this.cloudy_scrollbar.Size = new System.Drawing.Size(185, 17);
            this.cloudy_scrollbar.TabIndex = 2;
            this.cloudy_scrollbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cloudy_scrollbar_Scroll);
            // 
            // pressure_textbox
            // 
            this.pressure_textbox.Location = new System.Drawing.Point(111, 69);
            this.pressure_textbox.Name = "pressure_textbox";
            this.pressure_textbox.Size = new System.Drawing.Size(140, 20);
            this.pressure_textbox.TabIndex = 1;
            this.pressure_textbox.TextChanged += new System.EventHandler(this.pressure_textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ciśnienie [hPa]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(15, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 205);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reguły wnioskowania";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.result_name_row4_label, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.result_name_row2_label, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.result_name_row1_label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.result_value_row1_label, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.result_value_row2_label, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.result_name_row3_label, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.result_value_row3_label, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.result_value_row4_label, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(566, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(212, 168);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // result_name_row4_label
            // 
            this.result_name_row4_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result_name_row4_label.AutoSize = true;
            this.result_name_row4_label.Location = new System.Drawing.Point(53, 143);
            this.result_name_row4_label.Name = "result_name_row4_label";
            this.result_name_row4_label.Size = new System.Drawing.Size(0, 13);
            this.result_name_row4_label.TabIndex = 11;
            // 
            // result_name_row2_label
            // 
            this.result_name_row2_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result_name_row2_label.AutoSize = true;
            this.result_name_row2_label.Location = new System.Drawing.Point(53, 76);
            this.result_name_row2_label.Name = "result_name_row2_label";
            this.result_name_row2_label.Size = new System.Drawing.Size(0, 13);
            this.result_name_row2_label.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "P-stwo opadu";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(129, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Wartość";
            // 
            // result_name_row1_label
            // 
            this.result_name_row1_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result_name_row1_label.AutoSize = true;
            this.result_name_row1_label.Location = new System.Drawing.Point(53, 43);
            this.result_name_row1_label.Name = "result_name_row1_label";
            this.result_name_row1_label.Size = new System.Drawing.Size(0, 13);
            this.result_name_row1_label.TabIndex = 5;
            // 
            // result_value_row1_label
            // 
            this.result_value_row1_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result_value_row1_label.AutoSize = true;
            this.result_value_row1_label.Location = new System.Drawing.Point(158, 43);
            this.result_value_row1_label.Name = "result_value_row1_label";
            this.result_value_row1_label.Size = new System.Drawing.Size(0, 13);
            this.result_value_row1_label.TabIndex = 6;
            // 
            // result_value_row2_label
            // 
            this.result_value_row2_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result_value_row2_label.AutoSize = true;
            this.result_value_row2_label.Location = new System.Drawing.Point(158, 76);
            this.result_value_row2_label.Name = "result_value_row2_label";
            this.result_value_row2_label.Size = new System.Drawing.Size(0, 13);
            this.result_value_row2_label.TabIndex = 8;
            // 
            // result_name_row3_label
            // 
            this.result_name_row3_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result_name_row3_label.AutoSize = true;
            this.result_name_row3_label.Location = new System.Drawing.Point(53, 109);
            this.result_name_row3_label.Name = "result_name_row3_label";
            this.result_name_row3_label.Size = new System.Drawing.Size(0, 13);
            this.result_name_row3_label.TabIndex = 9;
            // 
            // result_value_row3_label
            // 
            this.result_value_row3_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result_value_row3_label.AutoSize = true;
            this.result_value_row3_label.Location = new System.Drawing.Point(158, 109);
            this.result_value_row3_label.Name = "result_value_row3_label";
            this.result_value_row3_label.Size = new System.Drawing.Size(0, 13);
            this.result_value_row3_label.TabIndex = 10;
            // 
            // result_value_row4_label
            // 
            this.result_value_row4_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result_value_row4_label.AutoSize = true;
            this.result_value_row4_label.Location = new System.Drawing.Point(158, 143);
            this.result_value_row4_label.Name = "result_value_row4_label";
            this.result_value_row4_label.Size = new System.Drawing.Size(0, 13);
            this.result_value_row4_label.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.30651F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.28353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.26437F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.1456F));
            this.tableLayoutPanel1.Controls.Add(this.min_row4_label, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.precipitation_row4_label, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.pressure_row4_label, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cloudy_row4_label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.min_row3_label, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.precipitation_row3_label, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.pressure_row3_label, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cloudy_row3_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.min_row2_label, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.precipitation_row2_label, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pressure_row2_label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cloudy_row2_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.min_row1_label, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.precipitation_row1_label, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pressure_row1_label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cloudy_row1_label, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(523, 168);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // min_row4_label
            // 
            this.min_row4_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.min_row4_label.AutoSize = true;
            this.min_row4_label.Location = new System.Drawing.Point(412, 143);
            this.min_row4_label.Name = "min_row4_label";
            this.min_row4_label.Size = new System.Drawing.Size(0, 13);
            this.min_row4_label.TabIndex = 19;
            // 
            // precipitation_row4_label
            // 
            this.precipitation_row4_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.precipitation_row4_label.AutoSize = true;
            this.precipitation_row4_label.Location = new System.Drawing.Point(247, 143);
            this.precipitation_row4_label.Name = "precipitation_row4_label";
            this.precipitation_row4_label.Size = new System.Drawing.Size(0, 13);
            this.precipitation_row4_label.TabIndex = 18;
            // 
            // pressure_row4_label
            // 
            this.pressure_row4_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pressure_row4_label.AutoSize = true;
            this.pressure_row4_label.Location = new System.Drawing.Point(149, 143);
            this.pressure_row4_label.Name = "pressure_row4_label";
            this.pressure_row4_label.Size = new System.Drawing.Size(0, 13);
            this.pressure_row4_label.TabIndex = 17;
            // 
            // cloudy_row4_label
            // 
            this.cloudy_row4_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cloudy_row4_label.AutoSize = true;
            this.cloudy_row4_label.Location = new System.Drawing.Point(53, 143);
            this.cloudy_row4_label.Name = "cloudy_row4_label";
            this.cloudy_row4_label.Size = new System.Drawing.Size(0, 13);
            this.cloudy_row4_label.TabIndex = 16;
            // 
            // min_row3_label
            // 
            this.min_row3_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.min_row3_label.AutoSize = true;
            this.min_row3_label.Location = new System.Drawing.Point(412, 109);
            this.min_row3_label.Name = "min_row3_label";
            this.min_row3_label.Size = new System.Drawing.Size(0, 13);
            this.min_row3_label.TabIndex = 15;
            // 
            // precipitation_row3_label
            // 
            this.precipitation_row3_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.precipitation_row3_label.AutoSize = true;
            this.precipitation_row3_label.Location = new System.Drawing.Point(247, 109);
            this.precipitation_row3_label.Name = "precipitation_row3_label";
            this.precipitation_row3_label.Size = new System.Drawing.Size(0, 13);
            this.precipitation_row3_label.TabIndex = 14;
            // 
            // pressure_row3_label
            // 
            this.pressure_row3_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pressure_row3_label.AutoSize = true;
            this.pressure_row3_label.Location = new System.Drawing.Point(149, 109);
            this.pressure_row3_label.Name = "pressure_row3_label";
            this.pressure_row3_label.Size = new System.Drawing.Size(0, 13);
            this.pressure_row3_label.TabIndex = 13;
            // 
            // cloudy_row3_label
            // 
            this.cloudy_row3_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cloudy_row3_label.AutoSize = true;
            this.cloudy_row3_label.Location = new System.Drawing.Point(53, 109);
            this.cloudy_row3_label.Name = "cloudy_row3_label";
            this.cloudy_row3_label.Size = new System.Drawing.Size(0, 13);
            this.cloudy_row3_label.TabIndex = 12;
            // 
            // min_row2_label
            // 
            this.min_row2_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.min_row2_label.AutoSize = true;
            this.min_row2_label.Location = new System.Drawing.Point(412, 76);
            this.min_row2_label.Name = "min_row2_label";
            this.min_row2_label.Size = new System.Drawing.Size(0, 13);
            this.min_row2_label.TabIndex = 11;
            // 
            // precipitation_row2_label
            // 
            this.precipitation_row2_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.precipitation_row2_label.AutoSize = true;
            this.precipitation_row2_label.Location = new System.Drawing.Point(247, 76);
            this.precipitation_row2_label.Name = "precipitation_row2_label";
            this.precipitation_row2_label.Size = new System.Drawing.Size(0, 13);
            this.precipitation_row2_label.TabIndex = 10;
            // 
            // pressure_row2_label
            // 
            this.pressure_row2_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pressure_row2_label.AutoSize = true;
            this.pressure_row2_label.Location = new System.Drawing.Point(149, 76);
            this.pressure_row2_label.Name = "pressure_row2_label";
            this.pressure_row2_label.Size = new System.Drawing.Size(0, 13);
            this.pressure_row2_label.TabIndex = 9;
            // 
            // cloudy_row2_label
            // 
            this.cloudy_row2_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cloudy_row2_label.AutoSize = true;
            this.cloudy_row2_label.Location = new System.Drawing.Point(53, 76);
            this.cloudy_row2_label.Name = "cloudy_row2_label";
            this.cloudy_row2_label.Size = new System.Drawing.Size(0, 13);
            this.cloudy_row2_label.TabIndex = 8;
            // 
            // min_row1_label
            // 
            this.min_row1_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.min_row1_label.AutoSize = true;
            this.min_row1_label.Location = new System.Drawing.Point(412, 43);
            this.min_row1_label.Name = "min_row1_label";
            this.min_row1_label.Size = new System.Drawing.Size(0, 13);
            this.min_row1_label.TabIndex = 7;
            // 
            // precipitation_row1_label
            // 
            this.precipitation_row1_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.precipitation_row1_label.AutoSize = true;
            this.precipitation_row1_label.Location = new System.Drawing.Point(247, 43);
            this.precipitation_row1_label.Name = "precipitation_row1_label";
            this.precipitation_row1_label.Size = new System.Drawing.Size(0, 13);
            this.precipitation_row1_label.TabIndex = 6;
            // 
            // pressure_row1_label
            // 
            this.pressure_row1_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pressure_row1_label.AutoSize = true;
            this.pressure_row1_label.Location = new System.Drawing.Point(149, 43);
            this.pressure_row1_label.Name = "pressure_row1_label";
            this.pressure_row1_label.Size = new System.Drawing.Size(0, 13);
            this.pressure_row1_label.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(310, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Min (Zachmurzenie, Ciśnienie)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(200, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "P-stwo opadu";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(115, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ciśnienie";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Zachmurzenie";
            // 
            // cloudy_row1_label
            // 
            this.cloudy_row1_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cloudy_row1_label.AutoSize = true;
            this.cloudy_row1_label.Location = new System.Drawing.Point(53, 43);
            this.cloudy_row1_label.Name = "cloudy_row1_label";
            this.cloudy_row1_label.Size = new System.Drawing.Size(0, 13);
            this.cloudy_row1_label.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Location = new System.Drawing.Point(18, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(795, 283);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wyniki";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.mom_method_label, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.cog_method_label, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(563, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(212, 142);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // mom_method_label
            // 
            this.mom_method_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mom_method_label.AutoSize = true;
            this.mom_method_label.Location = new System.Drawing.Point(106, 117);
            this.mom_method_label.Name = "mom_method_label";
            this.mom_method_label.Size = new System.Drawing.Size(0, 13);
            this.mom_method_label.TabIndex = 7;
            // 
            // cog_method_label
            // 
            this.cog_method_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cog_method_label.AutoSize = true;
            this.cog_method_label.Location = new System.Drawing.Point(106, 46);
            this.cog_method_label.Name = "cog_method_label";
            this.cog_method_label.Size = new System.Drawing.Size(0, 13);
            this.cog_method_label.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(23, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Metoda środka ciężkości";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(7, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Metoda średniego maksimum";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(20, 19);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "wynik";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(523, 247);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 653);
            this.panel1.TabIndex = 11;
            // 
            // ConclusionForm
            // 
            this.AcceptButton = this.calc_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 665);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConclusionForm";
            this.Text = "Wnioskowanie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConclusionForm_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.ConclusionForm_ResizeEnd);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cloudy_textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button calc_btn;
        private System.Windows.Forms.HScrollBar pressure_scrollbar;
        private System.Windows.Forms.HScrollBar cloudy_scrollbar;
        private System.Windows.Forms.TextBox pressure_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label result_name_row2_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label result_name_row1_label;
        private System.Windows.Forms.Label result_value_row1_label;
        private System.Windows.Forms.Label result_value_row2_label;
        private System.Windows.Forms.Label min_row4_label;
        private System.Windows.Forms.Label precipitation_row4_label;
        private System.Windows.Forms.Label pressure_row4_label;
        private System.Windows.Forms.Label cloudy_row4_label;
        private System.Windows.Forms.Label min_row3_label;
        private System.Windows.Forms.Label precipitation_row3_label;
        private System.Windows.Forms.Label pressure_row3_label;
        private System.Windows.Forms.Label cloudy_row3_label;
        private System.Windows.Forms.Label min_row2_label;
        private System.Windows.Forms.Label precipitation_row2_label;
        private System.Windows.Forms.Label pressure_row2_label;
        private System.Windows.Forms.Label cloudy_row2_label;
        private System.Windows.Forms.Label min_row1_label;
        private System.Windows.Forms.Label precipitation_row1_label;
        private System.Windows.Forms.Label pressure_row1_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cloudy_row1_label;
        private System.Windows.Forms.Label result_name_row4_label;
        private System.Windows.Forms.Label result_name_row3_label;
        private System.Windows.Forms.Label result_value_row3_label;
        private System.Windows.Forms.Label result_value_row4_label;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label mom_method_label;
        private System.Windows.Forms.Label cog_method_label;
        private System.Windows.Forms.Panel panel1;
    }
}