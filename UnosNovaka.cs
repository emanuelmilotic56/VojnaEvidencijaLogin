using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AplikacijaZaVojnoNovacenje_EM
{
    public partial class UnosNovaka : Form
    {

        List<KlasaNovak> listaNovaka = new List<KlasaNovak>();
        static string dokumenti = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string putanja = Path.Combine(dokumenti, "Novaci.xml");



        public UnosNovaka()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Želite li upisati novog novaka";
            string naslov = "Upit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon ikona = MessageBoxIcon.Information;
            DialogResult rez = MessageBox.Show(poruka, naslov, buttons, ikona);


            KlasaNovak UnosNovaka = new KlasaNovak(textBox1.Text, textBox2.Text, textBox3.Text, datumPrijavaPicker.Value);
            listaNovaka.Add(UnosNovaka);

            if (Regex.IsMatch(textBox3.Text, @"^\d+$") & textBox3.TextLength < 12)
            {
                if (rez == DialogResult.No)
                {
                    try
                    {
                        var KlasaNovak = XDocument.Load(putanja);
                        foreach (KlasaNovak novaci in listaNovaka)
                        {
                            var Novak = (new XElement("Novak",
                            new XElement("OIB", novaci.Id),
                            new XElement("Ime", novaci.Ime),
                            new XElement("DatumPrijave", novaci.DatumPrijave1),
                            new XElement("Prezime", novaci.Prezime)));
                            KlasaNovak.Root.Add(novaci);


                        }
                        KlasaNovak.Save(putanja);


                    }
                    catch (Exception ex)
                    {
                        var KlasaNovak = new XDocument();
                        KlasaNovak.Add(new XElement("novaci"));
                        foreach (KlasaNovak novaci in listaNovaka)
                        {
                            var Novaci = new XElement("Novaci",
                            new XElement("OIB", novaci.Id),
                            new XElement("Ime", novaci.Ime),
                            new XElement("Prezime", novaci.Prezime));
                            KlasaNovak.Root.Add(Novaci);




                        }
                        KlasaNovak.Save(putanja);


                    }
                    listaNovaka.Clear();
                    this.Close();



                }



            }
            else
            {
                string poruka1 = "Molimo da upišete ispravan OIB.";
                string naslov1 = "Pogrešan upis.";
                MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                MessageBoxButtons ikona1 = (MessageBoxButtons)MessageBoxIcon.Error;
                DialogResult rez1 = MessageBox.Show(poruka1, naslov1, buttons1, (MessageBoxIcon)ikona1);


            }
        }

        private void UnosNovaka_Load(object sender, EventArgs e)
        {

        }
    }
}
