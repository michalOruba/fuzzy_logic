namespace FuzzyLogicPrecipitation
{
    partial class VariablesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VariablesForm));
            this.exit_btn = new System.Windows.Forms.Button();
            this.cloudy_btn = new System.Windows.Forms.Button();
            this.pressure_btn = new System.Windows.Forms.Button();
            this.precipitation_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.LightBlue;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_btn.Location = new System.Drawing.Point(34, 360);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(126, 43);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Zamknij";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // cloudy_btn
            // 
            this.cloudy_btn.BackColor = System.Drawing.Color.LightBlue;
            this.cloudy_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cloudy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cloudy_btn.Location = new System.Drawing.Point(34, 25);
            this.cloudy_btn.Name = "cloudy_btn";
            this.cloudy_btn.Size = new System.Drawing.Size(126, 43);
            this.cloudy_btn.TabIndex = 0;
            this.cloudy_btn.Text = "Zachmurzenie";
            this.cloudy_btn.UseVisualStyleBackColor = false;
            this.cloudy_btn.Click += new System.EventHandler(this.cloudy_btn_Click);
            // 
            // pressure_btn
            // 
            this.pressure_btn.BackColor = System.Drawing.Color.LightBlue;
            this.pressure_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pressure_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pressure_btn.Location = new System.Drawing.Point(34, 106);
            this.pressure_btn.Name = "pressure_btn";
            this.pressure_btn.Size = new System.Drawing.Size(126, 43);
            this.pressure_btn.TabIndex = 1;
            this.pressure_btn.Text = "Ciśnienie";
            this.pressure_btn.UseVisualStyleBackColor = false;
            this.pressure_btn.Click += new System.EventHandler(this.pressure_btn_Click);
            // 
            // precipitation_btn
            // 
            this.precipitation_btn.BackColor = System.Drawing.Color.LightBlue;
            this.precipitation_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.precipitation_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.precipitation_btn.Location = new System.Drawing.Point(34, 187);
            this.precipitation_btn.Name = "precipitation_btn";
            this.precipitation_btn.Size = new System.Drawing.Size(126, 43);
            this.precipitation_btn.TabIndex = 2;
            this.precipitation_btn.Text = "Opad";
            this.precipitation_btn.UseVisualStyleBackColor = false;
            this.precipitation_btn.Click += new System.EventHandler(this.precipitation_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.precipitation_btn);
            this.panel1.Controls.Add(this.pressure_btn);
            this.panel1.Controls.Add(this.cloudy_btn);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Location = new System.Drawing.Point(305, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 434);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // VariablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VariablesForm";
            this.Text = "Zmienne wejściowe i wyjściowe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VariablesForm_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.VariablesForm_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button cloudy_btn;
        private System.Windows.Forms.Button pressure_btn;
        private System.Windows.Forms.Button precipitation_btn;
        private System.Windows.Forms.Panel panel1;
    }
}