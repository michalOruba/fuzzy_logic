namespace FuzzyLogicPrecipitation
{
    partial class CloudyForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloudyForm));
            this.exit_btn = new System.Windows.Forms.Button();
            this.fuzzyDataSet = new FuzzyLogicPrecipitation.FuzzyDataSet();
            this.cloudyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cloudyTableAdapter = new FuzzyLogicPrecipitation.FuzzyDataSetTableAdapters.CloudyTableAdapter();
            this.tableAdapterManager = new FuzzyLogicPrecipitation.FuzzyDataSetTableAdapters.TableAdapterManager();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cloudyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cloudyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fuzzyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudyDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.LightBlue;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_btn.Location = new System.Drawing.Point(325, 589);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(126, 43);
            this.exit_btn.TabIndex = 6;
            this.exit_btn.Text = "Zamknij";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // fuzzyDataSet
            // 
            this.fuzzyDataSet.DataSetName = "FuzzyDataSet";
            this.fuzzyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cloudyBindingSource
            // 
            this.cloudyBindingSource.DataMember = "Cloudy";
            this.cloudyBindingSource.DataSource = this.fuzzyDataSet;
            // 
            // cloudyTableAdapter
            // 
            this.cloudyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CloudyTableAdapter = this.cloudyTableAdapter;
            this.tableAdapterManager.PrecipitationTableAdapter = null;
            this.tableAdapterManager.PressureTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FuzzyLogicPrecipitation.FuzzyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.cloudyBindingSource1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 244);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Bezchmurno";
            series1.XValueMember = "Zachmurzenie";
            series1.YValueMembers = "Bezchmurne";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Małe";
            series2.XValueMember = "Zachmurzenie";
            series2.YValueMembers = "Male";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Pochmurno";
            series3.XValueMember = "Zachmurzenie";
            series3.YValueMembers = "Pochmurno";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Całkowite";
            series4.XValueMember = "Zachmurzenie";
            series4.YValueMembers = "Calkowite";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(776, 321);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // cloudyBindingSource1
            // 
            this.cloudyBindingSource1.DataMember = "Cloudy";
            this.cloudyBindingSource1.DataSource = this.fuzzyDataSet;
            // 
            // cloudyDataGridView
            // 
            this.cloudyDataGridView.AllowUserToAddRows = false;
            this.cloudyDataGridView.AllowUserToDeleteRows = false;
            this.cloudyDataGridView.AllowUserToResizeColumns = false;
            this.cloudyDataGridView.AllowUserToResizeRows = false;
            this.cloudyDataGridView.AutoGenerateColumns = false;
            this.cloudyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cloudyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4});
            this.cloudyDataGridView.DataSource = this.cloudyBindingSource;
            this.cloudyDataGridView.Location = new System.Drawing.Point(69, 2);
            this.cloudyDataGridView.Name = "cloudyDataGridView";
            this.cloudyDataGridView.ReadOnly = true;
            this.cloudyDataGridView.Size = new System.Drawing.Size(644, 221);
            this.cloudyDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Zachmurzenie";
            this.dataGridViewTextBoxColumn2.HeaderText = "Zachmurzenie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Bezchmurne";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Bezchmurne";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Male";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Male";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Pochmurno";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Pochmurno";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Calkowite";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Calkowite";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.cloudyDataGridView);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Location = new System.Drawing.Point(8, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 635);
            this.panel1.TabIndex = 9;
            // 
            // CloudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CloudyForm";
            this.Text = "Zachmurzenie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloudyForm_FormClosing);
            this.Load += new System.EventHandler(this.CloudyForm_Load);
            this.ResizeEnd += new System.EventHandler(this.CloudyForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.fuzzyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudyDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private FuzzyDataSet fuzzyDataSet;
        private System.Windows.Forms.BindingSource cloudyBindingSource;
        private FuzzyDataSetTableAdapters.CloudyTableAdapter cloudyTableAdapter;
        private FuzzyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource cloudyBindingSource1;
        private System.Windows.Forms.DataGridView cloudyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.Panel panel1;
    }
}