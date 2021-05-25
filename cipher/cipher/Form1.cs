using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            char[] alphabet = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'Й',
                'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х',
                'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'};
            int N = alphabet.Length;
            int keyword_index = 0;
            string result = "";
            string text = textBox1.Text;
            string[] words = text.Split(new char[] { '_' });

            //посчитаем количество символов без _
            int sumChar = 0;
            for (int i=0;i<words.Length;i++) sumChar += words[i].Length;
            


            if (textBox3.Text == "")
            {
                label1.Text += "Вы должны ввести ключ!";
                label1.ForeColor = Color.Red;
            }
            else { 
                label1.Text = null;
                string keyword_string = textBox3.Text;
                char[] keyword = keyword_string.ToCharArray();

                //зацикливание ключевого слова
                string key = "";
                int k_Repeat = sumChar / keyword.Length;
                int ost = sumChar % keyword.Length;
                for (int i=0; i<k_Repeat; i++)
                {
                    key += keyword_string;
                }
                for (int i=0;i < ost; i++)
                {
                    key += keyword[i];
                }


                if (radioButton1.Checked == false && radioButton2.Checked == false)
                { 
                    label1.Text += "Вы должны что-нибудь выбрать!";
                    label1.ForeColor = Color.Red;
                }
            
                if (radioButton1.Checked == true)
                {
                    label1.Text = null;
                    char[] t;
                    int c;
                    for (int i = 0; i < words.Length; i++)
                    {
                        t = words[i].ToCharArray();
                        foreach (char symbol in t)
                        {
                            c = (Array.IndexOf(alphabet, symbol) +
                                Array.IndexOf(alphabet, key[keyword_index])) % 32;

                            result += alphabet[c];
                            keyword_index++;

                            
                        }
                        
                        result += "_";
                    }
                    result = result.Remove(result.Length - 1);
                    textBox2.Text += result;
                    
                    
                }
                

                if (radioButton2.Checked == true)
                {
                    label1.Text = null;
                    char[] t;
                    int c;
                    for (int i = 0; i < words.Length; i++)
                    {
                        t = words[i].ToCharArray();
                        foreach (char symbol in t)
                        {
                            c = (Array.IndexOf(alphabet, symbol) + 32 -
                                Array.IndexOf(alphabet, key[keyword_index])) % 32;

                            result += alphabet[c];
                            keyword_index++;

                        }

                        result += "_";
                    }
                    result = result.Remove(result.Length - 1);
                    textBox2.Text += result;
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
             textBox2.Clear();
            textBox3.Clear();
        }
    }
}
