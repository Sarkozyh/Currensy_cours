using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currensy_cours
{
    public partial class Form2 : Form
    {
        public Valutes valutes;                                         // Переменная, в которой содержится информация о каждой из валют
        int index = 0; 
        public Form2()
        {
            InitializeComponent();
        }

        // Функция, с помощью которой можо получить индекс выбранной валюты 
        public int getIndex()
        {
            return index;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Если список валют в окне пуст, то заполняем его
            if (listBox1.Items.Count == 0)
            {
                int i = 0;
                while (i < valutes.valuteList.Count)
                {
                    Label tmp = new Label();
                    tmp.Text = valutes.valuteList[i].CharCode;
                    listBox1.Items.Add(tmp.Text);
                    i++;
                }
            }
        }

        // Изменение значения передвавемого в функции  getIndex() при выборе валюты
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;
            this.Close();
        }
    }
}
