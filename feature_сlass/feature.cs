using System;
using System.Globalization;
using System.Windows.Forms;


namespace feature_сlass
{
    public class feature
    {
        /// <summary>
        /// Ограничение на ввод только цифр 
        /// </summary>
        public static void TextIsDigitOnly(object sender, KeyPressEventArgs e)
        {
             e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,\b,',']");
            //char ch = e.KeyChar;
            //if (!Char.IsDigit(ch)&&!Char.IsControl(ch)&&!Char.IsSeparator(ch))
            //{
            //    e.Handled = true;
            //}
        }

        /// Вывод числа с учетом разделителей разрядности
        public static void TextBoxCurrency(TextBox tb)
        {
            if (!tb.Focused)
            {
                double sd = Convert.ToDouble(tb.Text);
                tb.Text = sd.ToString("N2", CultureInfo.CreateSpecificCulture("ru-RU"));
            }
        }

        ///Нормализация строки(числа) с дополнением нулями слева
        public static string NormalizeNumSort(string nmr)
        {
            string result = "";
            if (nmr != "")
            {

                string[] l = nmr.Split('.');
                foreach (string n in l)
                {
                    int i = Convert.ToInt32(n);
                    string n1 = i.ToString("D4");
                    if (result == "")
                    {
                        result = n1;
                    }
                    else
                    {
                        result = result + "." + n1;
                    }

                }
            }

            return result;
        }

    }
}
