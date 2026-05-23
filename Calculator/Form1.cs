using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblX2_Click(object sender, EventArgs e)
        {
        }

        private void tbLength_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // --- Валидация веса ---
            if (!double.TryParse(tbWeight.Text.Replace('.', ','), out double weight) || weight <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректный вес (число больше 0).",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbWeight.Focus();
                return;
            }

            // --- Валидация размеров ---
            if (!double.TryParse(tbLength.Text.Replace('.', ','), out double length) || length <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректную длину (число больше 0).",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbLength.Focus();
                return;
            }

            if (!double.TryParse(tbWidth.Text.Replace('.', ','), out double width) || width <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректную ширину (число больше 0).",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbWidth.Focus();
                return;
            }

            if (!double.TryParse(tbHeight.Text.Replace('.', ','), out double height) || height <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректную высоту (число больше 0).",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbHeight.Focus();
                return;
            }

            // --- Расчёт стоимости ---
            const double ratePerKg = 120.0;   // коэффициент: 120 руб/кг
            const double insurance = 300.0;    // фиксированная страховка

            double shippingCost = weight * ratePerKg;
            double totalCost = shippingCost + insurance;

            // --- Передача данных на Form2 и открытие ---
            Form2 resultForm = new Form2(weight, length, width, height, ratePerKg, insurance, totalCost);
            resultForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
