using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Cultuurhuis.Models
{
    public class MandjeItem
    {
        public int VoorstellingsNr { get; set; }
        public string Titel { get; set; }
        public string Uitvoerders { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy HH:mm}")]
        public System.DateTime Datum { get; set; }
        [DisplayFormat(DataFormatString = "{0:€ #,##0.00}")]
        public decimal Prijs { get; set; }
        public short Plaatsen { get; set; }
        public MandjeItem(int nr, string titel, string uitvoerders,
        DateTime datum, decimal prijs, short plaatsen)
        {
            VoorstellingsNr = nr;
            Titel = titel;
            Uitvoerders = uitvoerders;
            Datum = datum;
            Prijs = prijs;
            Plaatsen = plaatsen;
        }
    }
}