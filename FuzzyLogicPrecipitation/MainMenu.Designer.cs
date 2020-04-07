namespace FuzzyLogicPrecipitation
{
    partial class MainMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.conclusion_btn = new System.Windows.Forms.Button();
            this.variables_btn = new System.Windows.Forms.Button();
            this.rules_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conclusion_btn
            // 
            this.conclusion_btn.BackColor = System.Drawing.Color.LightBlue;
            this.conclusion_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conclusion_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.conclusion_btn.Location = new System.Drawing.Point(27, 54);
            this.conclusion_btn.Name = "conclusion_btn";
            this.conclusion_btn.Size = new System.Drawing.Size(126, 43);
            this.conclusion_btn.TabIndex = 0;
            this.conclusion_btn.Text = "Wnioskowanie";
            this.toolTip1.SetToolTip(this.conclusion_btn, "Menu wnioskowania - pozwala na wprowadzenie danych \r\ni przeprowadzenie dla nich w" +
        "nioskowania.");
            this.conclusion_btn.UseVisualStyleBackColor = false;
            this.conclusion_btn.Click += new System.EventHandler(this.conclusion_btn_Click);
            // 
            // variables_btn
            // 
            this.variables_btn.BackColor = System.Drawing.Color.LightBlue;
            this.variables_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.variables_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.variables_btn.Location = new System.Drawing.Point(27, 130);
            this.variables_btn.Name = "variables_btn";
            this.variables_btn.Size = new System.Drawing.Size(126, 43);
            this.variables_btn.TabIndex = 1;
            this.variables_btn.Text = "Zmienne";
            this.toolTip1.SetToolTip(this.variables_btn, "Menu zmiennych - Zawiera zmienne wykorzystane \r\nw procesie wnioskowania.");
            this.variables_btn.UseVisualStyleBackColor = false;
            this.variables_btn.Click += new System.EventHandler(this.variables_btn_Click);
            // 
            // rules_btn
            // 
            this.rules_btn.BackColor = System.Drawing.Color.LightBlue;
            this.rules_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rules_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rules_btn.Location = new System.Drawing.Point(27, 206);
            this.rules_btn.Name = "rules_btn";
            this.rules_btn.Size = new System.Drawing.Size(126, 43);
            this.rules_btn.TabIndex = 2;
            this.rules_btn.Text = "Reguły";
            this.toolTip1.SetToolTip(this.rules_btn, "Menu reguł - Zawiera reguły wykorzystane \r\nw procesie wnioskowania.");
            this.rules_btn.UseVisualStyleBackColor = false;
            this.rules_btn.Click += new System.EventHandler(this.rules_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.LightBlue;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_btn.Location = new System.Drawing.Point(27, 410);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(126, 43);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Zakończ";
            this.toolTip1.SetToolTip(this.exit_btn, "Zamknij program");
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.rules_btn);
            this.panel1.Controls.Add(this.variables_btn);
            this.panel1.Controls.Add(this.conclusion_btn);
            this.panel1.Location = new System.Drawing.Point(324, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 503);
            this.panel1.TabIndex = 4;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 519);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainMenu";
            this.Text = "Prawdopodobieństwo opadu - Fuzzy Logic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.MainMenu_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button conclusion_btn;
        private System.Windows.Forms.Button variables_btn;
        private System.Windows.Forms.Button rules_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
    }
}

