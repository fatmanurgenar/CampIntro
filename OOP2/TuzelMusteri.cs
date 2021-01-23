using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{

    //coorporate
    //inheritance- miras
    //class TuzelMusteri : Musteri bu yazımla tüzel müsteri bir müşteridir demiş olduk.
    //asıl olayı müşteride olan özellikler artık tüzel müşteride de vardır denir.
    class TuzelMusteri : Musteri
    {
       
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
