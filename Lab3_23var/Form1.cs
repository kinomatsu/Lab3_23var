using lab3_23var;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace lab3_23var
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //  Обработчик кнопки «Проверить»
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            if (input.Length == 0)
            {
                MessageBox.Show("Введите строку со скобками.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Алгоритм стека
            var sw1 = Stopwatch.StartNew();
            bool stackResult = BracketChecker.CheckWithStack(input, out long stackOps);
            sw1.Stop();

            // Алгоритм счётчика 
            var sw2 = Stopwatch.StartNew();
            bool counterResult = BracketChecker.CheckWithCounter(input, out long counterOps);
            sw2.Stop();

            // Вывод результатов
            lblStackResult.Text = stackResult ? "Корректна" : "Некорректна";
            lblStackResult.ForeColor = stackResult ? Color.Green : Color.Red;
            lblCounterResult.Text = counterResult ? "Корректна" : "Некорректна";
            lblCounterResult.ForeColor = counterResult ? Color.Green : Color.Red;

            lblStackTime.Text = $"{sw1.Elapsed.TotalMilliseconds:F4} мс";
            lblCounterTime.Text = $"{sw2.Elapsed.TotalMilliseconds:F4} мс";
            lblStackOps.Text = stackOps.ToString();
            lblCounterOps.Text = counterOps.ToString();

            // Обновить таблицу сравнения
            UpdateComparisonTable(input.Length, sw1.Elapsed.TotalMilliseconds,
                sw2.Elapsed.TotalMilliseconds, stackOps, counterOps);
        }

        //  Обработчик кнопки «Тест производительности»
        private void btnBenchmark_Click(object sender, EventArgs e)
        {
            dgvResults.Rows.Clear();
            int[] sizes = { 100, 500, 1000, 2000, 5000, 10000 };

            foreach (int n in sizes)
            {
                string testStr = GenerateBalanced(n);

                var sw1 = Stopwatch.StartNew();
                BracketChecker.CheckWithStack(testStr, out long sOps);
                sw1.Stop();

                var sw2 = Stopwatch.StartNew();
                BracketChecker.CheckWithCounter(testStr, out long cOps);
                sw2.Stop();

                dgvResults.Rows.Add(
                    n,
                    $"{sw1.Elapsed.TotalMilliseconds:F4}",
                    $"{sw2.Elapsed.TotalMilliseconds:F4}",
                    sOps,
                    cOps
                );
            }
        }

        // Генерация сбалансированной строки из n/2 пар скобок
        private static string GenerateBalanced(int n)
        {
            int pairs = n / 2;
            return new string('(', pairs) + new string(')', pairs);
        }

        // Добавить строку в таблицу сравнения
        private void UpdateComparisonTable(int len,
            double t1, double t2, long ops1, long ops2)
        {
            dgvResults.Rows.Add(
                len,
                $"{t1:F4}",
                $"{t2:F4}",
                ops1,
                ops2
            );
        }
    }
}
