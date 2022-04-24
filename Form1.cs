using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaVojnoNovacenje_EM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

       
    }

        private void btnUnosNovaka_Click(object sender, EventArgs e)
        {
            UnosNovaka Novak = new UnosNovaka();
            Novak.Show();

        }

        private void btnStatusNovaka_Click(object sender, EventArgs e)
        {
            StatusNovaka Status = new StatusNovaka();
            Status.Show(); 

        }

        private void btnPregledNovaka_Click(object sender, EventArgs e)
        {
            PregledNovaka pregledNovaka = new PregledNovaka();
            pregledNovaka.Show();
        }

        private void btnOtpustNovaka_Click(object sender, EventArgs e)
        {
            OtpustNovaka otpustNovaka = new OtpustNovaka();
            otpustNovaka.Show();

        }
    }
}
