using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChat
{
    public partial class Form1 : Form
    {
        Form2 form2;
        RichTextBox richTextBox2;
        public Form1()
        {
            InitializeComponent();
            Form2 form02 = new Form2();
            form2 = form02;
            richTextBox2 = form2.GetRichTextBox1();
            form2.Show();

        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            
            richTextBox2.Text = $"\n{textBox1.Text}";
            richTextBox1.Text = $"\n{textBox1.Text}";
            textBox1.Clear();
            
        }
        public RichTextBox GetRichTextBox2() { return richTextBox1; }
    }
}
