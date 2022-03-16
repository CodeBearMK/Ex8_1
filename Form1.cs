using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex8_1
{
    public partial class Form1 : Form
    {

        int TotalPrice = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] shopitems = { "鱈魚香絲 69 元", "新貴派 99 元", "蘇打餅乾 59 元", "方塊酥 89 元"};
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox2.SelectionMode = SelectionMode.MultiExtended;
            foreach (string item in shopitems)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedObject = listBox1.SelectedItems;
            foreach (var item in selectedObject.OfType<string>().ToList())
            {
                listBox2.Items.Add(item);
                if (item.Contains("鱈魚香絲"))
                {
                    TotalPrice += 69;
                }
                if (item.Contains("新貴派"))
                {
                    TotalPrice += 99;
                }
                if (item.Contains("蘇打餅乾"))
                {
                    TotalPrice += 59;
                }
                if (item.Contains("方塊酥"))
                {
                    TotalPrice += 89;
                }
            }
            label3.Text = "合計 " + TotalPrice + " 元";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedObject = listBox2.SelectedItems;
            foreach (var item in selectedObject.OfType<string>().ToList())
            {
                listBox2.Items.Remove(item);
                if (item.Contains("鱈魚香絲"))
                {
                    TotalPrice -= 69;
                }
                if (item.Contains("新貴派"))
                {
                    TotalPrice -= 99;
                }
                if (item.Contains("蘇打餅乾"))
                {
                    TotalPrice -= 59;
                }
                if (item.Contains("方塊酥"))
                {
                    TotalPrice -= 89;
                }
            }
            label3.Text = "合計 " + TotalPrice + " 元";
        }
    }
}
