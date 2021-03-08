using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button4.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //создание контекстного меню
            System.Windows.Forms.ContextMenu contextMenu1;
            contextMenu1 = new System.Windows.Forms.ContextMenu();
            System.Windows.Forms.MenuItem menuItem1;
            menuItem1 = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem menuItem2;
            menuItem2 = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem menuItem3;
            menuItem3 = new System.Windows.Forms.MenuItem();
            contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
menuItem1, menuItem2, menuItem3 });
            menuItem1.Index = 0;
            menuItem1.Text = "Открыть";
            menuItem2.Index = 1;
            menuItem2.Text = "Сохранить";
            menuItem3.Index = 2;
            menuItem3.Text = "Сохранить как";
            richTextBox1.ContextMenu = contextMenu1;
            menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
        }
        string MyFName = "";

        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.Filter = "Текстовые файлы (*.rtf; *.txt; *.dat) | *.rtf;*.txt; *.dat";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MyFName = openFileDialog1.FileName;
                richTextBox1.LoadFile(MyFName);
            }

        }
        private void menuItem2_Click(object sender, EventArgs e)
        {
            if (MyFName != "")
            {
                richTextBox1.SaveFile(MyFName);
            }
            else
            {
                saveFileDialog1.Filter = "Текстовые файлы (*.rtf; *.txt; *.dat) | *.rtf;*.txt; *.dat";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    MyFName = saveFileDialog1.FileName;
                    richTextBox1.SaveFile(MyFName);
                }
            }
        }
        private void menuItem3_Click(object sender, System.EventArgs e)
        {
            saveFileDialog1.Filter = "Текстовые файлы (*.rtf; *.txt; *.dat) | *.rtf; *.txt; *.dat";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MyFName = saveFileDialog1.FileName;
                richTextBox1.SaveFile(MyFName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox1.Clear();
            textBox2.Clear();
            richTextBox1.Clear();
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }
        int result1, result2;
        private void button2_Click(object sender, EventArgs e)
        {
            int LenText;
            textBox2.Text += "Поиск первого слова" + Environment.NewLine;
            String FWord = textBox3.Text.ToString();
            LenText = richTextBox1.Text.Length;
            result1 = FindWord(FWord, LenText);
            if (result1 != -1)
            {
                textBox2.Text += "Позиция первого слова: " + (result1 + 1) +
               Environment.NewLine + Environment.NewLine;
                richTextBox1.SelectionStart = result1;
                richTextBox1.SelectionLength = FWord.Length;
                richTextBox1.SelectionBackColor = Color.Red;
                button2.Enabled = false;
                if (button3.Enabled == false)
                { button4.Enabled = true; }
            }
            else
            {
                textBox2.Text += "Слово не найдено " + Environment.NewLine
               + Environment.NewLine;
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            int LenText;

            textBox2.Text += "Поиск второго слова" + Environment.NewLine;
            String FWord = textBox1.Text.ToString();
            LenText = richTextBox1.Text.Length;
            result2 = FindWord(FWord, LenText);
            if (result2 != -1)
            {
                textBox2.Text += "Позиция второго слова: " + (result2 + 1) +
               Environment.NewLine + Environment.NewLine;
                
            richTextBox1.SelectionStart = result2;
                richTextBox1.SelectionLength = FWord.Length;
                richTextBox1.SelectionBackColor = Color.Green;
                button3.Enabled = false;
                if (button2.Enabled == false)
                { button4.Enabled = true; }
            }
            else
            {
                textBox2.Text += "Слово не найдено " + Environment.NewLine +
               Environment.NewLine;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (result1 < result2)
            {
                richTextBox1.Select(result2, textBox1.Text.Length);
                richTextBox1.SelectedText = textBox3.Text.ToString();
                richTextBox1.Select(result1, textBox3.Text.Length);
                richTextBox1.SelectedText = textBox1.Text.ToString();
                textBox2.Text += "Произошла замена слов";
                button4.Enabled = false;
            }
            else
            {
                richTextBox1.Select(result1, textBox3.Text.Length);
                richTextBox1.SelectedText = textBox1.Text.ToString();
                richTextBox1.Select(result2, textBox1.Text.Length);
                richTextBox1.SelectedText = textBox3.Text.ToString();
                textBox2.Text += "Произошла замена слов";
                button4.Enabled = false;
            }
        }


        //изменение



        private void Main(object sender, EventArgs e)
        {
            string Text = richTextBox1.Text.ToString();
            string[] words = Text.Split(new char[] {' ', '\n' });
            //string[] k;
            List<string> k = new List<string>() {""};
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim(new Char[] { ' ', ',', '!', '.','?',':',';', ',', '.', ';'});
            }
            int min = int.MaxValue;
            int exmin=0;
            foreach (String word in words)
            {
                if ((word.Length < min) && (word.Length != 0))
                {
                    k.Clear();
                    min = word.Length;
                    k.Add(word);
                }
                else if ((word.Length == min) && (word.Length != 0)) k.Add(word);
            }
            
            int[] res = new int[(k.Count)];
            string[] str = new string[(k.Count)];
            int LongText = richTextBox1.Text.Length;
            
            for (int i = 0; i < k.Count; i++)
            {
                str[i] = k[i];
                res[i] = FindWord(str[i], LongText);
            } 
            for (int i = 0; i < k.Count; i++)
            {
                if (res[i] != -1)
                {

                    richTextBox1.SelectionStart = res[i];
                    richTextBox1.SelectionLength = min;
                    richTextBox1.SelectionBackColor = Color.Gray;
                    
                }
            }
            
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter) Main(0, null);

        }
   
        //конец изменения

        int FindWord(String FWord, int n)
        {
            int LenWord;
            String ComparText;
            LenWord = FWord.Length;
            for (int i = 0; i <= n - LenWord; i++)
            {
                ComparText = richTextBox1.Text.Substring(i, LenWord);
                if (ComparText == FWord)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}