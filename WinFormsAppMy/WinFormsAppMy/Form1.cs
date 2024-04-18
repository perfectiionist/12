using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppMy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Выполнено", "В работе", "Не выполнено" });
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID заявки", 150);
            listView1.Columns.Add("Дата", 150);
            listView1.Columns.Add("Оборудование", 200);
            listView1.Columns.Add("Тип неисправности", 220);
            listView1.Columns.Add("Описание проблемы", 220);
            listView1.Columns.Add("Фамилия клиента", 200);
            listView1.Columns.Add("Статус заявки", 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(textBox1.Text);
            newItem.SubItems.Add(textBox2.Text);
            newItem.SubItems.Add(textBox3.Text);
            newItem.SubItems.Add(textBox4.Text);
            newItem.SubItems.Add(textBox5.Text);
            newItem.SubItems.Add(textBox6.Text);
            newItem.SubItems.Add(comboBox1.Text);
            listView1.Items.Add(newItem);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            MessageBox.Show("Данные добавлены");
        }

       

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
                textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
                comboBox1.Text = listView1.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
                listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
                listView1.SelectedItems[0].SubItems[3].Text = textBox4.Text;
                listView1.SelectedItems[0].SubItems[4].Text = textBox5.Text;
                listView1.SelectedItems[0].SubItems[5].Text = textBox6.Text;
                listView1.SelectedItems[0].SubItems[6].Text = comboBox1.Text;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.Text = "";
                MessageBox.Show("Данные удалены");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        
    }
}
