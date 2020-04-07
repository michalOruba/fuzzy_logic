using System;
using System.Drawing;
using System.Windows.Forms;

namespace FuzzyLogicPrecipitation
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RulesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void RulesForm_ResizeEnd(object sender, EventArgs e)
        {
            Helper.setAnchorAndLocation(this, panel1);
        }
    }
}