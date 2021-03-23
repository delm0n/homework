﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            рекурсивнымиФункциямиToolStripMenuItem.Enabled = true;
            chart1.Series[0].BorderWidth = 3;
            chart1.Series[0].Color = Color.Red;
            chart1.Series[1].BorderWidth = 3;
            chart1.Series[1].Color = Color.Blue;
            chart1.Series[0].LegendText = "Сравнения";
            chart1.Series[1].LegendText = "Обмены";
            chart2.Series[0].BorderWidth = 3;
            chart2.Series[0].Color = Color.Red;
            chart2.Series[1].BorderWidth = 3;
            chart2.Series[1].Color = Color.Blue;
            chart2.Series[0].LegendText = "Сравнения";
            chart2.Series[1].LegendText = "Обмены";
            chart3.Series[0].BorderWidth = 3;
            chart3.Series[0].Color = Color.Red;
            chart3.Series[1].BorderWidth = 3;
            chart3.Series[1].Color = Color.Blue;
            chart3.Series[0].LegendText = "Сравнения";
            chart3.Series[1].LegendText = "Обмены";
            
            chart5.Series[0].LegendText = "ПузырёкР";
            chart5.Series[0].Color = Color.Blue;
            chart4.Series[0].Color = Color.Blue;
            chart5.Series[1].LegendText = "ВыборЦ";
            chart5.Series[1].Color = Color.DarkOrange;
            chart5.Series[2].LegendText = "Быстрая";
            chart5.Series[2].Color = Color.Green;

            chart4.Series[0].LegendText = "ПузырёкР";
            chart4.Series[0].Color = Color.Blue;
            chart4.Series[1].LegendText = "ВыборЦ";
            chart4.Series[1].Color = Color.DarkOrange;
            chart4.Series[2].LegendText = "Быстрая";
            chart4.Series[2].Color = Color.Green;
        }
        public void output_textBox(int[] out_a, int n) //вывод массива в textBox
        {
            for (int i = 0; i < n; i++)
            { textBox1.Text += out_a[i] + " "; }
            textBox1.Text += Environment.NewLine;
        }
        public void output_dataGridView(int count, int sr, int obm, int vid_sort)
            //вывод в таблицу кол-ва сравнений и обменов
        {
            dataGridView1.Rows [count].Cells [vid_sort].Value = sr;
            dataGridView2.Rows [count].Cells [vid_sort].Value = obm;
        }
        public void output_dataGridView2(int count, int sr, int obm, int vid_sort)
        //вывод в таблицу кол-ва сравнений и обменов
        {
            dataGridView3.Rows[count].Cells[vid_sort].Value = sr;
            dataGridView4.Rows[count].Cells[vid_sort].Value = obm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            цикламиToolStripMenuItem.Enabled = false;
            button1.Enabled = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 4;
            
            dataGridView1.AutoResizeColumns();
            dataGridView2.AutoResizeColumns();
            dataGridView1.Columns[0].HeaderText = "Размер";
            dataGridView1.Columns[1].HeaderText = "Выбор";
            dataGridView1.Columns[2].HeaderText = "Вставки";
            dataGridView1.Columns[3].HeaderText = "Пузырек";

            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].HeaderText = "Размер";
            dataGridView2.Columns[1].HeaderText = "Выбор";
            dataGridView2.Columns[2].HeaderText = "Вставки"; 
            dataGridView2.Columns[3].HeaderText = "Пузырек";

            dataGridView1.ColumnCount = 4; 
            dataGridView2.ColumnCount = 4; 
            if (numericUpDown4.Value < numericUpDown5.Value)
            { label6.Text = "Макс значение не м.б. меньше мин значения!"; return; }
            int count = 0, n, sr = 0, obm = 0;
            ArraySort sort_select = new ArraySort();
            ArraySort sort_insert = new ArraySort();
            ArraySort sort_bubble = new ArraySort();
            ArraySort sort_quick = new ArraySort();
            for (n = Convert.ToInt32(numericUpDown1.Value); n <=
           Convert.ToInt32(numericUpDown2.Value); n += Convert.ToInt32(numericUpDown3.Value))
            {
                int[] base_a = new int[n];
                Random rand = new Random();
                for (int j = 0; j < n; j++)
                {
                    base_a[j] = rand.Next(Convert.ToInt32(numericUpDown5.Value),
                   Convert.ToInt32(numericUpDown4.Value));
                }

                textBox1.Text += Environment.NewLine + "Исходный массив " + Environment.NewLine;
                output_textBox(base_a, n);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[count].Cells[0].Value = n;
                dataGridView2.Rows.Add();
                dataGridView2.Rows[count].Cells[0].Value = n;



                sort_select.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                sort_select.SelectSort(sort_select.a, ref sr, ref obm);
                textBox1.Text += "Сортировка выбором " + Environment.NewLine;
                output_textBox(sort_select.a, n);
                output_dataGridView(count, sr, obm, 1);
                chart1.Series[0].Points.AddXY(n, sr);
                chart1.Series[1].Points.AddXY(n, obm);


                sort_insert.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                sort_insert.InsertSort(sort_insert.a, ref sr, ref obm);
                textBox1.Text += "Сортировка вставками " + Environment.NewLine;
                output_textBox(sort_insert.a, n);
                output_dataGridView(count, sr, obm, 2);
                chart2.Series[0].Points.AddXY(n, sr);
                chart2.Series[1].Points.AddXY(n, obm);

                sort_bubble.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                sort_bubble.BubbleSort(sort_bubble.a, ref sr, ref obm);
                textBox1.Text += "Сортировка пузырьком " + Environment.NewLine;
                output_textBox(sort_bubble.a, n);
                output_dataGridView(count, sr, obm, 3);
                chart3.Series[0].Points.AddXY(n, sr);
                chart3.Series[1].Points.AddXY(n, obm); 
                
                count++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();
            textBox1.Text = "";
            button1.Enabled = true;
            цикламиToolStripMenuItem.Enabled = true;
            рекурсивнымиФункциямиToolStripMenuItem.Enabled = true;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            chart3.Series[0].Points.Clear();
            chart3.Series[1].Points.Clear();
            chart4.Series[0].Points.Clear();
            chart4.Series[1].Points.Clear();
            chart4.Series[2].Points.Clear();
            chart5.Series[0].Points.Clear();
            chart5.Series[1].Points.Clear();
            chart5.Series[2].Points.Clear();
        }

        private void сохранитьВсеГрафикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            сохранитьГрафикСортировкиВставкамиToolStripMenuItem_Click(sender, e);
            сохранитьГрафикСортировкиВыборомToolStripMenuItem_Click(sender, e);
            сохранитьГрафикСортировкиПузырькомToolStripMenuItem_Click(sender, e);
            сохранитьГрафикОценкиЗатратToolStripMenuItem_Click(sender, e);
            сохранитьГрафикОценкиЗатратобменыToolStripMenuItem_Click(sender, e);
        }

        private void сохранитьГрафикСортировкиВставкамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr1 = new SaveFileDialog())
            {
                saveGr1.Title = "Сохранить график как ...";
                saveGr1.Filter = "*.jpg|*.jpg";
                saveGr1.AddExtension = true;
                saveGr1.FileName = "Insert";
                if (saveGr1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    chart2.SaveImage(saveGr1.FileName,
                   System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }

        private void сохранитьГрафикСортировкиВыборомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr = new SaveFileDialog())
            {
                saveGr.Title = "Сохранить график как ...";
                saveGr.Filter = "*.jpg|*.jpg";
                saveGr.AddExtension = true;
                saveGr.FileName = "Select";
                if (saveGr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    chart1.SaveImage(saveGr.FileName,
                   System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }
        private void сохранитьГрафикСортировкиПузырькомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr2 = new SaveFileDialog())
            {
                saveGr2.Title = "Сохранить график как ...";
                saveGr2.Filter = "*.jpg|*.jpg";
                saveGr2.AddExtension = true;
                saveGr2.FileName = "Bubble";
                if (saveGr2.ShowDialog() ==
                System.Windows.Forms.DialogResult.OK)
                {
                    chart3.SaveImage(saveGr2.FileName,
                   System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }

        private void цикламиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            цикламиToolStripMenuItem.Enabled = false;
            рекурсивнымиФункциямиToolStripMenuItem.Enabled = true;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 help = new Form2();
            help.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void рекурсивнымиФункциямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            рекурсивнымиФункциямиToolStripMenuItem.Enabled = false;
            button1.Enabled = false;
            dataGridView4.AutoResizeColumns();
            dataGridView3.AutoResizeColumns();
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.ColumnCount = 4;
            dataGridView3.Columns[0].HeaderText = "Размер";
            dataGridView3.Columns[1].HeaderText = "ПузырёкР";
            dataGridView3.Columns[2].HeaderText = "ВыборЦ";
            dataGridView3.Columns[3].HeaderText = "Быстрая";
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.ColumnCount = 4;
            dataGridView4.Columns[0].HeaderText = "Размер";
            dataGridView4.Columns[1].HeaderText = "ПузырёкР";
            dataGridView4.Columns[2].HeaderText = "ВыборЦ"; 
            dataGridView4.Columns[3].HeaderText = "Быстрая";
            dataGridView3.ColumnCount = 4;
            dataGridView4.ColumnCount = 4;
            
            int count = 0, n, sr = 0, obm = 0;
            ArraySort sort_selectcyc = new ArraySort();
            ArraySort sort_quick = new ArraySort();
            ArraySort sort_bubblerec = new ArraySort();
            for (n = Convert.ToInt32(numericUpDown1.Value); n <=
           Convert.ToInt32(numericUpDown2.Value); n += Convert.ToInt32(numericUpDown3.Value))
            {
                int[] base_a = new int[n];
                Random rand = new Random();
                for (int j = 0; j < n; j++)
                {
                    base_a[j] = rand.Next(Convert.ToInt32(numericUpDown5.Value),
                   Convert.ToInt32(numericUpDown4.Value));
                }

                textBox1.Text += Environment.NewLine + "Исходный массив " + Environment.NewLine;
                output_textBox(base_a, n);
                dataGridView3.Rows.Add();
                dataGridView3.Rows[count].Cells[0].Value = n;
                dataGridView4.Rows.Add();
                dataGridView4.Rows[count].Cells[0].Value = n;

                sort_bubblerec.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                sort_bubblerec.BubbleSortRecur(sort_bubblerec.a, ref sr, ref obm);
                textBox1.Text += "Сортировка пузырьком через рекурсию " + Environment.NewLine;
                output_textBox(sort_bubblerec.a, n);
                output_dataGridView2(count, sr, obm, 1);
                chart4.Series[0].Points.Add(sr);
                chart5.Series[0].Points.Add(obm);

                sort_selectcyc.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                sort_selectcyc.SelectSort(sort_selectcyc.a, ref sr, ref obm);
                textBox1.Text += "Сортировка выбором через цикл" + Environment.NewLine;
                output_textBox(sort_selectcyc.a, n);
                output_dataGridView2(count, sr, obm, 2);
                chart4.Series[1].Points.Add(sr);
                chart5.Series[1].Points.Add(obm);

                sort_quick.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                sort_quick.QuickSorting(sort_quick.a, 0, base_a.Length - 1, ref sr, ref obm);
                textBox1.Text += "Быстрая сортировка " + Environment.NewLine;
                output_textBox(sort_quick.a, n);
                output_dataGridView2(count, sr, obm, 3);
                chart4.Series[2].Points.Add(sr);
                chart5.Series[2].Points.Add(obm);

                count++;
            }
        }

        private void сохранитьГрафикОценкиЗатратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr3 = new SaveFileDialog())
            {
                saveGr3.Title = "Сохранить график как ...";
                saveGr3.Filter = "*.jpg|*.jpg";
                saveGr3.AddExtension = true;
                saveGr3.FileName = "Comparisons";
                if (saveGr3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    chart4.SaveImage(saveGr3.FileName,
                   System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }

        private void сохранитьГрафикОценкиЗатратобменыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr4 = new SaveFileDialog())
            {
                saveGr4.Title = "Сохранить график как ...";
                saveGr4.Filter = "*.jpg|*.jpg";
                saveGr4.AddExtension = true;
                saveGr4.FileName = "Exchange";
                if (saveGr4.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    chart5.SaveImage(saveGr4.FileName,
                   System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }
    }
    
}
