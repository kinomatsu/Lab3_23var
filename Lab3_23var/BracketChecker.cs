using System.Collections.Generic;

namespace lab3_23var
{
    /// <summary>
    /// Содержит два алгоритма проверки правильности скобочной последовательности.
    /// </summary>
    public static class BracketChecker
    {
        /// <summary>
        /// Проверка с использованием стека.
        /// Поддерживает круглые (), квадратные [] и фигурные {} скобки.
        /// </summary>
        /// <param name="input">Входная строка.</param>
        /// <param name="ops">Счётчик элементарных операций.</param>
        /// <returns>true, если последовательность корректна.</returns>
        public static bool CheckWithStack(string input, out long ops)
        {
            ops = 0;
            var stack = new Stack<char>();

            foreach (char c in input)
            {
                ops++; // чтение символа

                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                    ops++; // push
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    ops++; // проверка стека на пустоту
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();
                    ops++; // pop + сравнение

                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                        return false;
                }
            }

            ops++; // финальная проверка пустоты стека
            return stack.Count == 0;
        }

        /// <summary>
        /// Проверка с использованием счётчика.
        /// Поддерживает только круглые скобки ().
        /// </summary>
        /// <param name="input">Входная строка.</param>
        /// <param name="ops">Счётчик элементарных операций.</param>
        /// <returns>true, если последовательность корректна.</returns>
        public static bool CheckWithCounter(string input, out long ops)
        {
            ops = 0;
            int counter = 0;

            foreach (char c in input)
            {
                ops++; // чтение символа

                if (c == '(')
                {
                    counter++;
                    ops++;
                }
                else if (c == ')')
                {
                    counter--;
                    ops++;
                    if (counter < 0) return false; // ранний выход
                }
            }

            ops++; // финальная проверка
            return counter == 0;
        }
    }
}
