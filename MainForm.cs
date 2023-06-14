using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using CalculateLib;

namespace RPMLevchenko
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowAndSaveResultButton.Enabled = false;
            ClearButton.Enabled = false;
        }

        private void XValueInput_TextChanged(object sender, EventArgs e) => ButtonsMonitor();

        private void EpsilonValueInput_TextChanged(object sender, EventArgs e) => ButtonsMonitor();

        private void ClearButton_Click(object sender, EventArgs e)
        {
            XValueInput.Text = string.Empty;
            EpsilonValueInput.Text = string.Empty;

            ApproxResultOutput.Text = string.Empty;
            ExactResultOutput.Text = string.Empty;
            AbsoluteResultOutput.Text = string.Empty;
        }

        private void ShowAndSaveResultButton_Click(object sender, EventArgs e)
        {
            double x;
            double eps = default;
            bool isValidInput = false;

            do
            {
                if (double.TryParse(XValueInput.Text, out x) && (x >= 0 || x < 1) && double.TryParse(EpsilonValueInput.Text, out eps) && eps > 0)
                {
                    isValidInput = true;
                }
                else
                {
                    var result = MessageBox.Show("Некорректный ввод. Пожалуйста, введите double-значения в диапазоне (0, 1] для X и (0, inf] для Эпсилон, а также проверьте наличие запятой, а не точки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (result is DialogResult.OK) return;
                }
            }
            while (!isValidInput);

            double approxValue = Calculations.CalculateSumSeries(x, eps);
            ApproxResultOutput.Text = approxValue.ToString(CultureInfo.InvariantCulture);

            double exactValue = Math.Log(1 + x) / x;
            ExactResultOutput.Text = exactValue.ToString(CultureInfo.InvariantCulture);

            double absoluteValue = Math.Abs(exactValue - approxValue);
            AbsoluteResultOutput.Text = absoluteValue.ToString(CultureInfo.InvariantCulture);

            ResultWriter(approxValue, exactValue, absoluteValue);
        }

        private void ButtonsMonitor()
        {
            ShowAndSaveResultButton.Enabled = !string.IsNullOrEmpty(XValueInput.Text) && !string.IsNullOrEmpty(EpsilonValueInput.Text);
            ClearButton.Enabled = !string.IsNullOrEmpty(XValueInput.Text) && !string.IsNullOrEmpty(EpsilonValueInput.Text);
        }

        private void ResultWriter(double approxValue, double exactValue, double absoluteValue)
        {
            string resultFilePath = "C:\\Users\\levch\\OneDrive\\Рабочий стол\\result.txt";
            string text = $"Дата записи: {DateTime.Now}\nПриближенное значение функции: {approxValue}\nТочное значение функции: {exactValue}\nАбсолютная ошибка приближенного значения: {absoluteValue}\n\n";

            using (var sw = new StreamWriter(resultFilePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }
        }

        private void ApproxResultOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
