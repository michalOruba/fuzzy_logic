using System;
using System.Drawing;
using System.Windows.Forms;

namespace FuzzyLogicPrecipitation
{
    public partial class PrecipitationForm : Form
    {
        public PrecipitationForm()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrecipitationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VariablesForm variables = new VariablesForm();
            variables.Show();
        }

        private void precipitationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.precipitationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fuzzyDataSet);

        }

        private void PrecipitationForm_Load(object sender, EventArgs e)
        {
            this.precipitationTableAdapter.Fill(this.fuzzyDataSet.Precipitation);
            this.Cursor = Cursors.Default;
        }

        private void PrecipitationForm_ResizeEnd(object sender, EventArgs e)
        {
            Helper.setAnchorAndLocation(this, panel1);
        }
    }
}