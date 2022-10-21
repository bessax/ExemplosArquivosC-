using System;
using System.Windows.Forms;
using System.IO;

namespace ExemploTXT02
{
    public partial class frmTXT : Form
    {
        public frmTXT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Temp\\Nomes.txt", true);
                sw.WriteLine(txtNome.Text);
                sw.Close();
                MessageBox.Show("texto inserido no arquivo com sucesso!!!");
                txtNome.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception gerada " + ex.Message);
            }
            
        }
    }
}
