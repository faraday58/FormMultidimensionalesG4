using System;
using System.Windows.Forms;

namespace FormMultidimensionalesG4
{
    public partial class Form1 : Form
    {
        Unidimensional u1;
        Unidimensional u2;
        Unidimensional u3;
        Multidimensional m1;
        Multidimensional m2;
        Multidimensional m3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            try
            {
                if(  txtbIntro.Text.Contains(";") )
                {
                    m1 = Multidimensional.Leer(txtbIntro.Text);
                    lbMatriz1.Text = m1.ToString();
                }
                else
                {
                    u1 = Unidimensional.Leer(txtbIntro.Text);
                    lbMatriz1.Text = u1.ToString();
                }
                
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
