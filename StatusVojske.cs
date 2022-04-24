using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaVojnoNovacenje_EM
{
    internal class StatusVojske
    {
        int id_novaci;
        int BrojevniStatus;

        public StatusVojske(int id_novaci, int brojevniStatus)
        {
            this.id_novaci = id_novaci;
            BrojevniStatus = brojevniStatus;
        }

        public int Id_novaci { get => id_novaci; set => id_novaci = value; }
        public int BrojevniStatus1 { get => BrojevniStatus; set => BrojevniStatus = value; }
    }

}
