using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyChat
{
    public partial class Form2 : Form
    {
        Form1 form1;           
        RichTextBox richTextBox1;
        public Form2()
        {
            InitializeComponent();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            form1 = form01;
            richTextBox1 = form01.GetRichTextBox2();
            //richTextBox1 = form1.GetRichTextBox2();
            richTextBox1.Text = textBox2.Text;
            richTextBox2.Text = textBox2.Text;
            textBox2.Clear();
        }
        public RichTextBox GetRichTextBox1() { return richTextBox2; }
    }
}
