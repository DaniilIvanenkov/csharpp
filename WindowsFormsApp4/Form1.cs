using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 4; // Кол‐во столбцов
            int[,] a =  new int[3, 4]; // Инициализируем массив
                                       int i,j;
                             //Заполняем матрицу случайными числами
            Random rand = new Random();
            for (i = 0; i < 3; i++)
                for (j = 0; j < 4; j++)
                    a[i, j] = rand.Next(-100, 100);
            // Выводим матрицу в dataGridView1
            for (i = 0; i < 3; i++)
            for (j = 0; j < 4; j++) 
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
            // Поиск максимального элемента
            // на дополнительной диагонали
            int m = int.MinValue;
            for (i = 0; i < 3; i++)
                if (a[i, 14 - i] > m)
                {
                    m = a[i, 14 - i];
                }
            // выводим результат
            textBox1.Text = Convert.ToString(m);
        }
    }
}
