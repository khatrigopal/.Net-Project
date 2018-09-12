using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                label1.Invoke((Action)(() =>
                {
                  //  label1.Text = textBox1.Text;
                    //int a = Convert.ToInt32(textBox1.Text);
                    //int b = Convert.ToInt32(textBox2.Text);

                    //label1.Text = a.ToString() + b.ToString();
                    float first;
                    float second;
                    float output;
                    first = Convert.ToInt32(textBox1.Text);
                    second = Convert.ToInt32(textBox2.Text);
                    output = first + second;
                    label1.Text = (output.ToString());
                    
                }));
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(label1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

     

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(label1.Text);
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            label1.Invoke((Action)(() =>
            {
                float first;
                float second;
                float output;
                first = Convert.ToInt32(textBox1.Text);
                second = Convert.ToInt32(textBox2.Text);
                output = first - second;
                label1.Text = (output.ToString());
            }));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //divied
            Form2 ff = new Form2();

                 ff.Show();
          

           
        }

      

      

      
      
      
    }
}
