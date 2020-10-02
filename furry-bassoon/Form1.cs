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

namespace furry_bassoon
{
    public partial class furrybassoon : Form
    {

        FileStream file = null;
        float[] mas1;
        string MyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        float[,] mas2;
        public furrybassoon()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int array1Lentgh = Convert.ToInt32(textmas.Text);
            mas1 = new float[array1Lentgh];
            for (int i = 0; i < array1Lentgh; i++)
            {
                mas1[i] = r.Next(100);
                text.Text += $"{mas1[i].ToString()} ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text.Text = "";
            mas1 = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int array2Lentgh = Convert.ToInt32(textmas2.Text);
            string tooo = "";
            int array2Lentgh2 = Convert.ToInt32(textmas3.Text);
            mas2 = new float[array2Lentgh,array2Lentgh2];
            file = new FileStream(MyDocuments + @"\Array2.txt", FileMode.OpenOrCreate);
            for (int k = 0; k < array2Lentgh; k++)
            {
                for (int j = 0; j < array2Lentgh2; j++)
                {
                    mas2[k, j] = rd.Next(100);
                    tooo += $"{mas2[k, j].ToString()} ";
                }
                tooo += "\n";
                byte[] massiv = Encoding.Default.GetBytes(tooo);
                file.Write(massiv, 0, massiv.Length);
                tooo = "";
            }

            if (file != null)
            {
                file.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            file = null;
            mas2 = null;
        }

    }
}