using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Struct
{
    struct Employee
    {
        public string FIO;//ФИО
        public string Post;// Должность
        public string Date_of_Birth;// ДАта рождения
        public string Degree; //Ученая степеть
        public int Experience;//Стажработы
        public Employee(string f, string p, string d, string deg, int e)
        {
            FIO = f;
            Post = p;
            Date_of_Birth = d;
            Degree = deg;
            Experience = e;
        }
    }

    struct Employee2
    {
        public string Date;// Дата
        public string Day;// День недели
        public string Subject;//ФИО
        public string Group;// Должность

        public string Audit;//Аудитория
        public Employee2(string s, string p, string date, string day, string g, string a)
        {
            Date = date;
            Day = day;
            Subject = s;
            Group = g;
            Audit = a;
        }
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Преподаватель");
            comboBox1.Items.Add("Ст. преподаватель");
            comboBox1.Items.Add("Доцент");
            comboBox1.Items.Add("Профессор");

comboBox2.Items.AddRange(new object[] {"Без уч. степени","Кандидат наук", "Доктор наук"});

            comboBox3.Items.Add("ИТБ-1301");
            comboBox3.Items.Add("ГГб-1501");
            comboBox3.Items.Add("ХТб-4503");
            comboBox3.Items.Add("БИб-1601");

            

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "ФИО";
            dataGridView1.Columns[1].HeaderText = "Должность";
            dataGridView1.Columns[2].HeaderText = "Дата рождения";
            dataGridView1.Columns[3].HeaderText = "Ученая степень";
            dataGridView1.Columns[4].HeaderText = "Стаж";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnCount = 5;
            dataGridView2.Columns[0].HeaderText = "ФИО";
            dataGridView2.Columns[1].HeaderText = "Должность";
            dataGridView2.Columns[2].HeaderText = "Дата рождения";
            dataGridView2.Columns[3].HeaderText = "Ученая степень";
            dataGridView2.Columns[4].HeaderText = "Стаж";
            dataGridView2.RowHeadersVisible = false;

            //вторая страница
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.ColumnCount = 5;
            dataGridView3.Columns[0].HeaderText = "Дата";
            dataGridView3.Columns[1].HeaderText = "День недели";
            dataGridView3.Columns[2].HeaderText = "Предмет";
            dataGridView3.Columns[3].HeaderText = "Группа";
            dataGridView3.Columns[4].HeaderText = "Аудитория";
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.ColumnCount = 5;
            dataGridView4.Columns[0].HeaderText = "Дата";
            dataGridView4.Columns[1].HeaderText = "День недели";
            dataGridView4.Columns[2].HeaderText = "Предмет";
            dataGridView4.Columns[3].HeaderText = "Группа";
            dataGridView4.Columns[4].HeaderText = "Аудитория";
            dataGridView4.RowHeadersVisible = false;

        }

        Employee[] worker = new Employee[10];
        int cout = 0;
        Employee2[] raspis = new Employee2[10];
        int k = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            worker[cout].FIO = textBox1.Text;
            worker[cout].Post = comboBox1.Text;
            worker[cout].Date_of_Birth =
           dateTimePicker1.Value.ToString("dd.MM.yyyy");
            worker[cout].Degree = comboBox2.Text;
            worker[cout].Experience = Convert.ToInt32(textBox2.Text);
            dataGridView1.Rows.Add(worker[cout].FIO, worker[cout].Post,
           worker[cout].Date_of_Birth, worker[cout].Degree,
           worker[cout].Experience.ToString());
            cout++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dataGridView2.Rows.Clear();
                int select1 = Convert.ToInt32(textBox3.Text);
                foreach (Employee wSel in worker)
                {
                    if (wSel.Experience >= select1)
                        dataGridView2.Rows.Add(wSel.FIO, wSel.Post,
                       wSel.Date_of_Birth, wSel.Degree, wSel.Experience.ToString());
                }
            }

            if (radioButton2.Checked == true)
            {
                dataGridView2.Rows.Clear();
                string select2 = textBox3.Text;
                foreach (Employee wSel in worker)
                {
                    if (wSel.Post == select2)
                        dataGridView2.Rows.Add(wSel.FIO, wSel.Post,
                       wSel.Date_of_Birth, wSel.Degree, wSel.Experience.ToString());
                }
            }

        }

        private void добавитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            { button1_Click(sender, e); }
        }

        private void выполнитьЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            { button1_Click(sender, e); }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            { Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            raspis[k].Date = dateTimePicker2.Value.ToString("dd.MM.yyyy");
            raspis[k].Day = dateTimePicker2.Value.ToString("dddd", CultureInfo.GetCultureInfo("ru-ru"));
            raspis[k].Subject = textBox5.Text;
            raspis[k].Group = comboBox3.Text;
            raspis[k].Audit = textBox8.Text;
            dataGridView3.Rows.Add(raspis[k].Date, raspis[k].Day,
           raspis[k].Subject, raspis[k].Group, raspis[k].Audit);
            k++;

        }
        private void fun(string letter)
        {
            foreach (Employee2 Sel in raspis)
            {
                if (Sel.Group == letter)
                    dataGridView4.Rows.Add(Sel.Date, Sel.Day,
                   Sel.Group, Sel.Audit);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            fun(textBox4.Text);
        }
    }
}
