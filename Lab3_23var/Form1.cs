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

        // Проверка с использованием стека
        /// <summary>
        /// Проверяет правильность скобочной последовательности с помощью стека.
        /// Возвращает true, если последовательность корректна.
        /// Параметр ops — счётчик элементарных операций.
        /// </summary>
        public static bool CheckWithStack(string input, out long ops)
        {
            ops = 0;
            var stack = new Stack<char>();

            foreach (char c in input)
            {
                ops++; // операция чтения символа

                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                    ops++; // push
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    ops++; // проверка стека
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();
                    ops++; // pop + сравнение

                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                        return false;
                }
            }

            ops++; // финальная проверка
            return stack.Count == 0;
        }

        //  Проверка с использованием счётчика
        //  (работает только для одного вида скобок — '()')
        /// <summary>
        /// Проверяет правильность скобочной последовательности с помощью счётчика.
        /// Поддерживает только круглые скобки.
        /// Параметр ops — счётчик элементарных операций.
        /// </summary>
        public static bool CheckWithCounter(string input, out long ops)
        {
            ops = 0;
            int counter = 0;

            foreach (char c in input)
            {
                ops++; // операция чтения символа

                if (c == '(')
                {
                    counter++;
                    ops++;
                }
                else if (c == ')')
                {
                    counter--;
                    ops++;
                    if (counter < 0) return false; // несбалансировано
                }
            }

            ops++; // финальная проверка
            return counter == 0;
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
            bool stackResult = CheckWithStack(input, out long stackOps);
            sw1.Stop();

            // Алгоритм счётчика
            var sw2 = Stopwatch.StartNew();
            bool counterResult = CheckWithCounter(input, out long counterOps);
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
                CheckWithStack(testStr, out long sOps);
                sw1.Stop();

                var sw2 = Stopwatch.StartNew();
                CheckWithCounter(testStr, out long cOps);
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
