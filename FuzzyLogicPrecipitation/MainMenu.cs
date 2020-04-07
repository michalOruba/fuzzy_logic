using System;
using System.Drawing;
using System.Windows.Forms;

namespace FuzzyLogicPrecipitation
{
    public partial class MainMenu : Form
    {
        private ConclusionForm conclusionForm;
        private VariablesForm variablesForm;
        private RulesForm rulesForm;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e) => Close();

        private void conclusion_btn_Click(object sender, EventArgs e)
        {
            if (conclusionForm == null)
            {
                conclusionForm = new ConclusionForm();
                conclusionForm.FormClosed += ConclusionForm_FormClosed;
            }
            this.Hide();
            conclusionForm.Show();
        }

        private void ConclusionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conclusionForm.FormClosed -= ConclusionForm_FormClosed;
            conclusionForm = null;
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void variables_btn_Click(object sender, EventArgs e)
        {
            if (variablesForm == null)
            {
                variablesForm = new VariablesForm();
                variablesForm.FormClosed += VariablesForm_FormClosed;
            }
            this.Hide();
            variablesForm.Show();
        }

        private void VariablesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            variablesForm.FormClosed -= VariablesForm_FormClosed;
            variablesForm = null;
        }

        private void rules_btn_Click(object sender, EventArgs e)
        {
            if (rulesForm == null)
            {
                rulesForm = new RulesForm();
                rulesForm.FormClosed += RulesForm_FormClosed;
            }
            this.Hide();
            rulesForm.Show();
        }

        private void RulesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            rulesForm.FormClosed -= RulesForm_FormClosed;
            rulesForm = null;
        }

        private void MainMenu_ResizeEnd(object sender, EventArgs e)
        {
            Helper.setAnchorAndLocation(this, panel1);
        }
    }
}