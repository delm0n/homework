using System;
using System.Collections.Generic;
namespace BinaryTree
{
    public class Tree //Описание класса "Дерево"
    {
        public class TreeNode // вложенный класс "Поддерево"
        {
            public int Value; // значение ключа
            public string znacn; // значение строки
            public int Count = 0; // количество одинаковых ключей
            public TreeNode Left; // левое поддерево
            public TreeNode Right; // правое поддерево
        }
        public TreeNode Node; // экземпляр класса "Поддерево"
        public enum BypassOptions // перечисление - объявленные константы для выбора
        {
            LNR,
            NLR,
            LRN,
            RNL,
            BFS
        }
        public void Add(int value, string zn)// добавление элемента - интерфейсный метод
        {
            AddChildren(ref Node, value, zn);
        }
        private void AddChildren(ref TreeNode node, int val, string zn)
        {
            if (Form1.chars_is_symb == true)
            {
                if (node == null)//если в подветви ничего нет, то создать узел
                {
                    node = new TreeNode();
                    node.Value = val;
                    node.znacn = zn;
                    node.Count = 1;
                }
                else//если в подветви уже что то есть
                {
                    if (node.Value == val)//если длина элемента такая же
                    {
                        ///!!!
                        if (HowManyUnits(node.znacn) > HowManyUnits(zn)) AddChildren(ref node.Left, val, zn);
                        else AddChildren(ref node.Right, val, zn);
                        ///!!!
                    }
                    else if (node.Value != val)//если длина элемента не такая же
                    {
                        if ((node.Value) > val) AddChildren(ref node.Left, val, zn);
                        else AddChildren(ref node.Right, val, zn);
                    }
                }
            }//вариант действий, если содержатся символы
            else
            {
                if (node == null)
                {
                    node = new TreeNode();
                    node.Value = val;
                    node.znacn = zn;
                    node.Count = 1;
                }
                else
                {
                    if (node.Value == val)
                    {
                        node.Count++;
                    }
                    else if (node.Value != val)
                    {
                        if ((node.Value) > val) AddChildren(ref node.Left, val, zn);
                        else AddChildren(ref node.Right, val, zn);
                    }
                }
            }//вариант действий, если содержатся цифры
        }
        public void Output(ref string s) // вывод данных в форму - интерфейсный метод
        {
            s = ""; // обнуляем строку
            OutputTree(Node, 0, ref s);
        }
        private void OutputTree(TreeNode root, int spaces, ref string s)
        {
            if (root != null)
            {
                for (int i = 0; i < root.Count; i++)
                {
                    for (int j = 0; j <= spaces; j++)
                        if (j == 0) s += "|";
                        else s += " -";
                    s += " ";
                    if (Form1.chars_is_symb == true) s += $" ( long: {root.znacn.Length} ) ";
                    s += root.znacn.ToString();
                    s += Environment.NewLine;
                }
                OutputTree(root.Left, spaces + 1, ref s);
                OutputTree(root.Right, spaces + 1, ref s);
            }
        }

        public void KeySearch(ref string s, int key, ref int depth)// поиск ключа в дереве -интерфейсный метод
        {
            s = "";
            Find(Node, ref depth, ref key, ref s);
        }
        //ref TreeNode Node - текущий "элемент дерева" 

        private void Find(TreeNode node, ref int depth, ref int key, ref string s)
        {
            if (node != null)
            {
                if (node.Value < key)
                {
                    depth++;
                    Find(node.Right, ref depth, ref key, ref s);
                }
                else if (node.Value > key)
                {
                    depth++;
                    Find(node.Left, ref depth, ref key, ref s);
                }
                else
                {
                    depth++;
                    s += node.Value.ToString() + " ";
                }
            }
        }
        public void Bypass(BypassOptions option, ref string s)// обход дерева - интерфейсный метод
        {
            s = "";
            if (option == BypassOptions.LNR) LNR_bypass(Node, ref s);
            if (option == BypassOptions.NLR) NLR_bypass(Node, ref s);
            if (option == BypassOptions.LRN) LRN_bypass(Node, ref s);
            if (option == BypassOptions.RNL) RNL_bypass(Node, ref s);
            if (option == BypassOptions.BFS) BFS_bypass(Node, ref s);
            s += Environment.NewLine;
        }

        private int HowManyUnits(string str)
        {
            int sum = 0;
            foreach (char chr in str)
            {
                sum += Convert.ToInt32(chr);
            }
            return sum;
        }
        
        //Функция подсчета числа для строки
        private void LNR_bypass(TreeNode node, ref string s)
        {
            if (node != null)
            {
                LNR_bypass(node.Left, ref s); // обойти левое поддерево
                s += node.Value.ToString() + " "; // записать данные
                LNR_bypass(node.Right, ref s); // обойти правое поддерево
            }
        }
        private void NLR_bypass(TreeNode node, ref string s)
        {
            if (node != null)
            {
                s += node.Value.ToString() + " ";
                NLR_bypass(node.Left, ref s);
                NLR_bypass(node.Right, ref s);
            }
        }
        private void LRN_bypass(TreeNode node, ref string s)
        {
            if (node != null)
            {
                LRN_bypass(node.Left, ref s);
                LRN_bypass(node.Right, ref s);
                s += node.Value.ToString() + " ";
            }
        }
        private void RNL_bypass(TreeNode node, ref string s)
        {
            if (node != null)
            {
                RNL_bypass(node.Right, ref s); // обойти правое поддерево
                s += node.Value.ToString() + " "; // запомнить текущее значение
                RNL_bypass(node.Left, ref s); // обойти левое поддерево
            }
        }

        private void BFS_bypass(TreeNode node, ref string s)
        {
            var tail = new Queue<TreeNode>(); // создание очереди, принцип FIFO
            tail.Enqueue(node);
            while (tail.Count != 0)
            {
                if (tail.Peek().Left != null)
                {
                    tail.Enqueue(tail.Peek().Left);
                }
                if (tail.Peek().Right != null)
                {
                    tail.Enqueue(tail.Peek().Right);
                }
                s += tail.Peek().Value.ToString() + " ";
                tail.Dequeue();
            }
        }
        private void NRL_bypass(TreeNode node, ref string s)
        {
            if (node != null)
            {
                s += node.Value.ToString() + " ";
                NRL_bypass(node.Right, ref s);
                NRL_bypass(node.Left, ref s);
            }
        }

    }
}