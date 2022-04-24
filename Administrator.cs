using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AplikacijaZaVojnoNovacenje_EM
{
    public partial class Administrator : Form
    {

        public Administrator()
        {
            InitializeComponent();
        }


        public string FromXMLKorisnickoIme = "";
        public string FromXMLLozinka = "";


        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string KorisnickoIme = textBox1.Text;
            string Lozinka = textBox2.Text;

            XDocument doc = XDocument.Load(Application.StartupPath.ToString() + @"\Novaci.xml");
            var NoviKorisnikNovak = from x in doc.Descendants("KorisnikNovak").Where(x => (string)x.Element("KorisnickoIme") == textBox1.Text)
                                    select new
                                    {
                                        XMLuser = x.Element("username").Value,
                                        XMLpwd = x.Element("psw").Value,
                                    };

            foreach (var x in NoviKorisnikNovak)
            {
                FromXMLKorisnickoIme = x.XMLuser;
                FromXMLLozinka = x.XMLpwd;
                if (KorisnickoIme == FromXMLKorisnickoIme)
                {
                    if (Lozinka == FromXMLLozinka)
                    {

                        MessageBox.Show("Uspješno ste ulogirani u sustav OSRH");
                        Form1 Izbornik = new Form1();
                        Izbornik.Show();



                    }
                    else
                    {
                        MessageBox.Show("Upisali ste krivu lozinku");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Korisničko ime je pogrešno");
                    Clear();
                }
            }
        }
    }

}
        
   

