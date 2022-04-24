using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaVojnoNovacenje_EM
{
    class KlasaNovak
    {
        string oib;
        string ime;
        string prezime;
        DateTime DatumPrijave;

        public KlasaNovak(string oib, string ime, string prezime, DateTime datumPrijave)
        {
            this.oib = oib;
            this.ime = ime;
            this.prezime = prezime;
            this.DatumPrijave1 = datumPrijave;
        }

        public string Oib { get => oib; set => oib = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumPrijave1 { get => DatumPrijave; set => DatumPrijave = value; }
        public object Id { get; internal set; }
    }
}
