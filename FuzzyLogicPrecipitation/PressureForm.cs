using System;
using System.Drawing;
using System.Windows.Forms;

namespace FuzzyLogicPrecipitation
{
    public partial class PressureForm : Form
    {
        public PressureForm()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PressureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VariablesForm variables = new VariablesForm();
            variables.Show();
        }

        private void pressureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pressureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fuzzyDataSet);
        }

        private void PressureForm_Load(object sender, EventArgs e)
        {
            this.pressureTableAdapter.Fill(this.fuzzyDataSet.Pressure);
            this.Cursor = Cursors.Default;
        }

        private void PressureForm_ResizeEnd(object sender, EventArgs e)
        {
            Helper.setAnchorAndLocation(this, panel1);
        }
    }
}
