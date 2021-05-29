using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTree
{

    public partial class Form1 : Form
    {
        public static bool chars_is_symb; //тумблер - являются ли символы буквами

        private Tree osinka;
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void загрузитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            textBoxTree.Clear();
            textBoxBypass.Clear();
            textBoxSearch.Clear();
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    osinka = new Tree();// создать новое дерево
                    textBoxTree.Clear();
                    using (var file = new System.IO.StreamReader(openFileDialog1.FileName))
                    {
                        while (file.Peek() >= 0)
                        {
                            string currentElement = file.ReadLine();
                            try//если символы - числа
                            {                                
                                if (currentElement != null)
                                {
                                    int chek = int.Parse(currentElement);
                                    chars_is_symb = false;
                                    osinka.Add(int.Parse(currentElement), currentElement);
                                }                                   
                            }
                            catch//если символы - буквы
                            {                               
                                if (currentElement != null)
                                {
                                    chars_is_symb = true;
                                    int currEl_lenght = currentElement.Length;
                                    osinka.Add(currEl_lenght, currentElement);                                  
                                }    
                                    
                            }

                        }
                    }
                    string results = "";
                    osinka.Output(ref results);
                    textBoxTree.Text = results;

                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода", "Графы",
                MessageBoxButtons.OK,
               MessageBoxIcon.Question);
            }
        }

        private void симметричныйМетодLNRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bypass = "";
            osinka.Bypass(Tree.BypassOptions.LNR, ref bypass);
            textBoxBypass.Text += @"Симметричный метод LNR: " + bypass;
        }

        private void прямойМетодNLRToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string bypass = "";
            osinka.Bypass(Tree.BypassOptions.NLR, ref bypass);
            textBoxBypass.Text += @"Прямой метод NLR: " + bypass;
        }

        private void обратныйМетодLRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bypass = "";
            osinka.Bypass(Tree.BypassOptions.LRN, ref bypass);
            textBoxBypass.Text += @"Обратный метод LRN: " + bypass;
        }

        private void методСправаналевоRNLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bypass = "";
            osinka.Bypass(Tree.BypassOptions.RNL, ref bypass);
            textBoxBypass.Text += @"Справа налево RNL: " + bypass;
        }

        private void обходВШиринуBFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bypass = "";
            osinka.Bypass(Tree.BypassOptions.BFS, ref bypass);
            textBoxBypass.Text += @"Обход в ширину BFS: " + bypass;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string results = "";
            int key = Convert.ToInt32(textBoxKey.Text);
            int depth = 0;
            osinka.KeySearch(ref results, key, ref depth);
            if (results != "")
                textBoxSearch.Text += @"найден элемент " + results + @"уровень " + depth + Environment.NewLine;
                else textBoxSearch.Text += @"элемент " + key + @" не найден " + Environment.NewLine;
        }

        private void всеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                симметричныйМетодLNRToolStripMenuItem_Click(sender, e);
                прямойМетодNLRToolStripMenuItem_Click(sender, e);
                обратныйМетодLRNToolStripMenuItem_Click(sender, e);
                методСправаналевоRNLToolStripMenuItem_Click(sender, e);
                обходВШиринуBFSToolStripMenuItem_Click(sender, e);
        }
    }
}
