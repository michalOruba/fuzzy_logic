using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace FuzzyLogicPrecipitation
{
    public partial class VariablesForm : Form
    {
        private CloudyForm cloudyForm;
        private PressureForm pressureForm;
        private PrecipitationForm precipitationForm;
        public VariablesForm()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VariablesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void cloudy_btn_Click(object sender, EventArgs e)
        {
            if (cloudyForm == null)
            {
                cloudyForm = new CloudyForm();
                cloudyForm.FormClosed += CloudyForm_FormClosed;
            }
            this.Cursor = Cursors.WaitCursor;
            cloudyForm.Show();
            this.Hide();
        }

        private void CloudyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cloudyForm.FormClosed -= CloudyForm_FormClosed;
            cloudyForm = null;
        }

        private void pressure_btn_Click(object sender, EventArgs e)
        {
            if (pressureForm == null)
            {
                pressureForm = new PressureForm();
                pressureForm.FormClosed += PressureForm_FormClosed;
            }
            this.Cursor = Cursors.WaitCursor;
            pressureForm.Show();
            this.Hide();
        }

        private void PressureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            pressureForm.FormClosed -= PressureForm_FormClosed;
            pressureForm = null;
        }

        private void precipitation_btn_Click(object sender, EventArgs e)
        {
            if (precipitationForm == null)
            {
                precipitationForm = new PrecipitationForm();
                precipitationForm.FormClosed += PrecipitationForm_FormClosed;
            }
            this.Cursor = Cursors.WaitCursor;
            precipitationForm.Show();
            this.Hide();
        }

        private void PrecipitationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            precipitationForm.FormClosed -= PrecipitationForm_FormClosed;
            precipitationForm = null;
        }

        private void VariablesForm_ResizeEnd(object sender, EventArgs e)
        {
            Helper.setAnchorAndLocation(this, panel1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}