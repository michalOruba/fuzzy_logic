using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
    
namespace FuzzyLogicPrecipitation
{
    public partial class ConclusionForm : Form
    {
        public ConclusionForm()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e) => Close();

        private void ConclusionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cloudy_scrollbar_Scroll(object sender, ScrollEventArgs e)
        {
            cloudy_textbox.Text = cloudy_scrollbar.Value.ToString();
        }

        private void pressure_scrollbar_Scroll(object sender, ScrollEventArgs e)
        {
            pressure_textbox.Text = pressure_scrollbar.Value.ToString();
        }

        private void cloudy_textbox_TextChanged(object sender, EventArgs e)
        {
            int number;
            string numberStr = cloudy_textbox.Text;
            bool isParsable = Int32.TryParse(numberStr, out number);
            if (isParsable && number >= 0 && number <= 100)
            {
                cloudy_scrollbar.Value = number;
            }
        }
      
        private void pressure_textbox_TextChanged(object sender, EventArgs e)
        {
            int number;
            string numberStr = pressure_textbox.Text;
            bool isParsable = Int32.TryParse(numberStr, out number);
            if (isParsable && number >= 950 && number <= 1100)
                pressure_scrollbar.Value = number;
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            clearForm();
            if (!validateForm()) return;
            this.Cursor = Cursors.WaitCursor;
            calculatePrecipitation();
            this.Cursor = Cursors.Default;
        }
        
        private bool validateForm()
        {
            string numberCloudyStr = cloudy_textbox.Text;
            string numberPressureStr = pressure_textbox.Text;
            if (!validateInput(numberCloudyStr, 0, 100, "zachmurzenia") || !validateInput(numberPressureStr, 950, 1100, "ciśnienia"))
            {
                return false;
            }
            return true;
        }

        private bool validateInput(string text, int minValue, int maxValue, string textBoxName)
        {
            int result;
            bool isParsable = Int32.TryParse(text, out result);
            if (!(isParsable && result >= minValue && result <= maxValue))
            {
                MessageBox.Show("Błędna wartość " + textBoxName + ". \nWprowadź liczbę całkowitą z zakresu " + minValue + "- " + maxValue + ".",
                    "Błędny format",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void calculatePrecipitation()
        {
            Cloudy cloudy = new Cloudy(cloudy_scrollbar.Value);
            Pressure pressure = new Pressure(pressure_scrollbar.Value);
            DBConnection db = new DBConnection("Database.mdf");
            ArrayList rules = db.getRules(cloudy, pressure);

            fillFormWithVariableNamesAndValues(rules, cloudy, pressure);
            Dictionary<int, double> maxOfPrecipitation = calculateMaximumOfPercipitation(rules, cloudy, pressure);
            fillFormWithPrecipitationResult(maxOfPrecipitation);
            calculateDefuzzyficationAndShowResults(maxOfPrecipitation);
        }

        private void fillFormWithVariableNamesAndValues(ArrayList rules, Cloudy cloudy, Pressure pressure)
        {
            int currentRow = 1;
            foreach (int[] rule in rules)
            {
                int cloudyLevel = rule[1];
                int pressureLevel = rule[2];
                int precipitationLevel = rule[3];
                fillFormLabelsWithVariablesName(currentRow, cloudyLevel, pressureLevel, precipitationLevel);
                fillFormLabelsWithVariableMinValue(currentRow, cloudy, cloudyLevel, pressure, pressureLevel);
                currentRow++;
            }
        }

        private void fillFormLabelsWithVariablesName(int currentRow, int cloudyLevel, int pressureLevel, int precipitationLevel)
        {
            Label cloudyLabel = this.Controls.Find("cloudy_row" + currentRow + "_label", true).FirstOrDefault() as Label;
            Label pressureLabel = this.Controls.Find("pressure_row" + currentRow + "_label", true).FirstOrDefault() as Label;
            Label precipitationLabel = this.Controls.Find("precipitation_row" + currentRow + "_label", true).FirstOrDefault() as Label;

            cloudyLabel.Text = Cloudy.chooseCloudyName(cloudyLevel);
            pressureLabel.Text = Pressure.choosePressureName(pressureLevel);
            precipitationLabel.Text = Precipitation.choosePrecipitationName(precipitationLevel);
        }

        private void fillFormLabelsWithVariableMinValue(int currentRow, Cloudy cloudy, int cloudyLevel, Pressure pressure, int pressureLevel)
        {
            Label minLabel = this.Controls.Find("min_row" + currentRow + "_label", true).FirstOrDefault() as Label;
            double minValueFromActivatedRule = selectMinValueFormAcivatedRule(cloudy, cloudyLevel, pressure, pressureLevel);
            minLabel.Text = "" + minValueFromActivatedRule;
        }

        private Dictionary<int, double> calculateMaximumOfPercipitation(ArrayList rules, Cloudy cloudy, Pressure pressure)
        {
            int currentRow = 1;
            Dictionary<int, double> maxOfPrecipitation = new Dictionary<int, double>();
            foreach (int[] rule in rules)
            {
                int cloudyLevel = rule[1];
                int pressureLevel = rule[2];
                int precipitationLevel = rule[3];
                double minValueFromActivatedRule = selectMinValueFormAcivatedRule(cloudy, cloudyLevel, pressure, pressureLevel);
                addPrecipitationOrReplaceMaximumValueInDictionary(maxOfPrecipitation, precipitationLevel, minValueFromActivatedRule);
                currentRow++;
            }
            return maxOfPrecipitation;
        }

        private double selectMinValueFormAcivatedRule(Cloudy cloudy, int cloudyLevel, Pressure pressure, int pressureLevel)
        {
            double cloudyScore = cloudy.selectCloudyLevelValue(cloudyLevel);
            double pressureScore = pressure.selectPressureLevelValue(pressureLevel);
            return Math.Round(Math.Min(cloudyScore, pressureScore), 2);
        }

        private void addPrecipitationOrReplaceMaximumValueInDictionary(Dictionary<int, double> dictionary,
                     int precipitationKey, double precipitationValue)
        {
            double actualPrecipitationValue;
            if (dictionary.TryGetValue(precipitationKey, out actualPrecipitationValue))
            {
                dictionary[precipitationKey] = Math.Max(actualPrecipitationValue, precipitationValue);
            }
            else dictionary.Add(precipitationKey, precipitationValue);
        }

        private void fillFormWithPrecipitationResult(Dictionary<int, double> maxOfPrecipitation)
        {
            int rowInResults = 1;
            foreach (KeyValuePair<int, double> keyValuePair in maxOfPrecipitation)
            {
                Label resultNameLabel = this.Controls.Find("result_name_row" + rowInResults + "_label", true).FirstOrDefault() as Label;
                Label resultValueLabel = this.Controls.Find("result_value_row" + rowInResults + "_label", true).FirstOrDefault() as Label;

                resultNameLabel.Text = "" + Precipitation.choosePrecipitationName(keyValuePair.Key);
                resultValueLabel.Text = "" + keyValuePair.Value;
                rowInResults++;
            }
        }

        private void calculateDefuzzyficationAndShowResults(Dictionary<int, double> maxOfPrecipitation)
        {
            Precipitation precipitation = new Precipitation();
            double[] precipitationResultValues = precipitation.createTableOfPrecipitationResultValues(maxOfPrecipitation);
            cog_method_label.Text = "" + precipitation.calculateCOG(precipitationResultValues);
            mom_method_label.Text = "" + precipitation.calculateMOM(precipitationResultValues);
            fillChartWithData(precipitationResultValues);
        }

        private void fillChartWithData(double[] precipitationResultValues)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Wynik");
            chart1.Series["Wynik"].XValueType = ChartValueType.Int32;
            for (int i = 0; i < precipitationResultValues.Length; i++)
            {
                chart1.Series["Wynik"].Points.AddXY(Precipitation.maximums[i], precipitationResultValues[i]);
            }
            chart1.Series["Wynik"].BorderWidth = 3;
            chart1.Series["Wynik"].ChartType = SeriesChartType.Line;
            chart1.ChartAreas[0].AxisX.Interval = 5;
        }

        private void clearForm()
        {
            chart1.Series.Clear();
            cog_method_label.Text = "";
            mom_method_label.Text = "";
            for (int currentRow = 1; currentRow <= 4; currentRow++)
            {
                this.Controls.Find("result_name_row" + currentRow + "_label", true).FirstOrDefault().Text = "";
                this.Controls.Find("result_value_row" + currentRow + "_label", true).FirstOrDefault().Text = "";
                this.Controls.Find("cloudy_row" + currentRow + "_label", true).FirstOrDefault().Text = "";
                this.Controls.Find("pressure_row" + currentRow + "_label", true).FirstOrDefault().Text = "";
                this.Controls.Find("precipitation_row" + currentRow + "_label", true).FirstOrDefault().Text = "";
                this.Controls.Find("min_row" + currentRow + "_label", true).FirstOrDefault().Text = "";
            }
        }

        private void ConclusionForm_ResizeEnd(object sender, EventArgs e)
        {
            Helper.setAnchorAndLocation(this, panel1);
        }
    }
}