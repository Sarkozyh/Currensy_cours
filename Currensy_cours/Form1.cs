using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currensy_cours
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();
        
        public Valutes valutes;
        int valuteIndex_1;                                                  // Индексы, по которым будет производиться доступ к валютам в массиму valuteList класса Valute
        int valuteIndex_2;

        private void Form1_Load(object sender, EventArgs e)
        {
            valutes = new Valutes();
            f2.valutes = valutes;
            // Устанавливаем валюты при запуске программы
            valute_1.Text = valutes.valuteList[0].CharCode;
            valute_2.Text = valutes.valuteList[1].CharCode;
            valuteIndex_1 = 0;
            valuteIndex_2 = 1;
            currency.Text = "0";
            currency_converted.Text = "0";
        }

        private void currency_converted_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ограничиваем ввод в текстовые поля так, что вводятся тольцо цифры

            if (!char.IsControl(e.KeyChar) 
                && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.')                                           // Если была введена точка, то преврящаем ее в запятую чтобы избежать ошибок
            {
                if (currency_converted.Text.Contains(','))                  // Если в числе уже есть запятая, то не печатаем новую
                {
                    e.Handled = true;
                    return;
                }
                e.KeyChar = ',';
            }

            if (e.KeyChar == '.' 
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
            double val = 0;

            if (e.KeyChar != '\b')
            {
                val = Double.Parse(currency_converted.Text + e.KeyChar);   // Преврящаем текст поля ввода валюты в число
            }
            // Обработка стирания цифр
            else
            {
                if (currency_converted.Text.Length > 1)
                    val = Double.Parse(currency_converted.Text.Remove(
                        currency_converted.Text.Length - 1));
                else
                    val = 0;
            }

            // Конвертация валют

            // Если номинал учитывается

            //double text = (val * valutes.valuteList[valuteIndex_1].Value * valutes.valuteList[valuteIndex_2].Nominal) 
            // /(valutes.valuteList[valuteIndex_2].Value * valutes.valuteList[valuteIndex_1].Nominal);

            // Если номинал не учитывается
            double text = (val * valutes.valuteList[valuteIndex_2].Value) 
                / valutes.valuteList[valuteIndex_1].Value;

            text = Math.Round(text, 2, MidpointRounding.AwayFromZero);
            currency.Text = text.ToString();
        }

        private void currency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.')                                           // Если была введена точка, то преврящаем ее в запятую чтобы избежать ошибок
            {
                if (currency.Text.Contains(','))                            // Если в числе уже есть запятая, то не печатаем новую
                {
                    e.Handled = true;
                    return;
                }
                e.KeyChar = ',';
            }


            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
            double val = 0;

            if (e.KeyChar != '\b')
            {
                val = Double.Parse(currency.Text + e.KeyChar);             // Преврящаем текст поля ввода валюты в число
            }
            // Обработка стирания цифр
            else
            {
                if (currency.Text.Length > 1)
                    val = Double.Parse(currency.Text.Remove(
                        currency.Text.Length - 1));
                else
                    val = 0;
            }

            // Конвертация валют

            // Если номинал учитывается

            //double text = (val * valutes.valuteList[valuteIndex_1].Value * valutes.valuteList[valuteIndex_2].Nominal)
            // / (valutes.valuteList[valuteIndex_2].Value * valutes.valuteList[valuteIndex_1].Nominal);

            // Если номинал не учитывается
            double text = (val * valutes.valuteList[valuteIndex_1].Value) /
                valutes.valuteList[valuteIndex_2].Value;

            text = Math.Round(text, 2, MidpointRounding.AwayFromZero);
            currency_converted.Text = text.ToString();
        }

        private void cooseValute_2_Click(object sender, EventArgs e)
        {
            // Открытие окна выбора валют
            f2.ShowDialog();
            // Получение индекса выбранной валюты
            valuteIndex_2 = f2.getIndex();
            valute_2.Text = valutes.valuteList[valuteIndex_2].CharCode;

            // Пересчитываем курс для выбранной валюты
            double val = 0;
            if (currency.Text.Length > 1)
                val = Double.Parse(currency.Text);
            else
                val = 0;
            // Если номинал учитывается

            //double text = (val * valutes.valuteList[valuteIndex_1].Value * valutes.valuteList[valuteIndex_2].Nominal)
            // / (valutes.valuteList[valuteIndex_2].Value * valutes.valuteList[valuteIndex_1].Nominal);

            // Если номинал не учитывается
            double text = (val * valutes.valuteList[valuteIndex_1].Value) /
                valutes.valuteList[valuteIndex_2].Value;

            text = Math.Round(text, 2, MidpointRounding.AwayFromZero);
            currency_converted.Text = text.ToString();
        }

        private void cooseValute_1_Click(object sender, EventArgs e)
        {
            // Открытие окна выбора валют
            f2.ShowDialog();
            // Получение индекса выбранной валюты
            valuteIndex_1 = f2.getIndex();
            valute_1.Text = valutes.valuteList[valuteIndex_1].CharCode;

            // Пересчитываем курс для выбранной валюты
            double val = 0;
            if (currency_converted.Text.Length > 1)
                val = Double.Parse(currency_converted.Text);
            else
                val = 0;
            // Если номинал учитывается

            //double text = (val * valutes.valuteList[valuteIndex_1].Value * valutes.valuteList[valuteIndex_2].Nominal)
            // / (valutes.valuteList[valuteIndex_2].Value * valutes.valuteList[valuteIndex_1].Nominal);

            // Если номинал не учитывается
            double text = (val * valutes.valuteList[valuteIndex_2].Value) /
                valutes.valuteList[valuteIndex_1].Value;

            text = Math.Round(text, 2, MidpointRounding.AwayFromZero);
            currency.Text = text.ToString();
        }

    }
}
