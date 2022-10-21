using System;
using System.IO;
using System.Windows.Forms;

namespace ExemploTXT03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtCarga.Clear();
                // Cria um objeto do tipo StreamReader
                StreamReader sr = new StreamReader("C:\\Temp\\Nomes.txt");                
                while (!sr.EndOfStream)
                {
                    txtCarga.AppendText(sr.ReadLine()+"\n");
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceção capturada : " + ex.Message);
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCarga.Enabled = false;
        }
    }
}
