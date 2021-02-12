using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackPropTraining____
{
    public partial class Form1 : Form
    {
        List<Bitmap> pekchurs;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap pekchur = new Bitmap(openFileDialog1.FileName);
                pekchurs.Add(pekchur);

                pictureBox1.Image = pekchur;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int epochs = int.Parse(textBox1.Text);
            Console.WriteLine(epochs);
        }
    }
}
