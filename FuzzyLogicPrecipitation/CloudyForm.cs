using System;
using System.Drawing;
using System.Windows.Forms;

namespace FuzzyLogicPrecipitation
{
    public partial class CloudyForm : Form
    {
        public CloudyForm()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloudyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VariablesForm variables = new VariablesForm();
            variables.Show();
        }

        private void cloudyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            cloudyBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(fuzzyDataSet);

        }

        private void CloudyForm_Load(object sender, EventArgs e)
        {
            cloudyTableAdapter.Fill(fuzzyDataSet.Cloudy);
            Cursor = Cursors.Default;
        }

        private void CloudyForm_ResizeEnd(object sender, EventArgs e)
        {
            Helper.setAnchorAndLocation(this, panel1);
        }
    }
}