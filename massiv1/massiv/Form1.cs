using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace massiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label8.Text = "";
            if (numericUpDown4.Value < numericUpDown5.Value)
            {
                label8.Text = "Макс значение не может быть меньше мин значения!"; return; }
            int count, current = 0;
            count = (Convert.ToInt32(numericUpDown2.Value) -
           Convert.ToInt32(numericUpDown1.Value)) /
           Convert.ToInt32(numericUpDown3.Value) + 1;
            for (int n = Convert.ToInt32(numericUpDown1.Value); n <=
           Convert.ToInt32(numericUpDown2.Value); n +=
           Convert.ToInt32(numericUpDown3.Value))
            {
                int[] vptr = new int[n];
                Random rand = new Random();
                for (int j = 0; j < n; j++)
                {
                    vptr[j] =
                   rand.Next(Convert.ToInt32(numericUpDown5.Value),
                   Convert.ToInt32(numericUpDown4.Value));
                }
                if (checkBox1.Checked)
                {
                    dataGridView1.ColumnCount = n + 1;
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = "Исходный массив";
                    for (int j = 0; j < n; j++)
                    {
                        dataGridView1.Rows[i].Cells[j + 1].Value =
                     vptr[j];
                    }
                    i++;
                }
                sort(vptr, n);
                current += 1;
                progressBar1.Value = 100 * current / count;
            }
        }
        private void sort(int[] p, int n)
        {
            int k = 0, sr = 0, obm = 0, m = 0;
            for (int j = 0; j < n; j++)
            {
                if (p[j] == 0) k++;
                else p[j - k] = p[j];
            }
            n -= k;
            sr += n;
            if (n == 0)
            {
                label8.Text = "В массиве одни нули"; return;
            }
            for (m = 0; m < n - 1; m++)
                for (int j = m + 1; j < n; j++)
                {
                    if (p[m] > 0 && p[j] > 0 && p[m] < p[j])
                    {
                        swap(ref p[m], ref p[j]); obm++;
                    }
                    if (p[m] < 0 && p[j] < 0 && p[m] > p[j])
                    {
                        swap(ref p[m], ref p[j]); obm++;
                    }
                    sr += 6;
                }
            if (checkBox1.Checked)
            {
                dataGridView1.AutoResizeColumns();
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = "Получен массив";
                for (int j = 0; j < n; j++)
                { dataGridView1.Rows[i].Cells[j + 1].Value = p[j]; }
                i++;
            }
            if (Convert.ToInt32(numericUpDown1.Value) ==
           Convert.ToInt32(numericUpDown2.Value))
            {
                label8.Text = "Количество сравнений=" +
             Convert.ToString(sr) + " Количество обменов=" + Convert.ToString(obm);
            }
            if (checkBox2.Checked)
            {
                chart1.Series[0].Points.AddXY(n, sr);
                chart2.Series[0].Points.AddXY(n, obm);
            }
        }


        void swap(ref int x, ref int y)
        { int z = x; x = y; y = z; }

        int n, m;
        private void button2_Click_1(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            i = 0;
            button1.Enabled = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int i, j, k, q;
            button3.Enabled = false;
            if (numericUpDown7.Value < numericUpDown8.Value)
            {
                label17.Text = "Макс значение не м.б. меньше мин значения!"; return;
            }
            n = Convert.ToInt32(numericUpDown6.Value);
            m = Convert.ToInt32(numericUpDown6.Value);
            int[,] ptr;
            ptr = new int[m, n];
            Random rand = new Random();
            dataGridView2.AutoResizeColumns();
            dataGridView2.ColumnCount = n;
            for (i = 0; i < n; i++)
            {
                dataGridView2.Rows.Add();
                for (j = 0; j < m; j++)
                {
                    ptr[i, j] =
rand.Next(Convert.ToInt32(numericUpDown8.Value),
Convert.ToInt32(numericUpDown7.Value));
                    dataGridView2.Rows[i].Cells[j].Value = ptr[i, j];
                }
            }

            q = 0;
            k = 0;
            if (ptr[n - 1, m - 1] < 0) k++;
            for (q = 0; q < n - 1; q++)

            {
                if (ptr[q, m - 1] < 0)
                {
                    k++;
                    for (i = q; i < n - 1; i++)
                    {
                        for (j = 0; j < m; j++) ptr[i, j] = ptr[i + 1, j];

                    }
                    q--;
                }
                if (k + q + 1 == n) { break; }
            }
            if (k == n)
            {
                label15.Text = "В матрице удалены все строки";
                return;
            }
            if (k == 0)
            {
                label15.Text = "В матрице нет удаленных строк";
                return;
            }
            label15.Text = "В матрице удалено " + k + " строк(и)";
            for (j = 0; j < m; j++)
            {
                ptr[n - k, j] = 0;
                for (i = 0; i < n - k; i++)
                {
                    ptr[n - k, j] += ptr[i, j];
                }
            }
            dataGridView3.AutoResizeColumns();
            dataGridView3.ColumnCount = n;
            for (i = 0; i <= n - k; i++)
            {
                dataGridView3.Rows.Add();
                for (j = 0; j < m; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = ptr[i, j];
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i, j, k=0;
            button5.Enabled = false;
            if (numericUpDown10.Value < numericUpDown11.Value)
            {
                label24.Text = "Макс значение не м.б. меньше мин значения!"; return;
            }
            n = Convert.ToInt32(numericUpDown9.Value);
            m = Convert.ToInt32(numericUpDown9.Value);
            int[,] ptr;
            ptr = new int[n, m];
            Random rand = new Random();
            dataGridView4.AutoResizeColumns();
            dataGridView4.ColumnCount = m;
            for (i = 0; i < n; i++)
            {
                dataGridView4.Rows.Add();
                for (j = 0; j < m; j++)
                {
                    ptr[i, j] =
rand.Next(Convert.ToInt32(numericUpDown11.Value),
Convert.ToInt32(numericUpDown10.Value));
                    dataGridView4.Rows[i].Cells[j].Value = ptr[i, j];
                }
            }

            //сумма столбцов
            int[] sum = new int[m];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    sum[i] += ptr[j, i];
            }

            //k - количество столбцов с отрицательной суммой
            for (i = 0; i < sum.Length; i++)
                if (sum[i] >= 0) k++;

            int[,] newmas = new int[n, n];
            int f = 0;
            for (i = 0; i < n; i++)
                if (sum[i] >= 0)
                {
                    for (j = 0; j < n; j++)
                        newmas[j,f] = ptr[j, i];
                    f++;
                }

            dataGridView5.AutoResizeColumns();
            dataGridView5.ColumnCount = m;
            for (i = 0; i < n; i++)
            {
                dataGridView5.Rows.Add();
                for (j = 0; j < k; j++)
                {
                    dataGridView5.Rows[i].Cells[j].Value = newmas[i, j];
                }
            }
            if (k == 0)
            {
                label25.Text = "В матрице удалены все стобцы";
                return;
            }
            if (k == m)
            {
                label25.Text = "В матрице нет удаленных стобцов";
                return;
            }
            label25.Text = "В матрице удалено " + (m-k) + " стобца(ов)";


            int min, cc=0;
            int[] masmin = new int[n];
            for (i = 0; i < n; i++)
            {
                min = int.MaxValue;
                for (j = 0; j < k; j++)
                    if (newmas[i, j] < min)
                        min = newmas[i, j];
                masmin[cc] = min;
                cc++;
            }
            for (i = 0; i < n; i++)
                dataGridView5.Rows[i].Cells[k].Value = masmin[i];

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();
            dataGridView5.Rows.Clear();
            dataGridView5.Columns.Clear();
            button5.Enabled = true;
            label24.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            button3.Enabled = true;
            label17.Text = "";
        }
    }
}
