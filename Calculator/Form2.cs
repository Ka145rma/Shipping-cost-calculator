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
    public partial class Form2 : Form
    {
        // Константы тарифов
        private const double RatePerKg = 120.0;
        private const double InsuranceCost = 300.0;

        public Form2(double weight, double length, double width, double height,
                     double ratePerKg, double insurance, double totalCost)
        {
            InitializeComponent();

            // --- Заполнить панель данных (введённые параметры) ---
            lblWeightValue.Text = $"{weight:0.##} кг";
            lblSizeValue.Text = $"{length:0.##} × {width:0.##} × {height:0.##} см";

            // --- Заполнить формулу расчёта ---
            // label4 — текстовый узел с числом, отображающим коэффициент
            // Формула: Вес × Коэффициент + Страховка = Итог
            label4.Text = $"{weight:0.##} кг × {ratePerKg:0} ₽/кг + {insurance:0} ₽";

            // --- Итоговая сумма ---
            lblPrice.Text = $"{totalCost:0} ₽";
        }

        // Конструктор по умолчанию (нужен дизайнеру)
        public Form2()
        {
            InitializeComponent();
        }

        // --- Кнопка «Новый расчёт» ---
        private void btnNew_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        // --- Кнопка «Выход» ---
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- Заглушки для событий из Designer ---
        private void label4_Click(object sender, EventArgs e) { }
        private void lblSizeValue_Click(object sender, EventArgs e) { }
        private void lblResultSub_Click(object sender, EventArgs e) { }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
