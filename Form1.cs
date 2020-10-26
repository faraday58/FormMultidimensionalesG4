using System;
using System.Windows.Forms;

namespace FormMultidimensionalesG4
{
    public partial class Form1 : Form
    {
        Unidimensional u1;
        Unidimensional u2;
        Unidimensional u3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            try
            {
                u1 = Unidimensional.Leer(txtbIntro.Text);
                lbMatriz1.Text = u1.ToString();
                errorProviderTxtb.Clear();
            }
            catch(FormatException error )
            {
                errorProviderTxtb.SetError(txtbIntro, error.Message);
            }
            catch (Exception error)
            {
                errorProviderTxtb.SetError(txtbIntro, error.Message);
            }
        }
    }
}
